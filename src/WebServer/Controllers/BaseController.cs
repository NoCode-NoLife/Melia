using System.IO;
using System.Net;
using System.Text;
using EmbedIO.WebApi;

namespace Melia.Web.Controllers
{
	/// <summary>
	/// Base controller with improved sending functionality.
	/// </summary>
	public abstract class BaseController : WebApiController
	{
		private readonly Encoding _encoding = new UTF8Encoding(false);

		/// <summary>
		/// Sends the content with the given mime type and a 200 status code,
		/// indicating a successful response.
		/// </summary>
		/// <param name="mimeType"></param>
		/// <param name="content"></param>
		protected void SendText(string mimeType, string content)
			=> this.SendText(mimeType, HttpStatusCode.OK, content);

		/// <summary>
		/// Sends the content with the given mime type and status code.
		/// </summary>
		/// <param name="mimeType"></param>
		/// <param name="statusCode"></param>
		/// <param name="content"></param>
		protected void SendText(string mimeType, HttpStatusCode statusCode, string content)
		{
			var contentLength = _encoding.GetByteCount(content);

			this.Response.StatusCode = (int)statusCode;
			this.Response.ContentType = mimeType;
			this.Response.ContentLength64 = contentLength;

			using (var stream = this.Response.OutputStream)
			using (var sw = new StreamWriter(stream, _encoding))
				sw.Write(content);
		}

		/// <summary>
		/// A string writer that uses UTF-8 without BOM.
		/// </summary>
		protected class Utf8StringWriter : StringWriter
		{
			private readonly Encoding _encoding = new UTF8Encoding(false);

			/// <summary>
			/// Returns the writer's encoding.
			/// </summary>
			public override Encoding Encoding => _encoding;
		}
	}
}
