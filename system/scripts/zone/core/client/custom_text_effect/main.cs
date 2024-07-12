//--- Melia Script ----------------------------------------------------------
// Custom Text Effect
//--- Description -----------------------------------------------------------
// Modifies some code to enable custom text in text effects.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class CustomTextEffectClientScript : ClientScript
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
