using EmbedIO;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

public class AuthenticationModule : WebModuleBase
{
	/// <summary>
	/// Returns the list of API keys
	/// </summary>
	private static readonly List<string> ApiKeys = new List<string>();

	/// <summary>
	/// Returns whether the handling stops after this handler.
	/// </summary>
	public override bool IsFinalHandler => false;

	/// <summary>
	/// Creates new instance.
	/// </summary>
	/// <param name="baseRoute"></param>
	public AuthenticationModule(string baseRoute) : base(baseRoute)
	{
		string apiKeyFilePath = "./user/keys/api_key";

		if (!File.Exists(apiKeyFilePath))
		{
			// Save the private key JSON to a file
			File.WriteAllText(apiKeyFilePath, this.GenerateApiKey());
			
		}
		else
		{
			var apiKey = File.ReadAllText(apiKeyFilePath);
			ApiKeys.Add(apiKey);
		}
	}

	/// <summary>
	/// Handles a request.
	/// </summary>
	/// <param name="context"></param>
	/// <returns></returns>
	protected override async Task OnRequestAsync(IHttpContext context)
	{
		// Check if the request path starts with the "/api" segment.
		if (context.RequestedPath.StartsWith("/api", StringComparison.OrdinalIgnoreCase))
		{
			// Extract the API key from the request headers.
			var providedApiKey = context.Request.Headers["X-Api-Key"];

			// Validate the API key.
			if (string.IsNullOrWhiteSpace(providedApiKey) || !IsValidApiKey(providedApiKey))
			{
				// Unauthorized: API key is missing or invalid.
				context.Response.StatusCode = 401;
				context.Response.Headers.Add("WWW-Authenticate", "ApiKey realm=\"API\"");
				context.Response.Close();
				return;
			}

			// Continue with the request for authenticated API calls.
			await Task.CompletedTask;
			return;
		}

		// Allow the request to proceed for other routes.
		await Task.CompletedTask;
	}

	/// <summary>
	/// Generates a new Api Key
	/// </summary>
	private string GenerateApiKey()
	{
		string apiKey = Guid.NewGuid().ToString().Replace("-", "");
		ApiKeys.Add(apiKey);
		return apiKey;
	}

	/// <summary>
	/// Checks if a given api key is valid
	/// </summary>
	private static bool IsValidApiKey(string apiKey)
	{
		return ApiKeys.Contains(apiKey);
	}
}
