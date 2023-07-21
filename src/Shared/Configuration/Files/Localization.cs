using System.Collections.Generic;
using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents localization.conf.
	/// </summary>
	public class LocalizationConf : ConfFile
	{
		public string Language { get; protected set; }
		public string Culture { get; protected set; }
		public string CultureUi { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.Language = this.GetString("language", "en-US");
			this.Culture = this.GetString("culture", "en-US");
			this.CultureUi = this.GetString("culture_ui", "en-US");
		}

		public Dictionary<string, string> GetOptions()
		{
			return _options;
		}
	}
}
