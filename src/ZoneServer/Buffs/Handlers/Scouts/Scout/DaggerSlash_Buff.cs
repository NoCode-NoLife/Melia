using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scouts.Scout
{
	/// <summary>
	/// Handler for the Dagger Slash Buff.
	/// </summary>
	[BuffHandler(BuffId.DaggerSlash_Buff)]
	public class DaggerSlash_Buff : BuffHandler
	{
		/// <summary>
		/// Applies the buff's effect before the damage calculation.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.DaggerSlash_Buff)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!attacker.TryGetBuff(BuffId.DaggerSlash_Buff, out var buff))
				return;

			modifier.DamageMultiplier += buff.OverbuffCounter * 0.07f;
		}
	}
}
