//--- Melia Script ----------------------------------------------------------
// Server List XML file
//--- Description -----------------------------------------------------------
// Returns list of servers that the client can connect to.
//--- Notes -----------------------------------------------------------------
// TODO: Server Groups
//---------------------------------------------------------------------------

using System.IO;
using System.Text;
using System.Xml;
using Melia.Web;
using Swebs;
using Swebs.RequestHandlers.CSharp;

public class ServerListController : Controller
{
	public override void Handle(HttpRequestEventArgs args, string requestedPath, string localPath)
	{
		var request = args.Request;
		var response = args.Response;

		var serverData = WebServer.Instance.Data.ServerDb.FindLogin(1);

		using (var str = new Utf8StringWriter())
		using (var xml = new XmlTextWriter(str))
		{
			xml.WriteStartDocument();
			xml.WriteWhitespace("\n");
			xml.WriteStartElement("serverlist");
			xml.WriteWhitespace("\n");
			{
				xml.WriteWhitespace("\t");
				xml.WriteStartElement("server");
				xml.WriteAttributeString("GROUP_ID", "100");
				xml.WriteAttributeString("TRAFFIC", "0");
				xml.WriteAttributeString("ENTER_LIMIT", "100");
				xml.WriteAttributeString("NAME", "Melia");
				xml.WriteAttributeString("Server0_IP", serverData.Ip);
				xml.WriteAttributeString("Server0_Port", serverData.Port.ToString());
				xml.WriteEndElement();
				xml.WriteWhitespace("\n");
			}
			xml.WriteEndElement();
			xml.WriteWhitespace("\n");
			xml.WriteEndDocument();

			response.ContentType = "text/xml";
			response.Send(str.ToString());
		}
	}

	private class Utf8StringWriter : StringWriter
	{
		public override Encoding Encoding
		{
			get { return Encoding.UTF8; }
		}
	}
}
