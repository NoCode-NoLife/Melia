using System;
using Melia.Shared.Scripting;
using Yggdrasil.Scripting;

namespace Melia.Barracks.Scripting
{
	/// <summary>
	/// General purpose script class.
	/// </summary>
	public abstract class GeneralScript : IScript, IDisposable
	{
		/// <summary>
		/// Initializes script.
		/// </summary>
		/// <returns></returns>
		public bool Init()
		{
			this.Load();

			OnAttribute.Load(this, BarracksServer.Instance.ServerEvents);

			return true;
		}

		/// <summary>
		/// Called when the script is being removed before a reload.
		/// </summary>
		public void Dispose()
		{
			OnAttribute.Unload(this, BarracksServer.Instance.ServerEvents);
		}

		/// <summary>
		/// Called during initialization to set up the script.
		/// </summary>
		public virtual void Load()
		{
		}
	}
}
