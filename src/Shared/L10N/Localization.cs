namespace Melia.Shared.L10N
{
	/// <summary>
	/// Provides quick access to a global localizer, loaded with the
	/// server's default language.
	/// </summary>
	public static class Localization
	{
		private static Localizer Localizer = new Localizer();

		/// <summary>
		/// Sets the localizer that is to be used to translate strings.
		/// </summary>
		/// <param name="localizer"></param>
		internal static void SetLocalizer(Localizer localizer)
			=> Localizer = localizer;

		/// <summary>
		/// Returns translated string, or id if no translated version
		/// of id exists.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static string Get(string id)
			=> Localizer.Get(id);

		/// <summary>
		/// Returns translated string in context, or id if no translated
		/// version of id exists.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		public static string GetParticular(string context, string id)
			=> Localizer.GetParticular(context, id);

		/// <summary>
		/// Returns translated string as singular or plural, based on n,
		/// or id/idPlural if no translated version of id exists.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="idPlural"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		public static string GetPlural(string id, string idPlural, int n)
			=> Localizer.GetPlural(id, idPlural, n);

		/// <summary>
		/// Returns translated string in context as singular or plural,
		/// based on n, or id/idPlural if no translated version of id exists.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		public static string GetParticularPlural(string context, string id, string idPlural, int n)
			=> Localizer.GetParticularPlural(context, id, idPlural, n);
	}
}
