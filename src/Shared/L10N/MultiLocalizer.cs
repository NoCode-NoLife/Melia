using System;
using System.Collections.Generic;
using System.Linq;

namespace Melia.Shared.L10N
{
	/// <summary>
	/// Manages localization strings.
	/// </summary>
	public class MultiLocalizer
	{
		private Localizer _defaultLocalizer = new Localizer();
		private readonly Dictionary<string, Localizer> _localizers = new Dictionary<string, Localizer>();

		/// <summary>
		/// Loads messages from given PO file and creates a localizer
		/// for it under the language name.
		/// </summary>
		/// <param name="languageName"></param>
		/// <param name="path"></param>
		public void Load(string languageName, string path)
		{
			languageName = languageName.ToLower();

			lock (_localizers)
				_localizers[languageName] = new Localizer(path);
		}

		/// <summary>
		/// Returns true if a localizer for the given language exists.
		/// </summary>
		/// <param name="languageName"></param>
		/// <returns></returns>
		public bool Contains(string languageName)
		{
			languageName = languageName.ToLower();

			lock (_localizers)
				return _localizers.ContainsKey(languageName);
		}

		/// <summary>
		/// Returns the localizer for the given language, or the default
		/// one if no localizer exists for it.
		/// </summary>
		/// <param name="languageName"></param>
		/// <returns></returns>
		public Localizer Get(string languageName)
		{
			languageName = languageName.ToLower();

			lock (_localizers)
			{
				if (!_localizers.TryGetValue(languageName, out var localizer))
					return _defaultLocalizer;

				return localizer;
			}
		}

		/// <summary>
		/// Returns the localizer for the given language via out.
		/// If no matching localizer was found, this method returns
		/// false and a working default localizer is returned via out.
		/// </summary>
		/// <param name="languageName"></param>
		/// <param name="localizer"></param>
		/// <returns></returns>
		public bool TryGet(string languageName, out Localizer localizer)
		{
			languageName = languageName.ToLower();

			lock (_localizers)
			{
				if (_localizers.TryGetValue(languageName, out localizer))
					return true;

				localizer = _defaultLocalizer;
			}

			return false;
		}

		/// <summary>
		/// Returns a list of the names of the languages that were loaded.
		/// </summary>
		/// <returns></returns>
		public string[] GetLanguages()
		{
			lock (_localizers)
				return _localizers.Keys.ToArray();
		}

		/// <summary>
		/// Sets the loaded localizer for the given language as the
		/// default one to return when a language couldn't be found.
		/// </summary>
		/// <param name="languageName"></param>
		/// <exception cref="ArgumentException"></exception>
		public void SetDefault(string languageName)
		{
			var loweredName = languageName.ToLower();

			lock (_localizers)
			{
				if (!_localizers.TryGetValue(loweredName, out var localizer))
					throw new ArgumentException($"No localizer for language {languageName} found.");

				_defaultLocalizer = localizer;
			}
		}

		/// <summary>
		/// Returns the default localizer.
		/// </summary>
		/// <returns></returns>
		public Localizer GetDefault()
		{
			lock (_localizers)
				return _defaultLocalizer;
		}
	}
}
