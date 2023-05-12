using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	public class ServerData
	{
		public ServerType Type { get; set; }
		public int Id { get; set; }
		public string Ip { get; set; }
		public int Port { get; set; }
	}

	public class ChannelServerData : ServerData
	{
		public string Maps { get; set; }
	}

	public class ServerDb : DatabaseJson<ServerData>
	{
		public ServerData FindLogin(int id)
		{
			return this.Entries.FirstOrDefault(a => a.Type == ServerType.Login && a.Id == id);
		}

		public ChannelServerData FindChannel(int id)
		{
			return (ChannelServerData)this.Entries.FirstOrDefault(a => a.Type == ServerType.Channel && a.Id == id);
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("type", "id", "ip", "port");

			var type = entry.ReadString("type");

			ServerData data = null;

			switch (type)
			{
				case "Login":
				case "Barracks":
					data = new ServerData();
					this.ReadDefault(entry, data);

					break;

				case "Channel":
				case "Zone":
					entry.AssertNotMissing("maps");

					var channelData = new ChannelServerData();
					this.ReadDefault(entry, channelData);
					channelData.Maps = entry.ReadString("maps");

					data = channelData;

					break;

				default:
					throw new DatabaseErrorException("Invalid server type '" + type + "'.");
			}

			if (this.Entries.Any(a => a.Type == data.Type && a.Id == data.Id))
				throw new DatabaseErrorException(string.Format("Duplicate: {0}, {1}", data.Type, data.Id));

			this.Add(data);
		}

		private void ReadDefault(JObject entry, ServerData data)
		{
			data.Type = (ServerType)Enum.Parse(typeof(ServerType), entry.ReadString("type"));
			data.Id = entry.ReadInt("id");
			data.Ip = entry.ReadString("ip");
			data.Port = entry.ReadInt("port");
		}
	}

	public enum ServerType
	{
		Login,
		Channel,

		Barracks,
		Zone,
	}
}
