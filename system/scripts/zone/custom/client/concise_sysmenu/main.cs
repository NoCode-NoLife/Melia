//--- Melia Script ----------------------------------------------------------
// Concise Sysmenu
//--- Description -----------------------------------------------------------
// Removes clutter from the system menu at the bottom right of the screen.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class ConciseSysmenuClientScript : ClientScript
{
	public override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		this.SendAllScripts(character);
	}
}
