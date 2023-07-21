using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Shared.Configuration.Files;
using Melia.Shared.Network.Inter.Messages;
using Melia.Web.Serializer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Swan;
using Yggdrasil.IO;
using Yggdrasil.Network.Communication;

namespace Melia.Web.Controllers
{
	/// <summary>
	/// Controller for the web API.
	/// </summary>
	public class ApiController : BaseController
	{
		/// <summary>
		/// Example of an API endpoint that requests information from the
		/// coordinator before responding to the client.
		/// </summary>
		/// <returns></returns>
		[Route(HttpVerbs.Get, "/info/playercount")]
		public async Task GetPlayerCount()
		{
			var commMessage = new ReqPlayerCountMessage();
			var resPlayerCountMessage = await WebServer.Instance.Communicator.RequestResponse<ResPlayerCountMessage>("Coordinator", commMessage);

			if (resPlayerCountMessage == null)
			{
				this.SendText("text/json", "{ \"error\": \"Communicator timeout.\" }");
				return;
			}

			var playerCount = resPlayerCountMessage.PlayerCount;
			this.SendText("text/json", $"{{ \"playerCount\": {playerCount} }}");
		}

		/// <summary>
		/// Show the server process information
		/// </summary>
		[Route(HttpVerbs.Get, "/info/processes")]
		public void GetServerProcessInformation()
		{
			var list = WebServer.Instance.ServerInformationMessages.Values.ToArray().ToList();
			this.SendText("application/json", JsonConvert.SerializeObject(list));
		}

		/// <summary>
		/// Show the server process information
		/// </summary>
		[Route(HttpVerbs.Post, "/kick/all")]
		public void KickAllPlayers()
		{
			var kickAllMessage = new KickAllMessage();
			WebServer.Instance.Communicator.Send("Coordinator", kickAllMessage.BroadcastTo("AllZones"));

			this.SendText("text/json", "{ \"status\": \"Successful kicked all players.\" }");
		}

		/// <summary>
		/// Show the server process information
		/// </summary>
		[Route(HttpVerbs.Get, "/info/configs")]
		public void GetConfigurations()
		{
			var config = WebServer.Instance.Conf;

			var barrackConfigs = JsonConvert.SerializeObject(config.Barracks.GetOptions());
			var databaseConfigs = JsonConvert.SerializeObject(config.Database.GetOptions());
			var commandsConfigs = JsonConvert.SerializeObject(config.Commands.GetOptions());
			var logConfigs = JsonConvert.SerializeObject(config.Log.GetOptions());
			var webConfigs = JsonConvert.SerializeObject(config.Web.GetOptions());
			var worldConfigs = JsonConvert.SerializeObject(config.World.GetOptions());
			var localizationConfigs = JsonConvert.SerializeObject(config.Localization.GetOptions());
			
			this.SendText("application/json", $"{{ \"barracks\": {barrackConfigs}, \"database\": {databaseConfigs}, \"commands\": {commandsConfigs}, \"log\": {logConfigs}, \"web\": {webConfigs} , \"world\": {worldConfigs} , \"localization\": {localizationConfigs} }}");
		}

