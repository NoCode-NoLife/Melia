using Melia.Zone.World;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using System.Threading;

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

			//this.Properties.Add(new RefFloatProperty(PropertyId.Ability.Level, () => this.Level));
			//this.Properties.Add(new RefFloatProperty(PropertyId.Ability.ActiveState, () => this.Active ? 1 : 0));
		}
	}
}
