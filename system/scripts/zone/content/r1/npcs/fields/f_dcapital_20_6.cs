//--- Melia Script ----------------------------------------------------------
// Jonael Commemorative Orb
//--- Description -----------------------------------------------------------
// NPCs found in and around Jonael Commemorative Orb.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital206NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157031, "", "f_dcapital_20_6", -755.0917, 283.1046, 1777.638, 0, "f_dcapital_20_6_elt", 2, 1);
	}
}
