using System.Collections.Generic;
using System.Linq;
using Melia.Barracks.Network.Helpers;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Scripting;
using Melia.Shared.World;

namespace Melia.Barracks.Database
{
	/// <summary>
	/// Represents a player's character.
	/// </summary>
	public class Character : IBarrackPc
	{
		/// <summary>
		/// Gets or sets the character's unique database id.
		/// </summary>
		/// <remarks>
		/// Represents the id the character is known by in the database.
		/// This is different from the ObjectId, which is used in the game.
		/// </remarks>
		public long DbId { get; set; }

		/// <summary>
		/// Returns the character's globally unique id.
		/// </summary>
		/// <remarks>
		/// Represents the id the character is known by in the game, applying
		/// an offset to the database id.
		/// </remarks>
		public long ObjectId => ObjectIdRanges.Characters + this.DbId;

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
		/// Returns the character's displayed hair style, depending on
		/// their actual hair and factors like equipped items.
		/// </summary>
		public int DisplayHair
		{
			get
			{
				var hair = this.Hair;

				if (this.Variables.Perm.TryGetInt("Melia.DisplayHair", out var displayHair))
					hair = displayHair;

				return hair;
			}
		}

		/// <summary>
		/// Gets or sets the character's skin color.
		/// </summary>
		/// <remarks>
		/// This is a normal color code in integer format, i.e. white is
		/// 0xFFFFFF, red is 0xFF0000, etc.
		/// </remarks>
		public uint SkinColor { get; set; }

		/// <summary>
		/// Returns a list of equipped items.
		/// </summary>
		public EquipItem[] Equipment { get; private set; }

		/// <summary>
		/// Returns a list of the character's jobs.
		/// </summary>
		public HashSet<JobId> Jobs { get; } = new HashSet<JobId>();

		/// <summary>
		/// Returns a bitmask that specifies which equip items are visible
		/// on the character.
		/// </summary>
		public VisibleEquip VisibleEquip { get; set; } = VisibleEquip.All;

		/// <summary>
		/// Gets or sets the character's level.
		/// </summary>
		public int Level { get; set; } = 1;

		/// <summary>
		/// Gets or sets the amount of silver the character owns.
		/// </summary>
		/// <remarks>
		/// This is just for information's sake and modifying this property
		/// won't actually change the amount of silver a character owns.
		/// </remarks>
		public long Silver { get; set; }

		/// <summary>
		/// Gets or sets the layer in the barracks that the character should
		/// appear in.
		/// </summary>
		public int BarrackLayer { get; set; } = 1;

		/// <summary>
		/// Gets or sets the character's position in the barracks.
		/// </summary>
		public Position BarracksPosition { get; set; }

		/// <summary>
		/// Gets or sets the character's direction in the barracks.
		/// </summary>
		public Direction BarracksDirection { get; set; }

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
		/// Returns the character's stance based on job, equipment,
		/// and potentially other factors.
		/// </summary>
		public int Stance
		{
			get
			{
				var rightHand = this.Equipment[(int)EquipSlot.RightHand].Type;
				var leftHand = this.Equipment[(int)EquipSlot.LeftHand].Type;

				return BarracksServer.Instance.Data.StanceConditionDb.FindStanceId(this.JobId, false, rightHand, leftHand);
			}
		}

		/// <summary>
		/// Gets or sets the character's HP multiplier from their base job.
		/// </summary>
		public float HpRateByJob { get; set; }

		/// <summary>
		/// Gets or sets the character's current HP.
		/// </summary>
		public int Hp { get; set; }

		/// <summary>
		/// Gets or sets the character's SP multiplier from their base job.
		/// </summary>
		public float SpRateByJob { get; set; }

		/// <summary>
		/// Gets or sets the character's current SP.
		/// </summary>
		public int Sp { get; set; }

		/// <summary>
		/// Gets or sets the amount of stamina the character receives from
		/// their job.
		/// </summary>
		public int StaminaByJob { get; set; }

		/// <summary>
		/// Gets or sets the character's current stamina.
		/// </summary>
		public int Stamina { get; set; }

		/// <summary>
		/// Gets or sets the amount of STR the character receives from
		/// their job.
		/// </summary>
		public int StrByJob { get; set; }

		/// <summary>
		/// Gets or sets the amount of CON the character receives from
		/// their job.
		/// </summary>
		public int ConByJob { get; set; }

		/// <summary>
		/// Gets or sets the amount of INT the character receives from
		/// their job.
		/// </summary>
		public int IntByJob { get; set; }

		/// <summary>
		/// Gets or sets the amount of SPR/MNA the character receives from
		/// their job.
		/// </summary>
		public int SprByJob { get; set; }

		/// <summary>
		/// Gets or sets the amount of DEX the character receives from
		/// their job.
		/// </summary>
		public int DexByJob { get; set; }

		/// <summary>
		/// Returns the max EXP for the character's current level.
		/// </summary>
		public long MaxExp => BarracksServer.Instance.Data.ExpDb.GetNextExp(this.Level);

		/// <summary>
		/// Character's scripting variables.
		/// </summary>
		public VariablesContainer Variables { get; } = new VariablesContainer();

		/// <summary>
		/// Creates a new character with default values.
		/// </summary>
		public Character()
		{
			this.Equipment = new EquipItem[InventoryDefaults.EquipSlotCount];

			for (var i = 0; i < InventoryDefaults.EquipSlotCount; ++i)
			{
				var itemId = InventoryDefaults.EquipItems[i];
				var slot = (EquipSlot)i;

				this.Equipment[i] = new EquipItem(itemId, slot);
			}
		}

		/// <summary>
		/// Returns ids of equipped items.
		/// </summary>
		/// <returns></returns>
		public int[] GetEquipIds()
		{
			return this.Equipment.Select(a => a.Id).ToArray();
		}

		/// <summary>
		/// Returns the equipment properties as an array.
		/// </summary>
		/// <returns></returns>
		public Properties[] GetEquipmentProperties()
		{
			return this.Equipment.Select(a => a.Properties).ToArray();
		}

		/// <summary>
		/// Sets the character's equipment from the given list.
		/// </summary>
		/// <param name="equipment"></param>
		/// <returns></returns>
		public void SetEquipment(EquipList equipment)
		{
			foreach (var item in equipment)
			{
				var slot = item.Key;
				var itemId = item.Value;

				this.Equipment[(int)slot] = new EquipItem(itemId, slot);
			}
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

	/// <summary>
	/// A list of equipment slots and ids of items to equip on them.
	/// </summary>
	public class EquipList : Dictionary<EquipSlot, int>
	{
	}
}
