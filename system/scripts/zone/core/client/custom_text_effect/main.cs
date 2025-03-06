//--- Melia Script ----------------------------------------------------------
// Custom Text Effect
//--- Description -----------------------------------------------------------
// Modifies some code to enable custom text in text effects.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class CustomTextEffectClientScript : ClientScript
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
