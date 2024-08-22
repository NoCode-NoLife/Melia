using Melia.Shared.Game.Const;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handler for the passive Bullet Maker skill Tracer Bullet.
	/// </summary>
	[SkillHandler(SkillId.Bulletmarker_TracerBullet)]
	public class Bulletmarker_TracerBullet : ISkillHandler, ISkillCombatAttackBeforeCalcHandler
	{
		/// <summary>
		/// Applies the skill's effect before the combat calculations.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="attackerSkill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// Increase Accuracy by a percentage
			var accuracyRateBonus = this.GetAccuracyRateBonus(skill);
			attacker.Properties.Modify(PropertyName.HR_RATE_BM, accuracyRateBonus);

			// Increase Minimum Critical Rate by a percentage
			modifier.MinCritChance *= 1 + this.GetMinimumCriticalRateBonus(skill);
		}

		/// <summary>
		/// Returns the accuracy rate bonus applied on the skill
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetAccuracyRateBonus(Skill skill)
		{
			return (10 + (skill.Level * 2)) / 100;
		}

		/// <summary>
		/// Returns the minmum Critical Rate Bonus applied on the skill
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetMinimumCriticalRateBonus(Skill skill)
		{
			return (10 + (skill.Level * 2)) / 100;
		}
	}
}
