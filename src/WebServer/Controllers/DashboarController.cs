using System.IO;
using System.Linq;
using System.Text;
using EmbedIO;
using EmbedIO.Routing;
using EmbedIO.WebApi;
using Newtonsoft.Json;

namespace Melia.Web.Controllers
{
	/// <summary>
	/// Controller for the files the client downloads on launch.
	/// </summary>
	public class DashboarController : WebApiController
	{
		private readonly Encoding _encoding = new UTF8Encoding(false);

		/// <summary>
		/// Show the server process information
		/// </summary>
		[Route(HttpVerbs.Get, "/server/info")]
		public void GetServerProcessInformation()
		{
			var list = WebServer.Instance.ServerInformationMessages.Values.ToArray().ToList();
			this.SendText("application/json", JsonConvert.SerializeObject(list));
		}

		private void SendText(string mimeType, string content)
		{
			var contentLength = _encoding.GetByteCount(content);

			this.Response.StatusCode = 200;
			this.Response.ContentType = mimeType;
			this.Response.ContentLength64 = contentLength;

			using (var stream = this.Response.OutputStream)
			using (var sw = new StreamWriter(stream, _encoding))
				sw.Write(content);
		}

		private class Utf8StringWriter : StringWriter
		{
			private readonly Encoding _encoding = new UTF8Encoding(false);
			public override Encoding Encoding => _encoding;
		}
	}
}
