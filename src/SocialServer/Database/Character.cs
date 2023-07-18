using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a player's character.
	/// </summary>
	public class Character
	{
		/// <summary>
		/// Gets or sets the character's unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets id of the character's account.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Gets or sets index of character in character list.
		/// </summary>
		public byte Index { get; set; }

		/// <summary>
		/// Gets or sets character's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets character's team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Gets or sets character's job.
		/// </summary>
		public JobId JobId { get; set; }

		/// <summary>
		/// Gets or sets character's gender.
		/// </summary>
		public Gender Gender { get; set; }

		/// <summary>
		/// Gets or sets id of the character's hair style.
		/// </summary>
		public int Hair { get; set; }

		/// <summary>
		/// Returns a list of the character's jobs.
		/// </summary>
		public HashSet<JobId> Jobs { get; } = new HashSet<JobId>();

		/// <summary>
		/// Returns a bitmask that specifies which hats are visible on
		/// the character.
		/// </summary>
		public VisibleEquip VisibleHats => VisibleEquip.Headgear1 | VisibleEquip.Headgear2 | VisibleEquip.Headgear3;

		/// <summary>
		/// Gets or sets the character's level.
		/// </summary>
		public int Level { get; set; } = 1;

		/// <summary>
		/// Gets or sets the channel the character connected to last.
		/// </summary>
		public int Channel { get; set; } = 0;

		/// <summary>
		/// Gets or sets the id of the map the character is on.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// Gets or sets the character's current position in the world.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Gets or sets the character's current HP.
		/// </summary>
		public int Hp { get; set; }

		/// <summary>
		/// Gets or sets the character's current SP.
		/// </summary>
		public int Sp { get; set; }

		/// <summary>
		/// Gets or sets the character's last login date.
		/// </summary>
		public DateTime LastLoginDate { get; set; } = DateTime.MinValue;

		/// <summary>
		/// Creates a new character with default values.
		/// </summary>
		public Character()
		{
		}

		/// <summary>
		/// Returns ids of character's jobs.
		/// </summary>
		/// <returns></returns>
		public JobId[] GetJobIds()
		{
			return this.Jobs.OrderBy(a => a).ToArray();
		}
	}
}
