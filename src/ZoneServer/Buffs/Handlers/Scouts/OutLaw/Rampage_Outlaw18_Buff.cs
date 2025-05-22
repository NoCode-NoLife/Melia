using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handle for the Rampage Outlaw18 Buff, which gives 10%
	/// bonus crit chance per debuff that was active when it
	/// was started (which was calculated when it was applied)
	/// </summary>
	/// <remarks>
	/// NumArg1: Debuff Count
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Rampage_Outlaw18_Buff)]
	public class Rampage_Outlaw18_Buff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
	{
		public const float CritBonusPerDebuff = 10f;

		/// <summary>
		/// Adds the bonus crit chance
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			modifier.BonusCritChance = CritBonusPerDebuff * buff.NumArg1;
		}
	}
}
