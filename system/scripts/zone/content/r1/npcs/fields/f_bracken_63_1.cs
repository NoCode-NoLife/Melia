//--- Melia Script ----------------------------------------------------------
// Kateen Forest
//--- Description -----------------------------------------------------------
// NPCs found in and around Kateen Forest.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken631NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(153107, "", "f_bracken_63_1", -268.1401, 544.2999, 995.2676, 21, "f_bracken_63_1_elt", 3, 2);
	}
}
