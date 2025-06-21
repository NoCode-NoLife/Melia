using System.Text.Json.Serialization;

namespace Melia.Web.Controllers.Api.Objects
{
	internal class CreateAccountRequest
	{
		[JsonPropertyName("username")]
		public string Username { get; set; } = "";

		[JsonPropertyName("password1")]
		public string Password1 { get; set; } = "";

		[JsonPropertyName("password2")]
		public string Password2 { get; set; } = "";

		[JsonPropertyName("email")]
		public string EMail { get; set; } = "";
	}
}
