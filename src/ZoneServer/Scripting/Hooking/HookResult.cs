namespace Melia.Zone.Scripting
{
	/// <summary>
	/// The result of a hook function, defining the intended way to
	/// handle the potentially remaining hooks.
	/// </summary>
	public enum HookResult
	{
		/// <summary>
		/// The hook should be considered to have been skipped and the
		/// caller should continue to execute hooks.
		/// </summary>
		Skip,

		/// <summary>
		/// The hook executed, but the caller should still continue to
		/// execute hooks.
		/// </summary>
		Continue,

		/// <summary>
		/// The hook executed and the caller should stop executing hooks.
		/// </summary>
		Break,
	}
}
