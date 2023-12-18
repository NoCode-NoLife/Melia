using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared;
using Melia.Shared.Data.Database;
using Melia.Shared.IES;
using Melia.Shared.L10N;
using Melia.Shared.Network;
using Melia.Shared.Network.Inter.Messages;
using Melia.Zone.Buffs;
using Melia.Zone.Commands;
using Melia.Zone.Database;
using Melia.Zone.Events;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers;
using Melia.Zone.World;
using Microsoft.VisualBasic.Devices;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using Yggdrasil.Network.Communication;
using Yggdrasil.Network.TCP;
using Yggdrasil.Util;
using Yggdrasil.Util.Commands;

namespace Melia.Zone
{
	/// <summary>
	/// Represents a zone server.
	/// </summary>
	public class ZoneServer : Server
	{
		public readonly static ZoneServer Instance = new ZoneServer();

		private TcpConnectionAcceptor<ZoneConnection> _acceptor;

		/// <summary>
		/// Returns the server's inter-server communicator.
		/// </summary>
		public Communicator Communicator { get; private set; }

		/// <summary>
		/// Returns a reference to the server's packet handlers.
		/// </summary>
		public PacketHandler PacketHandler { get; } = new PacketHandler();

		/// <summary>
		/// Returns reference to the server's database interface.
		/// </summary>
		public ZoneDb Database { get; } = new ZoneDb();

		/// <summary>
		/// Returns reference to the server's world manager.
		/// </summary>
		public WorldManager World { get; } = new WorldManager();

		/// <summary>
		/// Returns reference to the server's skill handlers.
		/// </summary>
		public SkillHandlers SkillHandlers { get; } = new SkillHandlers();

		/// <summary>
		/// Returns reference to the server's buff handlers.
		/// </summary>
		public BuffHandlers BuffHandlers { get; } = new BuffHandlers();

		/// <summary>
		/// Returns reference to the server's chat command manager.
		/// </summary>
		public ChatCommands ChatCommands { get; } = new ChatCommands();

		/// <summary>
		/// Returns a reference to the server's event manager.
		/// </summary>
		public ServerEvents ServerEvents { get; } = new ServerEvents();

		/// <summary>
		/// Returns reference to the server's IES mods.
		/// </summary>
		public IesModList IesMods { get; } = new IesModList();

		/// <summary>
		/// Runs the server.
		/// </summary>
		/// <param name="args"></param>
		public override void Run(string[] args)
		{
			this.GetServerId(args, out var groupId, out var serverId);
			var title = string.Format("Zone ({0}, {1})", groupId, serverId);

			ConsoleUtil.WriteHeader(ConsoleHeader.ProjectName, title, ConsoleColor.DarkGreen, ConsoleHeader.Logo, ConsoleHeader.Credits);
			ConsoleUtil.LoadingTitle();

			// Set up zone server specific logging or we might run into
			// issues with multiple servers trying to write files at the
			// same time.
			Log.Init("ZoneServer" + serverId);

			this.NavigateToRoot();

			this.LoadConf();
			this.LoadLocalization(this.Conf);
			this.LoadData(ServerType.Zone);
			this.LoadServerList(this.Data.ServerDb, ServerType.Zone, groupId, serverId);
			this.InitDatabase(this.Database, this.Conf);
			this.InitSkills();
			this.InitWorld();
			this.LoadScripts("system/scripts/scripts_zone.txt");
			this.LoadIesMods();
			this.StartWorld();

			this.StartCommunicator();
			this.StartAcceptor();
			this.SendProcessInformation();

			ConsoleUtil.RunningTitle();
			new ConsoleCommands().Wait();
		}

		/// <summary>
		/// Starts accepting connections.
		/// </summary>
		private void StartAcceptor()
		{
			_acceptor = new TcpConnectionAcceptor<ZoneConnection>(this.ServerInfo.Port);
			_acceptor.ConnectionAccepted += this.OnConnectionAccepted;
			_acceptor.Listen();

			Log.Status("Server ready, listening on {0}.", _acceptor.Address);
		}

