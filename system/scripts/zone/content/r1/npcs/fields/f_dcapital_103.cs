//--- Melia Script ----------------------------------------------------------
// Taniel I Commemorative Orb
//--- Description -----------------------------------------------------------
// NPCs found in and around Taniel I Commemorative Orb.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital103NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(157032, "", "f_dcapital_103", 1260.842, 214.2436, -324.7393, 8, "f_dcapital_103_elt", 2, 1);
		AddTrackNPC(157033, "", "f_dcapital_103", -401.9065, 174.6531, -97.95161, 0, "f_dcapital_103_elt2", 2, 1);
	}
}
