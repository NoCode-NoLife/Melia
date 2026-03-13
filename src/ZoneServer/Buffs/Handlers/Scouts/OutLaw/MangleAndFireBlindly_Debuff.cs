using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handle for the Mangle and Fire Blindly Debuff, which
	/// reduces damage dealt to the inflictor of the buff.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.MangleAndFireBlindly_Debuff)]
	public class MangleAndFireBlindly_Debuff : BuffHandler
	{
		/// <summary>
		/// Reduces damage dealt if the target is the caster of the buff.
		/// </summary>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.MangleAndFireBlindly_Debuff)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!attacker.TryGetBuff(BuffId.MangleAndFireBlindly_Debuff, out var buff))
				return;

			if (target == buff.Caster)
				modifier.FinalDamageMultiplier -= 0.07f * buff.OverbuffCounter;
		}
	}
}
