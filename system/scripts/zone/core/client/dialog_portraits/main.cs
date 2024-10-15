//--- Melia Script ----------------------------------------------------------
// Dialog Portraits
//--- Description -----------------------------------------------------------
// Custom dialogues have certain restrictions, such as being unable
// to define a portrait for custom text, because the official function
// overwrites that variable. This script cleans up the functions
// responsible for this, to give scripters more freedom.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class DialogPortraitsClientScript : ClientScript
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
