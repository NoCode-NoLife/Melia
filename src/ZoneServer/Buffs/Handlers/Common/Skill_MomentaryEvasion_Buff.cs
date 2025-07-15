using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Contains code related to the Momentary Block Buff
	/// </summary>
	/// <remarks>
	/// This buff is granted by certain skills and causes you to always
	/// evade for a duration.
	/// </remarks>
	[BuffHandler(BuffId.Skill_MomentaryEvasion_Buff)]
	public class Skill_MomentaryEvasion_Buff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
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
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			modifier.ForcedEvade = true;
		}
	}
}
