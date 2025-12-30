using Melia.Zone.Network;

namespace Melia.Zone.World.Actors.Effects
{
	/// <summary>
	/// Base class for actor effects.
	/// </summary>
	public abstract class Effect
	{
		/// <summary>
		/// Shows an effect to a specific connection.
		/// </summary>
		/// <param name="conn">The connection to show the effect to.</param>
		/// <param name="actor">The actor that owns the effect.</param>
		public abstract void ShowEffect(IZoneConnection conn, IActor actor);

		/// <summary>
		/// Called when the effect is removed from its owner.
		/// </summary>
		/// <param name="actor">The actor that owned the effect.</param>
		public virtual void OnRemove(IActor actor) { }
	}
}
