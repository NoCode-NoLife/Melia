//--- Melia Script ----------------------------------------------------------
// Baltinel Memorial
//--- Description -----------------------------------------------------------
// NPCs found in and around Baltinel Memorial.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital105NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153231, "", "f_dcapital_105", -264.1042, 111.0862, -237.836, 0, "f_dcapital_105_elt", 2, 1);
	}
}
