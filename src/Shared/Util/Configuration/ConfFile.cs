// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.IO;

namespace Melia.Shared.Util.Configuration
{
	/// <summary>
	/// Configuration options manager.
	/// </summary>
	/// <remarks>
	/// Uses <see cref="FileReader"/> to read conf files, that are parsed in key:value pairs.
	/// Separating character is a colon ':'.
	/// </remarks>
	public class ConfFile
	{
		protected readonly Dictionary<string, string> _options;

		protected ConfFile()
		{
			_options = new Dictionary<string, string>();
		}

		/// <summary>
		/// Loads all options in the file, and included files.
		/// Does nothing if file doesn't exist.
		/// </summary>
		/// <param name="filePath"></param>
		public void Include(string filePath)
		{
			if (!File.Exists(filePath))
				return;

			this.LoadFile(filePath);
		}

		/// <summary>
		/// Loads all options in the file, and included files.
		/// Throws FileNotFoundException if file couldn't be found.
		/// </summary>
		/// <param name="filePath"></param>
		protected void Require(string filePath)
		{
			this.LoadFile(filePath);
		}

		/// <summary>
		/// Loads all options in the file, and included files.
		/// </summary>
		/// <param name="filePath"></param>
		private void LoadFile(string filePath)
		{
			using (var fr = new FileReader(filePath))
			{
				foreach (var line in fr)
				{
					var pos = -1;

					// Check for seperator
					if ((pos = line.Value.IndexOf(':')) < 0)
						return;

					_options[line.Value.Substring(0, pos).Trim()] = line.Value.Substring(pos + 1).Trim();
				}
			}
		}

		/// <summary>
		/// Returns the option as bool, or the default value, if the option
		/// doesn't exist.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected bool GetBool(string option, bool defaultValue = false)
		{
			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			value = value.ToLower().Trim();

			return (value == "1" || value == "yes" || value == "true");
		}

		/// <summary>
		/// Returns the option as byte, or the default value, if the option
		/// doesn't exist.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected byte GetByte(string option, byte defaultValue = 0)
		{
			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			if (byte.TryParse(value, out var ret))
				return ret;

			Log.Warning("Invalid value for '{0}', defaulting to '{1}'", option, defaultValue);
			return defaultValue;
		}

		/// <summary>
		/// Returns the option as short, or the default value, if the option
		/// doesn't exist.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected short GetShort(string option, short defaultValue = 0)
		{
			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			if (short.TryParse(value, out var ret))
				return ret;

			Log.Warning("Invalid value for '{0}', defaulting to '{1}'", option, defaultValue);
			return defaultValue;
		}

		/// <summary>
		/// Returns the option as int, or the default value, if the option
		/// doesn't exist.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected int GetInt(string option, int defaultValue = 0)
		{
			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			if (int.TryParse(value, out var ret))
				return ret;

			Log.Warning("Invalid value for '{0}', defaulting to '{1}'", option, defaultValue);
			return defaultValue;
		}

		/// <summary>
		/// Returns the option as long, or the default value, if the option
		/// doesn't exist.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected long GetLong(string option, long defaultValue = 0)
		{
			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			if (long.TryParse(value, out var ret))
				return ret;

			Log.Warning("Invalid value for '{0}', defaulting to '{1}'", option, defaultValue);
			return defaultValue;
		}

		/// <summary>
		/// Returns the option as string, or the default value, if the option
		/// doesn't exist.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected string GetString(string option, string defaultValue = "")
		{
			return !_options.TryGetValue(option, out var value) ? defaultValue : value;
		}

		/// <summary>
		/// Returns the option as float, or the default value, if the option
		/// doesn't exist.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected float GetFloat(string option, float defaultValue = 0)
		{
			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			if (float.TryParse(value, out var ret))
				return ret;

			Log.Warning("Invalid value for '{0}', defaulting to '{1}'", option, defaultValue);
			return defaultValue;

		}

		/// <summary>
		/// Returns the option as a DateTime, or the default value, if the
		/// option doesn't exist.
		/// </summary>
		/// <remarks>
		/// For acceptable value formatting, see <see href="http://msdn.microsoft.com/en-us/library/system.datetime.parse(v=vs.110).aspx">MSDN</see>.
		/// </remarks>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected DateTime GetDateTime(string option, DateTime defaultValue = default(DateTime))
		{
			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			if (DateTime.TryParse(value, out var ret))
				return ret;

			Log.Warning("Invalid value for '{0}', defaulting to '{1}'", option, defaultValue);
			return defaultValue;

		}

		/// <summary>
		/// Returns the option as a TimeSpan, or the default value, if the
		/// option doesn't exist.
		/// </summary>
		/// <remarks>
		/// Value must be formatted as [-]{ d | [d.]hh:mm[:ss[.ff]] }
		/// 
		/// For more details, see <see href="http://msdn.microsoft.com/en-us/library/se73z7b9(v=vs.110).aspx">MSDN</see>.
		/// </remarks>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected TimeSpan GetTimeSpan(string option, TimeSpan defaultValue = default(TimeSpan))
		{
			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			if (TimeSpan.TryParse(value, out var ret))
				return ret;

			Log.Warning("Invalid value for '{0}', defaulting to '{1}'", option, defaultValue);
			return defaultValue;
		}

		/// <summary>
		/// Returns the option as an enum, or the default value, if the option
		/// doesn't exist.
		/// </summary>
		/// <typeparam name="T">The type of the enum</typeparam>
		/// <param name="option"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		protected T GetEnum<T>(string option, T defaultValue = default(T)) where T : struct
		{
			if (!typeof(T).IsEnum)
				throw new NotSupportedException("Type " + typeof(T) + " is not an enum.");

			if (!_options.TryGetValue(option, out var value))
				return defaultValue;

			if (Enum.TryParse<T>(value, true, out var ret))
				return ret;

			Log.Warning("Invalid value for '{0}', defaulting to '{1}'", option, defaultValue);
			return defaultValue;
		}
	}
}
