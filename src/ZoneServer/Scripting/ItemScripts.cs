using System;
using System.Collections.Generic;
using System.Reflection;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Item script handler manager.
	/// </summary>
	public static class ItemScripts
	{
		private static readonly Dictionary<string, ItemScriptFunc> Scripts = new Dictionary<string, ItemScriptFunc>();

		/// <summary>
		/// Registers the given function as the handler for the script name.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		/// <param name="scriptFunc"></param>
		public static void Register(string scriptFuncName, ItemScriptFunc scriptFunc)
		{
			lock (Scripts)
				Scripts[scriptFuncName] = scriptFunc;
		}

		/// <summary>
		/// Returns the script for the given item class id via out,
		/// returns false if no script was defined.
		/// </summary>
		/// <param name="scriptName"></param>
		/// <param name="script"></param>
		/// <returns></returns>
		public static bool TryGet(string scriptName, out ItemScriptFunc scriptFunc)
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
				foreach (var attribute in method.GetCustomAttributes<ItemScriptAttribute>(false))
				{
					var func = (ItemScriptFunc)Delegate.CreateDelegate(typeof(ItemScriptFunc), obj, method);
					Register(attribute.ScriptFuncName, func);
				}
			}
		}
	}

	/// <summary>
	/// Used to specify information about an item script function.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class ItemScriptAttribute : Attribute
	{
		/// <summary>
		/// Returns the name of the script that is handled by the function.
		/// </summary>
		public string ScriptFuncName { get; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="scriptFuncName"></param>
		public ItemScriptAttribute(string scriptFuncName)
		{
			this.ScriptFuncName = scriptFuncName;
		}
	}

	/// <summary>
	/// A function that handles the usage of an item.
	/// </summary>
	/// <param name="character">The character who used the item.</param>
	/// <param name="item">The item that is being used.</param>
	/// <param name="strArg">String argument, as defined in the item data.</param>
	/// <param name="numArg1">First number argument, as defined in the item data.</param>
	/// <param name="numArg2">Second number argument, as defined in the item data.</param>
	/// <returns></returns>
	public delegate ItemUseResult ItemScriptFunc(Character character, Item item, string strArg, float numArg1, float numArg2);

	/// <summary>
	/// Specifies the result of using an item.
	/// </summary>
	public enum ItemUseResult
	{
		/// <summary>
		/// The item was used successfully and should be decremented.
		/// </summary>
		Okay,

		/// <summary>
		/// The usage failed and the item should not be decremented.
		/// </summary>
		Fail,
	}
}
