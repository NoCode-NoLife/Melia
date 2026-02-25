using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Handle for the Running Shot buff, which adds bonus factor
	/// and an extra hit to crossbow normal attacks, as well as
	/// increasing attack speed by 10%
	/// It also debuffs your movespeed if you use it on a PVP map
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Skill Factor
	/// </remarks>
	[BuffHandler(BuffId.RunningShot_Buff)]
	public class RunningShot_Buff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
	{
		private const float AspdRateBonus = 0.1f;
		private const float MspdDebuff = 2f;

		/// <summary>
		/// Starts buff, modifying the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			var aspdBonus = target.Properties.GetFloat(PropertyName.ASPD) * AspdRateBonus;
			AddPropertyModifier(buff, target, PropertyName.ASPD_BM, aspdBonus);

			// TODO: Should only apply the debuff on PVP maps
			// if (caster.Map.IsPvp)

			AddPropertyModifier(buff, target, PropertyName.MSPD_BM, -MspdDebuff);
			Send.ZC_MSPD(target);
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
			Send.ZC_MSPD(buff.Target);
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
		public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// only applies to crossbow normal attack
			if (skill.Id != SkillId.CrossBow_Attack)
				return;

			// Add extra Factor and +1 hit count
			modifier.BonusFactor += buff.NumArg2;
			modifier.HitCount++;
		}
	}
}
