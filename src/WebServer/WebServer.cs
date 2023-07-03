using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using EmbedIO;
using EmbedIO.Files;
using EmbedIO.Net;
using EmbedIO.WebApi;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Web.Controllers;
using Melia.Web.Logging;
using Melia.Web.Modules;
using Yggdrasil.Logging;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Web
{
	public class WebServer : Server
	{
		public readonly static WebServer Instance = new WebServer();

		private EmbedIO.WebServer _server;

		/// <summary>
		/// Runs the server.
		/// </summary>
		/// <param name="args"></param>
		public override void Run(string[] args)
		{
			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, "Web", ConsoleColor.DarkRed, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			this.NavigateToRoot();
			this.LoadConf(this.Conf);
			this.LoadData(ServerType.Web);
			this.CheckDependencies();

			this.StartWebServer();

			ConsoleUtil.RunningTitle();

			new ConsoleCommands().Wait();
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

#pragma warning disable SYSLIB0014 // Type or member is obsolete
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
#pragma warning restore SYSLIB0014 // Type or member is obsolete
		}

		/// <summary>
		/// Starts web server.
		/// </summary>
		private void StartWebServer()
		{
			try
			{
				var url = string.Format("http://*:{0}/", this.Conf.Web.Port);

				Swan.Logging.Logger.NoLogging();
				Swan.Logging.Logger.RegisterLogger<YggdrasilLogger>();

				EndPointManager.UseIpv6 = false;

				_server = new EmbedIO.WebServer(url);

				// The PHP module handles all requests to PHP scripts,
				// including defaulting to index.php and prioritizing
				// the user folder. Should this fail, we'll try static
				// requests to user and system.
				// TODO: Look into handling PHP scripts from a FileModule,
				//   adding a pre-processor.

				_server.WithWebApi("/toslive/patch/", m => m.WithController<TosPatchController>());

				_server.WithModule(new PhpModule("/"));

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
	}
}
