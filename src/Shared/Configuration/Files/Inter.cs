using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents inter.conf
	/// </summary>
	public class InterConfFile : ConfFile
	{
		public string Password { get; protected set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.Password = this.GetString("password", "change_me");
		}
	}
}
