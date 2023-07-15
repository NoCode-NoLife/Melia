using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Zone.Database;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World;
using Melia.Zone.World.Actors.Characters;
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

		/// <summary>
		/// Gets or sets the current party.
		/// </summary>
		Party Party { get; set; }

		/// <summary>
		/// Gets or sets the current guild.
		/// </summary>
		Guild Guild { get; set; }
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
		/// Gets or sets the current party.
		/// </summary>
		public Party Party { get; set; }

		/// <summary>
		/// Gets or sets the current guild.
		/// </summary>
		public Guild Guild { get; set; }

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

				// Remove all buffs that are not supposed to be saved
				character.Buffs.RemoveAll(a => !a.Data.Save);

				ZoneServer.Instance.Database.SaveCharacter(character);
				ZoneServer.Instance.Database.UpdateLoginState(this.Account.Id, 0, LoginState.LoggedOut);
			}
		}
	}
}
