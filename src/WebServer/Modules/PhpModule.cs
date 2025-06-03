using System.IO;
using System.Threading.Tasks;
using EmbedIO;

namespace Melia.Web.Modules
{
	/// <summary>
	/// Handles requests for PHP files.
	/// </summary>
	public class PhpModule : CgiModule
	{
		/// <summary>
		/// Returns the name of the PHP processor.
		/// </summary>
		protected override string ProcessorName => "PHP";

		/// <summary>
		/// Returns the path to the PHP processor executable.
		/// </summary>
		protected override string ProcessorPath => WebServer.Instance.Conf.Web.PhpCgiFilePath;

		/// <summary>
		/// Returns a list of default file names to try when the requested path is
		/// a directory.
		/// </summary>
		protected override string[] DefaultFileNames { get; } = ["index.php"];

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="baseRoute"></param>
		public PhpModule(string baseRoute) : base(baseRoute)
		{
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
			var isPhpFile = ext == ".php";

			return Task.FromResult(isPhpFile);
		}
	}
}
