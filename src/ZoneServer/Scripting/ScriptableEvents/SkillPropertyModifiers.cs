using System;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Scripting.ScriptableEvents
{
	/// <summary>
	/// Declares a scriptable function with the name "SCR_Get_SpendSP_"
	/// followed by the skill id, which overrides the SP cost calculations
	/// for the specified skill.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class SkillSpOverrideAttribute : ScriptableFunctionAttribute
	{
		public SkillSpOverrideAttribute(SkillId skillId)
			: base("SCR_Get_SpendSP_" + skillId)
		{
		}
	}

	/// <summary>
	/// Declares a scriptable function with the name
	/// "GET_SKILL_OVERHEAT_COUNT_" followed by the skill id, which
	/// overrides the max overheat count calculations for the specified
	/// skill.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class SkillOverheatOverrideAttribute : ScriptableFunctionAttribute
	{
		public SkillOverheatOverrideAttribute(SkillId skillId)
			: base("GET_SKILL_OVERHEAT_COUNT_" + skillId)
		{
		}
	}

	/// <summary>
	/// Declares a scriptable function with the name
	/// "SCR_GET_USEOVERHEAT_" followed by the skill id, which overrides
	/// the overheat cooldown calculations for the specified skill.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class SkillCooldownOverrideAttribute : ScriptableFunctionAttribute
	{
		public SkillCooldownOverrideAttribute(SkillId skillId)
			: base("SCR_GET_USEOVERHEAT_" + skillId)
		{
		}
	}
}
