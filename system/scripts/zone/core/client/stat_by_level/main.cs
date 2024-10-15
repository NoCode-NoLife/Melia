//--- Melia Script ----------------------------------------------------------
// Stat by Level
//--- Description -----------------------------------------------------------
// Officials removed the StatByLevel property from the stat point
// calculation when they switched to auto-statting. This script
// adds it again.
//---------------------------------------------------------------------------

using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class StatByLevelClientScript : ClientScript
{
	protected override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		// We'll only send the scripts if the feature to disable stats
		// by level wasn't enabled. We still keep track of the stat
		// points and automatically send them to the client, and
		// we don't want them to get included in the calculations
		// if the feature is enabled.

		if (!Feature.IsEnabled("NoStatByLevel"))
			this.SendAllScripts(character);
	}
}
