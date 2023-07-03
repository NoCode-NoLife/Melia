using Melia.Zone.World;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using System.Threading;
using Melia.Shared.Data.Database;
using System;

namespace Melia.Zone.Skills
{
	/// <summary>
	/// A character's ability.
	/// </summary>
	public class Ability : IPropertyObject
	{
		private static long ObjectIds = ObjectIdRanges.Abilities;

		/// <summary>
		/// The ability's object id.
		/// </summary>
		public long ObjectId { get; } = Interlocked.Increment(ref ObjectIds);

		/// <summary>
		/// Returns a reference to the ability's data.
		/// </summary>
		public AbilityData Data { get; }

		/// <summary>
		/// The ability's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("Ability");

		/// <summary>
		/// The ability's id.
		/// </summary>
		public AbilityId Id { get; set; }

		/// <summary>
		/// The ability's level.
		/// </summary>
		public int Level { get; set; } = 1;

		/// <summary>
		/// Whether the ability is active.
		/// </summary>
		public bool Active { get; set; } = true;

		/// <summary>
		/// Creates new instance.
		/// </summary>
		public Ability(AbilityId abilityId, int level)
		{
			this.Id = abilityId;
			this.Level = level;

			this.Data = ZoneServer.Instance.Data.AbilityDb.Find(this.Id) ?? throw new ArgumentException($"No data found for ability '{this.Id}'.");

			this.Properties.Create(new RFloatProperty(PropertyName.Level, () => this.Level));
			this.Properties.Create(new RFloatProperty(PropertyName.ActiveState, () => this.Active ? 1 : 0));
		}
	}
}
