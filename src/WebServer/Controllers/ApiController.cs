using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Shared.Network.Inter.Messages;
using Newtonsoft.Json;
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

			this.SendText("text/json", "{ \"status\": \"Sucesseful kicked all players.\" }");
		}
	}
}
