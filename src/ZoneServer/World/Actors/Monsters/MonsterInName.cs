using System;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Game.Const;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// Base class for monsters that are treated as monsters, but actually
	/// have very little to do with them, such as warps and items.
	/// </summary>
	public abstract class MonsterInName : Actor, IMonster
	{
		/// <summary>
		/// Returns the monster's class id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the monster's type.
		/// </summary>
		public MonsterType MonsterType => MonsterType.NPC;

		/// <summary>
		/// Returns the monster's race.
		/// </summary>
		public RaceType Race => RaceType.None;

		/// <summary>
		/// Returns the monster's element/attribute.
		/// </summary>
		public AttributeType Attribute => AttributeType.None;

		/// <summary>
		/// Returns the monster's current HP.
		/// </summary>
		public int Hp => 100;

		/// <summary>
		/// Returns the monster's maximum HP.
		/// </summary>
		public int MaxHp => 100;

		/// <summary>
		/// Returns the monster's level.
		/// </summary>
		public int Level => 1;

		/// <summary>
		/// Returns the monster's AoE Defense Ratio.
		/// </summary>
		public float SDR => 0;

		/// <summary>
		/// Returns whether the monster emerged from the ground.
		/// </summary>
		public bool FromGround { get; set; }

		/// <summary>
		/// Returns the monster's faction.
		/// </summary>
		public FactionType Faction => FactionType.Peaceful;

		/// <summary>
		/// Gets or sets the time the monster will be removed from
		/// the map its on.
		/// </summary>
		public DateTime DisappearTime { get; set; } = DateTime.MaxValue;

		/// <summary>
		/// Returns the monster's gen type.
		/// </summary>
		public int GenType { get; } = ZoneServer.Instance.World.CreateGenType();

		/// <summary>
		/// Returns a reference to the monster's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("Monster");

		/// <summary>
		/// Gets or sets the monster's display name.
		/// </summary>
		public override string Name { get; set; }

		/// <summary>
		/// Gets or sets the monster's unique name (?).
		/// </summary>
		public string UniqueName { get; set; }

		/// <summary>
		/// Gets or sets the name of the dialog function to call when
		/// the monster is interacted with.
		/// </summary>
		public string DialogName { get; set; }

		/// <summary>
		/// Gets or sets the name of the function to call when someone
		/// enters the monster's trigger area.
		/// </summary>
		public string EnterName { get; set; }

		/// <summary>
		/// Gets or sets the name of the function to call when someone
		/// leaves the monster's trigger area.
		/// </summary>
		public string LeaveName { get; set; }

		/// <summary>
		/// Gets or sets the handled who is the owner.
		/// </summary>
		public int OwnerHandle { get; set; }

		/// <summary>
		/// Gets or sets the handle associated
		/// with the spawn.
		/// </summary>
		public int AssociatedHandle { get; set; }

		/// <summary>
		/// Initializes the monster's properties.
		/// </summary>
		/// <param name="monsterClassId"></param>
		public MonsterInName(int monsterClassId)
		{
			this.Id = monsterClassId;
		}
	}
}
