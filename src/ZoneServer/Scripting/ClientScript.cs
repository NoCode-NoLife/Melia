using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Melia.Zone.Network;
using Melia.Zone.World.Entities;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// Specialized script for sending Lua scripts to the client.
	/// </summary>
	public abstract class ClientScript : GeneralScript
	{
		private readonly Dictionary<string, string> _files = new Dictionary<string, string>();

		/// <summary>
		/// Loads a Lua script from the same directory as the script.
		/// </summary>
		/// <param name="fileName">File name of the script.</param>
		/// <param name="sourceFilePath">Please ignore. Used to determine the path to the script file.</param>
		protected void LoadLuaScript(string fileName, [CallerFilePath] string sourceFilePath = "")
		{
			var fileDirPath = Path.GetDirectoryName(sourceFilePath);
			var filePath = Path.Combine(fileDirPath, fileName);

			var script = File.ReadAllText(filePath);

			_files[fileName] = script;
		}

		/// <summary>
		/// Lodads the Lua code and remembers it under the given name.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="code"></param>
		protected void LoadLuaCode(string name, string code)
		{
			_files[name] = code;
		}

		/// <summary>
		/// Sends a previously loaded Lua script to the character's client.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="fileName"></param>
		protected void SendLuaScript(Character character, string fileName)
		{
			var script = _files[fileName];
			Send.ZC_EXEC_CLIENT_SCP(character.Connection, script);
		}

		/// <summary>
		/// Loads a Lua script from the same directory as the script.
		/// </summary>
		/// <param name="sourceFilePath">Please ignore. Used to determine the path to the script file.</param>
		protected void LoadAllScripts([CallerFilePath] string sourceFilePath = "")
		{
			var fileDirPath = Path.GetDirectoryName(sourceFilePath);
			var luaFilePaths = Directory.EnumerateFiles(fileDirPath, "*.lua").OrderBy(a => a);

			foreach (var filePath in luaFilePaths)
			{
				var fileName = Path.GetFileName(filePath);
				var script = File.ReadAllText(filePath);
				_files[fileName] = script;
			}
		}

		/// <summary>
		/// Sends all loaded Lua scripts to the character's client.
		/// </summary>
		/// <param name="character"></param>
		protected void SendAllScripts(Character character)
		{
			foreach (var file in _files)
			{
				var script = file.Value;
				Send.ZC_EXEC_CLIENT_SCP(character.Connection, script);
			}
		}
	}
}
