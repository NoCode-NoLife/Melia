using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Restrain Buff, which reduces maximum HP
	/// in exchange for a chance to stun on normal attacks.
	/// </summary>
	[BuffHandler(BuffId.Restrain_Buff)]
	public class Restrain_Buff : BuffHandler
	{
		private const float MaxHpDropBase = 50f;
		private const float MaxHpDropPerLevel = 28f;
		private static readonly TimeSpan StunDuration = TimeSpan.FromSeconds(3);

		public override void OnStart(Buff buff)
		{
			var penalty = this.GetMaxHpPenalty(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.MHP_BM, -penalty);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MHP_BM);
		}

		/// <summary>
		/// Returns the HP penalty for the buff.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetMaxHpPenalty(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return MaxHpDropBase + skillLevel * MaxHpDropPerLevel;
		}

		/// <summary>
		/// Attempts to stun the target
		/// Returns false if the caster doesn't have the buff, the skill isn't allowed to stun the target,
		/// or the target resists the stun attempt
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static bool TryStunTarget(ICombatEntity attacker, ICombatEntity target, Skill skill)
		{
			if (!attacker.TryGetBuff(BuffId.Restrain_Buff, out var restrainBuff))
				return false;

			if (!skill.IsNormalAttack)
				return false;

			var stunChance = restrainBuff.NumArg2;

			if (RandomProvider.Get().Next(100) < stunChance)
			{
				target.StartBuff(BuffId.Stun, skill.Level, 0, StunDuration, attacker);
				return true;
			}

			return false;
		}
	}
}
