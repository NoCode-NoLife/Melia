using System;

namespace Melia.Zone.World.Actors.Characters
{
	/// <summary>
	/// Represents a player character.
	/// </summary>
	public class DummyCharacter : Character
	{
		/// <summary>
		/// Returns reference to the character's owner (In case of being a dummy).
		/// </summary>
		public Character Owner { get; set; }

		/// <summary>
		/// Returns true if the DummyCharacter has Owner
		/// </summary>
		public bool hasOwner => Owner != null;
	}
}
