using System;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Shared.Network.Inter.Messages;
using Melia.Web.Const;
using Yggdrasil.Logging;
using Yggdrasil.Network.Communication;

namespace Melia.Web.Controllers.Api
{
	/// <summary>
	/// Controller with API endpoints that provide access to administrative functions
	/// of the server.
	/// </summary>
	internal class AdminController : JsonApiController
	{
		/// <summary>
		/// Handles requests to kick a player by their team name.
		/// </summary>
		/// <param name="teamName"></param>
		/// <returns></returns>
		[Route(HttpVerbs.Post, "/kick/team/{teamName}")]
		public async Task KickTeam(string teamName)
		{
			var comm = WebServer.Instance.Communicator;

			try
			{
				var msg = new KickMessage(KickTargetType.Player, teamName, "WebAPI");
				comm.Send("Coordinator", msg.BroadcastTo("AllZones"));
			}
			catch (Exception ex)
			{
				Log.Warning("Failed to send kick message to coordinator. Error: {0}", ex);
				await this.Error("Request failed.");
				return;
			}

			await this.Ok(new
			{
				result = ApiResults.Success,
			});
		}

		/// <summary>
		/// Handles requests to kick all players on a specific map.
		/// </summary>
		/// <param name="mapName"></param>
		/// <returns></returns>
		[Route(HttpVerbs.Post, "/kick/map/{mapName}")]
		public async Task KickMap(string mapName)
		{
			var comm = WebServer.Instance.Communicator;

			try
			{
				var msg = new KickMessage(KickTargetType.Map, mapName, "WebAPI");
				comm.Send("Coordinator", msg.BroadcastTo("AllZones"));
			}
			catch (Exception ex)
			{
				Log.Warning("Failed to send kick message to coordinator. Error: {0}", ex);
				await this.Error("Request failed.");
				return;
			}

			await this.Ok(new
			{
				result = ApiResults.Success,
			});
		}

		/// <summary>
		/// Handles requests to kick all players from the server.
		/// </summary>
		/// <returns></returns>
		[Route(HttpVerbs.Post, "/kick/all")]
		public async Task KickAll()
		{
			var comm = WebServer.Instance.Communicator;

			try
			{
				var msg = new KickMessage(KickTargetType.Zone, "all", "WebAPI");
				comm.Send("Coordinator", msg.BroadcastTo("AllZones"));
			}
			catch (Exception ex)
			{
				Log.Warning("Failed to send kick message to coordinator. Error: {0}", ex);
				await this.Error("Request failed.");
				return;
			}

			await this.Ok(new
			{
				result = ApiResults.Success,
			});
		}
	}
}
