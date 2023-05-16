using Yggdrasil.Scripting;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// General purpose script class.
	/// </summary>
	public class GeneralScript : IScript
	{
		/// <summary>
		/// Initializes script.
		/// </summary>
		/// <returns></returns>
		public bool Init()
		{
			this.Load();
			return true;
		}

		/// <summary>
		/// Called when the script is being initialized.
		/// </summary>
		public virtual void Load()
		{
		}
	}
}
