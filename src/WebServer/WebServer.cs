using System;
using System.Collections.Generic;
using System.Net;
using Melia.Shared;
using Melia.Shared.Database;
using Melia.Shared.Util;
using Melia.Shared.Util.Configuration;
using Swebs;
using Yggdrasil.Util.Commands;

namespace Melia.Web
{
	public class WebServer : Server
	{
		public static readonly WebServer Instance = new WebServer();

		private List<object> _swebsReferences = new List<object>();

		/// <summary>
		/// Actual HTTP server.
		/// </summary>
		public HttpServer HttpServer { get; private set; }

		/// <summary>
		/// Configuration.
		/// </summary>
		public Conf Conf { get; private set; }

		/// <summary>
		/// Wev server's database.
		/// </summary>
		public MeliaDb Database { get; private set; }

		/// <summary>
		/// Starts the server.
		/// </summary>
		public override void Run()
		{
			base.Run();

			CliUtil.WriteHeader("Web", ConsoleColor.DarkRed);
			CliUtil.LoadingTitle();

			this.LoadConf(this.Conf = new Conf());
			this.InitDatabase(this.Database = new MeliaDb(), this.Conf);
			this.LoadData(DataToLoad.Servers, true);

			this.StartWebServer();

			CliUtil.RunningTitle();

			new ConsoleCommands().Wait();
		}

		/// <summary>
		/// Sets up default controllers and starts web server
		/// </summary>
		public void StartWebServer()
		{
			Log.Info("Starting web server...");

			// Trick compiler into referencing DLLs, so Swebs references them
			// in the C# scripts as well.
			//_swebsReferences.Add(...);

			var conf = new Configuration();
			conf.Host = IPAddress.Parse(this.Conf.Web.Ip);
			conf.Port = this.Conf.Web.Port;
			conf.SourcePaths.Add("user/web/");
			conf.SourcePaths.Add("system/web/");

			this.HttpServer = new HttpServer(conf);
			this.HttpServer.RequestReceived += (s, e) =>
			{
				Log.Debug("[{0}] - {1}", e.Request.HttpMethod, e.Request.Path);
				//Log.Debug(e.Request.UserAgent); // Client: TEST_ARI
			};
			this.HttpServer.UnhandledException += (s, e) => Log.Exception(e.Exception);

			try
			{
				this.HttpServer.Start();

				Log.Info("ServerListURL: http://*:{0}/{1}", this.Conf.Web.Port, "toslive/patch/serverlist.cs");
				Log.Info("StaticConfigURL: http://*:{0}/{1}", this.Conf.Web.Port, "toslive/patch/");
				Log.Status("Server ready, listening on 0.0.0.0:{0}.", this.Conf.Web.Port);
			}
			catch (NHttpException)
			{
				Log.Error("Failed to start web server.");
				Log.Info("Port {0} might already be in use, make sure no other application, like other web servers or Skype, are using it or set a different port in web.conf.", this.Conf.Web.Port);
				CliUtil.Exit(1);
			}
		}
	}
}
