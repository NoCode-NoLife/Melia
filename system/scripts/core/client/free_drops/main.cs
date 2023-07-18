//--- Melia Script ----------------------------------------------------------
// Free Drops
//--- Description -----------------------------------------------------------
// This client script modifies the item drop/destroy restrictions, so you
// can drop whatever you want. The server then decides whether the item
// should actually be destroyable. This way we can allow players to be
// able to get rid of otherwise undestroyable and unstorable items.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class FreeDropsClientScript : ClientScript
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
