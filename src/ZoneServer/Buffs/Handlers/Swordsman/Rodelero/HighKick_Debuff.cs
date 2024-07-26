using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Highlander
{
	/// <summary>
	/// Handle for the High Kick debuff, which increases damage
	/// taken from Strike attacks.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.HighKick_Debuff)]
	public class HighKick_Debuff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
	{
		public const float StrikeDamageIncrease = 0.1f;

		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (skill.IsNormalAttack && skill.Data.AttackType == SkillAttackType.Strike)
			{
				modifier.DamageMultiplier += StrikeDamageIncrease;
			}
			else if (skill.IsNormalAttack && attacker is Character character)
			{
				var weapon = character.Inventory.GetItem(EquipSlot.RightHand);
				if (weapon != null || weapon.Data.AttackType == SkillAttackType.Strike)
					modifier.DamageMultiplier += StrikeDamageIncrease;
			}
		}
	}
}
