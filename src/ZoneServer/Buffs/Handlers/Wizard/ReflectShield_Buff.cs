using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Wizard
{
	/// <summary>
	/// Handler for the Reflect Shield buff.
	/// </summary>
	public class ReflectShield_Buff : BuffHandler, IBuffCombatBeforeCalcHandler
	{
		/// <summary>
		/// Applies the buff's effects during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var skillLevel = buff.NumArg1;
			var multiplierReduction = skillLevel * 3 / 100f;

			// We originally reduced the damage directly from inside the combat
			// calculations, on BeforeBonuses, but we can't do that from here
			// currently. This should not have a big effect on the final damage,
			// but let's keep an eye on it.

			//damage = Math.Max(1, damage - damage * rate);
			modifier.DamageMultiplier -= multiplierReduction;

			var maxSp = target.Properties.GetFloat(PropertyName.MSP);
			var spRate = 0.7f / 100f;

			target.TrySpendSp(maxSp * spRate);
		}
	}
}
