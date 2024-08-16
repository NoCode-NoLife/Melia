using System.Collections.Generic;

namespace Melia.Zone.Scripting.Extensions.Keywords
{
	/// <summary>
	/// Global keyword database, storing the available keywords that
	/// players can learn and use.
	/// </summary>
	public static class KeywordDb
	{
		private readonly static Dictionary<string, Keyword> Keywords = new Dictionary<string, Keyword>();

		/// <summary>
		/// Adds a new keyword to the database.
		/// </summary>
		/// <param name="code"></param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		public static void Add(string code, string name, string description)
		{
			lock (Keywords)
				Keywords.Add(code, new Keyword(code, name, description));
		}

		/// <summary>
		/// Returns true if the keyword exists in the database.
		/// </summary>
		/// <param name="code"></param>
		/// <returns></returns>
		public static bool Exists(string code)
		{
			lock (Keywords)
				return Keywords.ContainsKey(code);
		}

		/// <summary>
		/// Returns the keyword with the given code via out. Returns false
		/// if no matching keyword was found.
		/// </summary>
		/// <param name="code"></param>
		/// <param name="keyword"></param>
		/// <returns></returns>
		public static bool TryGet(string code, out Keyword keyword)
		{
			lock (Keywords)
				return Keywords.TryGetValue(code, out keyword);
		}

		/// <summary>
		/// Returns a list of all keywords that match the given codes.
		/// The results is limited to those actually found in the database.
		/// </summary>
		/// <param name="codes"></param>
		/// <returns></returns>
		public static List<Keyword> GetFromCodes(HashSet<string> codes)
		{
			var result = new List<Keyword>();

			if (codes == null || codes.Count == 0)
				return result;

			lock (Keywords)
			{
				// Go through the keywords and check the codes to get
				// them in the order they were added to the db to.

				foreach (var keyword in Keywords.Values)
				{
					if (codes.Contains(keyword.Code))
						result.Add(keyword);
				}
			}

			return result;
		}
	}

	/// <summary>
	/// Represents a keyword that can be learned and used by players.
	/// </summary>
	public class Keyword
	{
		/// <summary>
		/// Returns the identifying code of the keyword.
		/// </summary>
		public string Code { get; }

		/// <summary>
		/// Returns the name of the keyword.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Returns the description of the keyword.
		/// </summary>
		public string Description { get; }

		/// <summary>
		/// Creates new keyword.
		/// </summary>
		/// <param name="code"></param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		public Keyword(string code, string name, string description)
		{
			this.Code = code;
			this.Name = name;
			this.Description = description;
		}
	}
}
