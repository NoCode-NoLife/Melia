using Melia.Channel.Database;
using Melia.Channel.Scripting;
using Melia.Channel.World.Entities;
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
			if (this.Account != null)
			{
				this.Account.Save();

				var character = this.SelectedCharacter;
				if (character != null)
				{
					character.Map.RemoveCharacter(character);

					// Remove all buffs on logout for now, until we have
					// buff saving. Otherwise, we would save and then
					// stack buff effects, such as from DashRun.
					character.Buffs.RemoveAll();

					ChannelServer.Instance.Database.SaveCharacter(character);
				}
			}

			this.ScriptState.Reset();
		}
	}
}
