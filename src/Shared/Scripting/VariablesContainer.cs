using Yggdrasil.Util;

namespace Melia.Shared.Scripting
{
	/// <summary>
	/// Holds references to a set of permanent and temporary variables.
	/// </summary>
	public class VariablesContainer
	{
		/// <summary>
		/// Returns the permanent variables.
		/// </summary>
		public Variables Perm { get; } = new Variables();

		/// <summary>
		/// Returns the temporary variables.
		/// </summary>
		public Variables Temp { get; } = new Variables();
	}
}
