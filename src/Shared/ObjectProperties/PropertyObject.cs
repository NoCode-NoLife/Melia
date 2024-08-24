namespace Melia.Shared.ObjectProperties
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

	public static class ObjectIdRanges
	{
		public const long Characters = 0x0100000000000000;
		public const long SocialUser = 0x0200000000000000;
		public const long Items = 0x0500000000000000;
		public const long Skills = 0x0600000000000000;
		public const long Abilities = 0x0700000000000000;
		public const long SessionObjects = 0x0A00000000000000;
		public const long Quests = 0x0B00000000000000;
		public const long Companions = 0x0C00000000000000;

		// Old stuff for referecence:

		// These are object id range starting points. The skill objects I
		// saw in-game so far were above 0x54B600000000 for example,
		// while the session and ability objects were above 0xE1A900000000.
		// In some games, ids have to to be in specific ranges, or nothing
		// will work. You might not be able to login, or interact with the
		// world, etc. I haven't seen any indication that this is the case
		// in R1 yet, but I'd rather be on the safe side for now, until we
		// can confirm that it's unnecessary.
		//private long _sessionObjectIds = 0x0000E1A900000000;
		//private long _skillObjectIds = 0x000054B600000000;

		// It seems like abilities and session objects use the same
		// id pool on officials, so we'll do the same for now.
		//public Ability(AbilityId abilityId, int level)
		//{
		//	this.ObjectId = ZoneServer.Instance.World.CreateSessionObjectId();
	}
}
