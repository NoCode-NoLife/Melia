using System;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsman
{
	/// <summary>
	/// Handler for the Bear buff.
	/// </summary>
	public class Bear_Buff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
	{
		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var skillLevel = buff.NumArg1;
			var multiplierReduction = skillLevel * 0.02f;

			// We originally reduced the damage directly from inside the combat
			// calculations, on AfterBonuses, but we can't do that from here
			// currently. This should not have a big effect on the final damage,
			// but let's keep an eye on it.

			//damage = Math.Max(1, damage * (1f - multiplierReduction));
			modifier.DamageMultiplier -= multiplierReduction;
		}
	}
}
