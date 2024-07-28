using Melia.Shared.Game.Const;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Abilities.Handlers
{
	/// <summary>
	/// Example ability handler for ability Swordman1.
	/// </summary>
	[AbilityHandler(AbilityId.Swordman1)]
	public class Example : IAbilityHandler, IAbilityCombatAttackAfterCalcHandler
	{
		/// <summary>
		/// Applies the ability effect after combat calculations.
		/// </summary>
		/// <param name="ability"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackAfterCalc(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// Do something after combat calculations if ability was active
		}
	}
}
