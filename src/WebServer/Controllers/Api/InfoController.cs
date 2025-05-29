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
		/// Handles requests for retrieving the list of servers.
		/// </summary>
		/// <returns></returns>
		[Route(HttpVerbs.Get, "/servers")]
		public async Task GetServers()
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
