using System;

namespace Melia.Zone.World.Actors.Components.AI
{
	/// <summary>
	/// An attribute for script functions, that can be loaded automatically.
	/// </summary>
	public class ScriptFunctionAttribute : Attribute
	{
		/// <summary>
		/// Returns the name of the script function within the scripting
		/// environment.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="name"></param>
		public ScriptFunctionAttribute(string name)
		{
			this.Name = name;
		}
	}
}
