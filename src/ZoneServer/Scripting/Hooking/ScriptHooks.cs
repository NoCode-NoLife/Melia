using System.Collections.Generic;
using System.Linq;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Global script hook registry.
	/// </summary>
	public static class ScriptHooks
	{
		private readonly static Dictionary<string, List<IScriptHook>> Hooks = new Dictionary<string, List<IScriptHook>>();

		/// <summary>
		/// Registers a new hook.
		/// </summary>
		/// <typeparam name="THook"></typeparam>
		/// <param name="hook"></param>
		public static void Register<THook>(THook hook) where THook : IScriptHook
		{
			var ident = GetHookIdent(hook.OwnerName, hook.HookName);

			lock (Hooks)
			{
				if (!Hooks.TryGetValue(ident, out var hookList))
					Hooks[ident] = hookList = new List<IScriptHook>();

				hookList.Add(hook);
			}
		}

		/// <summary>
		/// Returns all hooks for the given owner and name.
		/// </summary>
		/// <typeparam name="THook"></typeparam>
		/// <param name="ownerName"></param>
		/// <param name="hookName"></param>
		/// <returns></returns>
		public static THook[] GetAll<THook>(string ownerName, string hookName) where THook : IScriptHook
		{
			var ident = GetHookIdent(ownerName, hookName);

			lock (Hooks)
			{
				if (!Hooks.TryGetValue(ident, out var hookList))
					return new THook[0];

				return hookList.OfType<THook>().ToArray();
			}
		}

		/// <summary>
		/// Returns a string identifier for the given values.
		/// </summary>
		/// <param name="ownerName"></param>
		/// <param name="hookName"></param>
		/// <returns></returns>
		internal static string GetHookIdent(string ownerName, string hookName)
			=> ownerName + "::" + hookName;
	}
}
