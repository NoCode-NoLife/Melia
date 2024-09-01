using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the Crescendo Bane Buff, which decreases Wugushi skill damage cycle
	/// </summary>
	[BuffHandler(BuffId.Crescendo_Bane_Buff)]
	public class Crescendo_Bane_Buff : BuffHandler
	{
		/// <summary>
		/// Applies decrease damage thick delay of the others Wugushi buffs
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="damageTickDelay"></param>
		/// <returns></returns>
		public static bool TryApply(ICombatEntity caster, ref TimeSpan damageTickDelay)
		{
			if (!caster.TryGetBuff(BuffId.Crescendo_Bane_Buff, out var buff))
				return false;

			var reduction = GetBonusRatio((int)buff.NumArg1);
			var multiplier = Math.Max(0, 1f - reduction);

			damageTickDelay *= multiplier;

			return true;
		}

		/// <summary>
		/// Return the reduction ratio of the thick delay
		/// </summary>
		/// <param name="skillLevel"></param>
		/// <returns></returns>
		private static float GetBonusRatio(int skillLevel)
		{
			return Math.Min(1, (12 + skillLevel * 2) / 100f);
		}
	}
}
