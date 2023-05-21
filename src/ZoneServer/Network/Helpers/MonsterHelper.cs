using System.Text;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Zone.Network.Helpers
{
	public static class MonsterHelper
	{
		/// <summary>
		/// Adds information about the monster to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="monster"></param>
		public static void AddMonster(this Packet packet, IMonster monster)
		{
			packet.PutInt(monster.Handle);
			packet.PutFloat(monster.Position.X);
			packet.PutFloat(monster.Position.Y);
			packet.PutFloat(monster.Position.Z);
			packet.PutFloat(monster.Direction.Cos);
			packet.PutFloat(monster.Direction.Sin);
			packet.PutByte((byte)monster.NpcType); // 0~2,  0: friendly?, 1: monster, 2: NPC
			packet.PutByte(monster.FromGround);
			packet.PutInt(monster.Hp);
			packet.PutInt(monster.MaxHp);
			packet.PutShort(0);

			// [i11025 (2016-02-26)] ?
			{
				packet.PutShort(16832);
			}

			// [i364857 (2022-10-22)] ?
			{
				packet.PutInt(0); // 0 | 1098907648
			}

			packet.PutFloat(16);

			packet.AddMonsterApperanceBase(monster);

			packet.PutInt(5); // Name Size?

			//packet.PutShort(0); // parameters size
			// it was, like this in IDA o.o
			packet.PutByte(0); // parameters size
			packet.PutByte(0); // ??
			packet.PutByte(0); // [i170175] ?
			packet.PutByte(0);

			packet.PutInt(0);  // keeps getting added and removed every other week

			packet.PutShort(0); // Property Size?

			packet.PutInt(0);
			packet.PutInt(0);

			packet.PutShort(0);
			packet.PutByte(0);

			packet.AddMonsterApperance(monster);

			packet.PutEmptyBin(0); // parameters
		}

		/// <summary>
		/// Adds basic information about the monster to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="monster"></param>
		public static void AddMonsterApperanceBase(this Packet packet, IMonsterAppearanceBase monster)
		{
			packet.PutInt(monster.Id);
			packet.PutInt(0); // 600?
			packet.PutInt(monster.MaxHp);

			// [i11025 (2016-02-26)] Removed?
			{
				//packet.PutShort(0); // MaxShield?
				//packet.PutEmptyBin(2);
			}

			packet.PutInt(monster.Level);
			packet.PutFloat(monster.SDR);
			packet.PutByte(0);
			packet.PutEmptyBin(3);
			packet.PutInt(monster.GenType);
		}

		/// <summary>
		/// Adds monster name and script information to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="monster"></param>
		public static void AddMonsterApperance(this Packet packet, IMonsterAppearance monster)
		{
			packet.PutLpString(monster.Name);
			packet.PutLpString(monster.UniqueName);
			packet.PutLpString(monster.DialogName);
			packet.PutLpString(monster.EnterName);
			packet.PutLpString(monster.LeaveName);
		}
	}

	/// <summary>
	/// Represents a "monster" in the world, or in other words, an entity
	/// that is not a player, but can exist on a map.
	/// </summary>
	public interface IMonster : IMonsterAppearance, IMonsterAppearanceBase
	{
		/// <summary>
		/// Returns the monster's handle.
		/// </summary>
		int Handle { get; }

		/// <summary>
		/// Returns the monster's current position.
		/// </summary>
		Position Position { get; }

		/// <summary>
		/// Returns the direction the monster is facing.
		/// </summary>
		Direction Direction { get; }

		/// <summary>
		/// Returns the monster's type.
		/// </summary>
		NpcType NpcType { get; }

		/// <summary>
		/// Returns whether the monster emerged from the ground.
		/// </summary>
		/// <remarks>
		/// This determines the animation played when the monster spawns
		/// and should probably not be set all the time.
		/// </remarks>
		bool FromGround { get; }

		/// <summary>
		/// Returns the monster's current HP.
		/// </summary>
		int Hp { get; }

		/// <summary>
		/// Returns the monster's maximum HP.
		/// </summary>
		//int MaxHp { get; }

		/// <summary>
		/// Returns a reference to the monster's properties.
		/// </summary>
		Properties Properties { get; }
	}

	/// <summary>
	/// Represents a portion of a "monster", or in other words, an entity
	/// that is not a player, but can exist on a map.
	/// </summary>
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
