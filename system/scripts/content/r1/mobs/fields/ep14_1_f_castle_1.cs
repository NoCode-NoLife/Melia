//--- Melia Script -----------------------------------------------------------
// Delmore Hamlet Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep14_1_f_castle_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep141FCastle1MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("ep14_1_f_castle_1.Id1", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("ep14_1_f_castle_1.Id2", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("ep14_1_f_castle_1.Id3", MonsterId.Rootcrystal_05, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("ep14_1_f_castle_1.Id4", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id5", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id6", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id7", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id8", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id9", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id10", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id11", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id12", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id13", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id14", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id15", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id16", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id17", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id18", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id19", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id20", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id21", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id22", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id23", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id24", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id25", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id26", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id27", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id28", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id29", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id30", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id31", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id32", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id33", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id34", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id35", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id36", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id37", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id38", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id39", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id40", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id41", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id42", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id43", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id44", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id45", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id46", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id47", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id48", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id49", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id50", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id51", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id52", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id53", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id54", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id55", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id56", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id57", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id58", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id59", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id60", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id61", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id62", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id63", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id64", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id65", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id66", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id67", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id68", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id69", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id70", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id71", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id72", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id73", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id74", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id75", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id76", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id77", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id78", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id79", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id80", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id81", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id82", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id83", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id84", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id85", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id86", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id87", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id88", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id89", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id90", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id91", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id92", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id93", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id94", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id95", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id96", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id97", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id98", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id99", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id100", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id101", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id102", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id103", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id104", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id105", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id106", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id107", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id108", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id109", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id110", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id111", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id112", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id113", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id114", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id115", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id116", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id117", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id118", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id119", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id120", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id121", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id122", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id123", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id124", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id125", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id126", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id127", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id128", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id129", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id130", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id131", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id132", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id133", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id134", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id135", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id136", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id137", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id138", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id139", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id140", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id141", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id142", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id143", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id144", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id145", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id146", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id147", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id148", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id149", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id150", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id151", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id152", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id153", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id154", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id155", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id156", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id157", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id158", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id159", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id160", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id161", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id162", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id163", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id164", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id165", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id166", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id167", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id168", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id169", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id170", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id171", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id172", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id173", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id174", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id175", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id176", MonsterId.Bleakferret_Charger, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id177", MonsterId.Bleakferret_Cannon, amount: 1, respawn: TimeSpan.FromMilliseconds(30000));
		AddSpawner("ep14_1_f_castle_1.Id178", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("ep14_1_f_castle_1.Id179", MonsterId.Bleakferret_Spear, amount: 1, respawn: TimeSpan.FromMilliseconds(20000));

		// Monster Spawn Points -----------------------------

		// 'Bleakferret_Spear' GenType 36 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id1", "ep14_1_f_castle_1", Rectangle(40, 550, 60));

		// 'Bleakferret_Spear' GenType 38 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id2", "ep14_1_f_castle_1", Rectangle(284, 346, 60));

		// 'Rootcrystal_05' GenType 45 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(1230, -712, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(1052, -192, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(956, 558, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(998, 1265, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(116, 1342, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(167, 403, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(-582, 546, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(228, -314, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(308, -888, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(-337, -579, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(-895, -1285, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(-1568, -1117, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(38, -1500, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(581, -1615, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(1065, -1275, 100));

		// 'Bleakferret_Spear' GenType 1001 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id4", "ep14_1_f_castle_1", Rectangle(859, 458, 60));

		// 'Bleakferret_Spear' GenType 1002 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id5", "ep14_1_f_castle_1", Rectangle(938, 568, 60));

		// 'Bleakferret_Spear' GenType 1003 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id6", "ep14_1_f_castle_1", Rectangle(853, 675, 60));

		// 'Bleakferret_Spear' GenType 1004 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id7", "ep14_1_f_castle_1", Rectangle(1084, 424, 60));

		// 'Bleakferret_Spear' GenType 1005 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id8", "ep14_1_f_castle_1", Rectangle(1021, 694, 60));

		// 'Bleakferret_Spear' GenType 1006 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id9", "ep14_1_f_castle_1", Rectangle(1059, 1135, 60));

		// 'Bleakferret_Spear' GenType 1007 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id10", "ep14_1_f_castle_1", Rectangle(1095, 1238, 60));

		// 'Bleakferret_Spear' GenType 1008 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id11", "ep14_1_f_castle_1", Rectangle(1019, 1321, 60));

		// 'Bleakferret_Spear' GenType 1009 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id12", "ep14_1_f_castle_1", Rectangle(971, 1417, 60));

		// 'Bleakferret_Spear' GenType 1010 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id13", "ep14_1_f_castle_1", Rectangle(893, 1370, 60));

		// 'Bleakferret_Spear' GenType 1011 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id14", "ep14_1_f_castle_1", Rectangle(885, 1231, 60));

		// 'Bleakferret_Spear' GenType 1012 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id15", "ep14_1_f_castle_1", Rectangle(1170, 1284, 60));

		// 'Bleakferret_Spear' GenType 1013 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id16", "ep14_1_f_castle_1", Rectangle(215, 1247, 60));

		// 'Bleakferret_Spear' GenType 1014 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id17", "ep14_1_f_castle_1", Rectangle(178, 1158, 60));

		// 'Bleakferret_Spear' GenType 1015 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id18", "ep14_1_f_castle_1", Rectangle(60, 1259, 60));

		// 'Bleakferret_Spear' GenType 1016 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id19", "ep14_1_f_castle_1", Rectangle(158, 1341, 60));

		// 'Bleakferret_Spear' GenType 1017 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id20", "ep14_1_f_castle_1", Rectangle(34, 1407, 60));

		// 'Bleakferret_Spear' GenType 1018 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id21", "ep14_1_f_castle_1", Rectangle(131, 1441, 60));

		// 'Bleakferret_Spear' GenType 1019 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id22", "ep14_1_f_castle_1", Rectangle(286, 1478, 60));

		// 'Bleakferret_Spear' GenType 1020 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id23", "ep14_1_f_castle_1", Rectangle(206, 274, 60));

		// 'Bleakferret_Spear' GenType 1021 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id24", "ep14_1_f_castle_1", Rectangle(318, 467, 60));

		// 'Bleakferret_Spear' GenType 1022 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id25", "ep14_1_f_castle_1", Rectangle(143, 605, 60));

		// 'Bleakferret_Spear' GenType 1023 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id26", "ep14_1_f_castle_1", Rectangle(-2, 440, 60));

		// 'Bleakferret_Spear' GenType 1024 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id27", "ep14_1_f_castle_1", Rectangle(994, -340, 60));

		// 'Bleakferret_Spear' GenType 1025 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id28", "ep14_1_f_castle_1", Rectangle(1202, -506, 60));

		// 'Bleakferret_Spear' GenType 1026 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id29", "ep14_1_f_castle_1", Rectangle(1276, -313, 60));

		// 'Bleakferret_Spear' GenType 1027 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id30", "ep14_1_f_castle_1", Rectangle(1018, -122, 60));

		// 'Bleakferret_Spear' GenType 1028 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id31", "ep14_1_f_castle_1", Rectangle(1167, -307, 60));

		// 'Bleakferret_Spear' GenType 1029 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id32", "ep14_1_f_castle_1", Rectangle(1317, -763, 60));

		// 'Bleakferret_Spear' GenType 1030 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id33", "ep14_1_f_castle_1", Rectangle(1190, -834, 60));

		// 'Bleakferret_Spear' GenType 1031 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id34", "ep14_1_f_castle_1", Rectangle(1263, -1059, 60));

		// 'Bleakferret_Spear' GenType 1032 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id35", "ep14_1_f_castle_1", Rectangle(1117, -1170, 60));

		// 'Bleakferret_Spear' GenType 1033 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id36", "ep14_1_f_castle_1", Rectangle(1079, -1412, 60));

		// 'Bleakferret_Spear' GenType 1034 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id37", "ep14_1_f_castle_1", Rectangle(986, -1535, 60));

		// 'Bleakferret_Spear' GenType 1035 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id38", "ep14_1_f_castle_1", Rectangle(785, -1389, 60));

		// 'Bleakferret_Spear' GenType 1036 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id39", "ep14_1_f_castle_1", Rectangle(955, -1394, 60));

		// 'Bleakferret_Spear' GenType 1037 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id40", "ep14_1_f_castle_1", Rectangle(931, -1186, 60));

		// 'Bleakferret_Spear' GenType 1038 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id41", "ep14_1_f_castle_1", Rectangle(748, -1642, 60));

		// 'Bleakferret_Spear' GenType 1039 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id42", "ep14_1_f_castle_1", Rectangle(615, -1447, 60));

		// 'Bleakferret_Spear' GenType 1040 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id43", "ep14_1_f_castle_1", Rectangle(501, -1687, 60));

		// 'Bleakferret_Spear' GenType 1041 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id44", "ep14_1_f_castle_1", Rectangle(147, -1751, 60));

		// 'Bleakferret_Spear' GenType 1042 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id45", "ep14_1_f_castle_1", Rectangle(221, -1523, 60));

		// 'Bleakferret_Spear' GenType 1043 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id46", "ep14_1_f_castle_1", Rectangle(97, -1487, 60));

		// 'Bleakferret_Spear' GenType 1044 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id47", "ep14_1_f_castle_1", Rectangle(-117, -1627, 60));

		// 'Bleakferret_Spear' GenType 1045 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id48", "ep14_1_f_castle_1", Rectangle(-227, -1506, 60));

		// 'Bleakferret_Spear' GenType 1046 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id49", "ep14_1_f_castle_1", Rectangle(-324, -1646, 60));

		// 'Bleakferret_Spear' GenType 1047 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id50", "ep14_1_f_castle_1", Rectangle(-662, -1598, 60));

		// 'Bleakferret_Spear' GenType 1048 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id51", "ep14_1_f_castle_1", Rectangle(-875, -1535, 60));

		// 'Bleakferret_Spear' GenType 1049 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id52", "ep14_1_f_castle_1", Rectangle(-835, -1378, 60));

		// 'Bleakferret_Spear' GenType 1050 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id53", "ep14_1_f_castle_1", Rectangle(-803, -1273, 60));

		// 'Bleakferret_Spear' GenType 1051 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id54", "ep14_1_f_castle_1", Rectangle(-910, -1190, 60));

		// 'Bleakferret_Spear' GenType 1052 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id55", "ep14_1_f_castle_1", Rectangle(-1088, -1461, 60));

		// 'Bleakferret_Spear' GenType 1053 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id56", "ep14_1_f_castle_1", Rectangle(-992, -1557, 60));

		// 'Bleakferret_Spear' GenType 1054 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id57", "ep14_1_f_castle_1", Rectangle(-1029, -1196, 60));

		// 'Bleakferret_Spear' GenType 1055 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id58", "ep14_1_f_castle_1", Rectangle(-1281, -1210, 60));

		// 'Bleakferret_Spear' GenType 1056 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id59", "ep14_1_f_castle_1", Rectangle(-1276, -1019, 60));

		// 'Bleakferret_Spear' GenType 1057 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id60", "ep14_1_f_castle_1", Rectangle(-1485, -982, 60));

		// 'Bleakferret_Spear' GenType 1058 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id61", "ep14_1_f_castle_1", Rectangle(-1467, -1097, 60));

		// 'Bleakferret_Spear' GenType 1059 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id62", "ep14_1_f_castle_1", Rectangle(-1614, -1131, 60));

		// 'Bleakferret_Spear' GenType 1060 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id63", "ep14_1_f_castle_1", Rectangle(-579, -679, 60));

		// 'Bleakferret_Spear' GenType 1061 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id64", "ep14_1_f_castle_1", Rectangle(-507, -799, 60));

		// 'Bleakferret_Spear' GenType 1062 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id65", "ep14_1_f_castle_1", Rectangle(-319, -860, 60));

		// 'Bleakferret_Spear' GenType 1063 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id66", "ep14_1_f_castle_1", Rectangle(-304, -760, 60));

		// 'Bleakferret_Spear' GenType 1064 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id67", "ep14_1_f_castle_1", Rectangle(-214, -707, 60));

		// 'Bleakferret_Spear' GenType 1065 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id68", "ep14_1_f_castle_1", Rectangle(-279, -558, 60));

		// 'Bleakferret_Spear' GenType 1066 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id69", "ep14_1_f_castle_1", Rectangle(-103, -476, 60));

		// 'Bleakferret_Spear' GenType 1067 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id70", "ep14_1_f_castle_1", Rectangle(-196, -338, 60));

		// 'Bleakferret_Spear' GenType 1068 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id71", "ep14_1_f_castle_1", Rectangle(-364, -293, 60));

		// 'Bleakferret_Spear' GenType 1069 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id72", "ep14_1_f_castle_1", Rectangle(82, -363, 60));

		// 'Bleakferret_Spear' GenType 1070 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id73", "ep14_1_f_castle_1", Rectangle(9, -761, 60));

		// 'Bleakferret_Spear' GenType 1071 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id74", "ep14_1_f_castle_1", Rectangle(134, -860, 60));

		// 'Bleakferret_Spear' GenType 1072 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id75", "ep14_1_f_castle_1", Rectangle(209, -756, 60));

		// 'Bleakferret_Spear' GenType 1073 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id76", "ep14_1_f_castle_1", Rectangle(365, -883, 60));

		// 'Bleakferret_Spear' GenType 1074 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id77", "ep14_1_f_castle_1", Rectangle(297, -627, 60));

		// 'Bleakferret_Spear' GenType 1075 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id78", "ep14_1_f_castle_1", Rectangle(315, -427, 60));

		// 'Bleakferret_Spear' GenType 1076 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id79", "ep14_1_f_castle_1", Rectangle(227, -492, 60));

		// 'Bleakferret_Spear' GenType 1077 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id80", "ep14_1_f_castle_1", Rectangle(155, -168, 60));

		// 'Bleakferret_Spear' GenType 1078 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id81", "ep14_1_f_castle_1", Rectangle(423, -755, 60));

		// 'Bleakferret_Spear' GenType 1079 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id82", "ep14_1_f_castle_1", Rectangle(476, -185, 60));

		// 'Bleakferret_Spear' GenType 1080 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id83", "ep14_1_f_castle_1", Rectangle(388, -7, 60));

		// 'Bleakferret_Spear' GenType 1081 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id84", "ep14_1_f_castle_1", Rectangle(-571, 518, 60));

		// 'Bleakferret_Spear' GenType 1082 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id85", "ep14_1_f_castle_1", Rectangle(-449, 334, 60));

		// 'Bleakferret_Spear' GenType 1083 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id86", "ep14_1_f_castle_1", Rectangle(-300, 305, 60));

		// 'Bleakferret_Spear' GenType 1084 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id87", "ep14_1_f_castle_1", Rectangle(-241, 75, 60));

		// 'Bleakferret_Spear' GenType 1085 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id88", "ep14_1_f_castle_1", Rectangle(-155, -61, 60));

		// 'Bleakferret_Spear' GenType 1086 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id89", "ep14_1_f_castle_1", Rectangle(-201, -200, 60));

		// 'Bleakferret_Spear' GenType 1087 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id90", "ep14_1_f_castle_1", Rectangle(478, 224, 60));

		// 'Bleakferret_Spear' GenType 1088 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id91", "ep14_1_f_castle_1", Rectangle(643, 331, 60));

		// 'Bleakferret_Charger' GenType 1089 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id92", "ep14_1_f_castle_1", Rectangle(1041, -236, 60));

		// 'Bleakferret_Charger' GenType 1090 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id93", "ep14_1_f_castle_1", Rectangle(1192, -418, 60));

		// 'Bleakferret_Charger' GenType 1091 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id94", "ep14_1_f_castle_1", Rectangle(1271, -224, 60));

		// 'Bleakferret_Charger' GenType 1092 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id95", "ep14_1_f_castle_1", Rectangle(1307, -884, 60));

		// 'Bleakferret_Charger' GenType 1093 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id96", "ep14_1_f_castle_1", Rectangle(1144, -1036, 60));

		// 'Bleakferret_Charger' GenType 1094 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id97", "ep14_1_f_castle_1", Rectangle(1122, -1298, 60));

		// 'Bleakferret_Charger' GenType 1095 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id98", "ep14_1_f_castle_1", Rectangle(853, -1300, 60));

		// 'Bleakferret_Charger' GenType 1096 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id99", "ep14_1_f_castle_1", Rectangle(884, -1563, 60));

		// 'Bleakferret_Charger' GenType 1097 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id100", "ep14_1_f_castle_1", Rectangle(611, -1632, 60));

		// 'Bleakferret_Charger' GenType 1098 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id101", "ep14_1_f_castle_1", Rectangle(459, -1467, 60));

		// 'Bleakferret_Charger' GenType 1099 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id102", "ep14_1_f_castle_1", Rectangle(401, -1619, 60));

		// 'Bleakferret_Charger' GenType 1100 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id103", "ep14_1_f_castle_1", Rectangle(153, -1614, 60));

		// 'Bleakferret_Charger' GenType 1101 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id104", "ep14_1_f_castle_1", Rectangle(-7, -1483, 60));

		// 'Bleakferret_Charger' GenType 1102 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id105", "ep14_1_f_castle_1", Rectangle(-236, -1607, 60));

		// 'Bleakferret_Charger' GenType 1103 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id106", "ep14_1_f_castle_1", Rectangle(-467, -1647, 60));

		// 'Bleakferret_Charger' GenType 1104 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id107", "ep14_1_f_castle_1", Rectangle(-877, -1446, 60));

		// 'Bleakferret_Charger' GenType 1105 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id108", "ep14_1_f_castle_1", Rectangle(-887, -1277, 60));

		// 'Bleakferret_Charger' GenType 1106 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id109", "ep14_1_f_castle_1", Rectangle(-1022, -1125, 60));

		// 'Bleakferret_Charger' GenType 1107 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id110", "ep14_1_f_castle_1", Rectangle(-1102, -1373, 60));

		// 'Bleakferret_Charger' GenType 1108 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id111", "ep14_1_f_castle_1", Rectangle(-1595, -984, 60));

		// 'Bleakferret_Charger' GenType 1109 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id112", "ep14_1_f_castle_1", Rectangle(-1533, -1176, 60));

		// 'Bleakferret_Charger' GenType 1110 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id113", "ep14_1_f_castle_1", Rectangle(-398, -846, 60));

		// 'Bleakferret_Charger' GenType 1111 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id114", "ep14_1_f_castle_1", Rectangle(-330, -660, 60));

		// 'Bleakferret_Charger' GenType 1112 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id115", "ep14_1_f_castle_1", Rectangle(-150, -776, 60));

		// 'Bleakferret_Charger' GenType 1113 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id116", "ep14_1_f_castle_1", Rectangle(-114, -580, 60));

		// 'Bleakferret_Charger' GenType 1114 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id117", "ep14_1_f_castle_1", Rectangle(-220, -407, 60));

		// 'Bleakferret_Charger' GenType 1115 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id118", "ep14_1_f_castle_1", Rectangle(-28, -395, 60));

		// 'Bleakferret_Charger' GenType 1116 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id119", "ep14_1_f_castle_1", Rectangle(115, -734, 60));

		// 'Bleakferret_Charger' GenType 1117 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id120", "ep14_1_f_castle_1", Rectangle(325, -790, 60));

		// 'Bleakferret_Charger' GenType 1118 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id121", "ep14_1_f_castle_1", Rectangle(219, -389, 60));

		// 'Bleakferret_Charger' GenType 1119 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id122", "ep14_1_f_castle_1", Rectangle(354, -322, 60));

		// 'Bleakferret_Charger' GenType 1120 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id123", "ep14_1_f_castle_1", Rectangle(306, -31, 60));

		// 'Bleakferret_Charger' GenType 1121 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id124", "ep14_1_f_castle_1", Rectangle(277, 584, 60));

		// 'Bleakferret_Charger' GenType 1122 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id125", "ep14_1_f_castle_1", Rectangle(37, 308, 60));

		// 'Bleakferret_Charger' GenType 1123 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id126", "ep14_1_f_castle_1", Rectangle(562, 275, 60));

		// 'Bleakferret_Charger' GenType 1124 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id127", "ep14_1_f_castle_1", Rectangle(996, 474, 60));

		// 'Bleakferret_Charger' GenType 1125 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id128", "ep14_1_f_castle_1", Rectangle(844, 572, 60));

		// 'Bleakferret_Charger' GenType 1126 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id129", "ep14_1_f_castle_1", Rectangle(1014, 600, 60));

		// 'Bleakferret_Charger' GenType 1127 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id130", "ep14_1_f_castle_1", Rectangle(1004, 1236, 60));

		// 'Bleakferret_Charger' GenType 1128 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id131", "ep14_1_f_castle_1", Rectangle(1190, 1173, 60));

		// 'Bleakferret_Charger' GenType 1129 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id132", "ep14_1_f_castle_1", Rectangle(1284, 1264, 60));

		// 'Bleakferret_Charger' GenType 1130 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id133", "ep14_1_f_castle_1", Rectangle(1113, 1363, 60));

		// 'Bleakferret_Charger' GenType 1131 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id134", "ep14_1_f_castle_1", Rectangle(195, 1402, 60));

		// 'Bleakferret_Charger' GenType 1132 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id135", "ep14_1_f_castle_1", Rectangle(86, 1311, 60));

		// 'Bleakferret_Charger' GenType 1133 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id136", "ep14_1_f_castle_1", Rectangle(256, 1152, 60));

		// 'Bleakferret_Cannon' GenType 1134 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id137", "ep14_1_f_castle_1", Rectangle(1219, -937, 60));

		// 'Bleakferret_Cannon' GenType 1135 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id138", "ep14_1_f_castle_1", Rectangle(1038, -1302, 60));

		// 'Bleakferret_Cannon' GenType 1136 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id139", "ep14_1_f_castle_1", Rectangle(781, -1509, 60));

		// 'Bleakferret_Cannon' GenType 1137 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id140", "ep14_1_f_castle_1", Rectangle(548, -1550, 60));

		// 'Bleakferret_Cannon' GenType 1138 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id141", "ep14_1_f_castle_1", Rectangle(285, -1630, 60));

		// 'Bleakferret_Cannon' GenType 1139 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id142", "ep14_1_f_castle_1", Rectangle(-111, -1495, 60));

		// 'Bleakferret_Cannon' GenType 1140 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id143", "ep14_1_f_castle_1", Rectangle(-958, -1474, 60));

		// 'Bleakferret_Cannon' GenType 1141 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id144", "ep14_1_f_castle_1", Rectangle(-808, -1196, 60));

		// 'Bleakferret_Cannon' GenType 1142 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id145", "ep14_1_f_castle_1", Rectangle(-1534, -1095, 60));

		// 'Bleakferret_Cannon' GenType 1143 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id146", "ep14_1_f_castle_1", Rectangle(-411, -730, 60));

		// 'Bleakferret_Cannon' GenType 1144 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id147", "ep14_1_f_castle_1", Rectangle(-275, -467, 60));

		// 'Bleakferret_Cannon' GenType 1145 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id148", "ep14_1_f_castle_1", Rectangle(-88, -704, 60));

		// 'Bleakferret_Cannon' GenType 1146 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id149", "ep14_1_f_castle_1", Rectangle(141, -283, 60));

		// 'Bleakferret_Cannon' GenType 1147 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id150", "ep14_1_f_castle_1", Rectangle(233, -667, 60));

		// 'Bleakferret_Cannon' GenType 1148 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id151", "ep14_1_f_castle_1", Rectangle(266, -895, 60));

		// 'Bleakferret_Cannon' GenType 1149 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id152", "ep14_1_f_castle_1", Rectangle(468, -82, 60));

		// 'Bleakferret_Cannon' GenType 1150 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id153", "ep14_1_f_castle_1", Rectangle(144, 468, 60));

		// 'Bleakferret_Cannon' GenType 1151 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id154", "ep14_1_f_castle_1", Rectangle(395, 226, 60));

		// 'Bleakferret_Cannon' GenType 1152 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id155", "ep14_1_f_castle_1", Rectangle(809, 408, 60));

		// 'Bleakferret_Cannon' GenType 1153 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id156", "ep14_1_f_castle_1", Rectangle(1101, 624, 60));

		// 'Bleakferret_Cannon' GenType 1154 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id157", "ep14_1_f_castle_1", Rectangle(889, 1305, 60));

		// 'Bleakferret_Cannon' GenType 1155 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id158", "ep14_1_f_castle_1", Rectangle(1238, 1326, 60));

		// 'Bleakferret_Cannon' GenType 1156 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id159", "ep14_1_f_castle_1", Rectangle(165, 1265, 60));

		// 'Bleakferret_Cannon' GenType 1157 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id160", "ep14_1_f_castle_1", Rectangle(275, 1408, 60));

		// 'Bleakferret_Cannon' GenType 1158 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id161", "ep14_1_f_castle_1", Rectangle(-428, -352, 60));

		// 'Bleakferret_Charger' GenType 1159 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id162", "ep14_1_f_castle_1", Rectangle(-199, -119, 60));

		// 'Bleakferret_Charger' GenType 1160 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id163", "ep14_1_f_castle_1", Rectangle(-131, 58, 60));

		// 'Bleakferret_Charger' GenType 1161 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id164", "ep14_1_f_castle_1", Rectangle(-378, 288, 60));

		// 'Bleakferret_Charger' GenType 1162 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id165", "ep14_1_f_castle_1", Rectangle(-574, 630, 60));

		// 'Bleakferret_Cannon' GenType 1163 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id166", "ep14_1_f_castle_1", Rectangle(-526, 427, 60));

		// 'Bleakferret_Cannon' GenType 1164 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id167", "ep14_1_f_castle_1", Rectangle(-174, -1, 60));

		// 'Bleakferret_Cannon' GenType 1165 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id168", "ep14_1_f_castle_1", Rectangle(-574, -776, 60));

		// 'Bleakferret_Cannon' GenType 1166 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id169", "ep14_1_f_castle_1", Rectangle(1147, -168, 60));

		// 'Bleakferret_Cannon' GenType 1167 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id170", "ep14_1_f_castle_1", Rectangle(1072, -413, 60));

		// 'Bleakferret_Charger' GenType 1168 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id171", "ep14_1_f_castle_1", Rectangle(518, -1131, 60));

		// 'Bleakferret_Charger' GenType 1169 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id172", "ep14_1_f_castle_1", Rectangle(647, -1202, 60));

		// 'Bleakferret_Charger' GenType 1170 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id173", "ep14_1_f_castle_1", Rectangle(666, -261, 60));

		// 'Bleakferret_Charger' GenType 1171 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id174", "ep14_1_f_castle_1", Rectangle(794, -316, 60));

		// 'Bleakferret_Charger' GenType 1172 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id175", "ep14_1_f_castle_1", Rectangle(1106, 229, 60));

		// 'Bleakferret_Charger' GenType 1173 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id176", "ep14_1_f_castle_1", Rectangle(1157, 101, 60));

		// 'Bleakferret_Cannon' GenType 1174 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id177", "ep14_1_f_castle_1", Rectangle(1034, 888, 60));

		// 'Bleakferret_Spear' GenType 1175 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id178", "ep14_1_f_castle_1", Rectangle(118, 326, 60));

		// 'Bleakferret_Spear' GenType 1176 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id179", "ep14_1_f_castle_1", Rectangle(232, 526, 60));
	}
}
