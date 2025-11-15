//--- Melia Script ----------------------------------------------------------
// Downtown
//--- Description -----------------------------------------------------------
// NPCs found in and around Downtown.
//---------------------------------------------------------------------------

using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash63NpcScript : GeneralScript
{
	protected override void Load()
	{
		// Track NPCs
		//---------------------------------------------------------------------------
		AddTrackNPC(147427, "", "f_flash_63", 897.8192, 233.7511, 654.0224, 1, "flash_elevator");
	}
}
