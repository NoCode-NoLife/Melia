//--- Melia Script ----------------------------------------------------------
// Custom Books
//--- Description -----------------------------------------------------------
// Allows the use of custom books by sending the book text instead of
// a book name, prefixed with "CUSTOM:".
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class CustomBooksClientScript : ClientScript
{
	protected override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		this.SendAllScripts(character);
	}
}
