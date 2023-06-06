using System;
using Melia.Zone.Scripting.AI;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// Component that handles an entity's AI.
	/// </summary>
	public class AiComponent : CombatEntityComponent, IUpdateable
	{
		private readonly AiScript _script;

		/// <summary>
		/// Creates new component and loads the given AI script.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="aiName"></param>
		/// <exception cref="ArgumentException"></exception>
		public AiComponent(ICombatEntity entity, string aiName) : base(entity)
		{
			if (!AiScript.TryCreate(aiName, entity, out var aiScript))
				throw new ArgumentException($"No AI script with name '{aiName}' exists.");

			_script = aiScript;
		}

		/// <summary>
		/// Runs a tick for the AI.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			_script.Update(elapsed);
		}
	}
}
