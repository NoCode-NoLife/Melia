using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handle for the Rampage After Buff, which increases damage
	/// dealt and taken by 50% and prevents the caster from evading.
	/// </summary>
	/// <remarks>
	/// NumArg1: Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Rampage_After_Buff)]
	public class Rampage_After_Buff : BuffHandler
	{
		private const float DamageBonus = 0.5f;
		private const float DamagePenalty = 0.5f;

		/// <summary>
		/// Adds the damage bonus.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.Rampage_After_Buff)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (attacker.IsBuffActive(BuffId.Rampage_After_Buff))
			{
				modifier.FinalDamageMultiplier += DamageBonus;
			}

			if (target.IsBuffActive(BuffId.Rampage_After_Buff))
			{
				modifier.FinalDamageMultiplier += DamagePenalty;
				modifier.ForcedHit = true;
			}
		}
	}
}
