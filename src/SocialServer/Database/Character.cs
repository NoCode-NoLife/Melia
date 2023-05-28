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
		public HatVisibleStates VisibleHats { get { return HatVisibleStates.Hat1 | HatVisibleStates.Hat2 | HatVisibleStates.Hat3; } }

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
