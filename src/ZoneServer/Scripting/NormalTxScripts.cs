using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Normal transaction script manager.
	/// </summary>
	public static class NormalTxScripts
	{
		// We'll use this class for both strArg and numArgs varients,
		// since they use the same script name table and only differ
		// in the types of their arguments.

		private static readonly Dictionary<string, NormalTxScriptFunc> Scripts = new Dictionary<string, NormalTxScriptFunc>();
		private static readonly Dictionary<string, NormalTxNumScriptFunc> ScriptsNum = new Dictionary<string, NormalTxNumScriptFunc>();

		/// <summary>
		/// Registers the given function as the handler for the script name.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		/// <param name="scriptFunc"></param>
		public static void Register(string scriptFuncName, NormalTxScriptFunc scriptFunc)
		{
			lock (Scripts)
				Scripts[scriptFuncName] = scriptFunc;
		}

		/// <summary>
		/// Registers the given function as the handler for the script name.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		/// <param name="scriptFunc"></param>
		public static void Register(string scriptFuncName, NormalTxNumScriptFunc scriptFunc)
		{
			lock (ScriptsNum)
				ScriptsNum[scriptFuncName] = scriptFunc;
		}

		/// <summary>
		/// Returns the handler function for the tiven script via out,
		/// returns false if no script was defined.
		/// </summary>
		/// <param name="scriptName"></param>
		/// <param name="scriptFunc"></param>
		/// <returns></returns>
		public static bool TryGet(string scriptName, out NormalTxScriptFunc scriptFunc)
		{
			lock (Scripts)
				return Scripts.TryGetValue(scriptName, out scriptFunc);
		}

		/// <summary>
		/// Returns the handler function for the tiven script via out,
		/// returns false if no script was defined.
		/// </summary>
		/// <param name="scriptName"></param>
		/// <param name="scriptFunc"></param>
		/// <returns></returns>
		public static bool TryGetNum(string scriptName, out NormalTxNumScriptFunc scriptFunc)
		{
			lock (ScriptsNum)
				return ScriptsNum.TryGetValue(scriptName, out scriptFunc);
		}

		/// <summary>
		/// Loads handler methods on the given object.
		/// </summary>
		/// <param name="obj"></param>
		public static void Load(object obj)
		{
			foreach (var method in obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				foreach (var attribute in method.GetCustomAttributes<NormalTxScriptAttribute>(false))
				{
					// If the method has a string parameter, we'll assume
					// it's a strArg handler. If not, numArgs.

					if (method.GetParameters().Any(a => a.ParameterType == typeof(string)))
					{
						var func = (NormalTxScriptFunc)Delegate.CreateDelegate(typeof(NormalTxScriptFunc), obj, method);
						Register(attribute.ScriptFuncName, func);
					}
					else
					{
						var func = (NormalTxNumScriptFunc)Delegate.CreateDelegate(typeof(NormalTxNumScriptFunc), obj, method);
						Register(attribute.ScriptFuncName, func);
					}
				}
			}
		}
	}

	/// <summary>
	/// Used to mark a method as a dialog transcription script handler.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class NormalTxScriptAttribute : Attribute
	{
		/// <summary>
		/// Returns the name of the script that is handled by the function.
		/// </summary>
		public string ScriptFuncName { get; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		public NormalTxScriptAttribute(string scriptFuncName)
		{
			this.ScriptFuncName = scriptFuncName;
		}
	}

	/// <summary>
	/// A function that handles a transaction.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="strArg"></param>
	/// <returns></returns>
	public delegate NormalTxResult NormalTxScriptFunc(Character character, string strArg);

	/// <summary>
	/// A function that handles a transaction.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="numArgs"></param>
	/// <returns></returns>
	public delegate NormalTxResult NormalTxNumScriptFunc(Character character, int[] numArgs);

	/// <summary>
	/// Specifies the result of the transaction.
	/// </summary>
	public enum NormalTxResult
	{
		/// <summary>
		/// The transaction was successful.
		/// </summary>
		Okay,

		/// <summary>
		/// The transaction failed.
		/// </summary>
		Fail,
	}
}
