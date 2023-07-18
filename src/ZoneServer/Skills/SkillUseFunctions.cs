using System;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills
{
	/// <summary>
	/// Provides quick access to scriptable skill use functions.
	/// </summary>
	public static class SkillUseFunctions
	{
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
		public static SkillHitResult Call(string name, ICombatEntity caster, ICombatEntity target, Skill skill)
		{
			if (!ScriptableFunctions.SkillHit.TryGet(name, out var func))
				throw new ArgumentException($"Scriptable function '{name}' was not defined.");

			return func(caster, target, skill);
		}

		/// <summary>
		/// Calls the scriptable skill use function with the given name.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="skillHitInfo"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the skill use function with the given name was not
		/// defined.
		/// </exception>
		public static float Call(string name, ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
		{
			if (!ScriptableFunctions.Combat.TryGet(name, out var func))
				throw new ArgumentException($"Scriptable function '{name}' was not defined.");

			return func(caster, target, skill, skillHitResult);
		}

		/// <summary>
		/// Returns a random attack value between the min and max values
		/// for the type that matches the given skill (PATK or MATK).
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="skillHitInfo"></param>
		/// <returns></returns>
		public static float SCR_GetRandomAtk(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
			=> Call("SCR_GetRandomAtk", caster, target, skill, skillHitResult);

		/// <summary>
		/// Calculates the damage for the given skill if used by the attacker
		/// on the target, factoring in attack and defense properties.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="skillHitInfo"></param>
		/// <returns></returns>
		public static float SCR_CalculateDamage(ICombatEntity caster, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
			=> Call("SCR_CalculateDamage", caster, target, skill, skillHitResult);

		/// <summary>
		/// Determines the result of skill hitting the target.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static SkillHitResult SCR_SkillHit(ICombatEntity caster, ICombatEntity target, Skill skill)
			=> Call("SCR_SkillHit", caster, target, skill);
	}
}
