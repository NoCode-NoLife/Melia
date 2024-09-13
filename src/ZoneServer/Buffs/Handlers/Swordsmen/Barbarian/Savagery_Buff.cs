using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handle for the Savagery Buff, which increases crit chance and adds
	/// one extra hit to all thrust (Aries) type attacks.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Extra Crit Chance
	/// </remarks>
	[BuffHandler(BuffId.Savagery_Buff)]
	public class Savagery_Buff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.CRTHR_BM, buff.NumArg2);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.CRTHR_BM);
		}

		/// <summary>
		/// Adds 1 extra hit if the attack is Aries, or if it's Slash and Barbarian6
		/// is active.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (skill.Data.AttackType == SkillAttackType.Aries || (attacker.IsAbilityActive(AbilityId.Barbarian6) && skill.Data.AttackType == SkillAttackType.Slash))
				modifier.HitCount++;
		}
	}
}
