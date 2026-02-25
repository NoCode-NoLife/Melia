using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Buff handler for Block and Shoot Buff, which grants
	/// extra block.
	/// The covered shot version decreases damage dealt and
	/// taken by 50%, and cuts accuracy by 70%
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: 1 if Covered Shot is active
	/// </remarks>
	[BuffHandler(BuffId.BlockAndShoot_Buff)]
	public class BlockAndShoot_Buff : BuffHandler, IBuffCombatAttackBeforeCalcHandler, IBuffCombatDefenseBeforeCalcHandler
	{
		private const float BlkBuffRate = 0.5f;
		private const float HRDebuffRate = 0.7f;

		/// <summary>
		/// Starts buff, increasing Block
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			var bonusBlk = target.Properties.GetFloat(PropertyName.BLK) * BlkBuffRate;

			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_BM, bonusBlk);

			if (buff.NumArg2 > 0)
			{
				var reduceHR = target.Properties.GetFloat(PropertyName.HR) * HRDebuffRate;

				AddPropertyModifier(buff, buff.Target, PropertyName.HR_BM, -reduceHR);
			}
		}

		/// <summary>
		/// Ends the buff, resetting Block.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_BM);
			if (buff.NumArg2 > 0)
				RemovePropertyModifier(buff, buff.Target, PropertyName.HR_BM);
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
				modifier.DamageMultiplier -= 0.5f;
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
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (buff.NumArg2 > 0)
				modifier.DamageMultiplier -= 0.5f;
		}
	}
}
