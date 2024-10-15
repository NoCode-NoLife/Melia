//--- Melia Script ----------------------------------------------------------
// No Advancement
//--- Description -----------------------------------------------------------
// Disables the advancement button and screen, so player can no longer
// change jobs via the UI.
//---------------------------------------------------------------------------

using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class NoAdvancementClientScript : ClientScript
{
	protected override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		if (ZoneServer.Instance.Conf.World.NoAdvancement)
			this.SendAllScripts(character);
	}
}
