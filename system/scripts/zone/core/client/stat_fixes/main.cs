//--- Melia Script ----------------------------------------------------------
// Stat Fixes
//--- Description -----------------------------------------------------------
// Applies various client-side fixes for character stats.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class StatFixesClientScript : ClientScript
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
