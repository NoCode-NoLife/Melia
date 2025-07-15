using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using EmbedIO;
using Melia.Web.Const;

namespace Melia.Web.Controllers
{
	/// <summary>
	/// Base controller for JSON API endpoints.
	/// </summary>
	public abstract class JsonApiController : BaseController
	{
		/// <summary>
		/// Sends a JSON response with a 200 status code (OK).
		/// </summary>
		/// <remarks>
		/// The object is serialized as is and must contain all necessary fields,
		/// including a "result" field if expected by the receiver, indicating
		/// success or failure.
		/// </remarks>
		/// <example>
		/// this.Ok(new { result = ApiResults.Success, some_response = "Lorem ipsum dolor sit amet." });
		/// 
		/// Response:
		///   Status: 200 OK
		///   { "result": 0, "some_response": "Lorem ipsum dolor sit amet." }
		/// </example>
		/// <param name="content"></param>
		/// <returns></returns>
		public async Task Ok(object content)
		{
			var json = JsonSerializer.Serialize(content);
			await this.SendText(MimeTypes.Json, HttpStatusCode.OK, json);
		}

		/// <summary>
		/// Sends a JSON error response with a 500 status code (Internal Server Error).
		/// </summary>
		/// <example>
		/// this.Error("An error occurred.");
		/// 
		/// Response:
		///   Status: 500 Internal Server Error
		///   { "result": 1, "error": "An error occurred." }
		/// </example>
		/// <param name="message"></param>
		/// <returns></returns>
		public async Task Error(string message)
		{
			var response = new
			{
				result = ApiResults.Error,
				error = message,
			};

			await this.SendText(MimeTypes.Json, HttpStatusCode.InternalServerError, JsonSerializer.Serialize(response));
		}

		/// <summary>
		/// Reads the request body and parses it as JSON into the specified type.
		/// </summary>
		/// <typeparam name="TBody"></typeparam>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		protected async Task<TBody> ParseJsonBody<TBody>()
		{
			var context = this.HttpContext;

			if (context.Request.ContentLength64 <= 0)
				throw new InvalidOperationException("Request body is empty.");

			using var reader = context.OpenRequestText();
			var body = await reader.ReadToEndAsync();

			var result = JsonSerializer.Deserialize<TBody>(body);
			return result;
		}
	}
}
