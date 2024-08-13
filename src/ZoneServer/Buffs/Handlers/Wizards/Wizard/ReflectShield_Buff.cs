using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Wizards.Wizard
{
	/// <summary>
	/// Handler for the Reflect Shield buff.
	/// </summary>
	[BuffHandler(BuffId.ReflectShield_Buff)]
	public class ReflectShield_Buff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
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
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var skillLevel = buff.NumArg1;
			var multiplierReduction = skillLevel * 3 / 100f;

			// We originally reduced the damage directly from inside the combat
			// calculations, on BeforeBonuses, but setting the multiplier seems
			// much easier. Is this correct? Who knows.

			modifier.DamageMultiplier -= multiplierReduction;

			var maxSp = target.Properties.GetFloat(PropertyName.MSP);
			var spRate = 0.7f / 100f;

			target.TrySpendSp(maxSp * spRate);
		}
	}
}
