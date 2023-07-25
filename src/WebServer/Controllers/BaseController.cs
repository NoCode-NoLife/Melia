using System.IO;
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
		/// Sends content as text with the given mime type.
		/// </summary>
		/// <param name="mimeType"></param>
		/// <param name="content"></param>
		protected void SendText(string mimeType, string content)
		{
			var contentLength = _encoding.GetByteCount(content);

			this.Response.StatusCode = 200;
			this.Response.ContentType = mimeType;
			this.Response.ContentLength64 = contentLength;

			using (var stream = this.Response.OutputStream)
			using (var sw = new StreamWriter(stream, _encoding))
				sw.Write(content);
		}

		/// <summary>
		/// Sends content as text with the given mime type.
		/// </summary>
		/// <param name="mimeType"></param>
		/// <param name="content"></param>
		protected void SendText(string mimeType, string content, int code)
		{
			var contentLength = _encoding.GetByteCount(content);

			this.Response.StatusCode = code;
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
