//--- Melia Script ----------------------------------------------------------
// Free Drops
//--- Description -----------------------------------------------------------
// This client script modifies the item drop/destroy restrictions, so you
// can drop whatever you want. The server then decides whether the item
// should actually be destroyable. This way we can allow players to be
// able to get rid of otherwise undestroyable and unstorable items.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class FreeDropsClientScript : ClientScript
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
