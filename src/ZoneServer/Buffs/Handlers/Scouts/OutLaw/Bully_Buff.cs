using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.AI;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Buff handler for Bully Buff, which increases evasion
	/// and adds threat on successful evade.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Bully_Buff)]
	public class Bully_Buff : BuffHandler, IBuffCombatDefenseAfterCalcHandler
	{
		private const float DrBuffRateBase = 0.24f;
		private const float DrBuffRatePerLevel = 0.04f;
		private const float HatePerLevel = 3f;

		/// <summary>
		/// Starts buff, increasing dodge rate.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var dr = buff.Target.Properties.GetFloat(PropertyName.DR);
			var skillLevel = buff.NumArg1;
			var rate = DrBuffRateBase + DrBuffRatePerLevel * skillLevel;
			var bonus = dr * rate;

			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, bonus);
		}

		/// <summary>
		/// Ends the buff, resetting dodge rate.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);
		}

		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnDefenseAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (skillHitResult.Result == HitResultType.Dodge && attacker.Components.TryGet<AiComponent>(out var component))
			{
				component.Script.QueueEventAlert(new HateIncreaseAlert(target, buff.NumArg1 * HatePerLevel));

				// Outlaw12 adds additional duration to the buff on successful evade
				// Note that it only applies to monster attacks, which is why
				// it's done after the AI script check
				if (target.TryGetActiveAbilityLevel(AbilityId.Outlaw12, out var level))
				{
					buff.IncreaseDuration(TimeSpan.FromSeconds(level));
				}
			}
		}
	}
}
