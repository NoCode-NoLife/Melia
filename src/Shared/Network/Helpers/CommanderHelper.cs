using Melia.Shared.World;

namespace Melia.Shared.Network.Helpers
{
	public static class CommanderHelper
	{
		/// <summary>
		/// Serializes an object that implements ICommander and places it into the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="commander"></param>
		public static void AddCommander(this Packet packet, ICommander commander)
		{
			packet.PutInt(commander.Handle);
			packet.PutInt(0);
			packet.AddAppearancePc(commander);

			packet.PutFloat(commander.Position.X);
			packet.PutFloat(commander.Position.Y);
			packet.PutFloat(commander.Position.Z);
			packet.PutInt(0);
			packet.PutLong(commander.Exp);
			packet.PutLong(commander.MaxExp);
			packet.PutLong(commander.TotalExp);

			packet.PutLong(commander.ObjectId);
			packet.PutLong(commander.SocialUserId);

			packet.PutInt(commander.Hp);
			packet.PutInt(commander.MaxHp);
			packet.PutInt(commander.Sp);
			packet.PutInt(commander.MaxSp);
			packet.PutInt(commander.Stamina);
			packet.PutInt(commander.MaxStamina);
			packet.PutInt(0); // Shield
			packet.PutInt(0); // MaxShield

			// [i3XXXXX (202X-XX-XX)]
			// It's currently unclear when these were added, but it seems like
			// they've been here for a while... Guess we were lucky and the
			// client didn't actual try to read them.
			packet.PutEmptyBin(32);

			// [i387215 (2024-07-09)]
			// These were seemingly added in this patch, because this is the point
			// where the client started to mis-parse the packets, causing issues.
			// It's possible that they go before the 32 above though.
			{
				packet.PutEmptyBin(8);
			}
		}
	}

	public interface ICommander : IAppearancePc
	{
		int Handle { get; }
		Position Position { get; }
		long Exp { get; }
		long MaxExp { get; }
		long TotalExp { get; }
		long ObjectId { get; }
		long SocialUserId { get; }
		int Hp { get; }
		int MaxHp { get; }
		int Sp { get; }
		int MaxSp { get; }
		int Stamina { get; }
		int MaxStamina { get; }
	}
}
