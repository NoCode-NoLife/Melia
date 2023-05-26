using System.Collections.Generic;

namespace Melia.Shared.IES
{
	/// <summary>
	/// A group of IES classes.
	/// </summary>
	public class IesModGroup
	{
		/// <summary>
		/// Returns the name of the namespace the classes are in.
		/// </summary>
		public string Namespace { get; }

		/// <summary>
		/// Returns the modified classes.
		/// </summary>
		public Dictionary<int, IesModClass> Classes { get; } = new Dictionary<int, IesModClass>();

		/// <summary>
		/// Creates new group.
		/// </summary>
		/// <param name="namespaceName"></param>
		public IesModGroup(string namespaceName)
		{
			this.Namespace = namespaceName;
		}
	}
}
