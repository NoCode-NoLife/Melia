using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Components;

namespace Melia.Zone.World.Actors.Pads.Components
{
	public class PadMovementComponent : ActorMovementComponent
	{
		/// <summary>
		/// Returns the pad that owns this component.
		/// </summary>
		public Pad Pad { get; }

		/// <summary>
		/// Creates new instance for pad.
		/// </summary>
		/// <param name="pad"></param>
		public PadMovementComponent(Pad pad) : base(pad)
		{
			this.Pad = pad;
		}

		/// <summary>
		/// Updates the pad's movement on nearby clients.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="dest"></param>
		/// <param name="speed"></param>
		protected override void UpdateMoveTo(Position pos, Position dest, float speed)
		{
			Send.ZC_NORMAL.PadMoveTo(this.Pad, dest, speed);
		}

		/// <summary>
		/// Stops the pad at the given position on nearby clients.
		/// </summary>
		/// <param name="pos"></param>
		protected override void UpdateStop(Position pos)
		{
			// It's possible there's a dedicated packet for stopping pad movement,
			// but for now we'll just send a move with a very high speed, so it
			// snaps there instantly and stops moving. Alternatively, we could
			// just not send anything and hope it's in the right place.
			Send.ZC_NORMAL.PadMoveTo(this.Pad, pos, 10000);
		}
	}
}
