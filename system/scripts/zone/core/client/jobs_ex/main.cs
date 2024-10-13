//--- Melia Script ----------------------------------------------------------
// Jobs Expansion Script
//--- Description -----------------------------------------------------------
// Makes adjustments to job functions to make them more flexible.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events.Arguments;
using Melia.Zone.Scripting;

public class JobExClientScript : ClientScript
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
