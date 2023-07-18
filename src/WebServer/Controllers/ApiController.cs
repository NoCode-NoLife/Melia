using System;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Shared.Network.Inter.Messages;
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
			try
			{
				var commMessage = new ReqPlayerCountMessage();
				var resPlayerCountMessage = await WebServer.Instance.Communicator.RequestResponse<ResPlayerCountMessage>(commMessage);

				if (resPlayerCountMessage == null)
				{
					this.SendText("text/json", "{ \"error\": \"Communicator timeout.\" }");
					return;
				}

				var playerCount = resPlayerCountMessage.PlayerCount;
				this.SendText("text/json", $"{{ \"playerCount\": {playerCount} }}");
			}
			catch (Exception ex)
			{
				Log.Error(ex);
			}
		}
	}
}
