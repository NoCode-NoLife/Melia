namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Describes a scripting hook that belongs to something and can be
	/// executed.
	/// </summary>
	public interface IScriptHook
	{
		/// <summary>
		/// Returns the name of the object this hook is associated with.
		/// </summary>
		string OwnerName { get; }

		/// <summary>
		/// Returns the name of the hook, usually denoting when or where
		/// it will get executed.
		/// </summary>
		string HookName { get; }
	}
}
