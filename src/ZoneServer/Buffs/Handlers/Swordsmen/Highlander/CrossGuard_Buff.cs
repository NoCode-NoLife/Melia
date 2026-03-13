using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Highlander
{
	/// <summary>
	/// Handle for the Cross Guard Buff, which increases the target's block rate,
	/// but prevents evasion.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.CrossGuard_Buff)]
	public class CrossGuard_Buff : BuffHandler
	{
		private const float BlkRateBonusPerLevel = 0.01f;
		private const float DebuffDuration = 5f;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM, this.GetBlkBonus(buff));
			AddPropertyModifier(buff, buff.Target, PropertyName.DR_RATE_BM, -1f);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_RATE_BM);
		}

		/// <summary>
		/// Returns the Block bonus to use
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetBlkBonus(Buff buff)
		{
			// Some forum posts suggest your base level may affect the formula?
			return BlkRateBonusPerLevel * buff.NumArg1;
		}

		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.AfterCalc, BuffId.CrossGuard_Buff)]
		public void OnAfterCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!target.TryGetBuff(BuffId.CrossGuard_Buff, out var buff))
				return;

			// this previously instead applied a debuff to the attacker
			// attacker.StartBuff(BuffId.CrossGuard_Debuff, buff.NumArg1, 0, TimeSpan.FromSeconds(DebuffDuration), target);

			target.StartBuff(BuffId.CrossGuard_Damage_Buff, buff.NumArg1, 0, TimeSpan.FromSeconds(DebuffDuration), target);

			if (target.TryGetSkill(SkillId.Highlander_CrossGuard, out var crossGuardSkill))
				crossGuardSkill.StartCooldown(TimeSpan.FromSeconds(15));
		}
	}
}
