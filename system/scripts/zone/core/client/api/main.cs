//--- Melia Script ----------------------------------------------------------
// Melia Lua API
//--- Description -----------------------------------------------------------
// Provides QoL functions for client scripting.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Scripting;

[Priority(100)]
public class MeliaLuaApiScript : ClientScript
{
	protected override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		this.SendAllScripts(character);
	}
}
