using System.Linq;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Shared.Data.Database;
using Melia.Shared.Network.Inter.Messages;
using Melia.Web.Const;

namespace Melia.Web.Controllers.Api
{
	/// <summary>
	/// Controller with API endpoints that provide information about the servers
	/// and their current state.
	/// </summary>
	internal class InfoController : JsonApiController
	{
		/// <summary>
		/// Handles requests for retrieving general server information.
		/// </summary>
		/// <returns></returns>
		[Route(HttpVerbs.Get, "/world")]
		public async Task World()
		{
			var comm = WebServer.Instance.Communicator;
			var commMessage = new ReqServerListMessage();

			var responseMsg = await comm.RequestResponse<ResServerListMessage>("Coordinator", commMessage);
			if (responseMsg == null)
			{
				await this.Error("Failed to communicate with coordinator.");
				return;
			}

			// We'll consider the server online if at least one barracks and one
			// zone server are online, indicating that you can log in and play.
			var barracksOnline = responseMsg.Servers.Any(server => server.Type == ServerType.Barracks);
			var zonesOnline = responseMsg.Servers.Any(server => server.Type == ServerType.Zone);
			var serverOnline = barracksOnline && zonesOnline;

			// Player count for gauging server activity
			var playersOnline = responseMsg.Servers.Sum(server => server.CurrentPlayers);
			var playersMax = responseMsg.Servers.Sum(server => server.MaxPlayers);

			// World settings for information such as EXP and drop rates,
			// as well as other customizations.
			var worldSettings = WebServer.Instance.Conf.World;

			await this.Ok(new
			{
				result = ApiResults.Success,

				serverOnline,
				playersOnline,
				playersMax,
				worldSettings,
			});
		}

		/// <summary>
		/// Handles requests for retrieving the list of servers.
		/// </summary>
		/// <returns></returns>
		[Route(HttpVerbs.Get, "/servers")]
		public async Task Servers()
		{
			var comm = WebServer.Instance.Communicator;
			var commMessage = new ReqServerListMessage();

			var responseMsg = await comm.RequestResponse<ResServerListMessage>("Coordinator", commMessage);
			if (responseMsg == null)
			{
				await this.Error("Failed to communicate with coordinator.");
				return;
			}

			await this.Ok(new
			{
				result = ApiResults.Success,
				servers = responseMsg.Servers,
			});
		}
	}
}
