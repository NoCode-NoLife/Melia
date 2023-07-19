//--- Melia Script -----------------------------------------------------------
// ep14_1_f_castle_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Delmore Manor' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep141FCastle2MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("ep14_1_f_castle_2.Id1", MonsterId.Rootcrystal_05, 14, 18, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id2", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id3", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id4", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id5", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id6", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id7", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id8", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id9", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id10", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id11", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id12", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id13", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id14", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id15", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id16", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id17", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id18", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id19", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id20", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id21", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id22", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id23", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id24", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id25", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id26", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id27", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id28", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id29", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id30", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id31", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id32", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id33", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id34", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id35", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id36", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id37", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id38", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id39", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id40", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id41", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id42", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id43", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id44", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id45", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id46", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id47", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id48", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id49", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id50", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id51", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id52", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id53", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id54", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id55", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id56", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id57", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id58", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id59", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id60", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id61", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id62", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id63", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id64", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id65", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id66", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id67", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id68", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id69", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id70", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id71", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id72", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id73", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id74", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id75", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id76", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id77", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id78", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id79", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id80", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id81", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id82", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id83", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id84", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id85", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id86", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id87", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id88", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id89", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id90", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id91", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id92", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id93", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id94", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id95", MonsterId.Bleakferret_Gladiator, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id96", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id97", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id98", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id99", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id100", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id101", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id102", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id103", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id104", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id105", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id106", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id107", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id108", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id109", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id110", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id111", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id112", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id113", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id114", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id115", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id116", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id117", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id118", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id119", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id120", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id121", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id122", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id123", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id124", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id125", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id126", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id127", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id128", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id129", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id130", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id131", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id132", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id133", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id134", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id135", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id136", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id137", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id138", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id139", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id140", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id141", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id142", MonsterId.Bleakferret_Swordman, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id143", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id144", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id145", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id146", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id147", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id148", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id149", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id150", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id151", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id152", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id153", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id154", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id155", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id156", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id157", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id158", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id159", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id160", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id161", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id162", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id163", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id164", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id165", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id166", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id167", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id168", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id169", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id170", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id171", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id172", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id173", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id174", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id175", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id176", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id177", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id178", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id179", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id180", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id181", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id182", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id183", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id184", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_2.Id185", MonsterId.Bleakferret_Shielder, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 99 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(1991.6445, -142.24734, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(1964.8405, 358.17566, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(1529.228, 1084.0553, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(957.8, 1138.1361, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(1117.2474, 1937.8103, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(53.73077, 2029.8301, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(404.5444, 1109.3516, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(482.20984, 188.57588, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(1259.6177, -178.39127, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(1630.4563, -881.2125, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(1413.6772, -1694.8191, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(750.65857, -1704.2701, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(-301.86823, -1064.3865, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(131.12341, -446.44733, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(-1026.6246, 98.21397, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(-595.0481, 150.1966, 100));
		AddSpawnPoint("ep14_1_f_castle_2.Id1", "ep14_1_f_castle_2", Rectangle(241.94298, -1506.6393, 100));

		// 'Bleakferret_Gladiator' GenType 1001 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id2", "ep14_1_f_castle_2", Rectangle(1907.353, -52.02453, 60));

		// 'Bleakferret_Gladiator' GenType 1002 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id3", "ep14_1_f_castle_2", Rectangle(1889.0952, -252.0014, 60));

		// 'Bleakferret_Gladiator' GenType 1003 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id4", "ep14_1_f_castle_2", Rectangle(2072.5374, -211.35257, 60));

		// 'Bleakferret_Gladiator' GenType 1004 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id5", "ep14_1_f_castle_2", Rectangle(1803.2726, -504.111, 60));

		// 'Bleakferret_Gladiator' GenType 1005 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id6", "ep14_1_f_castle_2", Rectangle(1534.216, -790.4099, 60));

		// 'Bleakferret_Gladiator' GenType 1006 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id7", "ep14_1_f_castle_2", Rectangle(1650.4967, -998.87836, 60));

		// 'Bleakferret_Gladiator' GenType 1007 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id8", "ep14_1_f_castle_2", Rectangle(1717.409, -777.6269, 60));

		// 'Bleakferret_Gladiator' GenType 1008 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id9", "ep14_1_f_castle_2", Rectangle(1688.777, -1144.5073, 60));

		// 'Bleakferret_Gladiator' GenType 1009 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id10", "ep14_1_f_castle_2", Rectangle(1695.8877, -1335.676, 60));

		// 'Bleakferret_Gladiator' GenType 1010 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id11", "ep14_1_f_castle_2", Rectangle(1579.5454, -1556.532, 60));

		// 'Bleakferret_Gladiator' GenType 1011 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id12", "ep14_1_f_castle_2", Rectangle(1570.3015, -1814.2831, 60));

		// 'Bleakferret_Gladiator' GenType 1012 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id13", "ep14_1_f_castle_2", Rectangle(1420.8385, -1703.6056, 60));

		// 'Bleakferret_Gladiator' GenType 1013 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id14", "ep14_1_f_castle_2", Rectangle(1314.3499, -1827.0835, 60));

		// 'Bleakferret_Gladiator' GenType 1014 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id15", "ep14_1_f_castle_2", Rectangle(1323.6456, -1553.2201, 60));

		// 'Bleakferret_Gladiator' GenType 1015 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id16", "ep14_1_f_castle_2", Rectangle(1129.3065, -1690.771, 60));

		// 'Bleakferret_Gladiator' GenType 1016 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id17", "ep14_1_f_castle_2", Rectangle(1065.6465, -1569.2972, 60));

		// 'Bleakferret_Gladiator' GenType 1017 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id18", "ep14_1_f_castle_2", Rectangle(1008.0209, -1788.8434, 60));

		// 'Bleakferret_Gladiator' GenType 1018 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id19", "ep14_1_f_castle_2", Rectangle(856.52673, -1635.6398, 60));

		// 'Bleakferret_Gladiator' GenType 1019 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id20", "ep14_1_f_castle_2", Rectangle(723.22473, -1513.4231, 60));

		// 'Bleakferret_Gladiator' GenType 1020 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id21", "ep14_1_f_castle_2", Rectangle(672.5181, -1744.5511, 60));

		// 'Bleakferret_Gladiator' GenType 1021 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id22", "ep14_1_f_castle_2", Rectangle(561.4312, -1655.4916, 60));

		// 'Bleakferret_Gladiator' GenType 1022 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id23", "ep14_1_f_castle_2", Rectangle(410.28235, -1717.6501, 60));

		// 'Bleakferret_Gladiator' GenType 1023 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id24", "ep14_1_f_castle_2", Rectangle(329.48752, -1571.4281, 60));

		// 'Bleakferret_Gladiator' GenType 1024 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id25", "ep14_1_f_castle_2", Rectangle(108.79031, -1417.4669, 60));

		// 'Bleakferret_Gladiator' GenType 1025 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id26", "ep14_1_f_castle_2", Rectangle(-130.64679, -1233.0739, 60));

		// 'Bleakferret_Gladiator' GenType 1026 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id27", "ep14_1_f_castle_2", Rectangle(-103.48509, -1101.2407, 60));

		// 'Bleakferret_Gladiator' GenType 1027 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id28", "ep14_1_f_castle_2", Rectangle(-217.20648, -1081.1992, 60));

		// 'Bleakferret_Gladiator' GenType 1028 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id29", "ep14_1_f_castle_2", Rectangle(-92.43229, -949.61237, 60));

		// 'Bleakferret_Gladiator' GenType 1029 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id30", "ep14_1_f_castle_2", Rectangle(-345.92096, -863.65875, 60));

		// 'Bleakferret_Gladiator' GenType 1030 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id31", "ep14_1_f_castle_2", Rectangle(-347.1924, -1049.4674, 60));

		// 'Bleakferret_Gladiator' GenType 1031 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id32", "ep14_1_f_castle_2", Rectangle(-490.0058, -894.6768, 60));

		// 'Bleakferret_Gladiator' GenType 1032 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id33", "ep14_1_f_castle_2", Rectangle(-533.87054, -1138.6943, 60));

		// 'Bleakferret_Gladiator' GenType 1033 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id34", "ep14_1_f_castle_2", Rectangle(-288.6296, -1202.1215, 60));

		// 'Bleakferret_Gladiator' GenType 1034 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id35", "ep14_1_f_castle_2", Rectangle(113.50673, -565.1773, 60));

		// 'Bleakferret_Gladiator' GenType 1035 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id36", "ep14_1_f_castle_2", Rectangle(93.48817, -402.94907, 60));

		// 'Bleakferret_Gladiator' GenType 1036 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id37", "ep14_1_f_castle_2", Rectangle(241.60335, -495.68826, 60));

		// 'Bleakferret_Gladiator' GenType 1037 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id38", "ep14_1_f_castle_2", Rectangle(-231.04543, -626.2232, 60));

		// 'Bleakferret_Gladiator' GenType 1038 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id39", "ep14_1_f_castle_2", Rectangle(-267.34558, -422.8977, 60));

		// 'Bleakferret_Gladiator' GenType 1039 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id40", "ep14_1_f_castle_2", Rectangle(-445.91995, -392.6526, 60));

		// 'Bleakferret_Gladiator' GenType 1040 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id41", "ep14_1_f_castle_2", Rectangle(-698.03235, -367.44162, 60));

		// 'Bleakferret_Gladiator' GenType 1041 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id42", "ep14_1_f_castle_2", Rectangle(-721.2538, -134.82596, 60));

		// 'Bleakferret_Gladiator' GenType 1042 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id43", "ep14_1_f_castle_2", Rectangle(-944.70575, -27.86222, 60));

		// 'Bleakferret_Gladiator' GenType 1043 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id44", "ep14_1_f_castle_2", Rectangle(-569.9745, 40.57916, 60));

		// 'Bleakferret_Gladiator' GenType 1044 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id45", "ep14_1_f_castle_2", Rectangle(-743.2793, 47.294758, 60));

		// 'Bleakferret_Gladiator' GenType 1045 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id46", "ep14_1_f_castle_2", Rectangle(-940.5876, 239.5806, 60));

		// 'Bleakferret_Gladiator' GenType 1046 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id47", "ep14_1_f_castle_2", Rectangle(-741.1745, 303.28857, 60));

		// 'Bleakferret_Gladiator' GenType 1047 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id48", "ep14_1_f_castle_2", Rectangle(-549.96356, 201.26959, 60));

		// 'Bleakferret_Gladiator' GenType 1048 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id49", "ep14_1_f_castle_2", Rectangle(-235.83109, 244.75784, 60));

		// 'Bleakferret_Gladiator' GenType 1049 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id50", "ep14_1_f_castle_2", Rectangle(59.482136, 240.25511, 60));

		// 'Bleakferret_Gladiator' GenType 1050 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id51", "ep14_1_f_castle_2", Rectangle(176.50117, 239.4818, 60));

		// 'Bleakferret_Gladiator' GenType 1051 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id52", "ep14_1_f_castle_2", Rectangle(279.6031, 333.6889, 60));

		// 'Bleakferret_Gladiator' GenType 1052 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id53", "ep14_1_f_castle_2", Rectangle(441.8053, 339.95856, 60));

		// 'Bleakferret_Gladiator' GenType 1053 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id54", "ep14_1_f_castle_2", Rectangle(400.57138, 152.7643, 60));

		// 'Bleakferret_Gladiator' GenType 1054 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id55", "ep14_1_f_castle_2", Rectangle(329.0991, 23.61567, 60));

		// 'Bleakferret_Gladiator' GenType 1055 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id56", "ep14_1_f_castle_2", Rectangle(474.5117, 9.783918, 60));

		// 'Bleakferret_Gladiator' GenType 1056 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id57", "ep14_1_f_castle_2", Rectangle(606.19086, 42.98533, 60));

		// 'Bleakferret_Gladiator' GenType 1057 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id58", "ep14_1_f_castle_2", Rectangle(664.5902, 158.73062, 60));

		// 'Bleakferret_Gladiator' GenType 1058 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id59", "ep14_1_f_castle_2", Rectangle(544.8019, 339.3942, 60));

		// 'Bleakferret_Gladiator' GenType 1059 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id60", "ep14_1_f_castle_2", Rectangle(381.7941, 428.62946, 60));

		// 'Bleakferret_Gladiator' GenType 1060 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id61", "ep14_1_f_castle_2", Rectangle(510.40417, 511.98895, 60));

		// 'Bleakferret_Gladiator' GenType 1061 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id62", "ep14_1_f_castle_2", Rectangle(609.1733, 430.32416, 60));

		// 'Bleakferret_Gladiator' GenType 1062 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id63", "ep14_1_f_castle_2", Rectangle(535.35535, 718.66833, 60));

		// 'Bleakferret_Gladiator' GenType 1063 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id64", "ep14_1_f_castle_2", Rectangle(441.38913, 994.14716, 60));

		// 'Bleakferret_Gladiator' GenType 1064 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id65", "ep14_1_f_castle_2", Rectangle(553.2548, 1190.3677, 60));

		// 'Bleakferret_Gladiator' GenType 1065 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id66", "ep14_1_f_castle_2", Rectangle(687.49347, 965.1285, 60));

		// 'Bleakferret_Gladiator' GenType 1066 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id67", "ep14_1_f_castle_2", Rectangle(759.1757, 1257.5684, 60));

		// 'Bleakferret_Gladiator' GenType 1067 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id68", "ep14_1_f_castle_2", Rectangle(885.2202, 933.3355, 60));

		// 'Bleakferret_Gladiator' GenType 1068 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id69", "ep14_1_f_castle_2", Rectangle(1029.7554, 1002.8528, 60));

		// 'Bleakferret_Gladiator' GenType 1069 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id70", "ep14_1_f_castle_2", Rectangle(824.16644, 1138.8712, 60));

		// 'Bleakferret_Gladiator' GenType 1070 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id71", "ep14_1_f_castle_2", Rectangle(1029.1338, 1270.585, 60));

		// 'Bleakferret_Gladiator' GenType 1071 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id72", "ep14_1_f_castle_2", Rectangle(1013.8871, 1886.7542, 60));

		// 'Bleakferret_Gladiator' GenType 1072 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id73", "ep14_1_f_castle_2", Rectangle(1248.0968, 1890.5144, 60));

		// 'Bleakferret_Gladiator' GenType 1073 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id74", "ep14_1_f_castle_2", Rectangle(1114.8049, 2096.458, 60));

		// 'Bleakferret_Gladiator' GenType 1074 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id75", "ep14_1_f_castle_2", Rectangle(-247.9408, 2024.7068, 60));

		// 'Bleakferret_Gladiator' GenType 1075 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id76", "ep14_1_f_castle_2", Rectangle(-28.946129, 2138.5198, 60));

		// 'Bleakferret_Gladiator' GenType 1076 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id77", "ep14_1_f_castle_2", Rectangle(81.993904, 1918.6458, 60));

		// 'Bleakferret_Gladiator' GenType 1077 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id78", "ep14_1_f_castle_2", Rectangle(117.87223, 2115.4492, 60));

		// 'Bleakferret_Gladiator' GenType 1078 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id79", "ep14_1_f_castle_2", Rectangle(299.86023, 1935.8685, 60));

		// 'Bleakferret_Gladiator' GenType 1079 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id80", "ep14_1_f_castle_2", Rectangle(503.7213, 1989.5442, 60));

		// 'Bleakferret_Gladiator' GenType 1080 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id81", "ep14_1_f_castle_2", Rectangle(758.98175, 1973.6959, 60));

		// 'Bleakferret_Gladiator' GenType 1081 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id82", "ep14_1_f_castle_2", Rectangle(475.95584, 1584.1349, 60));

		// 'Bleakferret_Gladiator' GenType 1082 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id83", "ep14_1_f_castle_2", Rectangle(1458.1697, 1113.6678, 60));

		// 'Bleakferret_Gladiator' GenType 1083 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id84", "ep14_1_f_castle_2", Rectangle(1625.5668, 934.349, 60));

		// 'Bleakferret_Gladiator' GenType 1084 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id85", "ep14_1_f_castle_2", Rectangle(1922.6992, 184.9531, 60));

		// 'Bleakferret_Gladiator' GenType 1085 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id86", "ep14_1_f_castle_2", Rectangle(1962.4336, 403.4026, 60));

		// 'Bleakferret_Gladiator' GenType 1086 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id87", "ep14_1_f_castle_2", Rectangle(1857.5228, 415.1246, 60));

		// 'Bleakferret_Gladiator' GenType 1087 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id88", "ep14_1_f_castle_2", Rectangle(672.2166, -44.350742, 60));

		// 'Bleakferret_Gladiator' GenType 1088 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id89", "ep14_1_f_castle_2", Rectangle(972.45966, -125.07541, 60));

		// 'Bleakferret_Gladiator' GenType 1089 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id90", "ep14_1_f_castle_2", Rectangle(1151.8518, -193.60414, 60));

		// 'Bleakferret_Gladiator' GenType 1090 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id91", "ep14_1_f_castle_2", Rectangle(1244.962, -75.11737, 60));

		// 'Bleakferret_Gladiator' GenType 1091 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id92", "ep14_1_f_castle_2", Rectangle(1498.6882, -164.24176, 60));

		// 'Bleakferret_Gladiator' GenType 1092 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id93", "ep14_1_f_castle_2", Rectangle(1412.842, -317.1973, 60));

		// 'Bleakferret_Gladiator' GenType 1093 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id94", "ep14_1_f_castle_2", Rectangle(1704.0787, -138.7026, 60));

		// 'Bleakferret_Gladiator' GenType 1094 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id95", "ep14_1_f_castle_2", Rectangle(159.50977, -192.0611, 60));

		// 'Bleakferret_Swordman' GenType 1095 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id96", "ep14_1_f_castle_2", Rectangle(2035.7881, -79.257286, 60));

		// 'Bleakferret_Swordman' GenType 1096 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id97", "ep14_1_f_castle_2", Rectangle(1981.6833, 84.370026, 60));

		// 'Bleakferret_Swordman' GenType 1097 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id98", "ep14_1_f_castle_2", Rectangle(1913.9495, 293.6171, 60));

		// 'Bleakferret_Swordman' GenType 1098 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id99", "ep14_1_f_castle_2", Rectangle(2049.442, 222.96098, 60));

		// 'Bleakferret_Swordman' GenType 1099 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id100", "ep14_1_f_castle_2", Rectangle(1566.2546, 1056.5326, 60));

		// 'Bleakferret_Swordman' GenType 1100 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id101", "ep14_1_f_castle_2", Rectangle(967.6509, 1124.9645, 60));

		// 'Bleakferret_Swordman' GenType 1101 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id102", "ep14_1_f_castle_2", Rectangle(910.2463, 1282.1356, 60));

		// 'Bleakferret_Swordman' GenType 1102 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id103", "ep14_1_f_castle_2", Rectangle(679.38617, 1125.8435, 60));

		// 'Bleakferret_Swordman' GenType 1103 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id104", "ep14_1_f_castle_2", Rectangle(570.7197, 994.1504, 60));

		// 'Bleakferret_Swordman' GenType 1104 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id105", "ep14_1_f_castle_2", Rectangle(322.40887, 1188.6019, 60));

		// 'Bleakferret_Swordman' GenType 1105 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id106", "ep14_1_f_castle_2", Rectangle(-15.698532, 2013.1141, 60));

		// 'Bleakferret_Swordman' GenType 1106 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id107", "ep14_1_f_castle_2", Rectangle(369.75214, 2061.9722, 60));

		// 'Bleakferret_Swordman' GenType 1107 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id108", "ep14_1_f_castle_2", Rectangle(144.38077, 1824.3563, 60));

		// 'Bleakferret_Swordman' GenType 1108 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id109", "ep14_1_f_castle_2", Rectangle(929.9332, 1988.7231, 60));

		// 'Bleakferret_Swordman' GenType 1109 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id110", "ep14_1_f_castle_2", Rectangle(1249.644, 2045.584, 60));

		// 'Bleakferret_Swordman' GenType 1110 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id111", "ep14_1_f_castle_2", Rectangle(1133.1971, 1795.1527, 60));

		// 'Bleakferret_Swordman' GenType 1111 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id112", "ep14_1_f_castle_2", Rectangle(643.6952, 255.85934, 60));

		// 'Bleakferret_Swordman' GenType 1112 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id113", "ep14_1_f_castle_2", Rectangle(277.82697, 184.60092, 60));

		// 'Bleakferret_Swordman' GenType 1113 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id114", "ep14_1_f_castle_2", Rectangle(495.83884, 130.5059, 60));

		// 'Bleakferret_Swordman' GenType 1114 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id115", "ep14_1_f_castle_2", Rectangle(-31.839588, 245.9784, 60));

		// 'Bleakferret_Swordman' GenType 1115 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id116", "ep14_1_f_castle_2", Rectangle(-491.72525, 339.48828, 60));

		// 'Bleakferret_Swordman' GenType 1116 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id117", "ep14_1_f_castle_2", Rectangle(-681.27026, 164.95035, 60));

		// 'Bleakferret_Swordman' GenType 1117 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id118", "ep14_1_f_castle_2", Rectangle(-984.80347, 130.76385, 60));

		// 'Bleakferret_Swordman' GenType 1118 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id119", "ep14_1_f_castle_2", Rectangle(-1075.3467, -81.81149, 60));

		// 'Bleakferret_Swordman' GenType 1119 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id120", "ep14_1_f_castle_2", Rectangle(-596.6132, -77.062584, 60));

		// 'Bleakferret_Swordman' GenType 1120 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id121", "ep14_1_f_castle_2", Rectangle(-211.2757, -536.04584, 60));

		// 'Bleakferret_Swordman' GenType 1121 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id122", "ep14_1_f_castle_2", Rectangle(-575.1983, -347.35193, 60));

		// 'Bleakferret_Swordman' GenType 1122 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id123", "ep14_1_f_castle_2", Rectangle(-740.64514, -268.33777, 60));

		// 'Bleakferret_Swordman' GenType 1123 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id124", "ep14_1_f_castle_2", Rectangle(139.6966, -295.02536, 60));

		// 'Bleakferret_Swordman' GenType 1124 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id125", "ep14_1_f_castle_2", Rectangle(164.72185, -468.03534, 60));

		// 'Bleakferret_Swordman' GenType 1125 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id126", "ep14_1_f_castle_2", Rectangle(49.20877, -699.32056, 60));

		// 'Bleakferret_Swordman' GenType 1126 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id127", "ep14_1_f_castle_2", Rectangle(-418.61206, -1161.3236, 60));

		// 'Bleakferret_Swordman' GenType 1127 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id128", "ep14_1_f_castle_2", Rectangle(-25.49243, -1196.317, 60));

		// 'Bleakferret_Swordman' GenType 1128 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id129", "ep14_1_f_castle_2", Rectangle(-249.95177, -962.06067, 60));

		// 'Bleakferret_Swordman' GenType 1129 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id130", "ep14_1_f_castle_2", Rectangle(-13.526007, -1333.8555, 60));

		// 'Bleakferret_Swordman' GenType 1130 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id131", "ep14_1_f_castle_2", Rectangle(445.26617, -1565.1317, 60));

		// 'Bleakferret_Swordman' GenType 1131 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id132", "ep14_1_f_castle_2", Rectangle(727.6244, -1641.1685, 60));

		// 'Bleakferret_Swordman' GenType 1132 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id133", "ep14_1_f_castle_2", Rectangle(984.3702, -1663.0591, 60));

		// 'Bleakferret_Swordman' GenType 1133 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id134", "ep14_1_f_castle_2", Rectangle(539.0156, -1831.4591, 60));

		// 'Bleakferret_Swordman' GenType 1134 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id135", "ep14_1_f_castle_2", Rectangle(1195.8013, -1500.4427, 60));

		// 'Bleakferret_Swordman' GenType 1135 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id136", "ep14_1_f_castle_2", Rectangle(1279.7924, -1700.1133, 60));

		// 'Bleakferret_Swordman' GenType 1136 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id137", "ep14_1_f_castle_2", Rectangle(1560.0026, -1675.406, 60));

		// 'Bleakferret_Swordman' GenType 1137 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id138", "ep14_1_f_castle_2", Rectangle(1718.4404, -1590.901, 60));

		// 'Bleakferret_Swordman' GenType 1138 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id139", "ep14_1_f_castle_2", Rectangle(1627.0953, -867.3805, 60));

		// 'Bleakferret_Swordman' GenType 1139 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id140", "ep14_1_f_castle_2", Rectangle(1723.3591, -611.48334, 60));

		// 'Bleakferret_Swordman' GenType 1140 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id141", "ep14_1_f_castle_2", Rectangle(1261.3358, -345.1935, 60));

		// 'Bleakferret_Swordman' GenType 1141 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id142", "ep14_1_f_castle_2", Rectangle(1374.928, -198.66512, 60));

		// 'Bleakferret_Shielder' GenType 1142 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id143", "ep14_1_f_castle_2", Rectangle(1699.5403, -1442.7766, 60));

		// 'Bleakferret_Shielder' GenType 1143 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id144", "ep14_1_f_castle_2", Rectangle(1902.021, -403.3934, 60));

		// 'Bleakferret_Shielder' GenType 1144 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id145", "ep14_1_f_castle_2", Rectangle(1964.9087, -134.7667, 60));

		// 'Bleakferret_Shielder' GenType 1145 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id146", "ep14_1_f_castle_2", Rectangle(1401.1172, -80.87743, 60));

		// 'Bleakferret_Shielder' GenType 1146 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id147", "ep14_1_f_castle_2", Rectangle(2046.9404, 331.7368, 60));

		// 'Bleakferret_Shielder' GenType 1147 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id148", "ep14_1_f_castle_2", Rectangle(1301.57, 1109.9514, 60));

		// 'Bleakferret_Shielder' GenType 1148 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id149", "ep14_1_f_castle_2", Rectangle(552.3686, 864.91595, 60));

		// 'Bleakferret_Shielder' GenType 1149 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id150", "ep14_1_f_castle_2", Rectangle(790.68976, 1028.9026, 60));

		// 'Bleakferret_Shielder' GenType 1150 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id151", "ep14_1_f_castle_2", Rectangle(454.14142, 1285.0641, 60));

		// 'Bleakferret_Shielder' GenType 1151 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id152", "ep14_1_f_castle_2", Rectangle(1033.0051, 1468.0146, 60));

		// 'Bleakferret_Shielder' GenType 1152 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id153", "ep14_1_f_castle_2", Rectangle(1066.0226, 1623.0249, 60));

		// 'Bleakferret_Shielder' GenType 1153 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id154", "ep14_1_f_castle_2", Rectangle(1135.4375, 1958.1497, 60));

		// 'Bleakferret_Shielder' GenType 1154 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id155", "ep14_1_f_castle_2", Rectangle(630.99805, 1974.3981, 60));

		// 'Bleakferret_Shielder' GenType 1155 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id156", "ep14_1_f_castle_2", Rectangle(189.51225, 1992.8086, 60));

		// 'Bleakferret_Shielder' GenType 1156 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id157", "ep14_1_f_castle_2", Rectangle(-142.63687, 2092.5366, 60));

		// 'Bleakferret_Shielder' GenType 1157 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id158", "ep14_1_f_castle_2", Rectangle(302.9791, 1684.3397, 60));

		// 'Bleakferret_Shielder' GenType 1158 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id159", "ep14_1_f_castle_2", Rectangle(232.68845, 1103.6443, 60));

		// 'Bleakferret_Shielder' GenType 1159 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id160", "ep14_1_f_castle_2", Rectangle(456.35214, 1118.9374, 60));

		// 'Bleakferret_Shielder' GenType 1160 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id161", "ep14_1_f_castle_2", Rectangle(528.9907, 609.17706, 60));

		// 'Bleakferret_Shielder' GenType 1161 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id162", "ep14_1_f_castle_2", Rectangle(230.69469, 80.716484, 60));

		// 'Bleakferret_Shielder' GenType 1162 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id163", "ep14_1_f_castle_2", Rectangle(512.27905, 228.9739, 60));

		// 'Bleakferret_Shielder' GenType 1163 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id164", "ep14_1_f_castle_2", Rectangle(-404.20026, 214.9652, 60));

		// 'Bleakferret_Shielder' GenType 1164 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id165", "ep14_1_f_castle_2", Rectangle(-620.47736, 295.67282, 60));

		// 'Bleakferret_Shielder' GenType 1165 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id166", "ep14_1_f_castle_2", Rectangle(-815.3022, 174.99475, 60));

		// 'Bleakferret_Shielder' GenType 1166 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id167", "ep14_1_f_castle_2", Rectangle(-817.4241, -33.274887, 60));

		// 'Bleakferret_Shielder' GenType 1167 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id168", "ep14_1_f_castle_2", Rectangle(-1110.9562, 81.58197, 60));

		// 'Bleakferret_Shielder' GenType 1168 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id169", "ep14_1_f_castle_2", Rectangle(-201.22183, -841.2989, 60));

		// 'Bleakferret_Shielder' GenType 1169 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id170", "ep14_1_f_castle_2", Rectangle(-461.93842, -1011.5653, 60));

		// 'Bleakferret_Shielder' GenType 1170 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id171", "ep14_1_f_castle_2", Rectangle(-407.53763, -1283.7188, 60));

		// 'Bleakferret_Shielder' GenType 1171 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id172", "ep14_1_f_castle_2", Rectangle(-18.124815, -811.9752, 60));

		// 'Bleakferret_Shielder' GenType 1172 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id173", "ep14_1_f_castle_2", Rectangle(206.67114, -1474.6759, 60));

		// 'Bleakferret_Shielder' GenType 1173 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id174", "ep14_1_f_castle_2", Rectangle(559.65564, -1509.6589, 60));

		// 'Bleakferret_Shielder' GenType 1174 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id175", "ep14_1_f_castle_2", Rectangle(791.2216, -1771.31, 60));

		// 'Bleakferret_Shielder' GenType 1175 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id176", "ep14_1_f_castle_2", Rectangle(878.87115, -1510.4773, 60));

		// 'Bleakferret_Shielder' GenType 1176 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id177", "ep14_1_f_castle_2", Rectangle(1444.7653, -1510.1881, 60));

		// 'Bleakferret_Shielder' GenType 1177 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id178", "ep14_1_f_castle_2", Rectangle(1434.9209, -1873.2565, 60));

		// 'Bleakferret_Shielder' GenType 1178 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id179", "ep14_1_f_castle_2", Rectangle(1703.3295, -1716.3649, 60));

		// 'Bleakferret_Shielder' GenType 1179 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id180", "ep14_1_f_castle_2", Rectangle(1512.807, -925.94104, 60));

		// 'Bleakferret_Shielder' GenType 1180 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id181", "ep14_1_f_castle_2", Rectangle(1743.6635, -915.20624, 60));

		// 'Bleakferret_Shielder' GenType 1181 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id182", "ep14_1_f_castle_2", Rectangle(1266.6194, -212.65482, 60));

		// 'Bleakferret_Shielder' GenType 1182 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id183", "ep14_1_f_castle_2", Rectangle(785.318, -95.659744, 60));

		// 'Bleakferret_Shielder' GenType 1183 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id184", "ep14_1_f_castle_2", Rectangle(186.12888, -370.81323, 60));

		// 'Bleakferret_Shielder' GenType 1184 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_2.Id185", "ep14_1_f_castle_2", Rectangle(172.51846, -105.65453, 60));
	}
}
