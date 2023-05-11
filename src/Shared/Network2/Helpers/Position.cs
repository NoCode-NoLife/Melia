using Melia.Shared.World;

namespace Melia.Shared.Network2.Helpers
{
	/// <summary>
	/// Helper extension methods for reading and writing positions and
	/// directions.
	/// </summary>
	public static class PositionHelper
	{
		/// <summary>
		/// Reads X, Y, and Z coordinates as floats from packet and returns
		/// them as a Position.
		/// </summary>
		/// <param name="packet"></param>
		/// <returns></returns>
		public static Position GetPosition(this Packet packet)
		{
			var x = packet.GetFloat();
			var y = packet.GetFloat();
			var z = packet.GetFloat();

			return new Position(x, y, z);
		}

		/// <summary>
		/// Writes position into packet as 3 floats.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="pos"></param>
		/// <returns></returns>
		public static void PutPosition(this Packet packet, Position pos)
		{
			packet.PutFloat(pos.X);
			packet.PutFloat(pos.Y);
			packet.PutFloat(pos.Z);
		}

		/// <summary>
		/// Reads cosinus and sinus as floats from packet and returns
		/// them as a Direction.
		/// </summary>
		/// <param name="packet"></param>
		/// <returns></returns>
		public static Direction GetDirection(this Packet packet)
		{
			var cos = packet.GetFloat();
			var sin = packet.GetFloat();

			return new Direction(cos, sin);
		}

		/// <summary>
		/// Writes direction into packet as 2 floats.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="dir"></param>
		/// <returns></returns>
		public static void PutDirection(this Packet packet, Direction dir)
		{
			packet.PutFloat(dir.Cos);
			packet.PutFloat(dir.Sin);
		}
	}
}
