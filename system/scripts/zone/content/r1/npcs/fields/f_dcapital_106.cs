//--- Melia Script ----------------------------------------------------------
// Gliehel Memorial
//--- Description -----------------------------------------------------------
// NPCs found in and around Gliehel Memorial.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital106NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153230, "", "f_dcapital_106", 392.5825, 71.17463, 988.9101, 21, "f_dcapital_106_elt", 2, 1);
	}
}
