using System;
using Melia.Shared.Scripting;
using Yggdrasil.Scripting;

namespace Melia.Zone.Scripting
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

			OnAttribute.Load(this, ZoneServer.Instance.ServerEvents);

			// The game has an array of dynamically called scripting
			// functions for various purposes. They all have their own
			// parameter types and for the moment we'll treat them all
			// separately, loading them into static classes. We can clean
			// this up one day when we know everything we have to deal
			// with.
			ItemScripts.Load(this);
			DialogTxScripts.Load(this);
			NormalTxScripts.Load(this);
			CustomCommandScripts.Load(this);

			return true;
		}

		/// <summary>
		/// Called when the script is being removed before a reload.
		/// </summary>
		public void Dispose()
		{
			OnAttribute.Unload(this, ZoneServer.Instance.ServerEvents);
		}

		/// <summary>
		/// Called during initialization to set up the script.
		/// </summary>
		public virtual void Load()
		{
		}
	}
}
