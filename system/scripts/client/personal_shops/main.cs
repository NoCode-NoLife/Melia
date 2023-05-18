//--- Melia Script ----------------------------------------------------------
// Personal Shops
//--- Description -----------------------------------------------------------
// Personal Shops aren't officially supported anymore, and their scripts
// are partially broken. These client scripts fix them to a certain degree,
// to make the UI usable again.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class PersonalShopsClientScript : ClientScript
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
