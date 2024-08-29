using System;
using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Yggdrasil.Logging;

namespace Melia.Zone.World
{
	/// <summary>
	/// Manages the world's global variables.
	/// </summary>
	public class GlobalVariables
	{
		private bool _initialized = false;
		private readonly VariablesContainer _variables = new();

		/// <summary>
		/// Returns the variable containers.
		/// </summary>
		public VariablesContainer Variables
		{
			get
			{
				if (!_initialized)
					throw new InvalidOperationException("The global variables were not yet initialized.");

				return _variables;
			}
		}

		/// <summary>
		/// Initializes the global variables.
		/// </summary>
		internal void Init()
		{
			if (_initialized)
				throw new InvalidOperationException("The global variables were initialized already.");

			ZoneServer.Instance.Database.LoadVars(_variables.Perm, "vars_global", null, 0);
			ZoneServer.Instance.ServerEvents.MinuteTick += this.OnMinuteTick;

			_initialized = true;
		}

		/// <summary>
		/// Saves the permanent global variables to the database in regular
		/// intervals.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMinuteTick(object sender, TimeEventArgs e)
		{
			if (!_initialized)
				return;

			// TODO: Technically we could check if any variables actually
			//   changed and only save if necessary, but I'm not gonna
			//   bother with that for now.

			ZoneServer.Instance.Database.SaveVariables(this.Variables.Perm, "vars_global", null, 0);
			Log.Info("Global variables saved to database.");
		}
	}
}
