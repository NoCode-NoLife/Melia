//--- Melia Script ----------------------------------------------------------
// Classic Heal
//--- Description -----------------------------------------------------------
// Changes Cleric's Heal skill to get cast instantly instead of showing
// a target selection wheel.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class ClassicHealClientScript : ClientScript
{
	public override void Load()
	{
		// We only enable this script if the PartySelect feature is
		// disabled. If it is, we override a client function that
		// determines whether to show the target selection wheel
		// to cast the skill instantly.
		if (!Feature.IsEnabled("ClericHealPartySelect"))
			this.LoadAllScripts();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		this.SendAllScripts(e.Character);
	}
}
