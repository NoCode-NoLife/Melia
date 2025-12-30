using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Shared.Game.Const.Web;
using Melia.Web.Const;
using Melia.Web.Util;

namespace Melia.Web.Controllers
{
	/// <summary>
	/// Controller for TOS Guild and Team Storage related endpoints.
	/// </summary>
	public class TosGuildController : BaseController
	{
		/// <summary>
		/// Returns the list of account warehouse (team storage) tabs.
		/// </summary>
		/// <remarks>
		/// This endpoint is called by the client when accessing team storage
		/// to display the storage tabs/categories in the UI.
		/// </remarks>
		[Route(HttpVerbs.Get, "/accountwarehouse/get")]
		public async Task GetAccountWarehouse()
		{
			// Return the default account warehouse structure with 4 tabs
			// The client uses this to display the storage tabs in the UI
			var accountWarehouse = new AccountWarehouse();
			var json = JsonSerializer.Serialize(accountWarehouse);

			await this.SendText(MimeTypes.Text.Plain, json);
		}

		/// <summary>
		/// Stub implementation for guild emblem endpoint.
		/// </summary>
		/// <param name="guildId">The guild ID</param>
		/// <returns></returns>
		[Route(HttpVerbs.Get, "/guildemblem/{guildId}")]
		public async Task GetGuildEmblem(long guildId)
		{
			// Stub: Just return empty success response
			await this.SendText(MimeTypes.Text.Plain, string.Empty);
		}
	}
}
