using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Files;
using EmbedIO.Net;
using EmbedIO.WebApi;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.Network.Inter.Messages;
using Melia.Web.Controllers;
using Melia.Web.Controllers.Api;
using Melia.Web.Database;
using Melia.Web.Logging;
using Melia.Web.Modules;
using Yggdrasil.Logging;
using Yggdrasil.Network.Communication;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Web
{
	public class WebServer : Server
	{
		public readonly static WebServer Instance = new();

		private EmbedIO.WebServer _server;
		private EmbedIO.WebServer _guildServer;

		/// <summary>
		/// Returns the server's inter-server communicator.
		/// </summary>
		public Communicator Communicator { get; private set; }

		/// <summary>
		/// Returns reference to the server's database interface.
		/// </summary>
		public WebDb Database { get; } = new();

		/// <summary>
		/// Runs the server.
		/// </summary>
		/// <param name="args"></param>
		public override void Run(string[] args)
		{
			this.GetServerId(args, out var groupId, out var serverId);
			var title = string.Format("Web ({0}, {1})", groupId, serverId);

			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, title, ConsoleColor.DarkRed, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			this.NavigateToRoot();
			this.LoadConf(this.Conf);
			this.LoadData(ServerType.Web);
			this.LoadServerList(this.Data.ServerDb, ServerType.Web, groupId, serverId);
			this.InitDatabase(this.Database, this.Conf);
			this.CheckDependencies();

			this.StartWebServer();
			this.StartGuildWebServer();
			this.StartCommunicator();

			ConsoleUtil.RunningTitle();

			new ConsoleCommands().Wait();
		}

		/// <summary>
		/// Checks and downloads dependencies, such as PHP.
		/// </summary>
		private void CheckDependencies()
		{
			var phpProcessor = this.Conf.Web.CgiProcessors.Find(p => p.Name == "PHP");
			if (phpProcessor == null)
			{
				Log.Warning("No PHP CGI processor configured, the web server will not be able to handle PHP scripts.");
				return;
			}

			var phpFilePath = phpProcessor.Path;
			var phpFolderPath = Path.GetDirectoryName(phpFilePath);

			// If the binary exists we got all we need
			if (File.Exists(phpFilePath))
				return;

			// If the binary doesn't exist, and the intended path is
			// not inside the user folder, we'll let the user figure
			// out what to do, since they changed the path.
			if (!phpFilePath.Replace("\\", "/").StartsWith("user/tools/"))
			{
				Log.Warning("Configured PHP CGI binary not found at '{0}', please check your web configuration.", phpFilePath);
				//ConsoleUtil.Exit(1);
				return;
			}

			// If the binary wasn't found, and we're not on Windows, this is
			// the end of the road for now.
			// TODO: Add auto-download for Linux and MacOS?
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				Log.Warning("The configured PHP binary couldn't be found and we can't set it up automatically. Please install PHP on your system and set the binary path in the web configuration.");
				//ConsoleUtil.Exit(1);
				return;
			}

			Log.Info("PHP not found. Downloading now...");

			using var wc = new HttpClient();

			var downloadRootUrl = "https://windows.php.net";
			var downloadPageUrl = downloadRootUrl + "/download";
			var downloadPageContents = wc.GetStringAsync(downloadPageUrl).Result;

			// Get link to the first PHP zip file, which should be the
			// latest.
			var match = Regex.Match(downloadPageContents, @"/downloads/releases/php-\d+\.\d+\.\d+-nts-Win32-vs16-x64\.zip");
			if (!match.Success)
			{
				Log.Warning("Failed to find PHP download on '{0}'. Please install PHP and set its path manually in the web web configuration or you won't be able to use all of the web server's features.", downloadPageUrl);
				return;
			}

			var tempFileName = Path.GetTempFileName();
			//var downloadUrl = this.Conf.Web.PhpDownloadUrl;
			var downloadUrl = downloadRootUrl + match.Value;
			var fileName = Path.GetFileName(downloadUrl);

			Log.Info("Filename: {0}", fileName);

			var downloading = true;

			try
			{
				wc.DefaultRequestHeaders.UserAgent.ParseAdd("Melia");

				Task.Run(() =>
				{
					while (downloading)
					{
						Console.Write(".");
						Thread.Sleep(1000);
					}
				});

				var result = wc.GetAsync(downloadUrl).Result;
				using (var fs = new FileStream(tempFileName, FileMode.Create, FileAccess.Write, FileShare.None))
					result.Content.CopyToAsync(fs).Wait();

				downloading = false;

				Console.WriteLine();
				Log.Info("PHP download complete, extracting...");

				if (Directory.Exists(phpFolderPath))
					Directory.Delete(phpFolderPath, true);

				if (!Directory.Exists(phpFolderPath))
					Directory.CreateDirectory(phpFolderPath);

				ZipFile.ExtractToDirectory(tempFileName, phpFolderPath);

				Log.Info("PHP extraction complete, setting up...");

				// Download cert file
				result = wc.GetAsync("https://curl.se/ca/cacert.pem").Result;
				var caCertFilePath = Path.GetFullPath(Path.Combine(phpFolderPath, "cacert.pem"));
				using (var fs = new FileStream(caCertFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
					result.Content.CopyToAsync(fs).Wait();

				// Create ini file
				var productionIniFilePath = Path.Combine(phpFolderPath, "php.ini-production");
				var iniFilePath = Path.Combine(phpFolderPath, "php.ini");
				File.Copy(productionIniFilePath, iniFilePath);

				// Enable common extensions
				var iniContents = File.ReadAllText(iniFilePath);
				iniContents = iniContents.Replace(";zend_extension=opcache",
					";zend_extension=opcache\r\n\r\n" +
					"extension_dir=\"ext\"\r\n" +
					"extension=curl\r\n" +
					"extension=mysqli\r\n" +
					"extension=openssl\r\n" +
					"extension=pdo_mysql\r\n" +
					"extension=pdo_sqlite\r\n" +
					"extension=zip\r\n" +
					"curl.cainfo=\"" + caCertFilePath + "\"\r\n" +
					""
				);
				File.WriteAllText(iniFilePath, iniContents);

				Log.Info("Successfully downloaded PHP to '{0}'.", phpFolderPath);
			}
			catch (Exception)
			{
				Log.Warning("Failed to download PHP from '{0}'. Please configure your PHP path manually or you won't be able to use all of the web server's features.", downloadUrl);
			}
			finally
			{
				try { File.Delete(tempFileName); }
				catch { }

				downloading = false;
			}
		}

		/// <summary>
		/// Starts the communicator and attempts to connect to the
		/// coordinator.
		/// </summary>
		private void StartCommunicator()
		{
			Log.Info("Attempting to connect to coordinator...");

			var commName = ServerType.Web.ToString();

			this.Communicator = new Communicator(commName);
			this.Communicator.Disconnected += this.Communicator_OnDisconnected;
			this.Communicator.MessageReceived += this.Communicator_OnMessageReceived;

			this.ConnectToCoordinator();
		}

		/// <summary>
		/// Attempts to establish a connection to the coordinator.
		/// </summary>
		private void ConnectToCoordinator()
		{
			var barracksServerInfo = this.GetServerInfo(ServerType.Barracks, 1);
			var authentication = this.Conf.Inter.Authentication;

			var tries = 0;
			var silenceThreshold = 4;

			while (true)
			{
				try
				{
					this.Communicator.Connect("Coordinator", authentication, barracksServerInfo.Ip, barracksServerInfo.InterPort);

					this.Communicator.Subscribe("Coordinator", "ServerUpdates");
					this.Communicator.Subscribe("Coordinator", "AllServers");

					Log.Info("Successfully connected to coordinator.");
					break;
				}
				catch
				{
					if (tries < silenceThreshold)
					{
						if (tries + 1 < silenceThreshold)
							Log.Error("Failed to connect to coordinator, trying again...");
						else
							Log.Error("Failed to connect to coordinator. Will keep trying...");
					}

					tries++;
					Thread.Sleep(5000);
				}
			}
		}

		/// <summary>
		/// Called when the connection to the coordinator was lost.
		/// </summary>
		/// <param name="commName"></param>
		private void Communicator_OnDisconnected(string commName)
		{
			Log.Error("Lost connection to coordinator, attempting to reconnect...");
			Thread.Sleep(5000);

			this.ConnectToCoordinator();
		}

		/// <summary>
		/// Called when a message was received from the coordinator.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		private void Communicator_OnMessageReceived(string sender, ICommMessage message)
		{
			//Log.Debug("Message received from '{0}': {1}", sender, message);

			switch (message)
			{
				case ServerUpdateMessage serverUpdateMessage:
				{
					this.ServerList.Update(serverUpdateMessage);
					break;
				}
			}
		}

		/// <summary>
		/// Starts web server.
		/// </summary>
		private void StartWebServer()
		{
			try
			{
				var serverInfo = this.ServerInfo;
				var url = string.Format("http://*:{0}/", serverInfo.Port);

				Swan.Logging.Logger.NoLogging();
				Swan.Logging.Logger.RegisterLogger(new YggdrasilLogger(this.Conf.Log.Filter));

				EndPointManager.UseIpv6 = false;

				_server = new EmbedIO.WebServer(url);

				_server.WithWebApi("/toslive/patch/", m => m.WithController<LaunchController>());
				_server.WithWebApi("/api/info/", m => m.WithController<InfoController>());
				_server.WithWebApi("/api/account/", m => m.WithController<AccountController>());

				_server.WithModule(new AuthModule("/api/admin/"));
				_server.WithWebApi("/api/admin/", m => m.WithController<AdminController>());

				// The CGI module handles all requests to the scripts, including
				// defaulting to index.* and prioritizing the user folder. Should
				// this fail, we'll try static requests to user and system.
				// TODO: Look into handling CGI scripts from a FileModule,
				//   adding a pre-processor.

				foreach (var processor in this.Conf.Web.CgiProcessors)
					_server.WithModule(new CgiProcessorModule("/", processor.Name, processor.Path, processor.FileExtensions));

				if (Directory.Exists("user/web/"))
				{
					_server.WithStaticFolder("/", "user/web/", false, fm =>
					{
						fm.DefaultDocument = "index.htm";
						fm.OnMappingFailed = FileRequestHandler.PassThrough;
						fm.OnDirectoryNotListable = FileRequestHandler.PassThrough;
					});
				}

				if (Directory.Exists("system/web/"))
				{
					_server.WithStaticFolder("/", "system/web/", false, fm =>
					{
						fm.DefaultDocument = "index.htm";
					});
				}

				_server.RunAsync();

				if (_server.State == WebServerState.Stopped)
				{
					Log.Error("Failed to start web server, make sure there's only one instance running.");
					ConsoleUtil.Exit(1);
				}

				// Disabled for now. Giving the URLs makes things easier,
				// but the IP should ideally match what the user will
				// actually use to connect.
				//Log.Info("Client XML Config:");
				//Log.Info("  ServerListURL: {0}", url + "toslive/patch/serverlist.xml");
				//Log.Info("  StaticConfigURL: {0}", url + "toslive/patch/");

				Log.Status("Server now running on '{0}'", url);
			}
			catch (Exception ex)
			{
				Log.Error("Failed to start web server: {0}", ex);
				ConsoleUtil.Exit(1);
			}
		}

		/// <summary>
		/// Starts guild web server.
		/// </summary>
		private void StartGuildWebServer()
		{
			try
			{
				var url = string.Format("http://*:{0}/", this.Conf.Web.GuildPort);

				Swan.Logging.Logger.NoLogging();
				Swan.Logging.Logger.RegisterLogger(new YggdrasilLogger(this.Conf.Log.Filter));

				EndPointManager.UseIpv6 = false;

				var options = new WebServerOptions()
					.WithMode(HttpListenerMode.EmbedIO)
					.WithUrlPrefix(url);
				_guildServer = new EmbedIO.WebServer(options);

				var webFolder = "system/web/";
				if (Directory.Exists("user/web/"))
					webFolder = "user/web/";

				_guildServer
					.WithWebApi("/", m => m.WithController<TosGuildController>())
					.WithStaticFolder("/", webFolder, false, fm =>
					{
						fm.DefaultDocument = "index.htm";
						fm.OnMappingFailed = FileRequestHandler.PassThrough;
						fm.OnDirectoryNotListable = FileRequestHandler.PassThrough;
					});
				_guildServer.RunAsync();

				if (_guildServer.State == WebServerState.Stopped)
				{
					Log.Error("Failed to start guild server, make sure there's only one instance running.");
					ConsoleUtil.Exit(1);
				}

				Log.Status("Guild Server now running on '{0}'", url);
			}
			catch (Exception ex)
			{
				Log.Error("Failed to start guild web server: {0}", ex);
				ConsoleUtil.Exit(1);
			}
		}
	}
}
