﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Melia.Shared.Data.Database;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
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
		// New collections can be added by creating a new delegate type
		// and adding a public collection for it below. The public
		// collections are added to the collections list automatically.

		private static readonly List<IDelegateCollection> Collections = new List<IDelegateCollection>();

		public static readonly DelegateCollection<CharacterCalcFunc> Character = new DelegateCollection<CharacterCalcFunc>();
		public static readonly DelegateCollection<MonsterCalcFunc> Monster = new DelegateCollection<MonsterCalcFunc>();
		public static readonly DelegateCollection<SkillCalcFunc> Skill = new DelegateCollection<SkillCalcFunc>();
		public static readonly DelegateCollection<CombatCalcFunction> Combat = new DelegateCollection<CombatCalcFunction>();
		public static readonly DelegateCollection<SkillHitFunction> SkillHit = new DelegateCollection<SkillHitFunction>();
		public static readonly DelegateCollection<ItemScriptFunc> Item = new DelegateCollection<ItemScriptFunc>();
		public static readonly DelegateCollection<NormalTxScriptFunc> NormalTx = new DelegateCollection<NormalTxScriptFunc>();
		public static readonly DelegateCollection<NormalTxNumScriptFunc> NormalTxNum = new DelegateCollection<NormalTxNumScriptFunc>();
		public static readonly DelegateCollection<DialogTxScriptFunc> DialogTx = new DelegateCollection<DialogTxScriptFunc>();
		public static readonly DelegateCollection<CustomCommandScriptFunc> CustomCommand = new DelegateCollection<CustomCommandScriptFunc>();
		public static readonly DelegateCollection<AbilityUnlockFunc> AbilityUnlock = new DelegateCollection<AbilityUnlockFunc>();
		public static readonly DelegateCollection<AbilityPriceFunc> AbilityPrice = new DelegateCollection<AbilityPriceFunc>();

		/// <summary>
		/// Sets up delegate collections.
		/// </summary>
		static ScriptableFunctions()
		{
			foreach (var fieldInfo in typeof(ScriptableFunctions).GetFields(BindingFlags.Static | BindingFlags.Public))
			{
				if (fieldInfo.FieldType.GetInterface(nameof(IDelegateCollection)) != null)
					Collections.Add((IDelegateCollection)fieldInfo.GetValue(null));
			}
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
					var funcName = attribute.ScriptFuncName ?? method.Name;
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
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class ScriptableFunctionAttribute : Attribute
	{
		/// <summary>
		/// Returns the name of the script that is handled by the function.
		/// </summary>
		public string ScriptFuncName { get; }

		/// <summary>
		/// Creates new attribute that uses the name of the method it's
		/// on as the script function name.
		/// </summary>
		public ScriptableFunctionAttribute()
		{
			// Getting the method name actually happens in the scriptable
			// function loading code, see ScriptableFunctions.
		}

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
	public delegate float MonsterCalcFunc(Mob monster);

	/// <summary>
	/// A function that calculates a value for a skill.
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	public delegate float SkillCalcFunc(Skill skill);

	/// <summary>
	/// A function that calculates values related to skill usage and combat.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	public delegate float CombatCalcFunction(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult);

	/// <summary>
	/// A function that determines the result of a skill hitting a target.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <returns></returns>
	public delegate SkillHitResult SkillHitFunction(ICombatEntity attacker, ICombatEntity target, Skill skill);

	/// <summary>
	/// A function that determines whether an ability can be learned.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="argStr"></param>
	/// <param name="argInt"></param>
	/// <param name="data"></param>
	/// <returns></returns>
	public delegate bool AbilityUnlockFunc(Character character, string argStr, int argInt, AbilityData data);

	/// <summary>
	/// A function that returns the price and time it takes to learn an
	/// ability.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="abilityData"></param>
	/// <param name="abilityTreeData"></param>
	/// <param name="abilityLevel"></param>
	/// <param name="price"></param>
	/// <param name="time"></param>
	/// <returns></returns>
	public delegate void AbilityPriceFunc(Character character, AbilityData abilityData, AbilityTreeData abilityTreeData, int abilityLevel, out int price, out int time);
}
