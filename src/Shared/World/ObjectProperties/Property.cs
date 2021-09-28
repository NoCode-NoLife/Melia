namespace Melia.Shared.World.ObjectProperties
{
	/// <summary>
	/// Describes a property of an object.
	/// </summary>
	public interface IProperty
	{
		/// <summary>
		/// Returns the property's id.
		/// </summary>
		int Id { get; }

		/// <summary>
		/// Returns the property's size in bytes, as it would take
		/// up in a packet, incl. the id.
		/// </summary>
		int Size { get; }

		/// <summary>
		/// Returns the property's type.
		/// </summary>
		PropertyType Type { get; }

		/// <summary>
		/// Returns a string representation of the property's value.
		/// </summary>
		/// <returns></returns>
		string GetString();
	}
}
