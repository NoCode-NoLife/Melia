using System;
using System.Collections.Generic;
using System.Text;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Database
{
	/// <summary>
	/// Manages account's settings.
	/// </summary>
	public class AccountSettings
	{
		private readonly Dictionary<AccountOptionId, int> _options = new Dictionary<AccountOptionId, int>();

		/// <summary>
		/// Creates new account settings.
		/// </summary>
		public AccountSettings()
		{
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

				if (!Enum.IsDefined(typeof(AccountOptionId), option))
					continue;

				this.Set((AccountOptionId)option, value);
			}
		}

		/// <summary>
		/// Sets the given option.
		/// </summary>
		/// <param name="optionId"></param>
		/// <param name="value"></param>
		public void Set(AccountOptionId optionId, int value)
		{
			lock (_options)
				_options[optionId] = value;
		}

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
					sb.AppendFormat("{0} {1}", (int)option.Key, option.Value);
				}
			}

			return sb.ToString();
		}
	}
}
