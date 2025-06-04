using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmbedIO;

namespace Melia.Web.Modules
{
	/// <summary>
	/// Handles requests for files via CGI.
	/// </summary>
	public class CgiProcessorModule : CgiModule
	{
		// This class was originally dedicated to PHP, but it was generalized to
		// potentially handle other CGI processors as well. We don't really need
		// the abstraction from CgiModule, but having it would allow us to have
		// more customized processors, so we'll keep it for now.

		/// <summary>
		/// Returns the name of the processor.
		/// </summary>
		protected override string ProcessorName { get; }

		/// <summary>
		/// Returns the path to the processor executable.
		/// </summary>
		protected override string ProcessorPath { get; }

		/// <summary>
		/// Returns a list of file extensions that this module can handle.
		/// </summary>
		protected string[] FileExtensions { get; }

		/// <summary>
		/// Returns a list of default file names to try when the requested path is
		/// a directory.
		/// </summary>
		protected override string[] DefaultFileNames { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="baseRoute"></param>
		public CgiProcessorModule(string baseRoute, string name, string path, string[] fileExts) : base(baseRoute)
		{
			this.ProcessorName = name;
			this.ProcessorPath = path;
			this.FileExtensions = fileExts;
			this.DefaultFileNames = fileExts.Select(a => "index" + a).ToArray();
		}

		/// <summary>
		/// Returns true if the requested file is a PHP file that can be handled
		/// by this module.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="scriptFilePath"></param>
		/// <returns></returns>
		protected override Task<bool> AbleToHandle(IHttpContext context, string scriptFilePath)
		{
			var ext = Path.GetExtension(scriptFilePath);

			foreach (var fileExt in this.FileExtensions)
			{
				if (ext == fileExt)
					return Task.FromResult(true);
			}

			return Task.FromResult(false);
		}
	}
}
