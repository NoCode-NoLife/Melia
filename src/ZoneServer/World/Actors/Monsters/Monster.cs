using System;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.World.Maps;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// Represents a "monster" in the world, or in other words, an entity
	/// that is not a player, but can exist on a map.
	/// </summary>
	public interface IMonster : IMonsterBase
	{
		/// <summary>
		/// Gets or sets the time the actor will be removed from the
		/// map it's on.
		/// </summary>
		DateTime DisappearTime { get; }
	}

	public interface IMonsterBase : IActor, IMonsterAppearance, IMonsterAppearanceBase
	{
		/// <summary>
		/// Returns the monster's type.
		/// </summary>
		MonsterType MonsterType { get; }

		/// <summary>
		/// Returns the monster's race.
		/// </summary>
		RaceType Race { get; }

		/// <summary>
		/// Returns the monster's element/attribute.
		/// </summary>
		AttributeType Attribute { get; }

		/// <summary>
		/// Returns whether the monster emerged from the ground.
		/// </summary>
		/// <remarks>
		/// This determines the animation played when the monster spawns
		/// and should probably not be set all the time.
		/// </remarks>
		bool FromGround { get; set; }

		/// <summary>
		/// Returns the monster's current HP.
		/// </summary>
		int Hp { get; }

		/// <summary>
		/// Returns a reference to the monster's properties.
		/// </summary>
		Properties Properties { get; }

		/// <summary>
		/// Returns the owner's handle.
		/// </summary>
		int OwnerHandle { get; }

		/// <summary>
		/// Returns an associated handle.
		/// </summary>
		int AssociatedHandle { get; }
	}

	/// <summary>
	/// Represents a portion of a "monster", or in other words, an entity
	/// that is not a player, but can exist on a map.
	/// </summary>
	/// <remarks>
	/// Primarily used in communicating monster data to the client.
	/// </remarks>
	public interface IMonsterAppearanceBase
	{
		/// <summary>
		/// Returns the monster's class id.
		/// </summary>
		int Id { get; }

		/// <summary>
		/// Returns the monster's maximum HP.
		/// </summary>
		int MaxHp { get; }

		/// <summary>
		/// Returns the monster's level.
		/// </summary>
		int Level { get; }

		/// <summary>
		/// Returns the monster's AoE/Skill Defense Ratio.
		/// </summary>
		float SDR { get; }

		/// <summary>
		/// Returns the monster's gen type, which is similar to an id.
		/// </summary>
		int GenType { get; }
	}

	/// <summary>
	/// Represents a portion of a "monster", or in other words, an entity
	/// that is not a player, but can exist on a map.
	/// </summary>
	/// <remarks>
	/// Primarily used in communicating monster data to the client.
	/// </remarks>
	public interface IMonsterAppearance
	{
		/// <summary>
		/// Returns the monster's name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Returns the monster's unique name (?).
		/// </summary>
		string UniqueName { get; }

		/// <summary>
		/// Returns the name of the dialog function to call when the
		/// monster gets triggered.
		/// </summary>
		/// <remarks>
		/// Not currently used in Melia, but required for the client to
		/// mark a monster as a potential conversation target.
		/// </remarks>
		string DialogName { get; }

		/// <summary>
		/// Returns the name of the function to call when someone enters
		/// this monster's trigger area.
		/// </summary>
		/// <remarks>
		/// Not currently used in Melia, but might serve a purpose on the
		/// client-side, similar to DialogName.
		/// </remarks>
		string EnterName { get; }

		/// <summary>
		/// Returns the name of the function to call when someone leaves
		/// this monster's trigger area.
		/// </summary>
		/// <remarks>
		/// Not currently used in Melia, but might serve a purpose on the
		/// client-side, similar to DialogName.
		/// </remarks>
		string LeaveName { get; }
	}
}
