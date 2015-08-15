using SharpExpress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Web.Controllers
{
	public class StaticConfigController : IController
	{
		public void Index(Request req, Response res)
		{
			var response = new StringBuilder();
			response.AppendLine(string.Format("ServiceNation={0}", "GLOBAL"));
			response.AppendLine(string.Format("Dictionary={0}", "YES"));
			response.AppendLine(string.Format("UseNexonSSO={0}", "NO"));
			response.AppendLine(string.Format("UseNexonGLM={0}", "NO"));
			response.AppendLine(string.Format("UseHackshield={0}", "NO"));
			response.AppendLine(string.Format("UseSteamClient={0}", "NO"));
			response.AppendLine(string.Format("UseXigncode={0}", "NO"));

			res.Send(response.ToString());
		}
	}
}
