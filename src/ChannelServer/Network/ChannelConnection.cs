// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Database;
using Melia.Channel.Scripting;
using Melia.Channel.World;
using Melia.Shared.Network;

namespace Melia.Channel.Network
{
	public class ChannelConnection : Connection
	{
		/// <summary>
		/// Account associated with this connection.
		/// </summary>
		public Account Account { get; set; }

		/// <summary>
		/// Gets or set connection's script state.
		/// </summary>
		public ScriptState ScriptState { get; private set; }

		/// <summary>
		/// Active character.
		/// </summary>
		public Character SelectedCharacter { get; set; }

		/// <summary>
		/// Instantiates new channel connection.
		/// </summary>
		public ChannelConnection()
			: base()
		{
			this.ScriptState = new ScriptState(this);
		}

		/// <summary>
		/// Handles channel packets.
		/// </summary>
		/// <param name="packet"></param>
		protected override void HandlePacket(Packet packet)
		{
			ChannelPacketHandler.Instance.Handle(this, packet);
		}

		/// <summary>
		/// Cleans up connection, incl. account and characters.
		/// </summary>
		protected override void CleanUp()
		{
			this.Account.Save();

			if (this.SelectedCharacter != null)
			{
				this.SelectedCharacter.Map.RemoveCharacter(this.SelectedCharacter);
				ChannelServer.Instance.Database.SaveCharacter(this.SelectedCharacter);
			}

			this.ScriptState.Reset();
		}
	}
}
