using Melia.Shared.Database;
using Melia.Shared.Network;
using Melia.Zone.Database;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Groups;
using Yggdrasil.Logging;
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

		/// <summary>
		/// Saves the account and character associated with this connection.
		/// </summary>
		void SaveAccountAndCharacter();
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

			var character = this.SelectedCharacter;
			var justSaved = character?.SavedForWarp ?? false;

			// We have two situations in which we want to save: On logout,
			// and when the connection is closed somewhat unexpectedly.
			// This save is for the latter case, but we only want to do
			// this if we didn't save for logout already, because if we
			// did, the client might at this point already be connecting
			// to the next server, and the saving and loading operations
			// could interfere with each other.
			if (!justSaved)
				this.SaveAccountAndCharacter();

			character?.Map.RemoveCharacter(character);
		}

		/// <summary>
		/// Saves the account and character associated with this connection.
		/// </summary>
		public void SaveAccountAndCharacter()
		{
			if (this.Account == null)
				return;

			var account = this.Account;
			var character = this.SelectedCharacter;

			// If, for whatever reason, a character managed to stay logged in
			// after another session was started for the account, we want to
			// skip saving the character, as it might interfere with the new
			// session. This should only happen in a rare edge case, where
			// a zone server is not connected to the coordinater, misses a
			// logout request upon double login, and two people end up
			// playing the same account.
			if (!ZoneServer.Instance.Database.CheckSessionKey(account.Id, this.SessionKey))
			{
				var accountName = account.Name;
				var characterName = character?.Name ?? "NULL";

				Log.Warning("ZoneConnection.Save: Skipping save for account '{0}' and character '{1}' because the connection's session key does not match.", accountName, characterName);
				return;
			}

			ZoneServer.Instance.Database.SaveAccount(account);
			ZoneServer.Instance.Database.UpdateLoginState(account.Id, 0, LoginState.LoggedOut);

			if (character != null)
			{
				character.Components.Get<BuffComponent>().StopTempBuffs();
				ZoneServer.Instance.Database.SaveCharacter(character);
			}
		}
	}
}
