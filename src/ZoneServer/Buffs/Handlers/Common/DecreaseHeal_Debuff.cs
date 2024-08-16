﻿using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handle for the DecreaseHeal_Debuff that changes the character's
	/// healing reduction and evasion properties.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.DecreaseHeal_Debuff)]
	public class DecreaseHeal_Debuff : BuffHandler
	{
		/// <summary>
		/// Applies decrease heal debuff to the hpAmount the entity is to be
		/// healed by if applicable. Returns false if they don't have the debuff
		/// and the amount was not changed.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="hpAmount"></param>
		/// <returns></returns>
		public static bool TryApply(ICombatEntity entity, ref float hpAmount)
		{
			if (!entity.TryGetBuff(BuffId.DecreaseHeal_Debuff, out var buff))
				return false;

			var reduction = GetHealingReduction(buff);
			var multiplier = Math.Max(0, 1f - reduction);

			hpAmount *= multiplier;

			return true;
		}

		/// <summary>
		/// Return the Buff Healing Reduction value
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private static float GetHealingReduction(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return 3 * skillLevel / 100f;
		}
	}
}
