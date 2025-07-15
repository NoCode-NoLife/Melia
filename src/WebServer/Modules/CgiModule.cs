using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Files;
using Melia.Web.Const;
using Yggdrasil.Logging;

namespace Melia.Web.Modules
{
	/// <summary>
	/// Handles requests that are handled by external CGI processes, such as PHP.
	/// </summary>
	public abstract class CgiModule : WebModuleBase
	{
		private readonly static Regex ServerNameRegex = new(@"//(?<name>[^\:\/]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

		private string _serverSoftware;

		/// <summary>
		/// Returns whether the handling stops after this handler.
		/// </summary>
		public override bool IsFinalHandler => false;

		/// <summary>
		/// Returns the name of the CGI processor, such as "PHP" or "Python".
		/// </summary>
		protected abstract string ProcessorName { get; }

		/// <summary>
		/// Returns the path to the CGI processor executable.
		/// </summary>
		protected abstract string ProcessorPath { get; }

		/// <summary>
		/// Returns a list of default file names to try when the requested path is
		/// a directory.
		/// </summary>
		protected virtual string[] DefaultFileNames { get; } = [];

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="baseRoute"></param>
		public CgiModule(string baseRoute) : base(baseRoute)
		{
		}

		/// <summary>
		/// Returns true if the module is able to handle the request for the given
		/// script file and context.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="scriptFilePath"></param>
		/// <returns></returns>
		protected abstract Task<bool> AbleToHandle(IHttpContext context, string scriptFilePath);

		/// <summary>
		/// Handles a request.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		protected override async Task OnRequestAsync(IHttpContext context)
		{
			if (!this.TryGetFileInfo(context, "user/web/", out var resInfo, out var documentRootPath))
			{
				if (!this.TryGetFileInfo(context, "system/web/", out resInfo, out documentRootPath))
					return;
			}

			if (!await this.AbleToHandle(context, resInfo.Path))
				return;

			if (!File.Exists(this.ProcessorPath))
			{
				context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
				context.Response.ContentType = MimeTypes.Text.Plain;

				using (var output = context.OpenResponseText())
					output.Write("CGI processor not found.");

				context.SetHandled();
				return;
			}

			// Read body for POST requests
			byte[] requestBody;
			using (var ms = new MemoryStream())
			{
				context.Request.InputStream.CopyTo(ms);
				requestBody = ms.ToArray();
			}

			// Get paths
			documentRootPath = SanitizePath(documentRootPath);
			var scriptFilePath = SanitizePath(resInfo.Path);
			var scriptNamePath = scriptFilePath.Replace(documentRootPath, "");
			var tempPath = SanitizePath(Path.GetTempPath());
			var systemRootPath = SanitizePath(Environment.GetEnvironmentVariable("SystemRoot") ?? string.Empty);

			// Execute processor
			using (var process = new Process())
			{
				// The way processors handle script files can vary, like PHP-CGI
				// getting the script file to execute from the environment variables,
				// but passing the script file as the first argument should work
				// pretty much universally. If not, we'll have to adapt.

				process.StartInfo.FileName = this.ProcessorPath;
				process.StartInfo.Arguments = scriptFilePath;
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
				process.StartInfo.EnvironmentVariables.Add("DOCUMENT_ROOT", documentRootPath);
				process.StartInfo.EnvironmentVariables.Add("SCRIPT_NAME", scriptNamePath);
				process.StartInfo.EnvironmentVariables.Add("SCRIPT_FILENAME", scriptFilePath);
				process.StartInfo.EnvironmentVariables.Add("QUERY_STRING", context.Request.Url.Query.TrimStart('?'));
				process.StartInfo.EnvironmentVariables.Add("CONTENT_LENGTH", requestBody.Length.ToString());
				process.StartInfo.EnvironmentVariables.Add("CONTENT_TYPE", context.Request.ContentType);
				process.StartInfo.EnvironmentVariables.Add("REQUEST_METHOD", context.Request.HttpMethod);
				process.StartInfo.EnvironmentVariables.Add("REQUEST_SCHEME", context.Request.IsSecureConnection ? "https" : "http");
				process.StartInfo.EnvironmentVariables.Add("SERVER_NAME", GetServerName(context));
				process.StartInfo.EnvironmentVariables.Add("SERVER_ADDR", context.LocalEndPoint.Address.ToString());
				process.StartInfo.EnvironmentVariables.Add("SERVER_PORT", context.LocalEndPoint.Port.ToString());
				process.StartInfo.EnvironmentVariables.Add("REMOTE_ADDR", context.Request.RemoteEndPoint.Address.ToString());
				process.StartInfo.EnvironmentVariables.Add("REMOTE_PORT", context.Request.RemoteEndPoint.Port.ToString());
				process.StartInfo.EnvironmentVariables.Add("REFERER", context.Request.UrlReferrer?.ToString() ?? "");
				process.StartInfo.EnvironmentVariables.Add("REQUEST_URI", context.Request.RawUrl);
				process.StartInfo.EnvironmentVariables.Add("SERVER_SOFTWARE", this.GetServerSoftware());
				process.StartInfo.EnvironmentVariables.Add("TMPDIR", tempPath);
				process.StartInfo.EnvironmentVariables.Add("TEMP", tempPath);

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
				process.StartInfo.EnvironmentVariables.Add("SystemRoot", systemRootPath);

				// Learning so much about PHP CGI. So, we need the request headers
				// inside PHP, which are communicated via env variables prefixed
				// with "HTTP_". We could be selective here, but it's easier and
				// more future proof to just throw all of them in.
				for (var i = 0; i < context.Request.Headers.Count; ++i)
				{
					var headerName = context.Request.Headers.GetKey(i);
					var value = context.Request.Headers.Get(i);

					var envName = HeaderNameToEnvName(headerName);
					process.StartInfo.EnvironmentVariables.Add(envName, value);
				}

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

							// Transfer headers to context's response
							var index = line.IndexOf(':');
							var name = line.Substring(0, index);
							var value = line.Substring(index + 2);

							// Since Set-Cookie commonly appears multiple times,
							// we need to add it to the response headers. Others
							// we replace, to ensure that the processor has control
							// over them.
							if (name.Equals("Set-Cookie", StringComparison.OrdinalIgnoreCase))
								context.Response.Headers.Add(name, value);
							else
								context.Response.Headers[name] = value;

							// Set certain response properties based on header values
							if (name.Equals("Status", StringComparison.OrdinalIgnoreCase))
							{
								index = value.IndexOf(' ');

								if (index != -1 && int.TryParse(value.AsSpan(0, index), out var code))
								{
									context.Response.StatusCode = code;
									context.Response.StatusDescription = value.Substring(index + 1).Trim();
								}
								else
								{
									Log.Warning($"Invalid Status header value '{value}' in {scriptFilePath}.");
								}
							}
							else if (name.Equals("Content-Type", StringComparison.OrdinalIgnoreCase))
							{
								context.Response.ContentType = value;
							}
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
					Log.Debug($"CGI Processing Errors:" + Environment.NewLine + errorOutput);
				}
			}

			// Set context to handled, so no more modules get the request
			context.SetHandled();

			await Task.CompletedTask;
		}

