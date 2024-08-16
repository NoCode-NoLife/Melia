using System.Threading.Tasks;
using Melia.Zone.Scripting.Dialogues;

namespace Melia.Zone.Scripting.Hooking
{
	/// <summary>
	/// A hook that can be executed during dialog.
	/// </summary>
	public class DialogHook : IScriptHook
	{
		/// <summary>
		/// Returns the unique name of the NPC this hook is associated with.
		/// </summary>
		public string OwnerName { get; }

		/// <summary>
		/// Returns the name of the hook, hinting at where inside the
		/// NPC it will get executed.
		/// </summary>
		public string HookName { get; }

		/// <summary>
		/// Returns the function that will be called when this hook is
		/// executed.
		/// </summary>
		public DialogHookFunc Func { get; }

		/// <summary>
		/// Creates a new dialog hook.
		/// </summary>
		/// <param name="uniqueNpcName"></param>
		/// <param name="hookName"></param>
		/// <param name="func"></param>
		public DialogHook(string uniqueNpcName, string hookName, DialogHookFunc func)
		{
			this.OwnerName = uniqueNpcName;
			this.HookName = hookName;
			this.Func = func;
		}

		/// <summary>
		/// Delegate for a dialog hook function.
		/// </summary>
		/// <param name="dialog"></param>
		/// <returns></returns>
		public delegate Task<HookResult> DialogHookFunc(Dialog dialog);
	}
}
