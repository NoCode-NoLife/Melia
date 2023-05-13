using Melia.Shared.World.ObjectProperties;

namespace Melia.Zone.World
{
	/// <summary>
	/// Represents an identifiable object with properties.
	/// </summary>
	public interface IPropertyObject
	{
		/// <summary>
		/// The object's globally unique id.
		/// </summary>
		long ObjectId { get; }

		/// <summary>
		/// The object's properties.
		/// </summary>
		Properties Properties { get; }
	}
}
