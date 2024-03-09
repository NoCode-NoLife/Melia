//--- Melia Script ----------------------------------------------------------
// Dialog Portraits
//--- Description -----------------------------------------------------------
// Custom dialogues have certain restrictions, such as being unable
// to define a portrait for custom text, because the official function
// overwrites that variable. This script cleans up the functions
// responsible for this, to give scripters more freedom.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class DialogPortraitsClientScript : ClientScript
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
