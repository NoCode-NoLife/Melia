// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Util.Configuration.Files;

namespace Melia.Shared.Util.Configuration
{
	public class Conf : ConfFile
	{
		/// <summary>
		/// log.conf
		/// </summary>
		public LogConfFile Log { get; private set; }

		/// <summary>
		/// database.conf
		/// </summary>
		public DatabaseConfFile Database { get; private set; }

		/// <summary>
		/// database.conf
		/// </summary>
		public CommandsConfFile Commands { get; private set; }

		/// <summary>
		/// web.conf
		/// </summary>
		public WebConfFile Web { get; private set; }

		/// <summary>
		/// world.conf
		/// </summary>
		public WorldConfFile World { get; private set; }

		/// <summary>
		/// Initilizes default confs.
		/// </summary>
		public Conf()
		{
			this.Log = new LogConfFile();
			this.Database = new DatabaseConfFile();
			this.Commands = new CommandsConfFile();
			this.Web = new WebConfFile();
			this.World = new WorldConfFile();
		}

		/// <summary>
		/// Loads all conf files.
		/// </summary>
		public void LoadAll()
		{
			this.Log.Load();
			this.Database.Load();
			this.Commands.Load();
			this.Web.Load();
			this.World.Load();
		}
	}
}
