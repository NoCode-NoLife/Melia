using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handler for the Swordman skill Liberate.
	/// </summary>
	[SkillHandler(SkillId.Swordman_Liberate)]
	public class Swordman_Liberate : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying the buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.Liberate_Buff, skill.Level, 0, GetDuration(caster), caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);
		}

		/// <summary>
		/// Returns the duration of the buff for the caster, affected by
		/// factors such as active abilities.
		/// </summary>
		/// <param name="caster"></param>
		/// <returns></returns>
		public static TimeSpan GetDuration(ICombatEntity caster)
		{
			var duration = TimeSpan.FromSeconds(30);

			// Ability "Liberate: Awaken"
			// Reduces the duration to 12 seconds
			if (caster.TryGetActiveAbility(AbilityId.Swordman31, out var ability))
				duration = TimeSpan.FromSeconds(12);

			// Ability "Liberate: Fortitude"
			// Reduces the duration to 6 seconds
			if (caster.TryGetActiveAbility(AbilityId.Swordman32, out ability))
				duration = TimeSpan.FromSeconds(6);

			return duration;
		}

		/// <summary>
		/// Increases damage of attackers affected by the Liberate buff
		/// and the Awaken ability.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, AbilityId.Swordman31)]
		public static void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// Ability "Liberate: Awaken"
			// Increases damage to enemies by 50%
			if (attacker.IsAbilityActive(AbilityId.Swordman31))
				modifier.DamageMultiplier += 0.50f;

			// Ability "Liberate: Fortitude"
			// Increases damage reduction by 50%
			if (target.IsAbilityActive(AbilityId.Swordman32))
				modifier.DamageMultiplier -= 0.50f;
		}
	}
}
