using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Components;

namespace Melia.Zone.Buffs.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Buff handler for Archer Kneelingshot Buff, which grants
	/// extra damage, range, attack speed, and possibly
	/// crit rate, but prevents movement.  
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Crit bonus
	/// </remarks>
	[BuffHandler(BuffId.Archer_Kneelingshot)]
	public class Archer_Kneelingshot : BuffHandler, IBuffCombatAttackBeforeCalcHandler
	{
		private const float PAtkBuffRate = 0.15f;
		private const float RangeBonus = 35f;
		private const float AspdBonus = 250f;

		/// <summary>
		/// Starts buff, increasing stats and disallowing movement.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;
			buff.Target.AddState(StateType.Held);

			var bonusPatk = target.Properties.GetFloat(PropertyName.PATK) * PAtkBuffRate;

			AddPropertyModifier(buff, buff.Target, PropertyName.PATK_BM, bonusPatk);
			AddPropertyModifier(buff, buff.Target, PropertyName.SkillRange_BM, RangeBonus);
			AddPropertyModifier(buff, buff.Target, PropertyName.ASPD_BM, AspdBonus);
		}

		/// <summary>
		/// Ends the buff, resetting stats and allowing movement.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			buff.Target.RemoveState(StateType.Held);

			RemovePropertyModifier(buff, buff.Target, PropertyName.PATK_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.SkillRange_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM);
		}

		/// <summary>
		/// Applies the debuff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (buff.NumArg2 > 0)
				modifier.BonusCritChance += buff.NumArg2;
		}
	}
}
