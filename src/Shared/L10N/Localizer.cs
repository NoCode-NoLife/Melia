using nettext;

namespace Melia.Shared.L10N
{
	/// <summary>
	/// Manages the localization of strings.
	/// </summary>
	public class Localizer
	{
		private readonly PoFile _catalog;

		/// <summary>
		/// Creates an empty localizer that can load messages via Load
		/// at a later time.
		/// </summary>
		/// <param name="path"></param>
		public Localizer()
		{
			_catalog = new PoFile();
		}

		/// <summary>
		/// Creates localizer from PO file at given path.
		/// </summary>
		/// <param name="path"></param>
		public Localizer(string path)
		{
			_catalog = new PoFile(path);
		}

		/// <summary>
		/// Loads messages from given PO file.
		public void Load(string path)
		{
			_catalog.LoadFromFile(path);
		}

		/// <summary>
		/// Returns translated string, or id if no translated version
		/// of id exists.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public string Get(string id)
		{
			return _catalog.GetString(id);
		}

		/// <summary>
		/// Returns translated string in context, or id if no translated
		/// version of id exists.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		public string GetParticular(string context, string id)
		{
			return _catalog.GetParticularString(context, id);
		}

		/// <summary>
		/// Returns translated string as singular or plural, based on n,
		/// or id/idPlural if no translated version of id exists.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="idPlural"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		public string GetPlural(string id, string idPlural, int n)
		{
			return _catalog.GetPluralString(id, idPlural, n);
		}

		/// <summary>
		/// Returns translated string in context as singular or plural,
		/// based on n, or id/idPlural if no translated version of id exists.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		public string GetParticularPlural(string context, string id, string idPlural, int n)
		{
			return _catalog.GetParticularPluralString(context, id, idPlural, n);
		}
	}
}
