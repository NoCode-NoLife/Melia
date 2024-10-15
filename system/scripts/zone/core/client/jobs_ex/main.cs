//--- Melia Script ----------------------------------------------------------
// Jobs Expansion Script
//--- Description -----------------------------------------------------------
// Makes adjustments to job functions to make them more flexible.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class JobExClientScript : ClientScript
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
