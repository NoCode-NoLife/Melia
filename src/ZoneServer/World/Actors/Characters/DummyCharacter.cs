using Melia.Zone.Network;

namespace Melia.Zone.World.Actors.Characters
{
	/// <summary>
	/// Represents a dummy character.
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
		public bool HasOwner => Owner != null;

		/// <summary>
		/// Despawns/Removes this entity from the map.
		/// </summary>
		public void Despawn()
		{
			Send.ZC_OWNER(this.Owner, this, 0);
			Send.ZC_LEAVE(this);

			this.Map.RemoveCharacter(this);
		}
	}
}
