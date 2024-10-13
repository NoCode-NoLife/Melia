//--- Melia Script ----------------------------------------------------------
// Respawn Options Script
//--- Description -----------------------------------------------------------
// Modifies the respawn option display, to be more in line with what
// we expect of it for the server.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events.Arguments;
using Melia.Zone.Scripting;

public class RespawnOptionsClientScript : ClientScript
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
