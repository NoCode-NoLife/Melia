// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using Melia.Shared.Const;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World
{
	/// <summary>
	/// A character's ability.
	/// </summary>
	public class Ability : IPropertyObject
	{
		/// <summary>
		/// The ability's object id.
		/// </summary>
		public long ObjectId { get; }

		/// <summary>
		/// The ability's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties();

		/// <summary>
		/// The ability's id.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The ability's level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		public Ability(int abilityId, int level)
		{
			// It seems like abilities and session objects use the same
			// id pool on officials, so we'll do the same for now.
			this.ObjectId = ChannelServer.Instance.World.CreateSessionObjectId();

			this.Id = abilityId;
			this.Level = level;

			this.Properties.Add(new RefFloatProperty(PropertyId.Ability.Level, () => this.Level));
		}
	}
}
