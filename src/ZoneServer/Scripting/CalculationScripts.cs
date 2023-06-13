using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Manager for scriptable calculation functions.
	/// </summary>
	/// <remarks>
	/// Primarily used for the calculation of properties.
	/// </remarks>
	public static class CalculationScripts
	{
		private static readonly Dictionary<string, CharacterCalcFunc> CharacterFuncs = new Dictionary<string, CharacterCalcFunc>();
		private static readonly Dictionary<string, MonsterCalcFunc> MonsterFuncs = new Dictionary<string, MonsterCalcFunc>();
		private static readonly Dictionary<string, SkillCalcFunc> SkillFuncs = new Dictionary<string, SkillCalcFunc>();

		/// <summary>
		/// Registers the given function as the calculator for the name.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		/// <param name="scriptFunc"></param>
		public static void RegisterCharacterFunc(string scriptFuncName, CharacterCalcFunc scriptFunc)
		{
			lock (CharacterFuncs)
				CharacterFuncs[scriptFuncName] = scriptFunc;
		}

		/// <summary>
		/// Returns the calc function for the given name via out,
		/// returns false if no script was defined.
		/// </summary>
		/// <param name="scriptName"></param>
		/// <param name="scriptFunc"></param>
		/// <returns></returns>
		public static bool TryGetCharacterFunc(string scriptName, out CharacterCalcFunc scriptFunc)
		{
			lock (CharacterFuncs)
				return CharacterFuncs.TryGetValue(scriptName, out scriptFunc);
		}

		/// <summary>
		/// Registers the given function as the calculator for the name.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		/// <param name="scriptFunc"></param>
		public static void RegisterMonsterFunc(string scriptFuncName, MonsterCalcFunc scriptFunc)
		{
			lock (MonsterFuncs)
				MonsterFuncs[scriptFuncName] = scriptFunc;
		}

		/// <summary>
		/// Returns the calc function for the given name via out,
		/// returns false if no script was defined.
		/// </summary>
		/// <param name="scriptName"></param>
		/// <param name="scriptFunc"></param>
		/// <returns></returns>
		public static bool TryGetMonsterFunc(string scriptName, out MonsterCalcFunc scriptFunc)
		{
			lock (MonsterFuncs)
				return MonsterFuncs.TryGetValue(scriptName, out scriptFunc);
		}

		/// <summary>
		/// Registers the given function as the calculator for the name.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		/// <param name="scriptFunc"></param>
		public static void RegisterSkillFunc(string scriptFuncName, SkillCalcFunc scriptFunc)
		{
			lock (SkillFuncs)
				SkillFuncs[scriptFuncName] = scriptFunc;
		}

		/// <summary>
		/// Returns the calc function for the given name via out,
		/// returns false if no script was defined.
		/// </summary>
		/// <param name="scriptName"></param>
		/// <param name="scriptFunc"></param>
		/// <returns></returns>
		public static bool TryGetSkillFunc(string scriptName, out SkillCalcFunc scriptFunc)
		{
			lock (SkillFuncs)
				return SkillFuncs.TryGetValue(scriptName, out scriptFunc);
		}

		/// <summary>
		/// Loads handler methods on the given object.
		/// </summary>
		/// <param name="obj"></param>
		public static void Load(object obj)
		{
			foreach (var method in obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				foreach (var attribute in method.GetCustomAttributes<CalculationAttribute>(false))
				{
					// Choose delegate based on the parameters

					if (method.GetParameters().Any(a => a.ParameterType == typeof(Character)))
					{
						var func = (CharacterCalcFunc)Delegate.CreateDelegate(typeof(CharacterCalcFunc), obj, method);
						RegisterCharacterFunc(attribute.ScriptFuncName, func);
					}
					else if (method.GetParameters().Any(a => a.ParameterType == typeof(IMonster)))
					{
						var func = (MonsterCalcFunc)Delegate.CreateDelegate(typeof(MonsterCalcFunc), obj, method);
						RegisterMonsterFunc(attribute.ScriptFuncName, func);
					}
					else if (method.GetParameters().Any(a => a.ParameterType == typeof(Skill)))
					{
						var func = (SkillCalcFunc)Delegate.CreateDelegate(typeof(SkillCalcFunc), obj, method);
						RegisterSkillFunc(attribute.ScriptFuncName, func);
					}
					else
					{
						throw new Exception("Invalid parameters for calculation script function: " + method.Name);
					}
				}
			}
		}
	}

	/// <summary>
	/// Used to mark a method as a custom command script handler.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class CalculationAttribute : Attribute
	{
		/// <summary>
		/// Returns the name of the script that is handled by the function.
		/// </summary>
		public string ScriptFuncName { get; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		public CalculationAttribute(string scriptFuncName)
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
}
