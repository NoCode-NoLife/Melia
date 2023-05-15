using Melia.Shared.Network.Helpers;
using Melia.Shared.Network;
using Melia.Shared.World;

namespace Melia.Barracks.Network.Helpers
{
	/// <summary>
	/// Contains extensions to write appearance data of a characters
	/// to packets.
	/// </summary>
	public static class AppearanceBarrackPcHelper
	{
		/// <summary>
		/// Writes full barracks appearance data to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="pc"></param>
		public static void AddAppearanceBarrackPc(this Packet packet, IAppearanceBarrackPc pc)
		{
			packet.AddAppearancePc(pc);

			packet.PutLong(pc.Id);

			// [i11025 (2016-02-26)]
			// Index was previously stored as a short, now there seem
			// to be two byte, with the first being the index.
			{
				packet.PutByte(pc.Index);
				packet.PutByte(0);
			}

			packet.PutShort(1);
			packet.PutShort(pc.MapId);
			packet.PutShort(pc.Channel);
			packet.PutLong(0); // Current XP?
			packet.PutLong(8); // Max XP?

			packet.PutInt(0);
			packet.PutShort(0);
			packet.PutShort(0);
			packet.PutLong(pc.Silver);

			// Position?
			packet.PutFloat(pc.BarracksPosition.X);
			packet.PutFloat(pc.BarracksPosition.Y);
			packet.PutFloat(pc.BarracksPosition.Z);
			packet.PutFloat(0); // Vector direction
			packet.PutFloat(0); // Vector direction

			packet.PutFloat(pc.BarracksPosition.X);
			packet.PutFloat(pc.BarracksPosition.Y);
			packet.PutFloat(pc.BarracksPosition.Z);
			packet.PutFloat(0); // Vector direction
			packet.PutFloat(0); // Vector direction
		}
	}

	/// <summary>
	/// Describes a full barracks character with all its associated data.
	/// </summary>
	public interface IAppearanceBarrackPc : IAppearancePc
	{
		/// <summary>
		/// Returns the character's unique id.
		/// </summary>
		long Id { get; }

		/// <summary>
		/// Returns the character's index in the character list.
		/// </summary>
		byte Index { get; }

		/// <summary>
		/// Returns the id of the map the character is currently on.
		/// </summary>
		int MapId { get; }

		/// <summary>
		/// ?
		/// </summary>
		int Channel { get; }

		/// <summary>
		/// Returns the character's current position inside the barracks.
		/// </summary>
		Position BarracksPosition { get; }

		/// <summary>
		/// Returns the direction the character is facing inside the barracks.
		/// </summary>
		Direction BarracksDirection { get; }

		/// <summary>
		/// Returns the amount of silver the character has.
		/// </summary>
		long Silver { get; }
	}
}
