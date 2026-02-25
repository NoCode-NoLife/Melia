using System;
using Melia.Shared.Game.Const;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a user's character.
	/// </summary>
	public class Character
	{
		/// <summary>
		/// Gets or sets the character's unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets character's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets character's team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Gets or sets the character's level.
		/// </summary>
		public int Level { get; set; } = 1;

		/// <summary>
		/// Gets or sets character's job.
		/// </summary>
		public JobId JobId { get; set; }

		/// <summary>
		/// Gets or sets character's job level.
		/// </summary>
		public int JobLevel { get; set; } = 1;

		/// <summary>
		/// Gets or sets character's gender.
		/// </summary>
		public Gender Gender { get; set; }

		/// <summary>
		/// Gets or sets id of the character's hair style.
		/// </summary>
		public int Hair { get; set; }

		/// <summary>
		/// Gets or sets id of the character's skin color.
		/// </summary>
		public uint SkinColor { get; set; }

		/// <summary>
		/// Returns a bitmask that specifies which hats are visible on
		/// the character.
		/// </summary>
		public VisibleEquip VisibleHats { get; set; } = VisibleEquip.All;

		/// <summary>
		/// Gets or sets the id of the map the character is currently on.
		/// Returns 0 if they aren't online.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// Gets or sets the id of the channel the character is currently on.
		/// Returns 0 if they aren't online.
		/// </summary>
		public int ChannelId { get; set; }

		/// <summary>
		/// Gets or sets the character's party id.
		/// </summary>
		public long PartyId { get; set; }

		/// <summary>
		/// Resets select properties that will make the character appear offline
		/// when included in a friend list refresh.
		/// </summary>
		internal void Clear()
		{
			// If the map id is 0, the client will display the user as offline.
			// We could clear the whole character object, but there isn't really
			// any reason for it and this way we have access to the last character
			// that was online. Whatever use we might have for that.
			this.MapId = 0;

			// Let's also clear the channel id for good measure, even though it's
			// not technically necessary.
			this.ChannelId = 0;
		}
	}
}
