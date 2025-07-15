//--- Melia Script ----------------------------------------------------------
// Classic Heal
//--- Description -----------------------------------------------------------
// Changes Cleric's Heal skill to get cast instantly instead of showing
// a target selection wheel.
//---------------------------------------------------------------------------

using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class ClassicHealClientScript : ClientScript
{
	protected override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		// We only send this script if the PartySelect feature is
		// disabled. If it is, we override a client function that
		// determines whether to show the target selection wheel
		// to cast the skill instantly.
		if (!Feature.IsEnabled("ClericHealPartySelect"))
			this.SendAllScripts(character);
	}
}
