using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Rodelero
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
			if (skill.IsNormalAttack && IsStrike(attacker, skill))
				modifier.DamageMultiplier += StrikeDamageIncrease;
		}

		/// <summary>
		/// Returns true if the skill attack is classified as a strike.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="attacker"></param>
		/// <returns></returns>
		private static bool IsStrike(ICombatEntity attacker, Skill skill)
		{
			if (skill.Data.AttackType == SkillAttackType.Strike)
				return true;

			var weaponAttackType = attacker.Components.Get<InventoryComponent>()?.GetItem(EquipSlot.RightHand)?.Data.AttackType;
			if (weaponAttackType == SkillAttackType.Strike)
				return true;

			return false;
		}
	}
}
