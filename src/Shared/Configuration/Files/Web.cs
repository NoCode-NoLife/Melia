using System.IO;
using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents web.conf.
	/// </summary>
	public class WebConfFile : ConfFile
	{
		/// <summary>
		/// Returns true if accounts can be created via the API.
		/// </summary>
		public bool EnableApiAccountCreation { get; private set; }

		/// <summary>
		/// Returns the path to the PHP CGI executable file.
		/// </summary>
		public string PhpCgiFilePath { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.EnableApiAccountCreation = this.GetBool("enable_api_account_creation", false);
			this.PhpCgiFilePath = this.GetString("php_cgi_bin", Path.Combine("user", "tools", "php", "php-cgi.exe"));
		}
	}
}
