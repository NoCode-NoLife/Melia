using System.Text;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Network.Helpers
{
	public static class MonsterHelper
	{
		/// <summary>
		/// Adds information about the monster to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="monster"></param>
		public static void AddMonster(this Packet packet, IMonsterBase monster)
		{
			var propertyList = monster.Properties.GetAll();
			var propertiesSize = propertyList.GetByteCount();
			var appearanceSize = monster.GetByteCount();

			packet.PutInt(monster.Handle);
			packet.PutPosition(monster.Position);
			packet.PutDirection(monster.Direction);
			packet.PutByte((byte)monster.MonsterType); // 0~2,  0: friendly?, 1: monster, 2: NPC
			packet.PutByte(monster.FromGround);
			packet.PutInt(monster.Hp);
			packet.PutInt(monster.MaxHp);
			packet.PutInt(0); // monster.Shield
			packet.PutInt(0); // monster.MaxShield

			packet.PutFloat(monster.Properties.GetFloat(PropertyName.MSPD));

			packet.AddMonsterApperanceBase(monster);

			packet.PutInt((int)monster.Attribute);
			packet.PutInt((int)monster.Race);

			packet.AddMonsterApperance(monster);

			packet.PutShort(propertiesSize);

			packet.PutInt(0);
			packet.PutInt(0);

			packet.PutShort(0);
			packet.PutByte(0);

			packet.AddProperties(propertyList);
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
			packet.PutString(monster.Name, 256);
			packet.PutString(monster.UniqueName, 256);
			packet.PutString(monster.DialogName, 256);
			packet.PutString(monster.EnterName, 256);
			packet.PutString(monster.LeaveName, 256);
		}

		/// <summary>
		/// Returns the size the monster's names will take up in a packet.
		/// </summary>
		/// <param name="monster"></param>
		/// <returns></returns>
		public static int GetByteCount(this IMonsterAppearance monster)
		{
			var size = 0;

			// Length-prefixes
			size += 5 * sizeof(short);

			// Null-terminators
			size += 5;

			// Strings
			size += Encoding.UTF8.GetByteCount(monster.Name ?? "");
			size += Encoding.UTF8.GetByteCount(monster.UniqueName ?? "");
			size += Encoding.UTF8.GetByteCount(monster.DialogName ?? "");
			size += Encoding.UTF8.GetByteCount(monster.EnterName ?? "");
			size += Encoding.UTF8.GetByteCount(monster.LeaveName ?? "");

			return size;
		}
	}
}
