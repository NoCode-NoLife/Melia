using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Files;

namespace Melia.Web.Modules
{
	/// <summary>
	/// Handles requests for PHP files.
	/// </summary>
	public class PhpModule : WebModuleBase
	{
		private const string DefaultFileName = "index.php";

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="baseRoute"></param>
		public PhpModule(string baseRoute) : base(baseRoute)
		{
		}

		/// <summary>
		/// Returns whether the handling stops after this handler.
		/// </summary>
		public override bool IsFinalHandler => false;

		/// <summary>
		/// Returns file mapping info via out, resolving the request
		/// to a path to a PHP file if one was found.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="rootPath"></param>
		/// <param name="info"></param>
		/// <param name="documentRootPath"></param>
		/// <returns></returns>
		private bool TryGetFileInfo(IHttpContext context, string rootPath, out MappedResourceInfo info, out string documentRootPath)
		{
			documentRootPath = Path.GetFullPath(rootPath);
			info = null;

			if (!Directory.Exists(documentRootPath))
				return false;

			var provider = new FileSystemProvider(documentRootPath, false);
			info = provider.MapUrlPath(context.RequestedPath, context);
			if (info == null)
				return false;

			// Try the default file if path was a directory
			if (info.IsDirectory)
			{
				var defaultRequestPath = context.RequestedPath;
				if (!defaultRequestPath.EndsWith('/'))
					defaultRequestPath += "/";
				defaultRequestPath += DefaultFileName;

				info = provider.MapUrlPath(defaultRequestPath, context);

				// Skip if default file wasn't found either
				if (info == null || !info.IsFile)
					return false;
			}

			return true;
		}

		/// <summary>
		/// Handles a request.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		protected override async Task OnRequestAsync(IHttpContext context)
		{
			if (!this.TryGetFileInfo(context, "user/web/", out var info, out var documentRootPath))
			{
				if (!this.TryGetFileInfo(context, "system/web/", out info, out documentRootPath))
					return;
			}

			// Skip if file isn't a PHP file
			var scriptFilePath = info.Path;
			var ext = Path.GetExtension(scriptFilePath);
			if (ext != ".php")
				return;

			// Get query string from URL
			var index = context.Request.RawUrl.IndexOf('?');
			var queryString = index == -1 ? "" : context.Request.RawUrl.Substring(index + 1);

			// Read body for POST requests
			byte[] requestBody;
			using (var ms = new MemoryStream())
			{
				context.Request.InputStream.CopyTo(ms);
				requestBody = ms.ToArray();
			}

			//string requestBody;
			//using (var sr = new StreamReader(context.Request.InputStream))
			//	requestBody = sr.ReadToEnd();

			// Get paths for PHP
			var scriptFileName = Path.GetFileName(scriptFilePath);
			var scriptFolderPath = Path.GetDirectoryName(scriptFilePath);

			// Execute PHP
			using (var process = new Process())
			{
				process.StartInfo.FileName = WebServer.Instance.Conf.Web.PhpCgiFilePath;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.CreateNoWindow = true;

				process.StartInfo.EnvironmentVariables.Clear();

				process.StartInfo.EnvironmentVariables.Add("GATEWAY_INTERFACE", "CGI/1.1");
				process.StartInfo.EnvironmentVariables.Add("SERVER_PROTOCOL", "HTTP/1.1");
				process.StartInfo.EnvironmentVariables.Add("REDIRECT_STATUS", "200");
				process.StartInfo.EnvironmentVariables.Add("DOCUMENT_ROOT", documentRootPath);
				process.StartInfo.EnvironmentVariables.Add("SCRIPT_NAME", scriptFileName);
				process.StartInfo.EnvironmentVariables.Add("SCRIPT_FILENAME", scriptFilePath);
				process.StartInfo.EnvironmentVariables.Add("QUERY_STRING", queryString);
				process.StartInfo.EnvironmentVariables.Add("CONTENT_LENGTH", requestBody.Length.ToString());
				process.StartInfo.EnvironmentVariables.Add("CONTENT_TYPE", context.Request.ContentType);
				process.StartInfo.EnvironmentVariables.Add("REQUEST_METHOD", context.Request.HttpMethod);
				process.StartInfo.EnvironmentVariables.Add("USER_AGENT", context.Request.UserAgent);
				process.StartInfo.EnvironmentVariables.Add("SERVER_ADDR", context.LocalEndPoint.Address.ToString());
				process.StartInfo.EnvironmentVariables.Add("REMOTE_ADDR", context.Request.RemoteEndPoint.Address.ToString());
				process.StartInfo.EnvironmentVariables.Add("REMOTE_PORT", context.Request.RemoteEndPoint.Port.ToString());
				process.StartInfo.EnvironmentVariables.Add("REFERER", context.Request.UrlReferrer?.ToString() ?? "");
				process.StartInfo.EnvironmentVariables.Add("REQUEST_URI", context.RequestedPath);
				process.StartInfo.EnvironmentVariables.Add("HTTP_COOKIE", context.Request.Headers["Cookie"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_ACCEPT", context.Request.Headers["Accept"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_ACCEPT_CHARSET", context.Request.Headers["Accept-Charset"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_ACCEPT_ENCODING", context.Request.Headers["Accept-Encoding"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_ACCEPT_LANGUAGE", context.Request.Headers["Accept-Language"]);
				process.StartInfo.EnvironmentVariables.Add("TMPDIR", Path.GetTempPath());
				process.StartInfo.EnvironmentVariables.Add("TEMP", Path.GetTempPath());

				process.Start();

				using (var sw = process.StandardInput)
				{
					sw.BaseStream.Write(requestBody, 0, requestBody.Length);
				}

				// Write headers and content to response stream
				var headersEnd = false;
				using (var sr = process.StandardOutput)
				using (var output = context.OpenResponseText())
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						if (!headersEnd)
						{
							if (line == "")
							{
								headersEnd = true;
								continue;
							}

							index = line.IndexOf(':');
							var name = line.Substring(0, index);
							var value = line.Substring(index + 2);

							context.Response.Headers[name] = value;
						}
						else
						{
							output.WriteLine(line);
						}
					}
				}
			}

			// Set context to handled, so no more modules get the request
			context.SetHandled();

			await Task.CompletedTask;
		}
	}
}
