//--- Melia Script ----------------------------------------------------------
// Unclutterer
//--- Description -----------------------------------------------------------
// Removes some of the clutter from the UI, such as cash shop buttons.
// 
// 001.lua: Removes unused and/or unnecessary buttons.
// 002.lua: -- moved to better_options --
// 003.lua: Disables functions, such as obsolete skill usage UI prompts.
// 004.lua: Removes certain unrelated information from the stats window.
// 005.lua: Removes empty enemy buff frame.
// 006.lua: Removes (currently) unused inventory features.
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
		this.SendAllScripts(character);
	}
}
