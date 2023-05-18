//--- Melia Script ----------------------------------------------------------
// Custom NPC Shops Enabler
//--- Description -----------------------------------------------------------
// This client script allows the server to send custom NPC shops to the
// client, which is usually in control over what items are displayed for
// specific shops. The Lua scripts intercept the requests to load the shop
// data and dynamically use custom data instead.
// 
// If this script is not loaded, custom shops opened by the server will
// simply be empty.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class CustomNpcShopsClientScript : ClientScript
{
	/// <summary>
	/// Loads script files.
	/// </summary>
	public override void Load()
	{
		this.LoadLuaScript("001.lua");
		this.LoadLuaScript("002.lua");
		this.LoadLuaScript("003.lua");
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		this.SendLuaScript(e.Character, "001.lua");
		this.SendLuaScript(e.Character, "002.lua");
		this.SendLuaScript(e.Character, "003.lua");
	}
}
