using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the Crescendo Bane Buff, which decreases the delays between
	/// damage ticks of Wugushi skills, aka the damage cycles.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Crescendo_Bane_Buff)]
	public class Crescendo_Bane_Buff : BuffHandler
	{
		/// <summary>
		/// Reduces the buff's update time once if applicable. Returns true
		/// if the update time was modified at any point, now or before.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		public static void TryApply(Buff buff)
		{
			if (buff.Vars.GetBool("CrescendoBaneBuff"))
				return;

			var updateTime = buff.Data.UpdateTime;

			if (TryApply(buff.Caster, ref updateTime))
			{
				buff.UpdateTime = updateTime;
				buff.Vars.SetBool("CrescendoBaneBuff", true);
			}
		}

		/// <summary>
		/// Reduces the given delay if applicable.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="damageTickDelay"></param>
		/// <returns></returns>
		public static bool TryApply(ICombatEntity caster, ref TimeSpan damageTickDelay)
		{
			if (!caster.TryGetBuff(BuffId.Crescendo_Bane_Buff, out var buff))
				return false;

			var reduction = GetBonusRatio(buff.NumArg1);
			var multiplier = Math.Max(0, 1f - reduction);

			damageTickDelay *= multiplier;

			return true;
		}

		/// <summary>
		/// Return the reduction ratio of the tick delay.
		/// </summary>
		/// <param name="skillLevel"></param>
		/// <returns></returns>
		private static float GetBonusRatio(float skillLevel)
		{
			return Math.Min(1, (12 + skillLevel * 2) / 100f);
		}
	}
}
