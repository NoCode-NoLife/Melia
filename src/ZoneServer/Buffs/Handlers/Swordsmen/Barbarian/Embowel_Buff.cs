using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handle for the Embowel buff, which decreases all damage taken
	/// while the skill is active.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Embowel_Buff)]
	public class Embowel_Buff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
	{
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
			modifier.DamageMultiplier -= 0.5f;
		}
	}
}
