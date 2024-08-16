using Melia.Shared.L10N;

namespace Melia.Zone.Scripting
{
	public static partial class Shortcuts
	{
		/// <summary>
		/// Returns a localized version of the given string.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string L(string key)
			=> Localization.Get(key);

		/// <summary>
		/// Returns a localized version of the given string, formatted
		/// with the optional arguments.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public static string LF(string key, params object[] args)
			=> string.Format(Localization.Get(key), args);

		/// <summary>
		/// Returns a localized plural version of the given string.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="keyPlural"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		public static string LN(string key, string keyPlural, int n)
			=> Localization.GetPlural(key, keyPlural, n);

		/// <summary>
		/// Returns a localized plural version of the given string,
		/// formatted with the optional arguments.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="keyPlural"></param>
		/// <param name="n"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public static string LNF(string key, string keyPlural, int n, params object[] args)
			=> string.Format(Localization.GetPlural(key, keyPlural, n), args);
	}
}
