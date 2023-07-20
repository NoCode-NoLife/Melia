using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;

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
		/// Returns a bitmask that specifies which hats are visible on
		/// the character.
		/// </summary>
		public VisibleEquip VisibleHats => VisibleEquip.Headgear1 | VisibleEquip.Headgear2 | VisibleEquip.Headgear3;

		/// <summary>
		/// Gets or sets the character's level.
		/// </summary>
		public int Level { get; set; } = 1;
	}
}
