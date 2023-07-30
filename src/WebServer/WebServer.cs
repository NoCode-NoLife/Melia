using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using EmbedIO;
using EmbedIO.Files;
using EmbedIO.Net;
using EmbedIO.WebApi;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.Network.Inter.Messages;
using Melia.Web.Controllers;
using Melia.Web.Logging;
using Melia.Web.Modules;
using Melia.Web.Network;
using Yggdrasil.Logging;
using Yggdrasil.Network.Communication;
using Yggdrasil.Network.TCP;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Web
{
	public class WebServer : Server
	{
		public readonly static WebServer Instance = new WebServer();

		private EmbedIO.WebServer _server;

		private TcpConnectionAcceptor<WebServerConnection> _acceptor;

		/// <summary>
		/// Returns the server's inter-server communicator.
		/// </summary>
		public Communicator Communicator { get; private set; }

		/// <summary>
		/// <summary>
		/// List containing Server Information Messages
		/// </summary>
		public Dictionary<int, ResServerInformationMessage> ServerInformationMessages { get; set; } = new Dictionary<int, ResServerInformationMessage>();
		
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
			this.CheckDependencies();
			this.StartCommunicator();
			this.StartWebServer();

			this.StartAcceptor();

			ConsoleUtil.RunningTitle();

			new ConsoleCommands().Wait();
		}

		/// <summary>
		/// Starts accepting connections.
		/// </summary>
		private void StartAcceptor()
		{
			_acceptor = new TcpConnectionAcceptor<WebServerConnection>(this.ServerInfo.InterPort);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.Listen();

			Log.Status("Server ready, listening on {0}.", _acceptor.Address);
		}

		/// <summary>
		/// Called when a new connection is accepted.
		/// </summary>
		/// <param name="conn"></param>
		private void OnConnectionAccepted(WebServerConnection conn)
		{
			Log.Info("New connection accepted from '{0}'.", conn.Address);
		}

		/// <summary>
		/// Checks and downloads dependencies, such as PHP.
		/// </summary>
		private void CheckDependencies()
		{
			var phpFilePath = this.Conf.Web.PhpCgiFilePath;
			var phpFolderPath = Path.GetDirectoryName(phpFilePath);

			// If the binary exists we got all we need
			if (File.Exists(phpFilePath))
				return;

			// If the binary doesn't exist, and the intended path is
			// not inside the user folder, we'll let the user figure
			// out what to do, since they changed the path.
			if (!phpFilePath.Replace("\\", "/").StartsWith("user/tools/"))
			{
				Log.Error("Configured PHP CGI binary not found at '{0}', please check your web configuration.", phpFilePath);
				ConsoleUtil.Exit(1);
				return;
			}

			// If the binary wasn't found, and we're not Windows, this is
			// the end of the road for now.
			// TODO: Add auto-download for Linux and MacOS?
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				Log.Error("The configured PHP binary couldn't be found and we can't set it up automatically. Please install PHP on your system and set the binary path in the web configuration.");
				ConsoleUtil.Exit(1);
				return;
			}

			Log.Info("PHP not found. Downloading now...");

			using (var wc = new WebClient())
			{
				var tempFileName = Path.GetTempFileName();
				var downloadUrl = this.Conf.Web.PhpDownloadUrl;

				try
				{
					wc.Headers.Set(HttpRequestHeader.UserAgent, "Melia");
					wc.DownloadProgressChanged += (s, e) => Console.Write("         Download Progress: {0,3:0}%\r", e.ProgressPercentage);

					var task = wc.DownloadFileTaskAsync(downloadUrl, tempFileName);
					task.Wait();

					Log.Info("PHP download complete, extracting...");

					if (!Directory.Exists(phpFolderPath))
						Directory.CreateDirectory(phpFolderPath);

					ZipFile.ExtractToDirectory(tempFileName, phpFolderPath);

					Log.Info("PHP extraction complete, setting up...");

					var productionIniFilePath = Path.Combine(phpFolderPath, "php.ini-production");
					var iniFilePath = Path.Combine(phpFolderPath, "php.ini");
					File.Copy(productionIniFilePath, iniFilePath);

					Log.Info("Successfully downloaded PHP to '{0}'.", phpFolderPath);

					Log.Info("PHP extraction complete, enabling extensions...");

					this.EnablPhpExtesion(iniFilePath, "extension=fileinfo");
					this.EnablPhpExtesion(iniFilePath, "extension=zip");
					this.EnablPhpExtesion(iniFilePath, "extension=mysqli");
					this.EnablPhpExtesion(iniFilePath, "extension=pdo_mysql");

					Log.Info("Successfully enabled PHP extensions.");
				}
				catch (Exception)
				{
					Log.Warning("Failed to download PHP from '{0}'. Please configure your PHP path manually or you won't be able to use all of the web server's features.", downloadUrl);
				}
				finally
				{
					try { File.Delete(tempFileName); }
					catch { }
				}
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

			try
			{
				this.Communicator.Connect("Coordinator", barracksServerInfo.Ip, barracksServerInfo.InterPort);

				this.Communicator.Subscribe("Coordinator", "ServerUpdates");
				this.Communicator.Subscribe("Coordinator", "AllServers");

				Log.Info("Successfully connected to coordinator.");
			}
			catch
			{
				Log.Error("Failed to connect to coordinator, trying again in 5 seconds...");
				Thread.Sleep(5000);

				this.ConnectToCoordinator();
			}
		}

		/// <summary>
		/// Called when the connection to the coordinator was lost.
		/// </summary>
		/// <param name="commName"></param>
		private void Communicator_OnDisconnected(string commName)
		{
			Log.Error("Lost connection to coordinator, will try to reconnect in 5 seconds...");
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
			switch (message)
			{
				case ServerUpdateMessage serverUpdateMessage:
					this.ServerList.Update(serverUpdateMessage);
					break;
				case ResServerInformationMessage serverInformationMessage:
					if (this.ServerInformationMessages.ContainsKey(serverInformationMessage.ProcessId))
					{
						this.ServerInformationMessages.Remove(serverInformationMessage.ProcessId);
					}
					this.ServerInformationMessages.Add(serverInformationMessage.ProcessId, serverInformationMessage);
					break;
				default:
					break;
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

				// The PHP module handles all requests to PHP scripts,
				// including defaulting to index.php and prioritizing
				// the user folder. Should this fail, we'll try static
				// requests to user and system.
				// TODO: Look into handling PHP scripts from a FileModule,
				//   adding a pre-processor.

				_server.WithWebApi("/toslive/patch/", m => m.WithController<TosPatchController>());
				_server.WithWebApi("/api/", m => m.WithController<ApiController>()));

				_server.WithModule(new PhpModule("/"));
				_server.WithModule(new AuthenticationModule("/api/"));

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

		private void EnablPhpExtesion(string iniFilePath, string extensionToEnable)
		{
			var phpConfigContent = File.ReadAllText(iniFilePath);
			var extensionIndex = phpConfigContent.IndexOf(extensionToEnable);

			if (extensionIndex != -1)
			{
				phpConfigContent = phpConfigContent.Remove(extensionIndex, extensionToEnable.Length);
				File.WriteAllText(iniFilePath, phpConfigContent);
			}
		}
	}
}
