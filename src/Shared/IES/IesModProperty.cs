using System.Collections.Generic;

namespace Melia.Shared.IES
{
	/// <summary>
	/// A property of a class and its modifications.
	/// </summary>
	public class IesModProperty
	{
		/// <summary>
		/// Returns the name of the property.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Returns the changed to the property.
		/// </summary>
		public List<IesModPropertyChange> Changes { get; } = new List<IesModPropertyChange>();

		/// <summary>
		/// Creates new property.
		/// </summary>
		/// <param name="name"></param>
		public IesModProperty(string name)
		{
			this.Name = name;
		}
	}
}
