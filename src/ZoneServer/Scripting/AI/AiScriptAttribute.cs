using System;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Used to decorate AI scripts, to register them as scripts for the
	/// given AI names.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	public class AiAttribute : Attribute
	{
		/// <summary>
		/// The name of the AI script.
		/// </summary>
		public string[] Names { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="names"></param>
		public AiAttribute(params string[] names)
		{
			if (names == null || names.Length == 0)
				throw new ArgumentException("At least one name must be provided.");

			this.Names = names;
		}
	}
}
