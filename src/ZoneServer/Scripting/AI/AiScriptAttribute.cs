using System;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Used to decorate AI scripts, to register them as scripts for the
	/// given AI names.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class AiAttribute : Attribute
	{
		/// <summary>
		/// The name of the AI script.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="name"></param>
		public AiAttribute(string name)
		{
			this.Name = name;
		}
	}
}
