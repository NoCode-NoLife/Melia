//--- Melia Script ----------------------------------------------------------
// Stat by Level
//--- Description -----------------------------------------------------------
// Officials removed the StatByLevel property from the stat point
// calculation when they switched to auto-statting. This script
// adds it again.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
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
		this.SendAllScripts(e.Character);
	}
}
