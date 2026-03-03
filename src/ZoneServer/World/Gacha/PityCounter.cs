using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Gacha
{
	/// <summary>
	/// Tracks a character's pity values.
	/// </summary>
	public class PityCounters
	{
		/// <summary>
		/// Returns the class name the pity counters are for.
		/// </summary>
		public string ClassName { get; }

		/// <summary>
		/// Returns the pity counter for rare items.
		/// </summary>
		public PityCounter Rare { get; } = new();

		/// <summary>
		/// Returns the pity counter for super rare items.
		/// </summary>
		public PityCounter SuperRare { get; } = new();

		/// <summary>
		/// Creates pity counters for the given gacha machine class name.
		/// </summary>
		/// <param name="className"></param>
		public PityCounters(string className)
		{
			this.ClassName = className;
		}

		/// <summary>
		/// Loads the pity from the character's variables.
		/// </summary>
		/// <param name="character"></param>
		public void Load(Character character)
		{
			this.Rare.PullsSince = character.Variables.Perm.GetInt($"Melia.Gacha.RarePity.{this.ClassName}", 0);
			this.SuperRare.PullsSince = character.Variables.Perm.GetInt($"Melia.Gacha.SuperRarePity.{this.ClassName}", 0);
		}

		/// <summary>
		/// Saves the pity to the character's variables.
		/// </summary>
		/// <param name="character"></param>
		public void Save(Character character)
		{
			character.Variables.Perm.SetInt($"Melia.Gacha.RarePity.{this.ClassName}", this.Rare.PullsSince);
			character.Variables.Perm.SetInt($"Melia.Gacha.SuperRarePity.{this.ClassName}", this.SuperRare.PullsSince);
		}
	}

	/// <summary>
	/// Tracks a character's pulls.
	/// </summary>
	public class PityCounter
	{
		/// <summary>
		/// Returns the number of pulls since the last reset.
		/// </summary>
		public int PullsSince { get; set; }

		/// <summary>
		/// Increases the pulls since the last reset.
		/// </summary>
		public void Increase()
		{
			this.PullsSince++;
		}

		/// <summary>
		/// Resets the counter, effectively resetting the pity.
		/// </summary>
		public void Reset()
		{
			this.PullsSince = 0;
		}
	}
}
