using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handler for the Bear buff.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Bear_Buff)]
	public class Bear_Buff : BuffHandler
	{
		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.Bear_Buff)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!target.TryGetBuff(BuffId.Bear_Buff, out var buff))
				return;

			var skillLevel = buff.NumArg1;
			var multiplierReduction = skillLevel * 0.02f;

			// We originally reduced the damage directly from inside the
			// combat calculations, on AfterBonuses, but setting the
			// multiplier seems much easier. Is this correct? Who knows.

			modifier.DamageMultiplier -= multiplierReduction;
		}
	}
}
