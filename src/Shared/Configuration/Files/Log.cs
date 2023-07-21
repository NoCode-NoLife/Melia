using System.Collections.Generic;
using Yggdrasil.Configuration;
using Yggdrasil.Logging;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents log.conf.
	/// </summary>
	public class LogConfFile : ConfFile
	{
		public LogLevel Filter { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.Filter = (LogLevel)this.GetInt("log_filter", 0);
		}

		public Dictionary<string, string> GetOptions()
		{
			return _options;
		}
	}
}
