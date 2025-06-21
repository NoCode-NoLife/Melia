using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents inter.conf
	/// </summary>
	public class InterConfFile : ConfFile
	{
		public string Authentication { get; protected set; }

		public const string AuthenticationDefault = "change_me";
		public bool IsUsingDefaultAuthentication => this.Authentication == AuthenticationDefault;

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.Authentication = this.GetString("authentication", AuthenticationDefault);
		}
	}
}
