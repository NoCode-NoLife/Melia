using System.Text.Json;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Shared.Network.Inter.Messages;
using Melia.Web.Const;

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
				this.SendText(MimeTypes.Json, "{ \"error\": \"Communicator timeout.\" }");
				return;
			}

			var playerCount = resPlayerCountMessage.PlayerCount;
			this.SendText(MimeTypes.Json, $"{{ \"playerCount\": {playerCount} }}");
		}

		/// <summary>
		/// Request for the server list.
		/// </summary>
		/// <returns></returns>
		[Route(HttpVerbs.Get, "/info/servers")]
		public async Task GetServers()
		{
			var commMessage = new ReqServerListMessage();
			var resMessage = await WebServer.Instance.Communicator.RequestResponse<ResServerListMessage>("Coordinator", commMessage);

			if (resMessage == null)
			{
				this.SendText(MimeTypes.Json, "{ \"error\": \"Communicator timeout.\" }");
				return;
			}

			var servers = JsonSerializer.Serialize(resMessage.Servers);
			this.SendText(MimeTypes.Json, $"{{ \"servers\": {servers} }}");
		}
	}
}
