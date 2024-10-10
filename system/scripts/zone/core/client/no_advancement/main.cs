//--- Melia Script ----------------------------------------------------------
// No Advancement
//--- Description -----------------------------------------------------------
// Disables the advancement button and screen, so player can no longer
// change jobs via the UI.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class NoAdvancementClientScript : ClientScript
{
	public override void Load()
	{
		this.LoadAllScripts();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		if (ZoneServer.Instance.Conf.World.NoAdvancement)
			this.SendAllScripts(e.Character);
	}
}
