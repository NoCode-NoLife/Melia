using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using EmbedIO;
using EmbedIO.Routing;
using EmbedIO.WebApi;
using Melia.Shared.Data.Database;

namespace Melia.Web.Controllers
{
	/// <summary>
	/// Controller for the files the client downloads on launch.
	/// </summary>
	public class TosPatchController : WebApiController
	{
		private readonly Encoding _encoding = new UTF8Encoding(false);

		/// <summary>
		/// Serves a list of barrack servers.
		/// </summary>
		[Route(HttpVerbs.Get, "/serverlist.xml")]
		public void GetServerList()
		{
			var serverGroupDataList = WebServer.Instance.Data.ServerDb.Entries.Values.OrderBy(a => a.Id);

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

				this.SendText("text/xml", str.ToString());
			}
		}

		/// <summary>
		/// Serves a config file that determines, among other things,
		/// whether to enable HacksShield and Steam logins.
		/// </summary>
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

			var staticConfig = string.Join("\r\n", options.Select(a => $"{a.Key}={a.Value}"));
			this.SendText("text/plain", staticConfig);
		}

		private void SendText(string mimeType, string content)
		{
			var contentLength = _encoding.GetByteCount(content);

			this.Response.StatusCode = 200;
			this.Response.ContentType = mimeType;
			this.Response.ContentLength64 = contentLength;

			using (var stream = this.Response.OutputStream)
			using (var sw = new StreamWriter(stream, _encoding))
				sw.Write(content);
		}

		private class Utf8StringWriter : StringWriter
		{
			private readonly Encoding _encoding = new UTF8Encoding(false);
			public override Encoding Encoding => _encoding;
		}
	}
}
