//--- Melia Script ----------------------------------------------------------
// Unclutterer
//--- Description -----------------------------------------------------------
// Removes some of the clutter from the UI, such as cash shop buttons.
// 
// 001.lua: Removes unused and/or unnecessary buttons.
// 002.lua: Turns off miscellaneous elements, such as the FPS counter.
// 003.lua: Disables functions, such as obsolete skill usage UI prompts.
// 004.lua: Removes certain unrelated information from the stats window.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class UnclutterClientScript : ClientScript
{
	/// <summary>
	/// Loads script files.
	/// </summary>
	protected override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		var vars = character.Connection.Account.Variables;

		this.SendLuaScript(character, "001.lua");
		this.SendLuaScript(character, "003.lua");
		this.SendLuaScript(character, "004.lua");

		if (vars.Perm.ActivateOnce("Melia.ClientScripts.Unclutter.DoneFirstTime"))
			this.SendLuaScript(character, "002.lua");
	}
}
