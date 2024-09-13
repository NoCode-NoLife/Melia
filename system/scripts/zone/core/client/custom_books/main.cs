//--- Melia Script ----------------------------------------------------------
// Custom Books
//--- Description -----------------------------------------------------------
// Allows the use of custom books by sending the book text instead of
// a book name, prefixed with "CUSTOM:".
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class CustomBooksClientScript : ClientScript
{
	public override void Load()
	{
		this.LoadAllScripts();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		this.SendAllScripts(e.Character);
	}
}
