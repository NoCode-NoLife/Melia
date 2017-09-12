// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World
{
	/// <summary>
	/// A session object, duh.
	/// </summary>
	/// <remarks>
	/// The exact purpose of those objects is unknown right now,
	/// but apparently they hold some properties of importance.
	/// </remarks>
	public class SessionObject
	{
		/// <summary>
		/// The object's unique, global id.
		/// </summary>
		public long ObjectId { get; } = ChannelServer.Instance.World.CreateSessionObjectId();

		/// <summary>
		/// The object's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// The object's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties();

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
