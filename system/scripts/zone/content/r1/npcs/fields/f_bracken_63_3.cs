//--- Melia Script ----------------------------------------------------------
// Dadan Jungle
//--- Description -----------------------------------------------------------
// NPCs found in and around Dadan Jungle.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken633NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153095, "", "f_bracken_63_3", -252.8264, 189.2868, -89.98244, 111, "f_bracken_63_3_elt", 2, 1);
	}
}
