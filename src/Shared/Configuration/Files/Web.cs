using System.Collections.Generic;
using System.IO;
using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents web.conf.
	/// </summary>
	public class WebConfFile : ConfFile
	{
		public string PhpCgiFilePath { get; protected set; }
		public string PhpDownloadUrl { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.PhpCgiFilePath = this.GetString("php_cgi_bin", Path.Combine("user", "tools", "php", "php-cgi.exe"));
			this.PhpDownloadUrl = this.GetString("php_download", "https://windows.php.net/downloads/releases/php-8.2.7-nts-Win32-vs16-x86.zip");
		}

		public Dictionary<string, string> GetOptions()
		{
			return _options;
		}
	}
}
