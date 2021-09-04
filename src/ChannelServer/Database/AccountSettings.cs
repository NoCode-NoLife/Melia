// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Text;
using Melia.Shared.Const;

namespace Melia.Channel.Database
{
	/// <summary>
	/// Manages account's settings.
	/// </summary>
	public class AccountSettings
	{
		private readonly Dictionary<Option, int> _options;

		/// <summary>
		/// Creates new account settings.
		/// </summary>
		public AccountSettings()
		{
			_options = new Dictionary<Option, int>();
		}

		/// <summary>
		/// Creates new account settings from string.
		/// </summary>
		public AccountSettings(string options)
			: this()
		{
			this.Parse(options);
		}

		/// <summary>
		/// Parses options string in format "option value option value...".
		/// </summary>
		/// <param name="options"></param>
		public void Parse(string options)
		{
			if (string.IsNullOrWhiteSpace(options))
				return;

			var split = options.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (split.Length % 2 != 0)
				throw new ArgumentException("String doesn't contain an even amount of keys and values.");

			for (var i = 0; i < split.Length; i += 2)
			{
				if (!int.TryParse(split[i], out var option))
					throw new ArgumentException("Invalid key '" + split[i] + "'.");

				if (!int.TryParse(split[i + 1], out var value))
					throw new ArgumentException("Invalid value '" + split[i + 1] + "'.");

				this.Set((Option)option, value);
			}
		}

		/// <summary>
		/// Sets the given option.
		/// </summary>
		/// <param name="option"></param>
		/// <param name="value"></param>
		public void Set(Option option, int value)
		{
			// Don't add option if it doesn't exist in the enum, someone could
			// flood the database with invalid values.
			if (!Enum.IsDefined(typeof(Option), option))
				throw new ArgumentException("Unknown option '" + option + "'.");

			// Set option
			lock (_options)
				_options[option] = value;
		}

		/// <summary>
		/// Returns account options as string, as required for option list.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var sb = new StringBuilder();

			var i = 0;
			lock (_options)
			{
				foreach (var option in _options)
				{
					if (i++ != 0)
						sb.Append(' ');
					sb.AppendFormat("{0} {1}", (int)option.Key, option.Value);
				}
			}

			return sb.ToString();
		}
	}
}
