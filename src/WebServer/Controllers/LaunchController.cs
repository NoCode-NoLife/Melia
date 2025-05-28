using System.Collections.Generic;
using System.Linq;
using System.Xml;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Shared.Data.Database;
using Melia.Web.Const;

namespace Melia.Web.Controllers
{
	/// <summary>
	/// Controller for certain files the client downloads on launch.
	/// </summary>
	public class LaunchController : BaseController
	{
		/// <summary>
		/// Serves a list of server groups in XML format, with barrack servers
		/// that the client may connect to upon login.
		/// </summary>
		/// <remarks>
		/// The list is based on the server groups defined in the server data.
		/// Every group is essentially a collection of primarily barracks and
		/// zone servers, with the former serving as the entry points. Picture
		/// these groups as independent worlds, like for different regions.
		/// </remarks>
		/// <example>
		///   &lt;serverlist&gt;
		///       &lt;server GROUP_ID="1001" TRAFFIC="0" ENTER_LIMIT="100" NAME="Melia" Server0_IP="127.0.0.1" Server0_Port="2000"/&gt;
		///   &lt;/serverlist&gt;
		/// </example>
		[Route(HttpVerbs.Get, "/serverlist.xml")]
		public void GetServerList()
		{
			var serverGroupDataList = WebServer.Instance.Data.ServerDb.Entries.Values.OrderBy(a => a.Id);

			// At one point the client had issues with parsing UTF8-BOM, so we're
			// using a custom writer to ensure no BOM is written.

			using (var str = new Utf8StringWriter())
			using (var xml = new XmlTextWriter(str))
			{
				xml.WriteStartDocument();
				xml.WriteWhitespace("\n");
				xml.WriteStartElement("serverlist");
				xml.WriteWhitespace("\n");

				foreach (var groupData in serverGroupDataList)
				{
					xml.WriteWhitespace("\t");
					xml.WriteStartElement("server");
					xml.WriteAttributeString("GROUP_ID", groupData.Id.ToString());
					xml.WriteAttributeString("TRAFFIC", "0");
					xml.WriteAttributeString("ENTER_LIMIT", "100");
					xml.WriteAttributeString("NAME", groupData.Name);

					var barracksServersData = groupData.Servers.Where(a => a.Type == ServerType.Barracks).ToArray();
					for (var i = 0; i < barracksServersData.Length; ++i)
					{
						var serverData = barracksServersData[i];

						xml.WriteAttributeString("Server0_IP", serverData.Ip);
						xml.WriteAttributeString("Server0_Port", serverData.Port.ToString());
					}

					xml.WriteEndElement();
					xml.WriteWhitespace("\n");
				}

				xml.WriteEndElement();
				xml.WriteWhitespace("\n");
				xml.WriteEndDocument();

				this.SendText(MimeTypes.Application.Xml, str.ToString());
			}
		}

		/// <summary>
		/// Serves a config file that determines, among other things,
		/// whether to enable HacksShield and Steam logins.
		/// </summary>
		/// <remarks>
		/// Modifying this file will rarely be necessary, as enabling anti-cheat
		/// measures or different login methods is not usually desired. Though
		/// the ServiceNation and Dictionary options may be useful in rare cases
		/// when running a non-English client.
		/// </remarks>
		/// <example>
		///   ServiceNation=GLOBAL
		///   Dictionary=YES
		///   UseNexonSSO=NO
		///   UseNexonGLM=NO
		///   UseHackshield=NO
		///   UseSteamClient=NO
		///   UseXigncode=NO
		///   UseNISMS_TESTURL=NO
		///   UseNISMS_ONLY_OFFER=YES
		/// </example>
		[Route(HttpVerbs.Get, "/static__Config.txt")]
		public void GetStaticConfig()
		{
			var options = new Dictionary<string, string>()
			{
				["ServiceNation"] = "GLOBAL",
				["Dictionary"] = "YES",
				["UseNexonSSO"] = "NO",
				["UseNexonGLM"] = "NO",
				["UseHackshield"] = "NO",
				["UseSteamClient"] = "NO",
				["UseXigncode"] = "NO",
				["UseNISMS_TESTURL"] = "NO",
				["UseNISMS_ONLY_OFFER"] = "YES",
			};

			var content = string.Join("\r\n", options.Select(a => $"{a.Key}={a.Value}"));
			this.SendText(MimeTypes.Text.Plain, content);
		}
	}
}
