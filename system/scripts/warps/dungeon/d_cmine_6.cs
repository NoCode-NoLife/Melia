//--- Melia Script ----------------------------------------------------------
// Warps
//--- Description -----------------------------------------------------------
// Sets up warps in Crystal Mine 3F
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class d_cmine_6WarpsScript : GeneralScript
{
	public override void Load()
	{
		// Crystal Mine 3F to Crystal Mine 2F
		AddWarp("WS_ACT4_3_ACT4_2", 252, From("d_cmine_6", -2147, -1590), To("d_cmine_02", 1911, 1516));

		// Crystal Mine 3F to Crystal Mine 3F
		AddWarp("WS_ACT4_3_ACT4_BOSS", 115, From("d_cmine_6", 170.2973, -161.5383), To("d_cmine_6", 1747, 2110));

		// Crystal Mine 3F to Crystal Mine 3F
		AddWarp("WS_ACT4_BOSS_ACT4_3", -67, From("d_cmine_6", 1625, 2069), To("d_cmine_6", 58, -210));
	}
}
