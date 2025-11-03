namespace Melia.Shared.Game.Const
{
	public enum TeamNameChangeResult : int
	{
		TeamNameAlreadyExist = -1,
		Okay = 0,
		TeamChangeFailed = 1,
	}

	/// <summary>
	/// Represents the state of a mailbox message.
	/// </summary>
	/// <remarks>
	/// These Mailbox states were previously defined,
	/// I've only seen 0 - 3 (Akinue)
	/// </remarks>
	public enum MailboxMessageState : byte
	{
		/// <summary>
		/// The message has not been read yet.
		/// </summary>
		Unread = 0,

		/// <summary>
		/// The message has been read.
		/// </summary>
		Read = 1,

		/// <summary>
		/// The message is stored.
		/// </summary>
		Store = 2,

		/// <summary>
		/// The message is marked for deletion or has been deleted.
		/// </summary>
		Delete = 3,

		/// <summary>
		/// Unknown purpose
		/// </summary>
		RequestLoad = 4,

		/// <summary>
		/// Unknown purpose
		/// </summary>
		Count = 5,
	}

	/// <summary>
	/// Defines the types of commands that can be issued to a pet.
	/// </summary>
	/// <remarks>
	/// These commands are sent from the client to the server through the
	/// <c>CB_PET_COMMAND</c> packet to perform actions such as reviving or
	/// deleting a pet.
	/// </remarks>
	public enum PetCommand
	{
		/// <summary>
		/// Revives a pet that has been defeated or removed.
		/// </summary>
		/// <remarks>
		/// Haven't seen any usage of this, legacy comment in Melia
		/// implies this value was used for this.
		/// </remarks>
		Revive = 0,

		/// <summary>
		/// Deletes the pet from the account's companion list.
		/// </summary>
		Delete = 1,
	}


	/// <summary>
	/// Defines how an actor leaves the map (visual and logical effects).
	/// </summary>
	public enum LeaveType : short
	{
		/// <summary>
		/// Shows a blue effect when the entity disappears.
		/// </summary>
		BlueEffect = 0,

		/// <summary>
		/// Default disappearance with no special effects.
		/// </summary>
		Normal = 1,

		/// <summary>
		/// Used when the entity is removed but an animation should still play.
		/// Specifically used with item pickup.
		/// </summary>
		PlayAnimation = 2,

		/// <summary>
		/// Used when the entity disappears immediately without an animation.
		/// Specifically used with item no pickup and companions leaving.
		/// </summary>
		NoAnimation = 4,
	}
}
