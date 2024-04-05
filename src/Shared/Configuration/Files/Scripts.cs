using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents scripts.conf.
	/// </summary>
	public class ScriptsConf : ConfFile
	{
		public bool CacheScripts { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.CacheScripts = this.GetBool("cache_scripts", false);
		}
	}
}
