//--- Melia Script ----------------------------------------------------------
// Concise Sysmenu
//--- Description -----------------------------------------------------------
// Removes clutter from the system menu at the bottom right of the screen.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class ConciseSysmenuClientScript : ClientScript
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
