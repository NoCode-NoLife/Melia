using System.Collections.Generic;
using Melia.Shared.World;
using Yggdrasil.Configuration;
using Yggdrasil.Logging;

namespace Melia.Shared.Configuration.Files
{
	/// <summary>
	/// Represents barracks.conf.
	/// </summary>
	public class BarracksConfFile : ConfFile
	{
		/// <summary>
		/// When enabled, client integrity checks are applied.
		/// </summary>
		public bool VerifyIpf { get; private set; }

		/// <summary>
		/// Checksum to prevent clients using modified or out-dated IPF files.
		/// </summary>
		public string IpfChecksum { get; private set; }

		/// <summary>
		/// Map new players start on.
		/// </summary>
		public string StartMap { get; private set; }

		/// <summary>
		/// Position new players start at.
		/// </summary>
		public Position StartPosition { get; private set; }

		/// <summary>
		/// Loads conf file and its options from the given path.
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			this.Include(filePath);

			this.IpfChecksum = this.GetString("ipf_checksum", "");
			this.VerifyIpf = this.GetBool("ipf_verifying", false);


			this.StartMap = this.GetString("start_map", "f_siauliai_west");
			this.StartPosition = this.GetPosition("start_position", new Position(-628, 260, -1025));
		}

		/// <summary>
		/// Parses the option as a position and returns it.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		private Position GetPosition(string option, Position defaultValue)
		{
			var value = this.GetString(option, "-628, 260, -1025");

			var split = value.Split(',');
			if (split.Length != 3)
			{
				Log.Warning("barracks.conf: Invalid position format for '{0}'.", option);
				return defaultValue;
			}

			if (!int.TryParse(split[0], out var x) || !int.TryParse(split[1], out var y) || !int.TryParse(split[2], out var z))
			{
				Log.Warning("barracks.conf: Invalid coordinates in '{0}'.", option);
				return defaultValue;
			}

			return new Position(x, y, z);
		}

		public Dictionary<string, string> GetOptions()
		{
			return _options;
		}
	}
}
