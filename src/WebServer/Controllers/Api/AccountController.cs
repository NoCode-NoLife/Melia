using System;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using Melia.Web.Const;
using Melia.Web.Controllers.Api.Objects;
using Yggdrasil.Logging;

namespace Melia.Web.Controllers.Api
{
	/// <summary>
	/// Controller with API endpoints that provide account-related functions.
	/// </summary>
	internal class AccountController : JsonApiController
	{
		/// <summary>
		/// Handles requests to create a new account.
		/// </summary>
		/// <example>
		/// POST /account/create
		/// { "username": "myname", "password1": "mypassword", "password2": "mypassword" }
		/// </example>
		/// <returns></returns>
		[Route(HttpVerbs.Post, "/create")]
		public async Task Create()
		{
			if (!WebServer.Instance.Conf.Web.EnableApiAccountCreation)
			{
				await this.Error("Account creation via API is disabled.");
				return;
			}

			try
			{
				var request = await this.ParseJsonBody<CreateAccountRequest>();

				if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password1) || string.IsNullOrWhiteSpace(request.Password2))
				{
					await this.Error("The username and password must not be empty.");
					return;
				}

				if (request.Password1 != request.Password2)
				{
					await this.Error("The passwords do not match.");
					return;
				}

				if (request.Username.Length < 4)
				{
					await this.Error("The username must be at least 4 characters long.");
					return;
				}

				if (request.Password1.Length < 6)
				{
					await this.Error("The password must be at least 6 characters long.");
					return;
				}

				if (WebServer.Instance.Database.AccountExists(request.Username))
				{
					await this.Error("The account name already exists.");
					return;
				}

				if (!WebServer.Instance.Database.CreateAccount(request.Username, request.Password1))
				{
					await this.Error("Failed to create account. Please try again later.");
					return;
				}
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
