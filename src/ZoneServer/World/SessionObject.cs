using Melia.Shared.ObjectProperties;

namespace Melia.Zone.World
{
	/// <summary>
	/// A session object, duh.
	/// </summary>
	/// <remarks>
	/// The exact purpose of those objects is unknown right now,
	/// but apparently they hold some properties of importance.
	/// </remarks>
	public class SessionObject : IPropertyObject
	{
		/// <summary>
		/// The object's unique, global id.
		/// </summary>
		public long ObjectId { get; } = ZoneServer.Instance.World.CreateSessionObjectId();

		/// <summary>
		/// The object's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// The object's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("SessionObject");

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="id"></param>
		public SessionObject(int id)
		{
			this.Id = id;
		}
	}
}
