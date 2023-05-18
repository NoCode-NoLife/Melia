using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents login.conf.
	/// </summary>
	public class LoginConfFile : ConfFile
	{
		/// <summary>
		/// When enabled, client integrity checks are applied.
		/// </summary>
		public bool VerifyIpf { get; private set; }

		/// <summary>
		/// Checksum to prevent clients using modified or out-dated IPF files.
		/// </summary>
		public string IpfChecksum { get; private set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.IpfChecksum = this.GetString("ipf_checksum", "");
			this.VerifyIpf = this.GetBool("ipf_verifying", false);
		}
	}
}
