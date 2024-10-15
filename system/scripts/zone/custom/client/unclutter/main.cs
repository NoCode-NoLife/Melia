//--- Melia Script ----------------------------------------------------------
// Unclutterer
//--- Description -----------------------------------------------------------
// Removes some of the clutter from the UI, such as cash shop buttons.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class UnclutterClientScript : ClientScript
{
	/// <summary>
	/// Loads script files.
	/// </summary>
	public override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		var vars = character.Connection.Account.Variables;

		this.SendLuaScript(character, "001.lua");
		this.SendLuaScript(character, "003.lua");

		if (vars.Perm.ActivateOnce("Melia.ClientScripts.Unclutter.DoneFirstTime"))
			this.SendLuaScript(character, "002.lua");
	}
}
