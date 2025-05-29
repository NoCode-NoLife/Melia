using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
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
	}
}
