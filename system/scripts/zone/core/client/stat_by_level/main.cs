//--- Melia Script ----------------------------------------------------------
// Stat by Level
//--- Description -----------------------------------------------------------
// Officials removed the StatByLevel property from the stat point
// calculation when they switched to auto-statting. This script
// adds it again.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events.Arguments;
using Melia.Zone.Scripting;

public class StatByLevelClientScript : ClientScript
{
	public override void Load()
	{
		this.LoadAllScripts();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		// We'll only send the scripts if the feature to disable stats
		// by level wasn't enabled. We still keep track of the stat
		// points and automatically send them to the client, and
		// we don't want them to get included in the calculations
		// if the feature is enabled.

		if (!Feature.IsEnabled("NoStatByLevel"))
			this.SendAllScripts(e.Character);
	}
}
