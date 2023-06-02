using System;
using System.Collections.Generic;
using System.Reflection;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Custom commands script manager.
	/// </summary>
	public static class CustomCommandScripts
	{
		private static readonly Dictionary<string, CustomCommandScriptFunc> Scripts = new Dictionary<string, CustomCommandScriptFunc>();

		/// <summary>
		/// Registers the given function as the handler for the script name.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		/// <param name="scriptFunc"></param>
		public static void Register(string scriptFuncName, CustomCommandScriptFunc scriptFunc)
		{
			lock (Scripts)
				Scripts[scriptFuncName] = scriptFunc;
		}

		/// <summary>
		/// Returns the handler function for the tiven script via out,
		/// returns false if no script was defined.
		/// </summary>
		/// <param name="scriptName"></param>
		/// <param name="scriptFunc"></param>
		/// <returns></returns>
		public static bool TryGet(string scriptName, out CustomCommandScriptFunc scriptFunc)
		{
			lock (Scripts)
				return Scripts.TryGetValue(scriptName, out scriptFunc);
		}

		/// <summary>
		/// Loads handler methods on the given object.
		/// </summary>
		/// <param name="obj"></param>
		public static void Load(object obj)
		{
			foreach (var method in obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				foreach (var attribute in method.GetCustomAttributes<CustomCommandScriptAttribute>(false))
				{
					var func = (CustomCommandScriptFunc)Delegate.CreateDelegate(typeof(CustomCommandScriptFunc), obj, method);
					Register(attribute.ScriptFuncName, func);
				}
			}
		}
	}

	/// <summary>
	/// Used to mark a method as a custom command script handler.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class CustomCommandScriptAttribute : Attribute
	{
		/// <summary>
		/// Returns the name of the script that is handled by the function.
		/// </summary>
		public string ScriptFuncName { get; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		public CustomCommandScriptAttribute(string scriptFuncName)
		{
			this.ScriptFuncName = scriptFuncName;
		}
	}

	/// <summary>
	/// A function that handles a custom command.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="numArg1"></param>
	/// <param name="numArg2"></param>
	/// <param name="numArg3"></param>
	/// <returns></returns>
	public delegate CustomCommandResult CustomCommandScriptFunc(Character character, int numArg1, int numArg2, int numArg3);

	/// <summary>
	/// Specifies the result of a custom command.
	/// </summary>
	public enum CustomCommandResult
	{
		/// <summary>
		/// The custom command was executed successfully.
		/// </summary>
		Okay,

		/// <summary>
		/// The custom command execution failed.
		/// </summary>
		Fail,
	}
}
