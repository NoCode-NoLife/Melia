using Melia.Shared.Network;
using Melia.Shared.World;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Network.Helpers
{
	/// <summary>
	/// Helper methods for adding movement information to packets.
	/// </summary>
	public static class MovementHelper
	{
		/// <summary>
		/// Adds information about the actor moving between the given cell
		/// positions to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="actor"></param>
		/// <param name="fromCellPos"></param>
		/// <param name="toCellPos"></param>
		/// <param name="speed"></param>
		public static void AddCellMovement(this Packet packet, IActor actor, Position fromCellPos, Position toCellPos, float speed)
		{
			packet.PutInt(actor.Handle);
			packet.PutInt((int)fromCellPos.X);
			packet.PutInt((int)fromCellPos.Z);
			packet.PutInt((int)fromCellPos.Y);
			packet.PutInt((int)toCellPos.X);
			packet.PutInt((int)toCellPos.Z);
			packet.PutInt((int)toCellPos.Y);
			packet.PutFloat(speed);

			// [i354444] Float removed, byte added. Same thing?
			//packet.PutFloat(0);
			packet.PutByte(0);
		}
	}
}
