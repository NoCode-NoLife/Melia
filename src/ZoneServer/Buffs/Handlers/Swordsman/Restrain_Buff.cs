using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Restrain Buff, which reduces maximum HP
	/// in exchange for a chance to stun on normal attacks.
	/// </summary>
	[BuffHandler(BuffId.Restrain_Buff)]
	public class Restrain_Buff : BuffHandler, IBuffCombatAttackAfterCalcHandler
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
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!skill.IsNormalAttack)
				return;

			var stunChance = buff.NumArg2;
			var applyBuff = RandomProvider.Get().Next(100) < stunChance;

			if (applyBuff)
				target.StartBuff(BuffId.Stun, skill.Level, 0, StunDuration, attacker);
		}
	}
}
