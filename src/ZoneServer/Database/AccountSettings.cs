using System;
using System.Collections.Generic;
using System.Text;

namespace Melia.Zone.Database
{
	/// <summary>
	/// Manages account's settings.
	/// </summary>
	public class AccountSettings
	{
		private readonly Dictionary<int, int> _options = new Dictionary<int, int>();

		/// <summary>
		/// Creates new account settings.
		/// </summary>
		public AccountSettings()
		{
		}

		/// <summary>
		/// Creates new account settings from string.
		/// </summary>
		public AccountSettings(string options)
		{
			this.Parse(options);
		}

		/// <summary>
		/// Parses options string in format "option value option value...".
		/// </summary>
		/// <param name="optionsStr"></param>
		public void Parse(string optionsStr)
		{
			if (string.IsNullOrWhiteSpace(optionsStr))
				return;

			var split = optionsStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (split.Length % 2 != 0)
				throw new ArgumentException("String doesn't contain an even amount of keys and values.");

			for (var i = 0; i < split.Length; i += 2)
			{
				if (!int.TryParse(split[i], out var option))
					throw new ArgumentException("Invalid key '" + split[i] + "'.");

				if (!int.TryParse(split[i + 1], out var value))
					throw new ArgumentException("Invalid value '" + split[i + 1] + "'.");

				this.Set(option, value);
			}
		}

		/// <summary>
		/// Sets the given option.
		/// </summary>
		/// <param name="optionId"></param>
		/// <param name="value"></param>
		public void Set(int optionId, int value)
		{
			// Don't add option if it doesn't exist in the data, as someone
			// could flood the database with invalid values.
			if (!this.IsValid(optionId))
				throw new ArgumentException($"Unknown account option '{optionId}'.");

			// Set option
			lock (_options)
				_options[optionId] = value;
		}

		/// <summary>
		/// Returns true if the given option exists and can be set.
		/// </summary>
		/// <param name="optionId"></param>
		/// <returns></returns>
		public bool IsValid(int optionId)
			=> ZoneServer.Instance.Data.AccountOptionDb.Contains(optionId);

		/// <summary>
		/// Returns account options as string, as required for the options
		/// list that is sent to the client.
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
					sb.AppendFormat("{0} {1}", option.Key, option.Value);
				}
			}

			return sb.ToString();
		}
	}
}
