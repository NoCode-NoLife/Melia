using System.Text.Json.Serialization;

namespace Melia.Web.Controllers.Api.Objects
{
	internal class MessageAllRequest
	{
		[JsonPropertyName("sender")]
		public string SenderName { get; set; } = "";

		[JsonPropertyName("message")]
		public string Message { get; set; } = "";
	}
}
