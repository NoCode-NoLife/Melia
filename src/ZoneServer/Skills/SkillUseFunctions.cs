using System;
using System.Collections.Generic;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills
{
	/// <summary>
	/// Provides quick access to scriptable skill use functions.
	/// </summary>
	public static class SkillUseFunctions
	{
		private readonly static Dictionary<string, SkillUseFunc> Cached = new Dictionary<string, SkillUseFunc>();

		/// <summary>
		/// Calls the scriptable skill use function with the given name.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the skill use function with the given name was not
		/// defined.
		/// </exception>
		public static float Call(string name, ICombatEntity caster, ICombatEntity target, Skill skill)
		{
			if (Cached.TryGetValue(name, out var func))
				return func(caster, target, skill);

			if (!ScriptableFunctions.TryGetSkillUseFunc(name, out func))
				throw new ArgumentException($"Scriptable function '{name}' was not defined.");

			Cached[name] = func;

			return func(caster, target, skill);
		}

		/// <summary>
		/// Calculates the damage for the given skill if used by the attacker
		/// on the target, factoring in attack and defense properties.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static float SCR_CalculateDamage(ICombatEntity caster, ICombatEntity target, Skill skill)
			=> Call("SCR_CalculateDamage", caster, target, skill);
	}
}
