using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Files;
using Yggdrasil.Logging;

namespace Melia.Web.Modules
{
	/// <summary>
	/// Handles requests for PHP files.
	/// </summary>
	public class PhpModule : WebModuleBase
	{
		private const string DefaultFileName = "index.php";
		private readonly static Regex ServerNameRegex = new(@"//(?<name>[^\:\/]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

		private string _serverSoftware;

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

			if (!File.Exists(WebServer.Instance.Conf.Web.PhpCgiFilePath))
			{
				context.Response.StatusCode = 500;
				context.Response.ContentType = "text/plain";

				using (var output = context.OpenResponseText())
					output.Write("PHP processor not found. If you're the admin, check your web configuration.");

				context.SetHandled();
				return;
			}

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
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
				process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
				process.StartInfo.CreateNoWindow = true;

				// Clear default environment variables for security and consistency
				process.StartInfo.EnvironmentVariables.Clear();

				process.StartInfo.EnvironmentVariables.Add("GATEWAY_INTERFACE", "CGI/1.1");
				process.StartInfo.EnvironmentVariables.Add("SERVER_PROTOCOL", "HTTP/1.1");
				process.StartInfo.EnvironmentVariables.Add("REDIRECT_STATUS", "200");
				process.StartInfo.EnvironmentVariables.Add("DOCUMENT_ROOT", SanitizePath(documentRootPath));
				process.StartInfo.EnvironmentVariables.Add("SCRIPT_NAME", SanitizePath(context.RequestedPath));
				process.StartInfo.EnvironmentVariables.Add("SCRIPT_FILENAME", SanitizePath(scriptFilePath));
				process.StartInfo.EnvironmentVariables.Add("QUERY_STRING", queryString);
				process.StartInfo.EnvironmentVariables.Add("CONTENT_LENGTH", requestBody.Length.ToString());
				process.StartInfo.EnvironmentVariables.Add("CONTENT_TYPE", context.Request.ContentType);
				process.StartInfo.EnvironmentVariables.Add("REQUEST_METHOD", context.Request.HttpMethod);
				process.StartInfo.EnvironmentVariables.Add("USER_AGENT", context.Request.UserAgent);
				process.StartInfo.EnvironmentVariables.Add("SERVER_NAME", GetServerName(context));
				process.StartInfo.EnvironmentVariables.Add("SERVER_ADDR", context.LocalEndPoint.Address.ToString());
				process.StartInfo.EnvironmentVariables.Add("SERVER_PORT", context.LocalEndPoint.Port.ToString());
				process.StartInfo.EnvironmentVariables.Add("REMOTE_ADDR", context.Request.RemoteEndPoint.Address.ToString());
				process.StartInfo.EnvironmentVariables.Add("REMOTE_PORT", context.Request.RemoteEndPoint.Port.ToString());
				process.StartInfo.EnvironmentVariables.Add("REFERER", context.Request.UrlReferrer?.ToString() ?? "");
				process.StartInfo.EnvironmentVariables.Add("REQUEST_URI", context.RequestedPath);
				process.StartInfo.EnvironmentVariables.Add("HTTP_COOKIE", context.Request.Headers["Cookie"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_ACCEPT", context.Request.Headers["Accept"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_ACCEPT_CHARSET", context.Request.Headers["Accept-Charset"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_ACCEPT_ENCODING", context.Request.Headers["Accept-Encoding"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_ACCEPT_LANGUAGE", context.Request.Headers["Accept-Language"]);
				process.StartInfo.EnvironmentVariables.Add("HTTP_HOST", context.Request.Headers["Host"]);
				process.StartInfo.EnvironmentVariables.Add("SERVER_SOFTWARE", this.GetServerSoftware());
				process.StartInfo.EnvironmentVariables.Add("TMPDIR", SanitizePath(Path.GetTempPath()));
				process.StartInfo.EnvironmentVariables.Add("TEMP", SanitizePath(Path.GetTempPath()));

				// A note on SCRIPT_NAME: While this is usually the absolute path
				// to the script, relative to the document root, which is also
				// the same as the requested path, these could be different if
				// any kind of URL rewriting occurs. That's not currently supported
				// by our server, but should that change, we need to reevaluate the
				// values of those variables.

				// Fun fact: You get an "Unknown error" from MySQL if SystemRoot
				// is missing. Why does it need this? Who knows!
				// TIL: You also need it to establish HTTP connections from PHP,
				// and for those it needs to not only be set, but also be correct.
				process.StartInfo.EnvironmentVariables.Add("SystemRoot", Environment.GetEnvironmentVariable("SystemRoot"));

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

				if (process.StandardError.Peek() > -1)
				{
					var errorOutput = await process.StandardError.ReadToEndAsync();
					Log.Debug($"PHP Errors:" + Environment.NewLine + errorOutput);
				}
			}

			// Set context to handled, so no more modules get the request
			context.SetHandled();

			await Task.CompletedTask;
		}

		/// <summary>
		/// Returns the server name requested by the client. In case of any issues,
		/// it returns the local endpoint address instead.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		private static string GetServerName(IHttpContext context)
		{
			var url = context.Request.Url.ToString();
			var match = ServerNameRegex.Match(url);

			if (match.Success)
				return match.Groups["name"].Value;

			return context.LocalEndPoint.Address.ToString();
		}

		/// <summary>
		/// Unifies slashes in the path and trims trailing slashes.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		private static string SanitizePath(string path)
		{
			return path.Replace("\\", "/").TrimEnd('/');
		}

		/// <summary>
		/// Returns a string that details the server software and its versions.
		/// </summary>
		/// <returns></returns>
		private string GetServerSoftware()
		{
			if (_serverSoftware != null)
				return _serverSoftware;

			var meliaCommitHash = "unknown";
			var phpVersion = "unknown";
			var embedioVersion = typeof(WebModuleBase).Assembly.GetName().Version.ToString(3);

			if (File.Exists(".git/HEAD"))
			{
				var headContent = File.ReadAllText(".git/HEAD").Trim();

				if (headContent.StartsWith("ref: "))
				{
					var refPath = headContent.Substring(5);
					var refFilePath = Path.Combine(".git", refPath);

					if (File.Exists(refFilePath))
						meliaCommitHash = File.ReadAllText(refFilePath).Trim().Substring(0, 7);
				}
				else
				{
					meliaCommitHash = headContent.Substring(0, 7);
				}
			}

			if (File.Exists(WebServer.Instance.Conf.Web.PhpCgiFilePath))
			{
				var fileVersionInfo = FileVersionInfo.GetVersionInfo(WebServer.Instance.Conf.Web.PhpCgiFilePath);
				phpVersion = fileVersionInfo.FileVersion ?? "unknown";
			}

			return _serverSoftware = $"Melia/{meliaCommitHash} EmbedIO/{embedioVersion} PHP/{phpVersion}";
		}
	}
}
