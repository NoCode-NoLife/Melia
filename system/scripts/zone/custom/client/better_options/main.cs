//--- Melia Script ----------------------------------------------------------
// Better (Default) Options
//--- Description -----------------------------------------------------------
// Sets certain options to absolutely objectively better default values.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class BetterOptionsClientScript : ClientScript
{
	/// <summary>
	/// Loads script files.
	/// </summary>
	public override void Load()
	{
		this.LoadAllScripts();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		if (e.Character.Connection.Account.Variables.Perm.ActivateOnce("Melia.ClientScripts.BetterOptions.DoneFirstTime"))
			this.SendLuaScript(e.Character, "001.lua");
	}
}
