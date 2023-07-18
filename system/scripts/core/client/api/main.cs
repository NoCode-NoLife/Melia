//--- Melia Script ----------------------------------------------------------
// Melia Lua API
//--- Description -----------------------------------------------------------
// Provides QoL functions for client scripting.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Yggdrasil.Scripting;

[Priority(100)]
public class MeliaLuaApiScript : ClientScript
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