		/// <summary>
		/// Show the server process information
		/// </summary>
		[Route(HttpVerbs.Post, "/info/configs")]
		public void SetConfigurations()
		{
			var data = HttpContext.GetRequestDataAsyncJson<Config>();

			var newBarracksConfigsJson = JsonConvert.DeserializeObject<JObject>(data.Result.Barracks.ToJson());
			var newBarracksConfigs = newBarracksConfigsJson?.ToObject<Dictionary<string, string>>();

			var newDatabaseConfigsJson = JsonConvert.DeserializeObject<JObject>(data.Result.Database.ToJson());
			var newDatabaseConfigs = newDatabaseConfigsJson?.ToObject<Dictionary<string, string>>();

			var newCommandsConfigsJson = JsonConvert.DeserializeObject<JObject>(data.Result.Commands.ToJson());
			var newCommandsConfigs = newCommandsConfigsJson?.ToObject<Dictionary<string, string>>();

			var newLogConfigsJson = JsonConvert.DeserializeObject<JObject>(data.Result.Log.ToJson());
			var newLogConfigs = newLogConfigsJson?.ToObject<Dictionary<string, string>>();

			var newWebConfigsJson = JsonConvert.DeserializeObject<JObject>(data.Result.Web.ToJson());
			var newWebConfigs = newWebConfigsJson?.ToObject<Dictionary<string, string>>();

			var newWorldConfigsJson = JsonConvert.DeserializeObject<JObject>(data.Result.World.ToJson());
			var newWorldConfigs = newWorldConfigsJson?.ToObject<Dictionary<string, string>>();

			var newLocalizationConfigsJson = JsonConvert.DeserializeObject<JObject>(data.Result.Localization.ToJson());
			var newLocalizationConfigs = newLocalizationConfigsJson?.ToObject<Dictionary<string, string>>();

			var oldBarracksConfigs = this.GetConfigFile("user/conf/barracks.conf");
			var oldDatabaseConfigs = this.GetConfigFile("user/conf/database.conf");
			var oldCommandsConfigs = this.GetConfigFile("user/conf/commands.conf");
			var oldLogConfigs = this.GetConfigFile("user/conf/log.conf");
			var oldWebConfigs = this.GetConfigFile("user/conf/web.conf");
			var oldWorldConfigs = this.GetConfigFile("user/conf/world.conf");
			var oldLocalizationConfigs = this.GetConfigFile("user/conf/localization.conf");

			this.UpdateConfigs(oldBarracksConfigs, newBarracksConfigs, "user/conf/barracks.conf");
			this.UpdateConfigs(oldDatabaseConfigs, newDatabaseConfigs, "user/conf/database.conf");
			this.UpdateConfigs(oldCommandsConfigs, newCommandsConfigs, "user/conf/commands.conf");
			this.UpdateConfigs(oldLogConfigs, newLogConfigs, "user/conf/log.conf");
			this.UpdateConfigs(oldWebConfigs, newWebConfigs, "user/conf/web.conf");
			this.UpdateConfigs(oldWorldConfigs, newWorldConfigs, "user/conf/world.conf");
			this.UpdateConfigs(oldLocalizationConfigs, newLocalizationConfigs, "user/conf/localization.conf");

			this.SendText("text/json", "{ \"status\": \"Successful updated configs.\" }");
		}

		private void UpdateConfigs(Dictionary<string, string> oldConfigs, Dictionary<string, string> newConfigs, string filePath)
		{
			if (newConfigs == null)
				return;

			foreach (var newConfig in newConfigs)
			{
				var configExists = false;
				foreach (var oldConfig in oldConfigs)
				{
					if (this.ConvertStringToUnderscoreCase(newConfig.Key) == oldConfig.Key)
					{
						configExists = true;
						break;
					}
				}

				if (!configExists)
				{
					if (File.Exists(filePath))
					{
						File.AppendAllText(filePath, this.ConvertStringToUnderscoreCase(newConfig.Key) + " : " + newConfig.Value + "\n");
					} else
					{
						using (FileStream fs = File.Create(filePath))
						{
							// Add some text to file    
							var title = new UTF8Encoding(true).GetBytes(this.ConvertStringToUnderscoreCase(newConfig.Key) + " : " + newConfig.Value + "\n");
							fs.Write(title, 0, title.Length);
						}
					}					
				} else
				{
					List<string> lines = new List<string>();
					using (StreamReader reader = new StreamReader(filePath))
					{
						string line;
						while ((line = reader.ReadLine()) != null)
						{
							var configFullStrings = line.Split('\n');
							foreach (var configString in configFullStrings)
							{
								var splitedConfigString = configString.Split(':');
								var configKey = splitedConfigString[0].Replace(" ", "");
								if (configKey == this.ConvertStringToUnderscoreCase(newConfig.Key))
								{


								}
							}

							var configKeyValue = configFullStrings[0];
							var contentBeforeNewline = newlineIndex >= 0 ? line.Substring(0, newlineIndex) : line;

							string[] parts = contentBeforeNewline.Split(':');
							if (parts.Length > 1)
							{
								parts[1] = " " + newConfig.Value + "\n";
								contentBeforeNewline = string.Join(":", parts);
							}
							lines.Add(contentBeforeNewline);
						}
					}

					using (StreamWriter writer = new StreamWriter(filePath))
					{
						foreach (string line in lines)
						{
							writer.WriteLine(line);
						}
					}
				}
			}
		}

		private Dictionary<string, string> GetConfigFile(string filePath)
		{
			if (File.Exists(filePath))
			{
				return this.LoadFile(filePath);
			} else
			{
				return new Dictionary<string, string>();
			}
		}

		private Dictionary<string, string> LoadFile(string filePath)
		{
			var options = new Dictionary<string, string>();

			using (var fileReader = new FileReader(filePath))
			{
				foreach (FileReaderLine item in fileReader)
				{
					int num = -1;
					if ((num = item.Value.IndexOf(':')) >= 0)
					{
						lock (options)
						{
							options[item.Value.Substring(0, num).Trim()] = item.Value.Substring(num + 1).Trim();
						}
					}
				}
			}

			return options;
		}

		public string ConvertStringToUnderscoreCase(string str)
		{
			return string.Concat(str.Select((x, i) => i > 1 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
		}
	}
}
