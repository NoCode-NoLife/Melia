using Melia.Shared.Util.Configuration.Files;

namespace Melia.Shared.Util.Configuration
{
	public class Conf : ConfFile
	{
		/// <summary>
		/// log.conf
		/// </summary>
		public LogConfFile Log { get; protected set; }

		/// <summary>
		/// database.conf
		/// </summary>
		public DatabaseConfFile Database { get; private set; }

		/// <summary>
		/// Initilizes default confs.
		/// </summary>
		public Conf()
		{
			this.Log = new LogConfFile();
			this.Database = new DatabaseConfFile();
		}

		/// <summary>
		/// Loads all conf files.
		/// </summary>
		public void LoadAll()
		{
			this.Log.Load();
			this.Database.Load();
		}
	}
}
