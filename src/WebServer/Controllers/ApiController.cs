using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Yggdrasil.Network.Communication;
using EmbedIO;
using EmbedIO.Routing;
using Swan;
using Melia.Shared.Network.Inter.Messages;
using Melia.Shared.Tos.Const;
using Melia.Web.Serializer;
using System.Runtime.InteropServices;
using Yggdrasil.Logging;

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
		/// Gets the server process information
		/// </summary>
		[Route(HttpVerbs.Get, "/info/processes")]
		public void GetServerProcessInformation()
		{
			var processes = Process.GetProcesses();
			var runningProcesses = new Dictionary<int, ResServerInformationMessage>();

			// Updates the list, removing the processes that are no longer running.
			foreach (var process in processes)
			{
				foreach (var processEntry in WebServer.Instance.ServerInformationMessages)
				{
					if (process.Id == processEntry.Key)
					{
						runningProcesses.Add(processEntry.Key, processEntry.Value);
					}
				}
			}

			WebServer.Instance.ServerInformationMessages = runningProcesses;

			var list = WebServer.Instance.ServerInformationMessages.Values.ToArray().ToList();
			this.SendText("application/json", JsonConvert.SerializeObject(list));
		}


		/// <summary>
		/// Gets the information if the web server is online
		/// </summary>
		[Route(HttpVerbs.Get, "/info/server")]
		public void GetServerIsOnline()
		{
			this.SendText("text/json", "{ \"status\": \"Web server is Online.\" }");
		}
		
		/// <summary>
		/// Kick all players from the server
		/// </summary>
		[Route(HttpVerbs.Post, "/kick/all")]
		public void KickAllPlayers()
		{
			var reqKickAllMessage = new ReqKickAllMessage();
			WebServer.Instance.Communicator.Send("Coordinator", reqKickAllMessage.BroadcastTo("AllZones"));

			this.SendText("text/json", "{ \"status\": \"Successful kicked all players.\" }");
		}

		/// <summary>
		/// Creates a new Zone Server Process
		/// </summary>
		[Route(HttpVerbs.Post, "/process/create/zone")]
		public void CreateZoneProcess()
		{
			var filePath = AppDomain.CurrentDomain.BaseDirectory + "../../bin/" + GetExecutableName();

			if (File.Exists(filePath))
			{
				this.StartZoneServerProcess(filePath);
			} else
			{
				filePath = AppDomain.CurrentDomain.BaseDirectory + "../../bin/Release/" + GetExecutableName();

				if (File.Exists(filePath))
				{
					this.StartZoneServerProcess(filePath);
				}
				else
				{
					filePath = AppDomain.CurrentDomain.BaseDirectory + "../../bin/Debug/" + GetExecutableName();

					if (File.Exists(filePath))
					{
						this.StartZoneServerProcess(filePath);
					}
					else
					{
						Log.Status("Failed to start the Zone Server process.");
						this.SendText("text/json", "{ \"status\": \"Failed to create a new zone server.\" }", 400);
					}
				}
			}
		}

		/// <summary>
		/// Updates the server.txt file adding a new zone if necessary
		/// </summary>
		private void AddZoneServerToUserDb(int serverId)
		{
			var filePath = AppDomain.CurrentDomain.BaseDirectory + "../../user/db/servers.txt";

			if (File.Exists(filePath))
			{
				var addNewEntry = true;
				string jsonString = File.ReadAllText(filePath);
				var serversObj = JsonConvert.DeserializeObject<List<RootServer>>(jsonString);
				var serverPort = 7003;

				foreach (var server in serversObj[0].Servers)
				{
					if (server.Id == serverId)
					{
						addNewEntry = false;
					}

					serverPort = server.Port + 1;
				}

				if (addNewEntry)
				{
					var newServerEntry = new ServerSerialize();
					newServerEntry.Type = "Zone";
					newServerEntry.Id = serverId;
					newServerEntry.Ip = WebServer.Instance.ServerInfo.Ip;
					newServerEntry.Port = serverPort;
					newServerEntry.Maps = "all";

					serversObj[0].Servers.Add(newServerEntry);

					string modifiedJsonString = JsonConvert.SerializeObject(serversObj, Formatting.Indented);

					File.WriteAllText(filePath, modifiedJsonString);
				}
			}
		}

		/// <summary>
		/// Updates the server.txt file removing the zone if necessary
		/// </summary>
		private void RemoveZoneServerToUserDb(int serverId)
		{
			var filePath = AppDomain.CurrentDomain.BaseDirectory + "../../user/db/servers.txt";

			if (File.Exists(filePath))
			{
				ServerSerialize serverEntryToRemove = null;
				string jsonString = File.ReadAllText(filePath);
				var serversObj = JsonConvert.DeserializeObject<List<RootServer>>(jsonString);

				foreach (var server in serversObj[0].Servers)
				{
					if (server.Id == serverId)
					{
						serverEntryToRemove = server;
					}
				}

				if (serverEntryToRemove != null)
				{
					serversObj[0].Servers.Remove(serverEntryToRemove);
					string modifiedJsonString = JsonConvert.SerializeObject(serversObj, Formatting.Indented);
					File.WriteAllText(filePath, modifiedJsonString);
				}
			}
		}

		/// <summary>
		/// Run a processs for a given Path
		/// </summary>
		private void StartZoneServerProcess(string processFilePath)
		{
			var groupId = 1001;
			var serverId = 1;
			var processes = Process.GetProcesses();

			foreach (var process in processes)
			{
				if (process.ProcessName.ToLower().Contains("zone"))
				{
					serverId++;
				}
			}

			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = processFilePath,
				Arguments = $"{groupId} {serverId}"
			};

			this.AddZoneServerToUserDb(serverId);

			try
			{
				Process.Start(startInfo);
			}
			catch (Exception ex)
			{
				this.RemoveZoneServerToUserDb(serverId);
				Log.Status("Could not start the ZoneServer process on {0}.", processFilePath);
				this.SendText("text/json", "{ \"status\": \"Failed to create a new zone server.\" }", 400);
				return;
			}

			Log.Status("Successeful started a new zone server.");
			this.SendText("text/json", "{ \"status\": \"Successful created a new zone server.\" }");
		}

		private string GetExecutableName()
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				// For Windows, use the executable name with ".exe" extension
				return "ZoneServer.exe";
			}
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				// For Linux, use the executable name without ".exe" extension
				return "ZoneServer";
			}

			return "ZoneServer";
		}

		/// <summary>
		/// Close a zone process by a given ProcessId
		/// </summary>
		[Route(HttpVerbs.Post, "/process/close/zone")]
		public void CloseZoneProcess()
		{
			var data = HttpContext.GetRequestDataAsyncJson<ProcessMessage>();

			if (data == null || data.Result == null || data.Result.processId == 0)
				this.SendText("text/json", "{ \"status\": \"Failed to close the zone.\" }", 400);

			try
			{
				// Get the process by its ProcessId
				Process process = Process.GetProcessById(data.Result.processId);

				// Check if the process name matches the target process name
				if (process != null && process.ProcessName.ToLower().Contains("zone"))
				{
					// Check if the process is running
					if (!process.HasExited)
					{
						// Close the process gracefully
						process.CloseMainWindow();

						// Wait for the process to exit
						if (!process.WaitForExit(2500)) // You can adjust the timeout (milliseconds) as needed
						{
							// If the process doesn't exit within the timeout, force it to close
							process.Kill();
						}

						if (WebServer.Instance.ServerInformationMessages.ContainsKey(data.Result.processId))
							WebServer.Instance.ServerInformationMessages.Remove(data.Result.processId);
					}
				}
				else
				{
					// The process with the given ProcessId does not match the target process name.
					this.SendText("text/json", "{ \"status\": \"Failed to close the zone.\" }", 400);
				}
			}
			catch (ArgumentException)
			{
				// Handle the case when the process with the given ProcessId is not found.
				this.SendText("text/json", "{ \"status\": \"Failed to close the zone.\" }", 400);
			}

			this.SendText("text/json", "{ \"status\": \"Successful closed the zone process.\" }");
		}


		/// <summary>
		/// Gets the server configurations
		/// </summary>
		[Route(HttpVerbs.Get, "/info/configs")]
		public void GetConfigurations()
		{
			var config = WebServer.Instance.Conf;

			var userBarracksConfigs = this.GetConfigFile("user/conf/barracks.conf");
			var userDatabaseConfigs = this.GetConfigFile("user/conf/database.conf");
			var userCommandsConfigs = this.GetConfigFile("user/conf/commands.conf");
			var userLogConfigs = this.GetConfigFile("user/conf/log.conf");
			var userWebConfigs = this.GetConfigFile("user/conf/web.conf");
			var userWorldConfigs = this.GetConfigFile("user/conf/world.conf");
			var userLocalizationConfigs = this.GetConfigFile("user/conf/localization.conf");

			var systemBarracksConfigs = this.GetConfigFile("system/conf/barracks.conf");
			var systemDatabaseConfigs = this.GetConfigFile("system/conf/database.conf");
			var systemCommandsConfigs = this.GetConfigFile("system/conf/commands.conf");
			var systemLogConfigs = this.GetConfigFile("system/conf/log.conf");
			var systemWebConfigs = this.GetConfigFile("system/conf/web.conf");
			var systemWorldConfigs = this.GetConfigFile("system/conf/world.conf");
			var systemLocalizationConfigs = this.GetConfigFile("system/conf/localization.conf");

			var systemWorldDropsConfigs = this.GetConfigFile("system/conf/world/drops.conf");
			var systemWorldExpConfigs = this.GetConfigFile("system/conf/world/exp.conf");
			var systemWorldGameTimeConfigs = this.GetConfigFile("system/conf/world/game_time.conf");
			var systemWorldSkillsConfigs = this.GetConfigFile("system/conf/world/skills.conf");
			var systemWorldSummonsConfigs = this.GetConfigFile("system/conf/world/summons.conf");

			this.MergeConfigsDictionaries(systemWorldConfigs, systemWorldDropsConfigs);
			this.MergeConfigsDictionaries(systemWorldConfigs, systemWorldExpConfigs);
			this.MergeConfigsDictionaries(systemWorldConfigs, systemWorldGameTimeConfigs);
			this.MergeConfigsDictionaries(systemWorldConfigs, systemWorldSkillsConfigs);
			this.MergeConfigsDictionaries(systemWorldConfigs, systemWorldSummonsConfigs);

			this.MergeConfigsDictionaries(userBarracksConfigs, systemBarracksConfigs);
			this.MergeConfigsDictionaries(userBarracksConfigs, systemBarracksConfigs);
			this.MergeConfigsDictionaries(userBarracksConfigs, systemBarracksConfigs);
			this.MergeConfigsDictionaries(userBarracksConfigs, systemBarracksConfigs);
			this.MergeConfigsDictionaries(userBarracksConfigs, systemBarracksConfigs);
			this.MergeConfigsDictionaries(userBarracksConfigs, systemBarracksConfigs);

			this.MergeConfigsDictionaries(userBarracksConfigs, systemBarracksConfigs);
			this.MergeConfigsDictionaries(userDatabaseConfigs, systemDatabaseConfigs);
			this.MergeConfigsDictionaries(userCommandsConfigs, systemCommandsConfigs);
			this.MergeConfigsDictionaries(userLogConfigs, systemLogConfigs);
			this.MergeConfigsDictionaries(userWebConfigs, systemWebConfigs);
			this.MergeConfigsDictionaries(userWorldConfigs, systemWorldConfigs);
			this.MergeConfigsDictionaries(userLocalizationConfigs, systemLocalizationConfigs);

			var barrackConfigs = JsonConvert.SerializeObject(userBarracksConfigs);
			var databaseConfigs = JsonConvert.SerializeObject(userDatabaseConfigs);
			var commandsConfigs = JsonConvert.SerializeObject(userCommandsConfigs);
			var logConfigs = JsonConvert.SerializeObject(userLogConfigs);
			var webConfigs = JsonConvert.SerializeObject(userWebConfigs);
			var worldConfigs = JsonConvert.SerializeObject(userWorldConfigs);
			var localizationConfigs = JsonConvert.SerializeObject(userLocalizationConfigs);
			
			this.SendText("application/json", $"{{ \"barracks\": {barrackConfigs}, \"database\": {databaseConfigs}, \"commands\": {commandsConfigs}, \"log\": {logConfigs}, \"web\": {webConfigs} , \"world\": {worldConfigs} , \"localization\": {localizationConfigs} }}");
		}

		/// <summary>
		/// Updates the server configurations
		/// </summary>
		[Route(HttpVerbs.Post, "/info/configs")]
		public void SetConfigurations()
		{
			var data = HttpContext.GetRequestDataAsyncJson<Config>();

			if (data == null)			
				this.SendText("text/json", "{ \"status\": \"Failed to update the configs.\" }", 400);
			
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

			var reqReloadConfigsMessage = new ReqReloadConfigsMessage();
			WebServer.Instance.Communicator.Send("Coordinator", reqReloadConfigsMessage.BroadcastTo("AllZones"));

			this.SendText("text/json", "{ \"status\": \"Successful updated configs.\" }");
		}

		/// <summary>
		/// Show the server process information
		/// </summary>
		[Route(HttpVerbs.Post, "/message/broadcast")]
		public void BroadcastGlolbalMessage()
		{
			var data = HttpContext.GetRequestDataAsyncJson<Message>();

			if (data == null || data.Result == null)
				this.SendText("text/json", "{ \"status\": \"Failed to broadcast the message to the server.\" }", 400);

			var commMessage = new NoticeTextMessage(NoticeTextType.GoldRed, data.Result.message);
			WebServer.Instance.Communicator.Send("Coordinator", commMessage.BroadcastTo("AllZones"));

			this.SendText("text/json", "{ \"status\": \"Successful broadcasted message.\" }");
		}

		/// <summary>
		/// Merge configurations dicitonaries
		/// </summary>
		private void MergeConfigsDictionaries(Dictionary<string, Dictionary<string, string>> dictionary1, Dictionary<string, Dictionary<string, string>> dictionary2)
		{
			foreach (var kvp in dictionary2)
			{
				if (!dictionary1.ContainsKey(kvp.Key))
				{
					dictionary1.Add(kvp.Key, kvp.Value);
				} else
				{
					// Adding comentaries
					if (kvp.Value["commentary"] != null)
					{
						var value = dictionary1[kvp.Key]["value"];
						var commentary = kvp.Value["commentary"];
						var withcommentary = new Dictionary<string, string>()
						{
							{ "value", value },
							{ "commentary", commentary },
						};
						dictionary1.Remove(kvp.Key);
						dictionary1.Add(kvp.Key, withcommentary);
					}
				}
			}
		}

		/// <summary>
		/// Updates the configs based on new dictionary values and file path
		/// </summary>
		private void UpdateConfigs(Dictionary<string, Dictionary<string, string>> oldConfigs, Dictionary<string, string> newConfigs, string filePath)
		{
			if (newConfigs == null)
				return;

			foreach (var newConfig in newConfigs)
			{
				var configExists = false;
				foreach (var oldConfig in oldConfigs)
				{
					var configName = this.ConvertStringToUnderscoreCase(newConfig.Key);
					if (configName == "database_name")
					{
						configName = "database";
					}
					if (configName == oldConfig.Key)
					{
						configExists = true;
						break;
					}
				}

				if (!configExists)
				{
					if (File.Exists(filePath))
					{
						var configName = this.ConvertStringToUnderscoreCase(newConfig.Key);
						if (configName == "database_name")
						{
							configName = "database";
						}
						File.AppendAllText(filePath, configName + " : " + newConfig.Value + "\n");
					} else
					{
						using (FileStream fs = File.Create(filePath))
						{
							var configName = this.ConvertStringToUnderscoreCase(newConfig.Key);
							if (configName == "database_name")
							{
								configName = "database";
							}
							var title = new UTF8Encoding(true).GetBytes(configName + " : " + newConfig.Value + "\n");
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
							if (!line.StartsWith("//") && !line.StartsWith("include"))
							{
								var parts = line.Split(':');
								if (parts.Length > 1)
								{
									var configName = this.ConvertStringToUnderscoreCase(newConfig.Key);
									if (configName == "database_name")
									{
										configName = "database";
									}
									if (parts[0].Remove(parts[0].Length - 1, 1).Equals(configName))
									{
										parts[1] = " " + newConfig.Value;
										line = string.Join(":", parts);
									}
								}
							}
							lines.Add(line);
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

		/// <summary>
		/// Gets the config file from a path
		/// </summary>
		private Dictionary<string, Dictionary<string, string>> GetConfigFile(string filePath)
		{
			if (File.Exists(filePath))
			{
				return this.LoadFile(filePath);
			} else
			{
				return new Dictionary<string, Dictionary<string, string>>();
			}
		}

		/// <summary>
		/// Loads config file
		/// </summary>
		private Dictionary<string, Dictionary<string, string>> LoadFile(string filePath)
		{
			var options = new Dictionary<string, Dictionary<string, string>>();
			string currentCommentary = string.Empty;

			using (StreamReader reader = new StreamReader(filePath))
			{
				string line;				
				while ((line = reader.ReadLine()) != null)
				{
					// Ignore lines that start with the specified comment
					if (line.Trim().StartsWith("// Melia") || line.Trim().StartsWith("// Configuration file") || line.Contains("--------------------------------------------------------------------------"))
					{
						continue;
					}

					// Check if the line starts with "//" (commentary line)
					if (line.Trim().StartsWith("//") && !line.StartsWith("include"))
					{
						// Append the line (excluding "//") to the current commentary
						currentCommentary += line.Remove(0, 2) + "\n";
					}
					else if (!line.StartsWith("include"))
					{
						var parts = line.Split(new char[] { ':' }, 2, StringSplitOptions.RemoveEmptyEntries);
						if (parts.Length == 2)
						{
							string key = parts[0].Trim();
							string value = parts[1].Trim();

							// Store the values in the nested dictionary along with commentary
							var dictionary = new Dictionary<string, string>() {
								{ "value", value },
								{ "commentary", currentCommentary }
							};

							// Add the nested dictionary to the options dictionary
							options[key] = dictionary;

							// Reset the current commentary for the next key-value pair
							currentCommentary = string.Empty;
						}
					}
				}
			}

			return options;
		}

		/// <summary>
		/// Format a string to underscore case
		/// </summary>
		private string ConvertStringToUnderscoreCase(string str)
		{
			return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
		}
	}
}
