using System;
using System.Collections;
using Melia.Zone.World.Actors;
using Yggdrasil.Ai.Enumerable;
using Yggdrasil.Scheduling;
using Yggdrasil.Scripting;

namespace Melia.Zone.Scripting.AI
{
	/// <summary>
	/// A script that sets up and controls a character or monster.
	/// </summary>
	public abstract partial class AiScript : EnumerableAi, IScript, IUpdateable
	{
		/// <summary>
		/// Returns the entity that this script is controlling.
		/// </summary>
		public ICombatEntity Entity { get; private set; }

		/// <summary>
		/// Returns the name of the currently running routine if it
		/// was named.
		/// </summary>
		public string CurrentRoutine { get; private set; }

		/// <summary>
		/// Executes the AI, furthering the current routine.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Heartbeat();
		}

		/// <summary>
		/// Called whenever the AI finishes a routine and doesn't
		/// know what to do next.
		/// </summary>
		protected override void Root()
		{
		}

		/// <summary>
		/// Starts executing the given routine and saves its name.
		/// </summary>
		/// <param name="routineName"></param>
		/// <param name="routine"></param>
		public void StartRoutine(string routineName, IEnumerable routine)
		{
			this.CurrentRoutine = routineName;
			this.StartRoutine(routine);
		}
	}
}
