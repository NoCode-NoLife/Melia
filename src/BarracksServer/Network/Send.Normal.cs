using System.Collections.Generic;
using System.Linq;
using Melia.Barracks.Database;
using Melia.Barracks.Network.Helpers;
using Melia.Shared.Network;
using Melia.Shared.Game.Const;
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
			/// Exact purpose unknown. Related to buying themas and appears
			/// to sometimes send the player back to the character selection
			/// screen.
			/// </summary>
			/// <param name="conn"></param>
			public static void ThemaSuccess(IBarracksConnection conn)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.ThemaSuccess);

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
			/// Updates the message list on the account's mailbox.
			/// </summary>
			/// <param name="conn">The connection used to send the mailbox data to the client.</param>
			/// <param name="messages"></param>
			/// <param name="page"></param>
			/// <param name="totalMessageCount"></param>
			public static void Mailbox(IBarracksConnection conn, IEnumerable<MailMessage> messages, int page, int totalMessageCount)
			{
				var messageCount = messages.Count();

				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.Mailbox);

				packet.Zlib(true, zpacket =>
				{
					zpacket.PutByte((byte)page);
					zpacket.PutByte(messageCount == 0);
					zpacket.PutEmptyBin(3); // Alignment?
					zpacket.PutInt(messageCount);
					zpacket.PutInt(totalMessageCount);

					foreach (var message in messages)
					{
						var items = message.GetItems();

						zpacket.PutLpString(message.Sender);
						zpacket.PutLpString(message.Subject);
						zpacket.PutLpString(message.Message);
						zpacket.PutDate(message.StartDate);
						zpacket.PutDate(message.ExpirationDate);
						zpacket.PutDate(message.CreatedDate);
						zpacket.PutLong(message.Id);
						zpacket.PutByte(message.IsRead);
						zpacket.PutByte(message.CanReceive);
						zpacket.PutByte(0); // Alignment Byte?
						zpacket.PutByte((byte)message.State);
						zpacket.PutByte(0);
						zpacket.PutByte((byte)message.ReceivableItemsCount);
						zpacket.PutShort(0);
						zpacket.PutInt(items.Count);

						foreach (var item in items)
						{
							zpacket.PutInt(item.DbId);
							zpacket.PutInt(item.Id);
							zpacket.PutInt(item.Amount);
							zpacket.PutByte(item.WasReceived);
							zpacket.PutEmptyBin(3); // Alignment
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
			public static void UpdateMailboxState(IBarracksConnection conn, long messageId, MailboxMessageState state)
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
				var items = message.GetItems();
				var receivedItemCount = items.Count(item => item.WasReceived);

				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.MailUpdate);

				packet.PutLong(message.Id);
				packet.PutByte((byte)message.State);
				packet.PutInt(receivedItemCount); // This is a guess, could be a different value.
				packet.PutInt(items.Count);

				foreach (var item in items)
				{
					packet.PutInt(item.DbId);
					packet.PutInt(item.Id);
					packet.PutInt(item.Amount);
					packet.PutInt(item.WasReceived ? 1 : 0);
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
					packet.PutLong(character.ObjectId);
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

			/// <summary>
			/// Moves a companion in the barrack.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="companionId"></param>
			/// <param name="position"></param>
			public static void SetCompanionPosition(IBarracksConnection conn, long companionId, Position position)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.SetCompanionPosition);

				packet.PutLong(conn.Account.Id);
				packet.PutLong(companionId);
				packet.PutFloat(position.X);
				packet.PutFloat(position.Y);
				packet.PutFloat(position.Z);

				conn.Send(packet);
			}

			/// <summary>
			/// Adds companions in the barrack.
			/// </summary>
			/// <param name="conn"></param>
			public static void CompanionInfo(IBarracksConnection conn)
			{
				var allCompanions = conn.Account.GetCompanions();
				var layerCompanions = allCompanions.Where(x => x.BarracksLayer == conn.Account.SelectedBarrackLayer);
				var companionCount = layerCompanions.Count();
				if (companionCount == 0)
					return;
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.CompanionInfo);

				packet.PutLong(conn.Account.Id);
				packet.PutInt(companionCount);
				foreach (var companion in layerCompanions)
				{
					packet.AddCompanion(companion);
				}
				packet.PutInt(companionCount);

				conn.Send(packet);
			}

			/// <summary>
			/// Set a companion's associated character in the barrack.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="companionId"></param>
			/// <param name="characterId"></param>
			public static void SetCompanion(IBarracksConnection conn, long companionId, long characterId)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.SetCompanion);

				packet.PutLong(conn.Account.Id);
				packet.PutLong(companionId);
				packet.PutLong(characterId);

				conn.Send(packet);
			}

			/// <summary>
			/// Deletes a companion in the barrack.
			/// </summary>
			/// <param name="conn"></param>
			/// <param name="companionId"></param>
			public static void DeleteCompanion(IBarracksConnection conn, long companionId)
			{
				var packet = new Packet(Op.BC_NORMAL);
				packet.PutInt(NormalOp.Barrack.DeleteCompanion);

				packet.PutLong(conn.Account.Id);
				packet.PutLong(companionId);

				conn.Send(packet);
			}
		}
	}
}
