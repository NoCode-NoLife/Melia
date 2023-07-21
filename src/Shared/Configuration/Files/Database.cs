using System.Collections.Generic;
using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents database.conf.
	/// </summary>
	public class DatabaseConfFile : ConfFile
	{
		public string Host { get; protected set; }
		public string User { get; protected set; }
		public string Pass { get; protected set; }
		public string Db { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.Host = this.GetString("host", "127.0.0.1");
			this.User = this.GetString("user", "root");
			this.Pass = this.GetString("pass", "");
			this.Db = this.GetString("database", "melia");
		}

		public Dictionary<string, string> GetOptions()
		{
			return _options;
		}
	}
}
