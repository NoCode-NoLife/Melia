using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handle for the Scan debuff, which makes it more likely to be critical hit.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Ranger_Scan_Debuff)]
	public class Ranger_Scan_Debuff : BuffHandler
	{
		private const float BaseCritBonus = 17.5f;
		private const float CritBonusPerLevel = 3f;

		/// <summary>
		/// Applies the debuff's effect during the combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.Ranger_Scan_Debuff)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!target.TryGetBuff(BuffId.Ranger_Scan_Debuff, out var buff))
				return;

			var skillLevel = buff.NumArg1;
			var bonus = BaseCritBonus + CritBonusPerLevel * skillLevel;

			modifier.BonusCritChance += bonus;
		}
	}
}
