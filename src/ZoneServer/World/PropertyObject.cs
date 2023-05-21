using Melia.Shared.World.ObjectProperties;

namespace Melia.Zone.World
{
	/// <summary>
	/// Represents an object with properties.
	/// </summary>
	public interface IPropertyHolder
	{
		/// <summary>
		/// The object's properties.
		/// </summary>
		Properties Properties { get; }
	}

	/// <summary>
	/// Represents an identifiable object with properties.
	/// </summary>
	public interface IPropertyObject : IPropertyHolder
	{
		/// <summary>
		/// The object's globally unique id.
		/// </summary>
		long ObjectId { get; }
	}
}
