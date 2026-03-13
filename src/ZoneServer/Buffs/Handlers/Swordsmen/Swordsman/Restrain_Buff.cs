using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handle for the Restrain Buff, which reduces maximum HP
	/// in exchange for a chance to stun on normal attacks.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Stun Chance (%)
	/// </remarks>
	[BuffHandler(BuffId.Restrain_Buff)]
	public class Restrain_Buff : BuffHandler
	{
		private const float MaxHpDropBase = 50f;
		private const float MaxHpDropPerLevel = 28f;
		private static readonly TimeSpan StunDuration = TimeSpan.FromSeconds(3);

		/// <summary>
		/// Called every time the buff is activated, including overbuff.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="activationType"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var penalty = this.GetMaxHpPenalty(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.MHP_BM, -penalty);
		}

		/// <summary>
		/// Called when the buff expires or is removed.
		/// </summary>
		/// <param name="buff"></param>
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
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.AfterCalc, BuffId.Restrain_Buff)]
		public void OnAfterCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// TODO: Move to a hit event handler, that is to be added,
			// to ensure this happens on actual hits and not during
			// calculations.

			if (!attacker.TryGetBuff(BuffId.Restrain_Buff, out var buff))
				return;

			if (!skill.IsNormalAttack)
				return;

			var stunChance = buff.NumArg2;
			var applyBuff = RandomProvider.Get().Next(100) < stunChance;

			if (applyBuff)
				target.StartBuff(BuffId.Stun, skill.Level, 0, StunDuration, attacker);
		}
	}
}
