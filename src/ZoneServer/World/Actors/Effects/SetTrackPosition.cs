using Melia.Zone.Network;

namespace Melia.Zone.World.Actors.Effects
{
	/// <summary>
	/// Effect that sets an NPC's track position.
	/// </summary>
	public class SetTrackPosition : Effect
	{
		/// <summary>
		/// Shows the effect by setting the NPC's track position.
		/// </summary>
		/// <param name="conn">The connection to show the effect to.</param>
		/// <param name="actor">The actor that owns the effect.</param>
		public override void ShowEffect(IZoneConnection conn, IActor actor)
		{
			Send.ZC_NORMAL.SetNPCTrackPosition(conn, actor);
		}
	}
}
