using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handle for the Aggressor Buff, which adds crit hit and dodge rate,
	/// and gives forced hit on all attacks.
	/// If the feature CleaveApplyAggressor is on, this only increases 
	/// crit rate and nothing else.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Aggressor_Buff)]
	public class Aggressor_Buff : BuffHandler
	{
		public const float CritHrRateBase = 0.1f;
		public const float CritDrRateBase = 0.1f;
		public const float CritHrRatePerLevel = 0.05f;
		public const float CritDrRatePerLevel = 0.05f;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			if (Feature.IsEnabled("CleaveApplyAggressor"))
			{
				AddPropertyModifier(buff, target, PropertyName.CRTHR_RATE_BM, CritHrRateBase);
			}
			else
			{
				AddPropertyModifier(buff, target, PropertyName.CRTHR_RATE_BM, CritHrRateBase * CritHrRatePerLevel * buff.NumArg1);
				AddPropertyModifier(buff, target, PropertyName.CRTDR_RATE_BM, CritDrRateBase * CritDrRatePerLevel * buff.NumArg1);
			}
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			RemovePropertyModifier(buff, target, PropertyName.CRTHR_RATE_BM);
			RemovePropertyModifier(buff, target, PropertyName.CRTDR_RATE_BM);
		}

		/// <summary>
		/// Adds the Forced Hit modifier to all attacks
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.Aggressor_Buff)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!attacker.TryGetBuff(BuffId.Aggressor_Buff, out var buff))
				return;

			if (!Feature.IsEnabled("CleaveApplyAggressor"))
				modifier.ForcedHit = true;
		}
	}
}
