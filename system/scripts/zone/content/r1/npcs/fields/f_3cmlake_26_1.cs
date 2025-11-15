//--- Melia Script ----------------------------------------------------------
// Lanko 26 Waters
//--- Description -----------------------------------------------------------
// NPCs found in and around Lanko 26 Waters.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class F3cmlake261NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(155160, "", "f_3cmlake_26_1", 948.2599, -117.9686, 444.7431, 0, "f_3cmlake_26_1_elt");
	}
}
