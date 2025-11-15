//--- Melia Script ----------------------------------------------------------
// Phamer Forest
//--- Description -----------------------------------------------------------
// NPCs found in and around Phamer Forest.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken432NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153179, "", "f_bracken_43_2", 1369.781, 116.1511, 470.741, 0, "f_bracken_43_2_elt");
		AddTrackNPC(153180, "", "f_bracken_43_2", 552.7917, 35.09259, -574.3962, 354, "f_bracken_43_2_elt2");
	}
}
