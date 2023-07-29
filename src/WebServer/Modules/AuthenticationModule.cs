using EmbedIO;
using EmbedIO.Routing;
using System;
using System.Net;
using System.Threading.Tasks;

public class AuthenticationModule : WebModuleBase
{
	private readonly string sharedSecret;

	/// <summary>
	/// Creates new instance.
	/// </summary>
	/// <param name="baseRoute"></param>
	public AuthenticationModule(string baseRoute) : base(baseRoute)
	{
	}

	/// <summary>
	/// Returns whether the handling stops after this handler.
	/// </summary>
	public override bool IsFinalHandler => false;

	protected override async Task OnRequestAsync(IHttpContext context)
	{
		// Check if the request path starts with the "/api" segment.
		if (context.RequestedPath.StartsWith("/api", StringComparison.OrdinalIgnoreCase))
		{
			// Extract the shared secret from request headers or query parameters.
			string providedSecret = context.Request.Headers["Authorization"] ?? context.Request.QueryString["secret"];

			// Compare the shared secret.
			if (string.Equals(providedSecret, sharedSecret, StringComparison.OrdinalIgnoreCase))
			{
				// Continue with the request.
				await Task.CompletedTask;
			}

			// Return a 401 Unauthorized response if the shared secret doesn't match.
			context.Response.StatusCode = 401;
			context.Response.Close();
			return;
		}

		// Allow the request to proceed for other routes.
		await Task.CompletedTask;
	}
}
