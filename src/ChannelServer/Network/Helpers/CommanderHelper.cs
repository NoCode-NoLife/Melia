// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.World;
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
			packet.PutInt(commander.Exp);
			packet.PutInt(commander.MaxExp);

			// TODO: Add a method to the character class to calculate total accumulated Exp.
			// This can be done by using the level table and adding the current Exp to the base.
			packet.PutInt(0);   // Total accumulated Exp.

			packet.PutLong(commander.Id);

			// TODO: Assign new IDs to characters such that the social ID does not conflict.
			packet.PutLong(commander.Id + 1);   // SocialInfoId

			packet.AddBaseStat(commander);
		}

		/// <summary>
		/// Serializes a comamnder's base stats into a packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="commander"></param>
		public static void AddBaseStat(this Packet packet, ICommander commander)
		{
			packet.PutInt(commander.BaseStat.Hp);
			packet.PutInt(commander.BaseStat.MaxHp);
			packet.PutShort(commander.BaseStat.Sp);
			packet.PutShort(commander.BaseStat.MaxSp);
			packet.PutInt(commander.BaseStat.Stamina);
			packet.PutInt(commander.BaseStat.MaxStamina);
			packet.PutInt(0); // Shield
		}
	}

	public interface ICommander : IAppearancePc
	{
		int Handle { get; }
		Position Position { get; }
		int Exp { get; }
		int MaxExp { get; }
		long Id { get; }
		IBaseStat BaseStat { get; }
	}
}
