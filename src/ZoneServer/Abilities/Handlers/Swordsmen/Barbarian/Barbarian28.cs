using System;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Abilities.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian ability Barbarian28 (Wild Nature)
	/// and Barbarian29 (Wild Nature: Duration).
	/// </summary>
	public static class Barbarian28
	{
		/// <summary>
		/// Starts Wild Nature buff if Barbarian28 is active.
		/// </summary>
		/// <param name="entity"></param>
		public static void TryApplyBuff(ICombatEntity entity)
		{
			if (!entity.IsAbilityActive(AbilityId.Barbarian28))
				return;

			var durationSeconds = 5;
			if (entity.IsAbilityActive(AbilityId.Barbarian26))
				durationSeconds += 5;

			entity.StartBuff(BuffId.ScudInstinct_Buff, 1, 0, TimeSpan.FromSeconds(durationSeconds), entity);
		}
	}
}