		/// <summary>
		/// Returns file mapping info via out, resolving the request
		/// to the path of a script file if one exists. Returns the
		/// mapping info and the full root path via out. Returns false
		/// if no file was found for the requested path.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="rootPath"></param>
		/// <param name="resInfo"></param>
		/// <param name="documentRootPath"></param>
		/// <returns></returns>
		private bool TryGetFileInfo(IHttpContext context, string rootPath, out MappedResourceInfo resInfo, out string documentRootPath)
		{
			documentRootPath = Path.GetFullPath(rootPath);
			resInfo = null;

			if (!Directory.Exists(documentRootPath))
				return false;

			var provider = new FileSystemProvider(documentRootPath, false);
			resInfo = provider.MapUrlPath(context.RequestedPath, context);
			if (resInfo == null)
				return false;

			// Try the default file if path was a directory
			if (resInfo.IsDirectory)
			{
				var defaultRequestPath = context.RequestedPath;
				if (!defaultRequestPath.EndsWith('/'))
					defaultRequestPath += "/";

				foreach (var defaultFileName in this.DefaultFileNames)
				{
					var filePath = defaultRequestPath + defaultFileName;
					resInfo = provider.MapUrlPath(filePath, context);

					if (resInfo != null && resInfo.IsFile)
						return true;
				}

				// Skip if default file wasn't found either
				return false;
			}

			return true;
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
			var processorVersion = "unknown";
			var embedioVersion = typeof(WebModuleBase).Assembly.GetName().Version.ToString(3);
			var processorName = this.ProcessorName ?? "unknown";

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

			if (File.Exists(this.ProcessorPath))
			{
				var fileVersionInfo = FileVersionInfo.GetVersionInfo(this.ProcessorPath);
				processorVersion = fileVersionInfo.FileVersion ?? "unknown";
			}

			return _serverSoftware = $"Melia/{meliaCommitHash} EmbedIO/{embedioVersion} {processorName}/{processorVersion}";
		}

		/// <summary>
		/// Returns the environment variable name for a given HTTP header name.
		/// </summary>
		/// <example>
		/// HeaderNameToEnvName("Content-Type");
		/// => "HTTP_CONTENT_TYPE"
		/// </example>
		/// <param name="headerName"></param>
		/// <returns></returns>
		private static string HeaderNameToEnvName(string headerName)
		{
			return "HTTP_" + headerName.ToUpperInvariant().Replace('-', '_').Replace('.', '_');
		}
	}
}
