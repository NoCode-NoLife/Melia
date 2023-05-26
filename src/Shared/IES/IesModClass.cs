using System.Collections.Generic;

namespace Melia.Shared.IES
{
	/// <summary>
	/// A modified class and its properties.
	/// </summary>
	public class IesModClass
	{
		/// <summary>
		/// Returns the id of the class that is modified.
		/// </summary>
		public int ClassId { get; }

		/// <summary>
		/// Returns a list of the modified properties.
		/// </summary>
		public Dictionary<string, IesModProperty> Properties { get; } = new Dictionary<string, IesModProperty>();

		/// <summary>
		/// Creates new class.
		/// </summary>
		/// <param name="classId"></param>
		public IesModClass(int classId)
		{
			this.ClassId = classId;
		}
	}
}
