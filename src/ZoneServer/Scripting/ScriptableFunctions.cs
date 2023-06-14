using System;
using System.Collections.Generic;
using System.Reflection;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Manager for scriptable functions.
	/// </summary>
	/// <remarks>
	/// Primarily used for the calculation of properties and results
	/// related to combat and skill usage.
	/// </remarks>
	public static class ScriptableFunctions
	{
		// A list with all delegate collections for easy iteration
		// during setup and dedicated lists for easy access afterwards.
		// New collections can be added by creating a new delegate type,
		// adding the collection to the class, and initializing it
		// in the constructor.

		private static readonly List<IDelegateCollection> Collections = new List<IDelegateCollection>();

		public static readonly DelegateCollection<CharacterCalcFunc> Character = new DelegateCollection<CharacterCalcFunc>();
		public static readonly DelegateCollection<MonsterCalcFunc> Monster = new DelegateCollection<MonsterCalcFunc>();
		public static readonly DelegateCollection<SkillCalcFunc> Skill = new DelegateCollection<SkillCalcFunc>();
		public static readonly DelegateCollection<SkillUseFunc> SkillUse = new DelegateCollection<SkillUseFunc>();

		/// <summary>
		/// Sets up delegate collections.
		/// </summary>
		static ScriptableFunctions()
		{
			Collections.Add(Character = new DelegateCollection<CharacterCalcFunc>());
			Collections.Add(Monster = new DelegateCollection<MonsterCalcFunc>());
			Collections.Add(Skill = new DelegateCollection<SkillCalcFunc>());
			Collections.Add(SkillUse = new DelegateCollection<SkillUseFunc>());
		}

		/// <summary>
		/// Loads and registers scriptable functions on the given object.
		/// </summary>
		/// <param name="obj"></param>
		public static void Load(object obj)
		{
			foreach (var method in obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				foreach (var attribute in method.GetCustomAttributes<ScriptableFunctionAttribute>(false))
				{
					var funcName = attribute.ScriptFuncName;
					var registered = false;

					foreach (var col in Collections)
					{
						if (col.TryRegister(funcName, method))
						{
							registered = true;
							break;
						}
					}

					if (!registered)
						throw new Exception($"Unknown method signature for scriptable function '{method.Name}' on '{obj.GetType().Name}'.");
				}
			}
		}
	}

	/// <summary>
	/// Used to mark a method as a custom command script handler.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class ScriptableFunctionAttribute : Attribute
	{
		/// <summary>
		/// Returns the name of the script that is handled by the function.
		/// </summary>
		public string ScriptFuncName { get; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		public ScriptableFunctionAttribute(string scriptFuncName)
		{
			this.ScriptFuncName = scriptFuncName;
		}
	}

	/// <summary>
	/// A function that calculates a value for a character.
	/// </summary>
	/// <param name="character"></param>
	/// <returns></returns>
	public delegate float CharacterCalcFunc(Character character);

	/// <summary>
	/// A function that calculates a value for a monster.
	/// </summary>
	/// <param name="monster"></param>
	/// <returns></returns>
	public delegate float MonsterCalcFunc(IMonster monster);

	/// <summary>
	/// A function that calculates a value for a skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	public delegate float SkillCalcFunc(Skill skill);

	/// <summary>
	/// A function that calculates values related to skills and combat.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <returns></returns>
	public delegate float SkillUseFunc(ICombatEntity attacker, ICombatEntity target, Skill skill);
}
