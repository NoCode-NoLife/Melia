Keywords
=============================================================================

This extension provides a system for defining keywords that players may
utilize during conversations with NPCs. It's modelled after the keyword
system used in Mabinogi, which allowed players to learn about key topics
and ask about them during dialogs.

Database
-----------------------------------------------------------------------------

Keywords are identified via simple string keys, which in turn have a name
and description assigned. They can be created and queried via the static
`KeywordDb` class.

```cs
void KeywordDb.Add(string code, string name, string description)
bool KeywordDb.Exists(string code)
bool KeywordDb.TryGet(string code, out Keyword keyword)
List<Keyword> KeywordDb.GetFromCodes(HashSet<string> codes)
```

Characters
-----------------------------------------------------------------------------

Each character can know about any number of keywords and they're stored
with the character as permanent character variables. For ease of use,
a series of extension methods is available for accessing and managing
a characters' keywords.

```cs
List<Keyword> GetKeywords(this Character character)
void AddKeyword(this Character character, string code)
void RemoveKeyword(this Character character, string code)
bool HasKeyword(this Character character, string code)
HashSet<string> GetKeywordCodes(this Character character)
void SetKeywordCodes(this Character character, IEnumerable<string> codes)
```

Usage Example
-----------------------------------------------------------------------------

```cs
while (true)
{
	var selection = await dialog.Select(moodMessage,
		Option(L("Ask about..."), "ask"),
		Option(L("Leave"), "leave")
	);

	if (selection == "leave")
		return;

	var perPage = 9;
	var curPage = 0;

	while (true)
	{
		var keywordOptions = new List<DialogOption>();
		
		var keywords = dialog.Player.GetKeywords();
		foreach (var keyword in keywords)
			keywordOptions.Add(Option(keyword.Name, keyword.Code));

		var pagesCount = (keywordOptions.Count + perPage - 1) / perPage;
		var pagedOptions = keywordOptions.Skip(curPage * perPage).Take(perPage).ToList();

		if (curPage < pagesCount - 1)
			pagedOptions.Add(Option(L(">>"), "next"));

		if (curPage > 0)
			pagedOptions.Insert(0, Option(L("<<"), "back"));

		pagedOptions.Add(Option(L("Leave"), "leave"));

		selection = await dialog.Select(moodMessage, pagedOptions);

		if (selection == "back")
		{
			curPage = Math.Max(0, curPage - 1);
			continue;
		}

		if (selection == "next")
		{
			curPage = Math.Min(pagesCount - 1, curPage + 1);
			continue;
		}

		if (selection == "leave")
			return;

		await HandleKeyword(dialog, selection);
	}
}
```
