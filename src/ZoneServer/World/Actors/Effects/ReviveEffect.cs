using Melia.Zone.Network;

namespace Melia.Zone.World.Actors.Effects
{
	/// <summary>
	/// Effect that sends a revive packet for an actor.
	/// </summary>
	public class ReviveEffect : Effect
	{
		/// <summary>
		/// Shows the effect by sending a revive packet.
		/// </summary>
		/// <param name="conn">The connection to show the effect to.</param>
		/// <param name="actor">The actor that owns the effect.</param>
		public override void ShowEffect(IZoneConnection conn, IActor actor)
		{
			Send.ZC_NORMAL.Revive(conn, actor);
		}
	}
}
