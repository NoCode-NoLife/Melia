using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Barbarian
{
	/// <summary>
	/// Handle for the Savagery Buff, which adds one extra hit
	/// to all Thurst (Aries) type attacks
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Unused
	/// </remarks>
	[BuffHandler(BuffId.Savagery_Buff)]
	public class Savagery_Buff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
	{
		/// <summary>
		/// Adds 1 extra hit if the attack is Aries
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (skill.Data.AttackType == SkillAttackType.Aries)
				modifier.HitCount++;
		}
	}
}
