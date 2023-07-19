//--- Melia Script -----------------------------------------------------------
// ep14_1_f_castle_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Delmore Hamlet' map.
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

		AddSpawner("ep14_1_f_castle_1.Id1", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id2", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id3", MonsterId.Rootcrystal_05, 12, 16, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id4", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id5", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id6", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id7", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id8", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id9", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id10", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id11", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id12", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id13", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id14", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id15", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id16", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id17", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id18", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id19", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id20", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id21", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id22", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id23", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id24", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id25", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id26", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id27", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id28", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id29", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id30", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id31", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id32", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id33", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id34", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id35", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id36", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id37", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id38", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id39", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id40", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id41", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id42", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id43", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id44", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id45", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id46", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id47", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id48", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id49", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id50", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id51", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id52", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id53", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id54", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id55", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id56", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id57", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id58", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id59", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id60", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id61", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id62", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id63", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id64", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id65", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id66", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id67", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id68", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id69", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id70", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id71", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id72", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id73", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id74", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id75", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id76", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id77", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id78", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id79", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id80", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id81", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id82", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id83", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id84", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id85", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id86", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id87", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id88", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id89", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id90", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id91", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id92", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id93", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id94", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id95", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id96", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id97", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id98", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id99", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id100", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id101", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id102", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id103", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id104", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id105", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id106", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id107", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id108", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id109", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id110", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id111", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id112", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id113", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id114", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id115", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id116", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id117", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id118", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id119", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id120", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id121", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id122", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id123", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id124", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id125", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id126", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id127", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id128", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id129", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id130", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id131", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id132", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id133", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id134", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id135", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id136", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id137", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id138", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id139", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id140", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id141", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id142", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id143", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id144", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id145", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id146", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id147", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id148", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id149", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id150", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id151", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id152", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id153", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id154", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id155", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id156", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id157", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id158", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id159", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id160", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id161", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id162", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id163", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id164", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id165", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id166", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id167", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id168", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id169", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id170", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id171", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id172", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id173", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id174", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id175", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id176", MonsterId.Bleakferret_Charger, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id177", MonsterId.Bleakferret_Cannon, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id178", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_1.Id179", MonsterId.Bleakferret_Spear, 1, 1, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Bleakferret_Spear' GenType 36 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id1", "ep14_1_f_castle_1", Rectangle(40.04773, 550.1831, 60));

		// 'Bleakferret_Spear' GenType 38 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id2", "ep14_1_f_castle_1", Rectangle(284.12564, 346.27957, 60));

		// 'Rootcrystal_05' GenType 45 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(1230.4673, -712.11475, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(1052.3915, -192.62265, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(956.2183, 558.0006, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(998.7494, 1265.0426, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(116.73933, 1342.7231, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(167.38347, 403.64838, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(-582.3826, 546.9892, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(228.87535, -314.9853, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(308.77307, -888.6566, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(-337.98203, -579.6618, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(-895.7222, -1285.5216, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(-1568.1907, -1117.0417, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(38.58274, -1500.0516, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(581.95276, -1615.9307, 100));
		AddSpawnPoint("ep14_1_f_castle_1.Id3", "ep14_1_f_castle_1", Rectangle(1065.5647, -1275.543, 100));

		// 'Bleakferret_Spear' GenType 1001 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id4", "ep14_1_f_castle_1", Rectangle(859.62463, 458.31354, 60));

		// 'Bleakferret_Spear' GenType 1002 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id5", "ep14_1_f_castle_1", Rectangle(938.6028, 568.43945, 60));

		// 'Bleakferret_Spear' GenType 1003 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id6", "ep14_1_f_castle_1", Rectangle(853.1461, 675.32654, 60));

		// 'Bleakferret_Spear' GenType 1004 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id7", "ep14_1_f_castle_1", Rectangle(1084.6687, 424.82526, 60));

		// 'Bleakferret_Spear' GenType 1005 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id8", "ep14_1_f_castle_1", Rectangle(1021.3495, 694.7182, 60));

		// 'Bleakferret_Spear' GenType 1006 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id9", "ep14_1_f_castle_1", Rectangle(1059.1984, 1135.6554, 60));

		// 'Bleakferret_Spear' GenType 1007 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id10", "ep14_1_f_castle_1", Rectangle(1095.3544, 1238.2821, 60));

		// 'Bleakferret_Spear' GenType 1008 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id11", "ep14_1_f_castle_1", Rectangle(1019.827, 1321.7037, 60));

		// 'Bleakferret_Spear' GenType 1009 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id12", "ep14_1_f_castle_1", Rectangle(971.86554, 1417.2391, 60));

		// 'Bleakferret_Spear' GenType 1010 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id13", "ep14_1_f_castle_1", Rectangle(893.27625, 1370.1019, 60));

		// 'Bleakferret_Spear' GenType 1011 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id14", "ep14_1_f_castle_1", Rectangle(885.754, 1231.6566, 60));

		// 'Bleakferret_Spear' GenType 1012 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id15", "ep14_1_f_castle_1", Rectangle(1170.4855, 1284.702, 60));

		// 'Bleakferret_Spear' GenType 1013 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id16", "ep14_1_f_castle_1", Rectangle(215.68697, 1247.7775, 60));

		// 'Bleakferret_Spear' GenType 1014 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id17", "ep14_1_f_castle_1", Rectangle(178.12898, 1158.9935, 60));

		// 'Bleakferret_Spear' GenType 1015 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id18", "ep14_1_f_castle_1", Rectangle(60.88967, 1259.0234, 60));

		// 'Bleakferret_Spear' GenType 1016 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id19", "ep14_1_f_castle_1", Rectangle(158.85649, 1341.2058, 60));

		// 'Bleakferret_Spear' GenType 1017 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id20", "ep14_1_f_castle_1", Rectangle(34.07369, 1407.6189, 60));

		// 'Bleakferret_Spear' GenType 1018 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id21", "ep14_1_f_castle_1", Rectangle(131.50446, 1441.4841, 60));

		// 'Bleakferret_Spear' GenType 1019 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id22", "ep14_1_f_castle_1", Rectangle(286.75192, 1478.6699, 60));

		// 'Bleakferret_Spear' GenType 1020 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id23", "ep14_1_f_castle_1", Rectangle(206.78711, 274.26895, 60));

		// 'Bleakferret_Spear' GenType 1021 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id24", "ep14_1_f_castle_1", Rectangle(318.352, 467.14297, 60));

		// 'Bleakferret_Spear' GenType 1022 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id25", "ep14_1_f_castle_1", Rectangle(143.87773, 605.6023, 60));

		// 'Bleakferret_Spear' GenType 1023 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id26", "ep14_1_f_castle_1", Rectangle(-2.2703342, 440.5339, 60));

		// 'Bleakferret_Spear' GenType 1024 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id27", "ep14_1_f_castle_1", Rectangle(994.1481, -340.3577, 60));

		// 'Bleakferret_Spear' GenType 1025 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id28", "ep14_1_f_castle_1", Rectangle(1202.574, -506.00208, 60));

		// 'Bleakferret_Spear' GenType 1026 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id29", "ep14_1_f_castle_1", Rectangle(1276.3881, -313.325, 60));

		// 'Bleakferret_Spear' GenType 1027 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id30", "ep14_1_f_castle_1", Rectangle(1018.0166, -122.01773, 60));

		// 'Bleakferret_Spear' GenType 1028 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id31", "ep14_1_f_castle_1", Rectangle(1167.433, -307.14804, 60));

		// 'Bleakferret_Spear' GenType 1029 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id32", "ep14_1_f_castle_1", Rectangle(1317.4847, -763.8488, 60));

		// 'Bleakferret_Spear' GenType 1030 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id33", "ep14_1_f_castle_1", Rectangle(1190.0475, -834.21216, 60));

		// 'Bleakferret_Spear' GenType 1031 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id34", "ep14_1_f_castle_1", Rectangle(1263.3536, -1059.1769, 60));

		// 'Bleakferret_Spear' GenType 1032 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id35", "ep14_1_f_castle_1", Rectangle(1117.8446, -1170.4999, 60));

		// 'Bleakferret_Spear' GenType 1033 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id36", "ep14_1_f_castle_1", Rectangle(1079.1072, -1412.6138, 60));

		// 'Bleakferret_Spear' GenType 1034 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id37", "ep14_1_f_castle_1", Rectangle(986.7377, -1535.8372, 60));

		// 'Bleakferret_Spear' GenType 1035 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id38", "ep14_1_f_castle_1", Rectangle(785.6858, -1389.5571, 60));

		// 'Bleakferret_Spear' GenType 1036 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id39", "ep14_1_f_castle_1", Rectangle(955.88446, -1394.3167, 60));

		// 'Bleakferret_Spear' GenType 1037 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id40", "ep14_1_f_castle_1", Rectangle(931.416, -1186.5764, 60));

		// 'Bleakferret_Spear' GenType 1038 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id41", "ep14_1_f_castle_1", Rectangle(748.31244, -1642.4814, 60));

		// 'Bleakferret_Spear' GenType 1039 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id42", "ep14_1_f_castle_1", Rectangle(615.75494, -1447.405, 60));

		// 'Bleakferret_Spear' GenType 1040 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id43", "ep14_1_f_castle_1", Rectangle(501.3138, -1687.2107, 60));

		// 'Bleakferret_Spear' GenType 1041 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id44", "ep14_1_f_castle_1", Rectangle(147.85373, -1751.5916, 60));

		// 'Bleakferret_Spear' GenType 1042 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id45", "ep14_1_f_castle_1", Rectangle(221.59795, -1523.4473, 60));

		// 'Bleakferret_Spear' GenType 1043 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id46", "ep14_1_f_castle_1", Rectangle(97.78143, -1487.5344, 60));

		// 'Bleakferret_Spear' GenType 1044 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id47", "ep14_1_f_castle_1", Rectangle(-117.89193, -1627.3185, 60));

		// 'Bleakferret_Spear' GenType 1045 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id48", "ep14_1_f_castle_1", Rectangle(-227.17752, -1506.9722, 60));

		// 'Bleakferret_Spear' GenType 1046 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id49", "ep14_1_f_castle_1", Rectangle(-324.34912, -1646.6643, 60));

		// 'Bleakferret_Spear' GenType 1047 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id50", "ep14_1_f_castle_1", Rectangle(-662.6627, -1598.6569, 60));

		// 'Bleakferret_Spear' GenType 1048 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id51", "ep14_1_f_castle_1", Rectangle(-875.6135, -1535.1688, 60));

		// 'Bleakferret_Spear' GenType 1049 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id52", "ep14_1_f_castle_1", Rectangle(-835.27985, -1378.4679, 60));

		// 'Bleakferret_Spear' GenType 1050 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id53", "ep14_1_f_castle_1", Rectangle(-803.72034, -1273.8304, 60));

		// 'Bleakferret_Spear' GenType 1051 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id54", "ep14_1_f_castle_1", Rectangle(-910.9743, -1190.0167, 60));

		// 'Bleakferret_Spear' GenType 1052 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id55", "ep14_1_f_castle_1", Rectangle(-1088.3202, -1461.8163, 60));

		// 'Bleakferret_Spear' GenType 1053 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id56", "ep14_1_f_castle_1", Rectangle(-992.9796, -1557.8003, 60));

		// 'Bleakferret_Spear' GenType 1054 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id57", "ep14_1_f_castle_1", Rectangle(-1029.1704, -1196.1672, 60));

		// 'Bleakferret_Spear' GenType 1055 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id58", "ep14_1_f_castle_1", Rectangle(-1281.7693, -1210.0764, 60));

		// 'Bleakferret_Spear' GenType 1056 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id59", "ep14_1_f_castle_1", Rectangle(-1276.0652, -1019.7979, 60));

		// 'Bleakferret_Spear' GenType 1057 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id60", "ep14_1_f_castle_1", Rectangle(-1485.9889, -982.04596, 60));

		// 'Bleakferret_Spear' GenType 1058 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id61", "ep14_1_f_castle_1", Rectangle(-1467.2914, -1097.257, 60));

		// 'Bleakferret_Spear' GenType 1059 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id62", "ep14_1_f_castle_1", Rectangle(-1614.521, -1131.2483, 60));

		// 'Bleakferret_Spear' GenType 1060 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id63", "ep14_1_f_castle_1", Rectangle(-579.94794, -679.21954, 60));

		// 'Bleakferret_Spear' GenType 1061 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id64", "ep14_1_f_castle_1", Rectangle(-507.23257, -799.63354, 60));

		// 'Bleakferret_Spear' GenType 1062 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id65", "ep14_1_f_castle_1", Rectangle(-319.82117, -860.98016, 60));

		// 'Bleakferret_Spear' GenType 1063 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id66", "ep14_1_f_castle_1", Rectangle(-304.00632, -760.18536, 60));

		// 'Bleakferret_Spear' GenType 1064 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id67", "ep14_1_f_castle_1", Rectangle(-214.58615, -707.25354, 60));

		// 'Bleakferret_Spear' GenType 1065 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id68", "ep14_1_f_castle_1", Rectangle(-279.2732, -558.07043, 60));

		// 'Bleakferret_Spear' GenType 1066 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id69", "ep14_1_f_castle_1", Rectangle(-103.91898, -476.2168, 60));

		// 'Bleakferret_Spear' GenType 1067 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id70", "ep14_1_f_castle_1", Rectangle(-196.25615, -338.25037, 60));

		// 'Bleakferret_Spear' GenType 1068 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id71", "ep14_1_f_castle_1", Rectangle(-364.5158, -293.67447, 60));

		// 'Bleakferret_Spear' GenType 1069 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id72", "ep14_1_f_castle_1", Rectangle(82.29755, -363.9312, 60));

		// 'Bleakferret_Spear' GenType 1070 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id73", "ep14_1_f_castle_1", Rectangle(9.692907, -761.1664, 60));

		// 'Bleakferret_Spear' GenType 1071 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id74", "ep14_1_f_castle_1", Rectangle(134.41743, -860.71454, 60));

		// 'Bleakferret_Spear' GenType 1072 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id75", "ep14_1_f_castle_1", Rectangle(209.53867, -756.8538, 60));

		// 'Bleakferret_Spear' GenType 1073 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id76", "ep14_1_f_castle_1", Rectangle(365.67902, -883.71906, 60));

		// 'Bleakferret_Spear' GenType 1074 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id77", "ep14_1_f_castle_1", Rectangle(297.20834, -627.21313, 60));

		// 'Bleakferret_Spear' GenType 1075 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id78", "ep14_1_f_castle_1", Rectangle(315.06927, -427.31116, 60));

		// 'Bleakferret_Spear' GenType 1076 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id79", "ep14_1_f_castle_1", Rectangle(227.05147, -492.3796, 60));

		// 'Bleakferret_Spear' GenType 1077 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id80", "ep14_1_f_castle_1", Rectangle(155.68857, -168.35338, 60));

		// 'Bleakferret_Spear' GenType 1078 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id81", "ep14_1_f_castle_1", Rectangle(423.34952, -755.2111, 60));

		// 'Bleakferret_Spear' GenType 1079 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id82", "ep14_1_f_castle_1", Rectangle(476.76505, -185.52838, 60));

		// 'Bleakferret_Spear' GenType 1080 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id83", "ep14_1_f_castle_1", Rectangle(388.17566, -7.26038, 60));

		// 'Bleakferret_Spear' GenType 1081 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id84", "ep14_1_f_castle_1", Rectangle(-571.0076, 518.80743, 60));

		// 'Bleakferret_Spear' GenType 1082 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id85", "ep14_1_f_castle_1", Rectangle(-449.1565, 334.5013, 60));

		// 'Bleakferret_Spear' GenType 1083 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id86", "ep14_1_f_castle_1", Rectangle(-300.5313, 305.5884, 60));

		// 'Bleakferret_Spear' GenType 1084 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id87", "ep14_1_f_castle_1", Rectangle(-241.67314, 75.83147, 60));

		// 'Bleakferret_Spear' GenType 1085 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id88", "ep14_1_f_castle_1", Rectangle(-155.71907, -61.938446, 60));

		// 'Bleakferret_Spear' GenType 1086 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id89", "ep14_1_f_castle_1", Rectangle(-201.22906, -200.3449, 60));

		// 'Bleakferret_Spear' GenType 1087 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id90", "ep14_1_f_castle_1", Rectangle(478.3713, 224.65862, 60));

		// 'Bleakferret_Spear' GenType 1088 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id91", "ep14_1_f_castle_1", Rectangle(643.10724, 331.79163, 60));

		// 'Bleakferret_Charger' GenType 1089 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id92", "ep14_1_f_castle_1", Rectangle(1041.8412, -236.97853, 60));

		// 'Bleakferret_Charger' GenType 1090 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id93", "ep14_1_f_castle_1", Rectangle(1192.3173, -418.34622, 60));

		// 'Bleakferret_Charger' GenType 1091 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id94", "ep14_1_f_castle_1", Rectangle(1271.1475, -224.21138, 60));

		// 'Bleakferret_Charger' GenType 1092 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id95", "ep14_1_f_castle_1", Rectangle(1307.6984, -884.14526, 60));

		// 'Bleakferret_Charger' GenType 1093 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id96", "ep14_1_f_castle_1", Rectangle(1144.1295, -1036.7837, 60));

		// 'Bleakferret_Charger' GenType 1094 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id97", "ep14_1_f_castle_1", Rectangle(1122.1494, -1298.1676, 60));

		// 'Bleakferret_Charger' GenType 1095 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id98", "ep14_1_f_castle_1", Rectangle(853.0419, -1300.0239, 60));

		// 'Bleakferret_Charger' GenType 1096 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id99", "ep14_1_f_castle_1", Rectangle(884.2514, -1563.0159, 60));

		// 'Bleakferret_Charger' GenType 1097 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id100", "ep14_1_f_castle_1", Rectangle(611.8474, -1632.3475, 60));

		// 'Bleakferret_Charger' GenType 1098 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id101", "ep14_1_f_castle_1", Rectangle(459.85153, -1467.2015, 60));

		// 'Bleakferret_Charger' GenType 1099 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id102", "ep14_1_f_castle_1", Rectangle(401.15494, -1619.731, 60));

		// 'Bleakferret_Charger' GenType 1100 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id103", "ep14_1_f_castle_1", Rectangle(153.41292, -1614.3921, 60));

		// 'Bleakferret_Charger' GenType 1101 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id104", "ep14_1_f_castle_1", Rectangle(-7.2704086, -1483.034, 60));

		// 'Bleakferret_Charger' GenType 1102 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id105", "ep14_1_f_castle_1", Rectangle(-236.70325, -1607.478, 60));

		// 'Bleakferret_Charger' GenType 1103 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id106", "ep14_1_f_castle_1", Rectangle(-467.6341, -1647.4344, 60));

		// 'Bleakferret_Charger' GenType 1104 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id107", "ep14_1_f_castle_1", Rectangle(-877.8214, -1446.4731, 60));

		// 'Bleakferret_Charger' GenType 1105 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id108", "ep14_1_f_castle_1", Rectangle(-887.4941, -1277.7773, 60));

		// 'Bleakferret_Charger' GenType 1106 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id109", "ep14_1_f_castle_1", Rectangle(-1022.9841, -1125.3375, 60));

		// 'Bleakferret_Charger' GenType 1107 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id110", "ep14_1_f_castle_1", Rectangle(-1102.0487, -1373.2739, 60));

		// 'Bleakferret_Charger' GenType 1108 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id111", "ep14_1_f_castle_1", Rectangle(-1595.5968, -984.5511, 60));

		// 'Bleakferret_Charger' GenType 1109 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id112", "ep14_1_f_castle_1", Rectangle(-1533.6476, -1176.6182, 60));

		// 'Bleakferret_Charger' GenType 1110 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id113", "ep14_1_f_castle_1", Rectangle(-398.025, -846.212, 60));

		// 'Bleakferret_Charger' GenType 1111 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id114", "ep14_1_f_castle_1", Rectangle(-330.83505, -660.14545, 60));

		// 'Bleakferret_Charger' GenType 1112 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id115", "ep14_1_f_castle_1", Rectangle(-150.9039, -776.1352, 60));

		// 'Bleakferret_Charger' GenType 1113 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id116", "ep14_1_f_castle_1", Rectangle(-114.52179, -580.00244, 60));

		// 'Bleakferret_Charger' GenType 1114 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id117", "ep14_1_f_castle_1", Rectangle(-220.57681, -407.25827, 60));

		// 'Bleakferret_Charger' GenType 1115 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id118", "ep14_1_f_castle_1", Rectangle(-28.088223, -395.8028, 60));

		// 'Bleakferret_Charger' GenType 1116 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id119", "ep14_1_f_castle_1", Rectangle(115.61575, -734.8005, 60));

		// 'Bleakferret_Charger' GenType 1117 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id120", "ep14_1_f_castle_1", Rectangle(325.39606, -790.5753, 60));

		// 'Bleakferret_Charger' GenType 1118 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id121", "ep14_1_f_castle_1", Rectangle(219.75774, -389.08105, 60));

		// 'Bleakferret_Charger' GenType 1119 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id122", "ep14_1_f_castle_1", Rectangle(354.48016, -322.69864, 60));

		// 'Bleakferret_Charger' GenType 1120 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id123", "ep14_1_f_castle_1", Rectangle(306.39545, -31.147125, 60));

		// 'Bleakferret_Charger' GenType 1121 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id124", "ep14_1_f_castle_1", Rectangle(277.49533, 584.93317, 60));

		// 'Bleakferret_Charger' GenType 1122 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id125", "ep14_1_f_castle_1", Rectangle(37.29596, 308.3028, 60));

		// 'Bleakferret_Charger' GenType 1123 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id126", "ep14_1_f_castle_1", Rectangle(562.9947, 275.32764, 60));

		// 'Bleakferret_Charger' GenType 1124 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id127", "ep14_1_f_castle_1", Rectangle(996.9712, 474.94116, 60));

		// 'Bleakferret_Charger' GenType 1125 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id128", "ep14_1_f_castle_1", Rectangle(844.5282, 572.00604, 60));

		// 'Bleakferret_Charger' GenType 1126 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id129", "ep14_1_f_castle_1", Rectangle(1014.7935, 600.21423, 60));

		// 'Bleakferret_Charger' GenType 1127 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id130", "ep14_1_f_castle_1", Rectangle(1004.8169, 1236.1046, 60));

		// 'Bleakferret_Charger' GenType 1128 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id131", "ep14_1_f_castle_1", Rectangle(1190.9978, 1173.1626, 60));

		// 'Bleakferret_Charger' GenType 1129 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id132", "ep14_1_f_castle_1", Rectangle(1284.5012, 1264.7004, 60));

		// 'Bleakferret_Charger' GenType 1130 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id133", "ep14_1_f_castle_1", Rectangle(1113.1232, 1363.9629, 60));

		// 'Bleakferret_Charger' GenType 1131 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id134", "ep14_1_f_castle_1", Rectangle(195.57956, 1402.1932, 60));

		// 'Bleakferret_Charger' GenType 1132 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id135", "ep14_1_f_castle_1", Rectangle(86.24589, 1311.719, 60));

		// 'Bleakferret_Charger' GenType 1133 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id136", "ep14_1_f_castle_1", Rectangle(256.40964, 1152.3031, 60));

		// 'Bleakferret_Cannon' GenType 1134 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id137", "ep14_1_f_castle_1", Rectangle(1219.287, -937.8217, 60));

		// 'Bleakferret_Cannon' GenType 1135 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id138", "ep14_1_f_castle_1", Rectangle(1038.1965, -1302.039, 60));

		// 'Bleakferret_Cannon' GenType 1136 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id139", "ep14_1_f_castle_1", Rectangle(781.81085, -1509.0095, 60));

		// 'Bleakferret_Cannon' GenType 1137 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id140", "ep14_1_f_castle_1", Rectangle(548.7079, -1550.0065, 60));

		// 'Bleakferret_Cannon' GenType 1138 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id141", "ep14_1_f_castle_1", Rectangle(285.6648, -1630.1754, 60));

		// 'Bleakferret_Cannon' GenType 1139 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id142", "ep14_1_f_castle_1", Rectangle(-111.29631, -1495.9203, 60));

		// 'Bleakferret_Cannon' GenType 1140 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id143", "ep14_1_f_castle_1", Rectangle(-958.56274, -1474.8539, 60));

		// 'Bleakferret_Cannon' GenType 1141 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id144", "ep14_1_f_castle_1", Rectangle(-808.691, -1196.4946, 60));

		// 'Bleakferret_Cannon' GenType 1142 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id145", "ep14_1_f_castle_1", Rectangle(-1534.9956, -1095.6046, 60));

		// 'Bleakferret_Cannon' GenType 1143 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id146", "ep14_1_f_castle_1", Rectangle(-411.8406, -730.69293, 60));

		// 'Bleakferret_Cannon' GenType 1144 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id147", "ep14_1_f_castle_1", Rectangle(-275.55618, -467.7801, 60));

		// 'Bleakferret_Cannon' GenType 1145 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id148", "ep14_1_f_castle_1", Rectangle(-88.85388, -704.6981, 60));

		// 'Bleakferret_Cannon' GenType 1146 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id149", "ep14_1_f_castle_1", Rectangle(141.4224, -283.32806, 60));

		// 'Bleakferret_Cannon' GenType 1147 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id150", "ep14_1_f_castle_1", Rectangle(233.05687, -667.2046, 60));

		// 'Bleakferret_Cannon' GenType 1148 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id151", "ep14_1_f_castle_1", Rectangle(266.26562, -895.6103, 60));

		// 'Bleakferret_Cannon' GenType 1149 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id152", "ep14_1_f_castle_1", Rectangle(468.89514, -82.42397, 60));

		// 'Bleakferret_Cannon' GenType 1150 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id153", "ep14_1_f_castle_1", Rectangle(144.28302, 468.39966, 60));

		// 'Bleakferret_Cannon' GenType 1151 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id154", "ep14_1_f_castle_1", Rectangle(395.4966, 226.39859, 60));

		// 'Bleakferret_Cannon' GenType 1152 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id155", "ep14_1_f_castle_1", Rectangle(809.5432, 408.6405, 60));

		// 'Bleakferret_Cannon' GenType 1153 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id156", "ep14_1_f_castle_1", Rectangle(1101.4385, 624.70483, 60));

		// 'Bleakferret_Cannon' GenType 1154 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id157", "ep14_1_f_castle_1", Rectangle(889.64886, 1305.0042, 60));

		// 'Bleakferret_Cannon' GenType 1155 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id158", "ep14_1_f_castle_1", Rectangle(1238.543, 1326.3016, 60));

		// 'Bleakferret_Cannon' GenType 1156 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id159", "ep14_1_f_castle_1", Rectangle(165.21085, 1265.9612, 60));

		// 'Bleakferret_Cannon' GenType 1157 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id160", "ep14_1_f_castle_1", Rectangle(275.5458, 1408.7358, 60));

		// 'Bleakferret_Cannon' GenType 1158 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id161", "ep14_1_f_castle_1", Rectangle(-428.71506, -352.63278, 60));

		// 'Bleakferret_Charger' GenType 1159 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id162", "ep14_1_f_castle_1", Rectangle(-199.89551, -119.03986, 60));

		// 'Bleakferret_Charger' GenType 1160 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id163", "ep14_1_f_castle_1", Rectangle(-131.32407, 58.318893, 60));

		// 'Bleakferret_Charger' GenType 1161 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id164", "ep14_1_f_castle_1", Rectangle(-378.50388, 288.7855, 60));

		// 'Bleakferret_Charger' GenType 1162 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id165", "ep14_1_f_castle_1", Rectangle(-574.589, 630.0776, 60));

		// 'Bleakferret_Cannon' GenType 1163 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id166", "ep14_1_f_castle_1", Rectangle(-526.63727, 427.89026, 60));

		// 'Bleakferret_Cannon' GenType 1164 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id167", "ep14_1_f_castle_1", Rectangle(-174.21672, -1.4752865, 60));

		// 'Bleakferret_Cannon' GenType 1165 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id168", "ep14_1_f_castle_1", Rectangle(-574.9172, -776.02136, 60));

		// 'Bleakferret_Cannon' GenType 1166 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id169", "ep14_1_f_castle_1", Rectangle(1147.6517, -168.5414, 60));

		// 'Bleakferret_Cannon' GenType 1167 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id170", "ep14_1_f_castle_1", Rectangle(1072.1007, -413.9625, 60));

		// 'Bleakferret_Charger' GenType 1168 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id171", "ep14_1_f_castle_1", Rectangle(518.3104, -1131.7302, 60));

		// 'Bleakferret_Charger' GenType 1169 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id172", "ep14_1_f_castle_1", Rectangle(647.45856, -1202.2076, 60));

		// 'Bleakferret_Charger' GenType 1170 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id173", "ep14_1_f_castle_1", Rectangle(666.00867, -261.63834, 60));

		// 'Bleakferret_Charger' GenType 1171 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id174", "ep14_1_f_castle_1", Rectangle(794.69525, -316.8605, 60));

		// 'Bleakferret_Charger' GenType 1172 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id175", "ep14_1_f_castle_1", Rectangle(1106.5504, 229.79768, 60));

		// 'Bleakferret_Charger' GenType 1173 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id176", "ep14_1_f_castle_1", Rectangle(1157.9702, 101.32238, 60));

		// 'Bleakferret_Cannon' GenType 1174 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id177", "ep14_1_f_castle_1", Rectangle(1034.457, 888.92426, 60));

		// 'Bleakferret_Spear' GenType 1175 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id178", "ep14_1_f_castle_1", Rectangle(118.0188, 326.03842, 60));

		// 'Bleakferret_Spear' GenType 1176 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_1.Id179", "ep14_1_f_castle_1", Rectangle(232.23804, 526.8306, 60));
	}
}
