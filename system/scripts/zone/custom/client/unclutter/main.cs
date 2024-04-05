//--- Melia Script ----------------------------------------------------------
// Unclutterer
//--- Description -----------------------------------------------------------
// Removes some of the clutter from the UI, such as cash shop buttons.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class UnclutterClientScript : ClientScript
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
		this.SendLuaScript(e.Character, "001.lua");

		if (e.Character.Connection.Account.Variables.Perm.ActivateOnce("Melia.ClientScripts.Unclutter.DoneFirstTime"))
			this.SendLuaScript(e.Character, "002.lua");
	}
}
