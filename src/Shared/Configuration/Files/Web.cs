using System;
using System.Collections.Generic;
using System.Linq;
using Yggdrasil.Configuration;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents web.conf.
	/// </summary>
	public class WebConfFile : ConfFile
	{
		/// <summary>
		/// Returns true if accounts can be created via the API.
		/// </summary>
		public bool EnableApiAccountCreation { get; private set; }

		/// <summary>
		/// Returns a list of configured CGI processors.
		/// </summary>
		public List<CgiProcessor> CgiProcessors { get; private set; }

		/// <summary>
		/// Returns the port for the guild web server.
		/// </summary>
		public int GuildPort { get; private set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.EnableApiAccountCreation = this.GetBool("enable_api_account_creation", false);
			this.CgiProcessors = this.GetCgiProcessors();
			this.GuildPort = this.GetInt("guild_port", 9004);
		}

		/// <summary>
		/// Returns a list of CGI processors based on the configuration options.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		private List<CgiProcessor> GetCgiProcessors()
		{
			var result = new List<CgiProcessor>();

			foreach (var option in _options)
			{
				var optionName = option.Key.ToLowerInvariant();
				if (!optionName.StartsWith("cgi_processor_"))
					continue;

				var split = option.Value.ToString().Split(';', StringSplitOptions.RemoveEmptyEntries);
				if (split.Length != 3)
					throw new InvalidOperationException($"Invalid CGI processor configuration: {option.Value}");

				var name = split[0].Trim();
				var exts = split[1].Trim().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(ext => ext.Trim()).ToArray();
				var path = split[2].Trim();

				var processor = new CgiProcessor(name, path, exts);
				result.Add(processor);
			}

			return result;
		}

		/// <summary>
		/// Represents a CGI processor configuration.
		/// </summary>
		public class CgiProcessor
		{
			/// <summary>
			/// Returns the name of the processor, which is primarily used for
			/// logging and debugging purposes.
			/// </summary>
			public string Name { get; }

			/// <summary>
			/// Returns the path to the processor executable.
			/// </summary>
			public string Path { get; }

			/// <summary>
			/// Returns the file extensions that the processor can handle.
			/// </summary>
			public string[] FileExtensions { get; }

			/// <summary>
			/// Creates new instance.
			/// </summary>
			/// <param name="name"></param>
			/// <param name="path"></param>
			/// <param name="fileExtensions"></param>
			public CgiProcessor(string name, string path, string[] fileExtensions)
			{
				this.Name = name;
				this.Path = path;
				this.FileExtensions = fileExtensions;
			}
		}
	}
}
