using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.Network.Inter.Messages;
using Melia.Shared.ObjectProperties;
using Melia.Social.Commands;
using Melia.Social.Database;
using Melia.Social.Network;
using Melia.Social.World;
using Yggdrasil.Logging;
using Yggdrasil.Network.Communication;
using Yggdrasil.Network.TCP;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Social
{
	/// <summary>
	/// Represents a social server.
	/// </summary>
	public class SocialServer : Server
	{
		public readonly static SocialServer Instance = new();

		private TcpConnectionAcceptor<SocialConnection> _acceptor;

		/// <summary>
		/// Returns the server's inter-server communicator.
		/// </summary>
		public Communicator Communicator { get; private set; }

		/// <summary>
		/// Returns a reference to the server's packet handlers.
		/// </summary>
		public PacketHandler PacketHandler { get; private set; }

		/// <summary>
		/// Returns reference to the server's database interface.
		/// </summary>
		public SocialDb Database { get; } = new SocialDb();

		/// <summary>
		/// Returns reference to the server's chat command handlers.
		/// </summary>
		public ChatCommands ChatCommands { get; } = new ChatCommands();

		/// <summary>
		/// Returns reference to the server's account manager.
		/// </summary>
		public UserManager UserManager { get; } = new UserManager();

		/// <summary>
		/// Returns reference to the server's chat manager.
		/// </summary>
		public ChatManager ChatManager { get; } = new ChatManager();

		/// <summary>
		/// Runs the server.
		/// </summary>
		/// <param name="args"></param>
		public override void Run(string[] args)
		{
			this.GetServerId(args, out var groupId, out var serverId);
			var title = string.Format("Social ({0}, {1})", groupId, serverId);

			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, title, ConsoleColor.DarkCyan, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			Log.Init($"SocialServer_{groupId}_{serverId}");

			this.NavigateToRoot();

			this.LoadConf();
			this.LoadLocalization(this.Conf);
			this.LoadData(ServerType.Social);
			this.LoadServerList(this.Data.ServerDb, ServerType.Social, groupId, serverId);
			this.InitDatabase(this.Database, this.Conf);
			this.LoadPacketHandler();
			this.LoadManagers();

			this.StartCommunicator();
			this.StartAcceptors();

			ConsoleUtil.RunningTitle();
			new ConsoleCommands().Wait();
		}

		/// <summary>
		/// Starts the communicator and attempts to connect to the
		/// coordinator.
		/// </summary>
		private void StartCommunicator()
		{
			Log.Info("Attempting to connect to coordinator...");

			var commName = (this.ServerInfo.Id == 1 ? "Chat" : "Relation");

			this.Communicator = new Communicator(commName);
			this.Communicator.Disconnected += this.Communicator_OnDisconnected;
			this.Communicator.MessageReceived += this.Communicator_OnMessageReceived;

			this.ConnectToCoordinator();
		}

		/// <summary>
		/// Attempts to establish a connection to the coordinator.
		/// </summary>
		private void ConnectToCoordinator()
		{
			var barracksServerInfo = this.GetServerInfo(ServerType.Barracks, 1);
			var authentication = this.Conf.Inter.Authentication;

			try
			{
				this.Communicator.Connect("Coordinator", authentication, barracksServerInfo.Ip, barracksServerInfo.InterPort);

				this.Communicator.Subscribe("Coordinator", "AllServers");
				this.Communicator.Subscribe("Coordinator", "AllSocials");
				if (this.ServerInfo.Id == 1)
					this.Communicator.Subscribe("Coordinator", "Chat");

				Log.Info("Successfully connected to coordinator.");
			}
			catch
			{
				Log.Error("Failed to connect to coordinator, trying again in 5 seconds...");
				Thread.Sleep(5000);

				this.ConnectToCoordinator();
			}
		}

		/// <summary>
		/// Called when the connection to the coordinator was lost.
		/// </summary>
		/// <param name="commName"></param>
		private void Communicator_OnDisconnected(string commName)
		{
			Log.Error("Lost connection to coordinator, will try to reconnect in 5 seconds...");
			Thread.Sleep(5000);

			this.ConnectToCoordinator();
		}

		/// <summary>
		/// Called when a message was received from the coordinator.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		private void Communicator_OnMessageReceived(string sender, ICommMessage message)
		{
			switch (message)
			{
				case ShoutMessage shoutMessage:
				{
					// This feels like a hack. Perhaps we should split up chat
					// and relation servers? Or merge them even more?
					if (this.Communicator.Name != "Chat")
						return;

					if (!this.UserManager.TryGet(shoutMessage.TeamName, out var shoutingUser))
					{
						Log.Warning("ShoutMessage: Shouting user '{0}' not found.", shoutMessage.TeamName);
						break;
					}

					Send.SC_NORMAL.Shout(shoutingUser, shoutMessage.Text);
					break;
				}
				case PartyUpdateMessage partyUpdateMessage:
				{
					if (!this.UserManager.TryGet(partyUpdateMessage.AccountId, out var user))
					{
						Log.Warning("PartyUpdateMessage: User not found for AccountId={0}, PartyId={1}, IsJoining={2}",
							partyUpdateMessage.AccountId, partyUpdateMessage.PartyId, partyUpdateMessage.IsJoining);
						break;
					}

					if (partyUpdateMessage.IsJoining)
					{
						// Update the user's PartyId directly from the message
						// (don't read from database - it may not be updated yet)
						var partyRoomId = partyUpdateMessage.PartyId | ObjectIdRanges.Party;
						user.Character.PartyId = partyRoomId;

						// Add them to the party chat room
						if (!this.ChatManager.TryGetChatRoom(partyRoomId, out var chatRoom))
							chatRoom = this.ChatManager.CreateChatRoom(user, partyRoomId, ChatRoomType.Friends);

						chatRoom.AddMember(user);

						if (user.TryGetConnection(out var conn))
							Send.SC_NORMAL.MessageList(conn, chatRoom, chatRoom.GetMessages());
					}
					else
					{
						// Clear the user's PartyId
						user.Character.PartyId = ObjectIdRanges.Party;

						// Remove them from all party chat rooms
						var rooms = this.ChatManager.FindChatRooms(user);
						foreach (var room in rooms)
						{
							if ((room.Id & unchecked((long)0xFF00000000000000)) == ObjectIdRanges.Party)
							{
								room.RemoveMember(user.AccountId);

								// Destroy the chat room if it's now empty
								if (room.MemberCount == 0)
									this.ChatManager.RemoveChatRoom(room.Id);
							}
						}
					}
					break;
				}
			}
		}

		/// <summary>
		/// Loads and initializes the server's managers.
		/// </summary>
		private void LoadManagers()
		{
			Log.Info("Loading information from the database...");

			this.UserManager.LoadUsers();
			this.ChatManager.LoadChats();
		}

		/// <summary>
		/// Initializes packet handler based on the server type.
		/// </summary>
		private void LoadPacketHandler()
		{
			if (this.ServerInfo.Id == 1)
				this.PacketHandler = new PacketHandlerChat();
			else
				this.PacketHandler = new PacketHandlerRelation();
		}

		/// <summary>
		/// Starts the server's TCP connection acceptors.
		/// </summary>
		private void StartAcceptors()
		{
			_acceptor = new TcpConnectionAcceptor<SocialConnection>(this.ServerInfo.Port);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.ConnectionRejected += this.OnConnectionRejected;
			_acceptor.Listen();

			Log.Status("Server ready, listening on {0}.", _acceptor.Address);
		}

		/// <summary>
		/// Called when a new connection is accepted.
		/// </summary>
		/// <param name="conn"></param>
		private void OnConnectionAccepted(SocialConnection conn)
		{
			Log.Info("New connection accepted from '{0}'.", conn.Address);
		}

		/// <summary>
		/// Called when a new connection was rejected.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="reason"></param>
		private void OnConnectionRejected(SocialConnection conn, string reason)
		{
			Log.Info("Connection rejected from '{0}'. Reason: {1}", conn.Address, reason);
		}
	}
}
