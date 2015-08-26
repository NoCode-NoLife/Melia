// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using SharpExpress;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Melia.Web.Controllers
{
	public class ServerListController : IController
	{
		public void Index(Request req, Response res)
		{
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
					xml.WriteAttributeString("NAME", "localhost");
					xml.WriteAttributeString("Server0_IP", "127.0.0.1");
					xml.WriteAttributeString("Server0_Port", "2000");
					xml.WriteEndElement();
					xml.WriteWhitespace("\n");
				}
				xml.WriteEndElement();
				xml.WriteWhitespace("\n");
				xml.WriteEndDocument();

				res.Send(str.ToString());
			}
		}
	}

	public class Utf8StringWriter : StringWriter
	{
		public override Encoding Encoding
		{
			get { return Encoding.UTF8; }
		}
	}
}
