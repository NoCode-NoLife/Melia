using System;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Scripting.ScriptableEvents
{
	/// <summary>
	/// Declares a method as a combat calculation modification handler for
	/// the specified phase and identifier.
	/// </summary>
	/// <remarks>
	/// Used to automatically set up events for affecting combat
	/// calculations, such as buffs, skills, and abilities. Methods marked
	/// with this attribute are turned into scriptable functions with the
	/// signature "SCR_Combat_{Phase}_{Identifier}" where supported, which
	/// are called as needed during combat calculations.
	///
	/// For maximum flexibility, the phases and identifiers are not
	/// strictly defined and use strings instead. This allows for the
	/// creation of custom phases and identifiers as needed. For standard
	/// values, see <see cref="CombatCalcPhase"/>.
	/// </remarks>
	/// <example>
	/// [CombatCalcModifier(CombatCalcPhase.BeforeCalc, SkillId.Ranger_SteadyAim)]
	/// public void OnCombatBeforeCalc(...)
	///
	/// The above method will be registered as a scriptable function with
	/// the name "SCR_Combat_BeforeCalc_Ranger_SteadyAim" and called
	/// during the BeforeCalc phase of combat calculations if the attacker
	/// or the target has the relevant skills. Effectively, it's the same
	/// as creating a scriptable function with these attributes:
	/// 
	/// [ScriptableFunction("SCR_Combat_BeforeCalc_Ranger_SteadyAim")]
	/// public void OnCombatBeforeCalc(...)
	/// 
	/// [ScriptableFunction]
	/// public void SCR_Combat_BeforeCalc_Ranger_SteadyAim(...)
	/// </example>
	[AttributeUsage(AttributeTargets.Method)]
	public class CombatCalcModifierAttribute : ScriptableFunctionAttribute
	{
		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="phase"></param>
		/// <param name="identifier"></param>
		public CombatCalcModifierAttribute(string phase, string identifier)
			: base($"SCR_Combat_{phase}_{identifier}")
		{
		}

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="phase"></param>
		/// <param name="identifier"></param>
		public CombatCalcModifierAttribute(string phase, int identifier)
			: this(phase, identifier.ToString())
		{
		}

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="phase"></param>
		/// <param name="skillId"></param>
		public CombatCalcModifierAttribute(string phase, SkillId skillId)
			: this(phase, skillId.ToString())
		{
		}
	}

	public static class CombatCalcPhase
	{
		/// <summary>
		/// Occurs before the combat calculations begin.
		/// </summary>
		public const string BeforeCalc = "BeforeCalc";

		/// <summary>
		/// Occurs after the basic combat calculations have been
		/// performed, but before bonuses such as race and size
		/// multipliers are applied.
		/// </summary>
		public const string BeforeBonuses = "BeforeBonuses";

		/// <summary>
		/// Occurs after the basic combat calculations have been performed
		/// and all bonuses have been applied. Only crit and block
		/// calculations follow this phase, before AfterCalc is triggered.
		/// </summary>
		public const string AfterBonuses = "AfterBonuses";

		/// <summary>
		/// Occurs after all combat calculations have been performed,
		/// including bonuses.
		/// </summary>
		public const string AfterCalc = "AfterCalc";
	}
}
