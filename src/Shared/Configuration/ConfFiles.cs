using Melia.Shared.Configuration.Files;

namespace Melia.Shared.Configuration
{
	/// <summary>
	/// Wrapper around all conf files for easy access.
	/// </summary>
	public class ConfFiles
	{
		/// <summary>
		/// commands.conf
		/// </summary>
		public CommandsConfFile Commands { get; } = new();

		/// <summary>
		/// database.conf
		/// </summary>
		public DatabaseConfFile Database { get; } = new();

		/// <summary>
		/// inter.conf
		/// </summary>
		public InterConfFile Inter { get; } = new();

		/// <summary>
		/// log.conf
		/// </summary>
		public LogConfFile Log { get; } = new();

		/// <summary>
		/// localization.conf
		/// </summary>
		public LocalizationConf Localization { get; } = new();

		/// <summary>
		/// scripts.conf
		/// </summary>
		public ScriptsConf Scripts { get; } = new();

		/// <summary>
		/// social.conf
		/// </summary>
		public SocialConf Social { get; } = new();

		/// <summary>
		/// barracks.conf
		/// </summary>
		public BarracksConfFile Barracks { get; } = new();

		/// <summary>
		/// web.conf
		/// </summary>
		public WebConfFile Web { get; } = new();

		/// <summary>
		/// world.conf
		/// </summary>
		public WorldConfFile World { get; } = new();

		/// <summary>
		/// Loads all conf files.
		/// </summary>
		public virtual void Load()
		{
			this.Barracks.Load("system/conf/barracks.conf");

			this.Commands.Load("system/conf/commands.conf");
			this.Database.Load("system/conf/database.conf");
			this.Inter.Load("system/conf/inter.conf");
			this.Log.Load("system/conf/log.conf");
			this.Localization.Load("system/conf/localization.conf");
			this.Scripts.Load("system/conf/scripts.conf");
			this.Social.Load("system/conf/social.conf");
			this.Web.Load("system/conf/web.conf");
			this.World.Load("system/conf/world.conf");
		}
	}
}
