using System.Net;
using System.Text;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Utilities;
using Melia.Web.Const;

namespace Melia.Web.Modules
{
	public class AuthModule : WebModuleBase
	{
		public const string Scheme = "InterKey";

		/// <summary>
		/// Returns whether the handling automatically stops after this handler.
		/// </summary>
		public override bool IsFinalHandler => false;

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="baseRoute"></param>
		public AuthModule(string baseRoute) : base(baseRoute)
		{
		}

		/// <summary>
		/// Handles the request, checking for basic authentication and stopping
		/// the request if the authentication fails.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		protected override async Task OnRequestAsync(IHttpContext context)
		{
			if (!context.Request.Headers.ContainsKey("Authorization"))
			{
				await UnauthorizedResponse(context);
				return;
			}

			var authHeader = context.Request.Headers["Authorization"];
			var prefix = Scheme + " ";

			if (!authHeader.StartsWith(prefix))
			{
				await UnauthorizedResponse(context);
				return;
			}

			var interKey = authHeader.Substring(prefix.Length).Trim();
			if (interKey != WebServer.Instance.Conf.Inter.Authentication)
			{
				await UnauthorizedResponse(context);
				return;
			}

			// Authentication succeeded
		}

		/// <summary>
		/// Sends an unauthorized response to the client and sets the context
		/// to have been handled.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		private static async Task UnauthorizedResponse(IHttpContext context)
		{
			context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
			await context.SendStringAsync("Unauthorized", MimeTypes.Text.Plain, Encoding.ASCII);
			context.SetHandled();
		}
	}
}
