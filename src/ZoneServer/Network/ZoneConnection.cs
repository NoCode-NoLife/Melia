using Melia.Shared.Network;
using Melia.Zone.Database;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Entities;
using Yggdrasil.Network.TCP;

namespace Melia.Zone.Network
{
	/// <summary>
	/// A connection from the client to the zone server.
	/// </summary>
	public interface IZoneConnection : IConnection
	{
		/// <summary>
		/// Gets or sets the account associated with the connection.
		/// </summary>
		Account Account { get; set; }

		/// <summary>
		/// Gets or sets a reference to the currently controlled character.
		/// </summary>
		Character SelectedCharacter { get; set; }

		/// <summary>
		/// Gets or sets the current dialog.
		/// </summary>
		Dialog CurrentDialog { get; set; }
	}

	/// <summary>
	/// A connection from the client to the zone server.
	/// </summary>
	public class ZoneConnection : Connection, IZoneConnection
	{
		/// <summary>
		/// Gets or sets the account associated with the connection.
		/// </summary>
		public Account Account { get; set; }

		/// <summary>
		/// Gets or sets a reference to the currently controlled character.
		/// </summary>
		public Character SelectedCharacter { get; set; }

		/// <summary>
		/// Gets or sets the current dialog.
		/// </summary>
		public Dialog CurrentDialog { get; set; }

		/// <summary>
		/// Handles the given packet for this connection.
		/// </summary>
		/// <param name="packet"></param>
		protected override void OnPacketReceived(Packet packet)
		{
			ZoneServer.Instance.PacketHandler.Handle(this, packet);
		}

		/// <summary>
		/// Called when the connection was closed.
		/// </summary>
		/// <param name="type"></param>
		protected override void OnClosed(ConnectionCloseType type)
		{
			base.OnClosed(type);

			this.Account?.Save();

			var character = this.SelectedCharacter;
			if (character != null)
			{
				character.Map.RemoveCharacter(character);

				// Remove all buffs on logout for now, until we have
				// buff saving. Otherwise, we would save and then
				// stack buff effects, such as from DashRun.
				character.Buffs.RemoveAll();

				ZoneServer.Instance.Database.SaveCharacter(character);
			}
		}
	}
}
