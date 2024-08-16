namespace Melia.Zone.Scripting.Extensions.Keywords
{
	/// <summary>
	/// Provides shortcuts for managing keywords.
	/// </summary>
	public static class Shortcuts
	{
		/// <summary>
		/// Adds a new keyword to the global database.
		/// </summary>
		/// <param name="code"></param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		public static void RegisterKeyword(string code, string name, string description)
		{
			KeywordDb.Add(code, name, description);
		}
	}
}