		/// <summary>
		/// Starts the communicator and attempts to connect to the
		/// coordinator.
		/// </summary>
		private void StartCommunicator()
		{
			Log.Info("Attempting to connect to coordinator...");

			var commName = "" + this.ServerInfo.Type + this.ServerInfo.Id;

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

			try
			{
				this.Communicator.Connect("Coordinator", barracksServerInfo.Ip, barracksServerInfo.InterPort);

				this.Communicator.Subscribe("Coordinator", "ServerUpdates");
				this.Communicator.Subscribe("Coordinator", "AllServers");
				this.Communicator.Subscribe("Coordinator", "AllZones");

				this.UpdateServerInfo();

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
			//Log.Debug("Message received from '{0}': {1}", sender, message);

			// TODO: Would be nice to have a proper message handler system.

			switch (message)
			{
				case ServerUpdateMessage serverUpdateMessage:
				{
					this.ServerList.Update(serverUpdateMessage);
					break;
				}
				case NoticeTextMessage noticeTextMessage:
				{
					Send.ZC_TEXT(noticeTextMessage.Type, noticeTextMessage.Text);
					break;
				}
				case KickMessage kickMessage:
				{
					IEnumerable<Character> characters;

					if (kickMessage.TargetType == KickTargetType.Player)
					{
						var targetCharacter = this.World.GetCharacterByTeamName(kickMessage.TargetName);
						if (targetCharacter == null)
							break;

						characters = new[] { targetCharacter };
					}
					else if (kickMessage.TargetType == KickTargetType.Map)
					{
						if (!this.World.TryGetMap(kickMessage.TargetName, out var map))
							break;

						characters = map.GetCharacters();
					}
					else
					{
						throw new InvalidDataException($"Invalid kick target type '{kickMessage.TargetType}'.");
					}

					foreach (var character in characters)
					{
						character.MsgBox(Localization.Get("You were kicked by {0}."), kickMessage.OriginName);
						character.Connection.Close(100);
					}
					break;
				}
				case ReqKickAllMessage reqKickAllMessage:
				{
					var characters = this.World.GetCharacters();
					foreach (var character in characters) {
						character.MsgBox(Localization.Get("You were kicked."));
						character.Connection.Close(100);
					}
					break;
				}
				case ReqReloadConfigsMessage reqReloadConfigsMessage:
				{					
					Log.Info("Reloading configuration...");
					this.Conf.Load();
					break;
				}
			}
		}

		/// <summary>
		/// Sends an update about the server's status to the coordinator.
		/// </summary>
		internal void UpdateServerInfo()
		{
			var zoneServer = this;

			var serverId = zoneServer.ServerInfo.Id;
			var playerCount = zoneServer.World.GetCharacterCount();

			var message = new ServerUpdateMessage(ServerType.Zone, serverId, playerCount, ServerStatus.Online);
			zoneServer.Communicator.Send("Coordinator", message);
		}

		/// <summary>
		/// Loads skill handlers.
		/// </summary>
		private void InitSkills()
		{
			Log.Info("Initializing skills...");
			this.SkillHandlers.Init();
		}

		/// <summary>
		/// Loads maps ad initializes them.
		/// </summary>
		private void InitWorld()
		{
			Log.Info("Initializing world...");
			this.World.Initialize();
			Log.Info("  done loading {0} maps.", this.World.Count);
		}

		/// <summary>
		/// Starts the world's update loop, aka the hearbeat.
		/// </summary>
		private void StartWorld()
		{
			Log.Info("Starting world update...");
			this.World.Start();
		}

		/// <summary>
		/// Sets up IES mods.
		/// </summary>
		private void LoadIesMods()
		{
			// This method is temporary until we have a more proper way
			// way of handling IES mods.

			// Centurion was apparently disabled during the beta phase
			// in 2015 and replaced with Fencer, and while it was supposed
			// get added back in on a higher rank, that never happened (?).
			// To enable it, we need to adjust the job rank to make it
			// selectable and give the skills a max level.
			if (!Feature.IsEnabled("CenturionRemoved"))
			{
				this.IesMods.Add("Job", 1005, "Rank", 2);
				this.IesMods.Add("SkillTree", 10502, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10503, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10504, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10505, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10506, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10507, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10508, "MaxLevel", 5);
				this.IesMods.Add("SkillTree", 10509, "MaxLevel", 5);
			}
		}

		/// <summary>
		/// Called when a new connection is accepted.
		/// </summary>
		/// <param name="conn"></param>
		private void OnConnectionAccepted(ZoneConnection conn)
		{
			Log.Info("New connection accepted from '{0}'.", conn.Address);
		}

		/// <summary>
		/// Send the information about the process to the coordinator.
		/// </summary>
		private async void SendProcessInformation()
		{
			var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
			cpuCounter.NextValue();
			Thread.Sleep(1000);
			var cpuUsage = cpuCounter.NextValue();

			var processRamCounter = new PerformanceCounter("Process", "Working Set", Process.GetCurrentProcess().ProcessName);

			var totalRam = new ComputerInfo().TotalPhysicalMemory;
			var processRamUsage = processRamCounter.NextValue();

			var serverInformationMessage = new ResServerInformationMessage(
				this.ServerInfo.Type, Process.GetCurrentProcess().Id, this.ServerInfo.Id,
				Process.GetCurrentProcess().ProcessName, this.ServerInfo.Status,
				cpuUsage, processRamUsage, totalRam, this.ServerInfo.Ip
			);

			try
			{
				this.Communicator.Send("Coordinator", serverInformationMessage);
			}
			catch (Exception)
			{
			}

			await Task.Delay(TimeSpan.FromMinutes(5));
		}
	}
}
