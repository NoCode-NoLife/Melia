using System;
using System.Collections.Generic;
using Melia.Shared.L10N;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Scripting.Extensions.Keywords
{
	/// <summary>
	/// Keyword-related extension methods for characters.
	/// </summary>
	public static class CharacterExtensions
	{
		private const string KeywordsVar = "Ashen.Character.Keywords";
		private const char Delimiter = ';';

		/// <summary>
		/// Returns a list of all keywords that the character has learned.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public static List<Keyword> GetKeywords(this Character character)
		{
			var codes = character.GetKeywordCodes();
			return KeywordDb.GetFromCodes(codes);
		}

		/// <summary>
		/// Adds the keyword to the ones the character has learned and
		/// is able to use.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="code"></param>
		/// <exception cref="ArgumentException"></exception>
		public static void AddKeyword(this Character character, string code)
		{
			var codes = character.GetKeywordCodes();

			if (codes.Contains(code))
				return;

			if (!KeywordDb.TryGet(code, out var keyword))
				throw new ArgumentException($"Keyword '{code}' not found.");

			codes.Add(code);
			character.SetKeywordCodes(codes);

			character.ServerMessage(string.Format(Localization.Get("You learned of the '{0}' keyword."), keyword.Name));
		}

		/// <summary>
		/// Removes the keyword from the ones the character has learned.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="code"></param>
		public static void RemoveKeyword(this Character character, string code)
		{
			var codes = character.GetKeywordCodes();

			if (!codes.Contains(code))
				return;

			codes.Remove(code);
			character.SetKeywordCodes(codes);
		}

		/// <summary>
		/// Returns true if the character has learned the keyword.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="code"></param>
		/// <returns></returns>
		public static bool HasKeyword(this Character character, string code)
		{
			var codes = character.GetKeywordCodes();
			return codes.Contains(code);
		}

		/// <summary>
		/// Returns a list of all keywords that the character has learned.
		/// </summary>
		/// <remarks>
		/// The keywords are stored as a semicolon-separated list of codes
		/// in a permanent character variable.
		/// </remarks>
		/// <param name="character"></param>
		/// <returns></returns>
		private static HashSet<string> GetKeywordCodes(this Character character)
		{
			var codeList = character.Variables.Perm.GetString(KeywordsVar, "");

			var result = new HashSet<string>();

			var startIndex = 0;
			int nextIndex;

			while ((nextIndex = codeList.IndexOf(';', startIndex)) != -1)
			{
				var entry = codeList.Substring(startIndex, nextIndex - startIndex);

				if (!string.IsNullOrWhiteSpace(entry))
					result.Add(entry);

				startIndex = nextIndex + 1;
			}

			var lastEntry = codeList.Substring(startIndex);

			if (!string.IsNullOrWhiteSpace(lastEntry))
				result.Add(lastEntry);

			return result;
		}

		/// <summary>
		/// Sets the keywords the character has learned.
		/// </summary>
		/// <remarks>
		/// The keywords are stored as a semicolon-separated list of codes
		/// in a permanent character variable.
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="codes"></param>
		private static void SetKeywordCodes(this Character character, IEnumerable<string> codes)
		{
			var codeList = string.Join(Delimiter.ToString(), codes);
			character.Variables.Perm.SetString(KeywordsVar, codeList);
		}
	}
}
