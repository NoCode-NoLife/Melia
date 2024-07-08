using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Zone.Database;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
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

			var account = this.Account;
			var character = this.SelectedCharacter;
			var justSaved = character?.SavedForWarp ?? false;

			if (!justSaved)
			{
				if (account != null)
				{
					ZoneServer.Instance.Database.SaveAccount(account);
					ZoneServer.Instance.Database.UpdateLoginState(account.Id, 0, LoginState.LoggedOut);
				}

				if (character != null)
				{
					character.Components.Get<BuffComponent>().StopTempBuffs();
					ZoneServer.Instance.Database.SaveCharacter(character);
				}
			}

			character?.Map.RemoveCharacter(character);
		}
	}
}
