using Melia.Login.Util.Configuration.Files;
using Melia.Shared.Util.Configuration;

namespace Melia.Login.Util.Configuration
{
	public class LoginConf : Conf
	{
		/// <summary>
		/// login.conf
		/// </summary>
		public LoginConfFile Login { get; private set; }

		/// <summary>
		/// Initilizes default confs.
		/// </summary>
		public LoginConf() : base()
		{
			this.Login = new LoginConfFile();
		}

		/// <summary>
		/// Loads all conf files.
		/// </summary>
		public override void LoadAll()
		{
			base.LoadAll();

			this.Login.Load();
		}
	}
}
