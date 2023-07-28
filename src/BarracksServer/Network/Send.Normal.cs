using System;
using System.Linq;
using Melia.Barracks.Database;
using Melia.Barracks.Network.Helpers;
using Melia.Shared.Network;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;

namespace Melia.Barracks.Network
{
	public static partial class Send
	{
		public static class BC_NORMAL
		{
			/// <summary>
			/// Sets the character for the barrack
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="id"></param>
			public static void SetBarrackCharacter(IBarracksConnection conn, Character character)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.SetBarrackCharacter);

				packet.PutLong(conn.Account.Id);
				packet.PutLong(conn.Account.Id);
				packet.AddBarrackPc(character);

				conn.Send(packet);
			}

			/// <summary>
			/// Sets the barrack, but not working for some reason.
			/// Use the account property to do this.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="mapId"></param>
			public static void SetBarrack(IBarracksConnection conn, int mapId)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.SetBarrack);
				packet.PutLong(conn.Account.Id);
				packet.PutInt(mapId);
				packet.PutByte(1);
				packet.PutInt(0);
				conn.Send(packet);
			}

			/// <summary>
			/// Purpose unknown. Related to buying themas and appears to
			/// sometimes send the player back to the character selection
			/// screen.
			/// </summary>
			/// <param name="conn"></param>
			public static void UnkThema1(IBarracksConnection conn)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.UnkThema1);

				conn.Send(packet);
			}

			/// <summary>
			/// Moves a character in the barrack.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="index"></param>
			/// <param name="position"></param>
			public static void SetPosition(IBarracksConnection conn, byte index, Position position)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.SetPosition);
				packet.PutLong(conn.Account.Id);
				packet.PutByte(index);
				packet.PutFloat(position.X);
				packet.PutFloat(position.Y);
				packet.PutFloat(position.Z);

				conn.Send(packet);
			}

			/// <summary>
			/// Sends information related to the team to be displayed in the barrack.
			/// </summary>
			/// <param name="conn"></param>
			public static void TeamUI(IBarracksConnection conn)
			{
				var characters = conn.Account.GetCharacters();

				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.TeamUI);
				packet.PutLong(conn.Account.Id);
				packet.PutShort(conn.Account.AdditionalSlotCount);
				packet.PutInt(conn.Account.TeamExp);
				packet.PutShort(conn.Account.CharacterCount);

				conn.Send(packet);
			}

			/// <summary>
			/// Updates server list on client.
			/// </summary>
			/// <param name="conn"></param>
			public static void ZoneTraffic(IBarracksConnection conn)
			{
				var characters = conn.Account.GetCharacters();
				var mapIds = characters.Select(a => a.MapId).Distinct();
				var mapCount = mapIds.Count();
				var maxPlayersPerMap = 100;

				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.ZoneTraffic);

				// The response is a list of maps and the zone servers they
				// are available on, with the maps corresponding to the maps
				// the characters are on. For example, if you have 2 characters,
				// one on map 1021 and one on 5001, you'll get information for
				// those two maps and all zone servers that are hosting that map.

				packet.Zlib(true, zpacket =>
				{
					// [i373239 (2023-05-10)] Might've been added before
					{
						zpacket.PutShort(0);
						zpacket.PutShort(0);
					}

					if (mapCount == 0)
					{
						zpacket.PutShort(0);
						zpacket.PutInt(100);
					}
					else
					{
						zpacket.PutShort(maxPlayersPerMap);
						zpacket.PutShort(mapCount);

						foreach (var mapId in mapIds)
						{
							var availableZoneServers = BarracksServer.Instance.ServerList.GetZoneServers(mapId);

							zpacket.PutShort(mapId);
							zpacket.PutShort(availableZoneServers.Length);

							for (var channelId = 0; channelId < availableZoneServers.Length; ++channelId)
							{
								var zoneServerInfo = availableZoneServers[channelId];

								// The client uses the "channelId" as part of the
								// channel name. For example, id 0 becomes "Ch 1",
								// id 1 becomes "Ch 2", etc. Because of this we
								// can't just send anything here, it needs to be
								// a sequential number starting from 0 to match
								// official behavior.

								zpacket.PutShort(channelId);
								zpacket.PutShort(zoneServerInfo.CurrentPlayers);
								zpacket.PutShort(zoneServerInfo.MaxPlayers);
							}
						}
					}
				});

				conn.Send(packet);
			}

			/// <summary>
			/// Updates server list on all logged in clients.
			/// </summary>
			/// <param name="conn"></param>
			public static void ZoneTraffic()
			{
				var connections = BarracksServer.Instance.GetAllConnections();

				foreach (var conn in connections)
				{
					if (conn.LoggedIn)
						ZoneTraffic(conn);
				}
			}

			/// <summary>
			/// Invokes a lua function.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="str"></param>
			public static void Run(IBarracksConnection conn, string str)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.Run);
				packet.PutLpString(str);

				conn.Send(packet);
			}

			/// <summary>
			/// Mailbox
			/// </summary>
			/// <param name="conn"></param>
			public static void Mailbox(IBarracksConnection conn)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.Mailbox);

				packet.Zlib(true, zpacket =>
				{
					var mailBox = conn.Account.Mailbox;
					zpacket.PutByte(mailBox.HasMessages);
					zpacket.PutInt(mailBox.ReadMessages);
					zpacket.PutInt(mailBox.UnreadMesages);
					zpacket.PutInt(mailBox.MessageCount); //Message Count?

					foreach (var message in mailBox.GetMail())
					{
						zpacket.PutLpString(message.Sender);
						zpacket.PutLpString(message.Subject);
						zpacket.PutLpString(message.Message);
						zpacket.PutDate(message.StartDate); // Date Sent?
						zpacket.PutDate(message.ExpirationDate); // Expiration
						zpacket.PutDate(message.CreatedDate);
						zpacket.PutLong(message.Id); // Message Id
						zpacket.PutByte(message.IsRead);
						zpacket.PutShort(message.Items.Count);
						zpacket.PutByte(0); // Changes Visibility?
						zpacket.PutByte(0);
						zpacket.PutByte(1);
						zpacket.PutShort(0);
						zpacket.PutInt(message.Items.Count); // Message Item Count

						foreach (var item in message.Items)
						{
							zpacket.PutInt(item.Id);
							zpacket.PutInt(item.ItemId);
							zpacket.PutInt(item.Amount);
							zpacket.PutInt(item.IsReceived ? 1 : 0);
						}
					}
				});

				conn.Send(packet);
			}

			/// <summary>
			/// Updates the state of a mailbox message.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="messageId"></param>
			/// <param name="state"></param>
			public static void UpdateMailboxState(IBarracksConnection conn, long messageId, MailBoxMessageState state)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.MailboxState);
				packet.PutLong(messageId);
				packet.PutByte((byte)state);

				conn.Send(packet);
			}

			/// <summary>
			/// Mail Update
			/// </summary>
			/// <param name="conn"></param>
			public static void MailUpdate(IBarracksConnection conn, MailMessage message)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.MailUpdate);

				packet.PutLong(message.Id);
				packet.PutByte((byte)message.State);
				packet.PutInt(7);
				packet.PutInt(message.Items.Count); // Message Item Count

				foreach (var item in message.Items)
				{
					packet.PutInt(item.Id);
					packet.PutInt(item.ItemId);
					packet.PutInt(item.Amount);
					packet.PutInt(item.IsReceived ? 1 : 0);
				}

				conn.Send(packet);
			}

			/// <summary>
			/// Sends the session key to the client.
			/// </summary>
			/// <param name="conn"></param>
			public static void SetSessionKey(IBarracksConnection conn)
			{
				var packet = new Packet(Op.ZC_NORMAL);
				packet.PutInt(NormalOp.Barrack.SetSessionKey);
				packet.PutLpString(conn.SessionKey);

				conn.Send(packet);
			}

			/// <summary>
			/// Notifies the client that it has failed the integrity check of its files.
			/// </summary>
			/// <param name="conn"></param>
			public static void ClientIntegrityFailure(IBarracksConnection conn)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.ClientIntegrityFailure);

				conn.Send(packet);
			}

			/// <summary>
			/// Updates the number of purchased character slots.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="count"></param>
			public static void BarrackSlotCount(IBarracksConnection conn, int count)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.BarrackSlotCount);
				packet.PutInt(count);

				conn.Send(packet);
			}

			/// <summary>
			/// Updates the number of purchased character slots.
			/// </summary>
			/// <param name="conn"></param>
			public static void CharacterInfo(IBarracksConnection conn)
			{
				var characters = conn.Account.GetCharacters();

				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.CharacterInfo);

				packet.PutLong(conn.Account.Id);
				packet.PutInt(characters.Length);
				foreach (var character in characters)
				{
					packet.PutLong(character.Id);
					packet.PutString(character.Name, 64);
					packet.PutEmptyBin(24);
				}

				conn.Send(packet);
			}

			/// <summary>
			/// Informs client that a connection attempt to a zone server
			/// has failed.
			/// </summary>
			/// <remarks>
			/// This packet needs to be sent when cancelling a connection
			/// attempt or the client won't react to any further attempts
			/// until the user relogged.
			/// </remarks>
			/// <param name="conn"></param>
			public static void StartGameFailed(IBarracksConnection conn)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.StartGameFailed);

				conn.Send(packet);
			}
		}
	}
}
