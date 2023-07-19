//--- Melia Script -----------------------------------------------------------
// ep14_1_f_castle_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Delmore Outskirts' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep141FCastle3MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("ep14_1_f_castle_3.Id1", MonsterId.Rootcrystal_05, 17, 22, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id2", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id3", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id4", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id5", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id6", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id7", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id8", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id9", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id10", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id11", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id12", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id13", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id14", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id15", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id16", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id17", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id18", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id19", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id20", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id21", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id22", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id23", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id24", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id25", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id26", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id27", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id28", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id29", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id30", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id31", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id32", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id33", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id34", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id35", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id36", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id37", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id38", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id39", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id40", MonsterId.Bleakferret_Cannon_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id41", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id42", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id43", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id44", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id45", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id46", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id47", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id48", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id49", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id50", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id51", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id52", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id53", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id54", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id55", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id56", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id57", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id58", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id59", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id60", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id61", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id62", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id63", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id64", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id65", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id66", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id67", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id68", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id69", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id70", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id71", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id72", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id73", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id74", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id75", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id76", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id77", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id78", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id79", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id80", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id81", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id82", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id83", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id84", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id85", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id86", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id87", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id88", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id89", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id90", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id91", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id92", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id93", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id94", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id95", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id96", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id97", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id98", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id99", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id100", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id101", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id102", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id103", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id104", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id105", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id106", MonsterId.Bleakferret_Swordman_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id107", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id108", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id109", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id110", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id111", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id112", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id113", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id114", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id115", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id116", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id117", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id118", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id119", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id120", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id121", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id122", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id123", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id124", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id125", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id126", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id127", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id128", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id129", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id130", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id131", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id132", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id133", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id134", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id135", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id136", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id137", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id138", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id139", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id140", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id141", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id142", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id143", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id144", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id145", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id146", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id147", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id148", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id149", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id150", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id151", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id152", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id153", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id154", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id155", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id156", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id157", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id158", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id159", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id160", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id161", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id162", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id163", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id164", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id165", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id166", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id167", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id168", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id169", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id170", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id171", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id172", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id173", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id174", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id175", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id176", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id177", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id178", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id179", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id180", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id181", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id182", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id183", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id184", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id185", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id186", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id187", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id188", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id189", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id190", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id191", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id192", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id193", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id194", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id195", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id196", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id197", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id198", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id199", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id200", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_3.Id201", MonsterId.Bleakferret_Spear_2, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 68 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-104.27925, -1096.0194, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(627.3744, -1211.3301, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(1004.9382, -1620.4966, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(1517.3412, -875.3513, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(1056.1841, -422.7601, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(442.95615, -521.86237, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(56.25014, -87.550285, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(775.04443, 108.56152, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(177.98325, 520.41516, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(400.39822, 1879.3589, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(333.26675, 1195.8729, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-919.8135, 1336.2438, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-712.63904, 904.58307, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-720.01117, 381.49567, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-1787.4142, 598.5259, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-1346.9178, 730.22455, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-1448.0686, -495.87823, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-1707.0995, -1078.5681, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-1103.0624, -1035.949, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-693.7307, -357.24118, 100));
		AddSpawnPoint("ep14_1_f_castle_3.Id1", "ep14_1_f_castle_3", Rectangle(-1708.0884, -34.37671, 100));

		// 'Bleakferret_Cannon_2' GenType 1001 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id2", "ep14_1_f_castle_3", Rectangle(319.54138, -1218.4781, 60));

		// 'Bleakferret_Cannon_2' GenType 1002 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id3", "ep14_1_f_castle_3", Rectangle(594.78174, -1349.8434, 60));

		// 'Bleakferret_Cannon_2' GenType 1003 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id4", "ep14_1_f_castle_3", Rectangle(610.6684, -1121.7145, 60));

		// 'Bleakferret_Cannon_2' GenType 1004 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id5", "ep14_1_f_castle_3", Rectangle(883.6119, -1247.1289, 60));

		// 'Bleakferret_Cannon_2' GenType 1005 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id6", "ep14_1_f_castle_3", Rectangle(1058.0153, -1582.5116, 60));

		// 'Bleakferret_Cannon_2' GenType 1006 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id7", "ep14_1_f_castle_3", Rectangle(1526.8152, -894.75446, 60));

		// 'Bleakferret_Cannon_2' GenType 1007 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id8", "ep14_1_f_castle_3", Rectangle(1026.437, -535.2467, 60));

		// 'Bleakferret_Cannon_2' GenType 1008 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id9", "ep14_1_f_castle_3", Rectangle(832.33954, -218.60562, 60));

		// 'Bleakferret_Cannon_2' GenType 1009 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id10", "ep14_1_f_castle_3", Rectangle(762.8056, 123.93713, 60));

		// 'Bleakferret_Cannon_2' GenType 1010 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id11", "ep14_1_f_castle_3", Rectangle(183.38316, 644.43243, 60));

		// 'Bleakferret_Cannon_2' GenType 1011 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id12", "ep14_1_f_castle_3", Rectangle(22.540047, 390.06326, 60));

		// 'Bleakferret_Cannon_2' GenType 1012 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id13", "ep14_1_f_castle_3", Rectangle(386.83118, 1325.9016, 60));

		// 'Bleakferret_Cannon_2' GenType 1013 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id14", "ep14_1_f_castle_3", Rectangle(471.83267, 1525.6891, 60));

		// 'Bleakferret_Cannon_2' GenType 1014 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id15", "ep14_1_f_castle_3", Rectangle(303.95673, 1877.0082, 60));

		// 'Bleakferret_Cannon_2' GenType 1015 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id16", "ep14_1_f_castle_3", Rectangle(-147.57954, 1249.3469, 60));

		// 'Bleakferret_Cannon_2' GenType 1016 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id17", "ep14_1_f_castle_3", Rectangle(-593.99615, 1051.798, 60));

		// 'Bleakferret_Cannon_2' GenType 1017 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id18", "ep14_1_f_castle_3", Rectangle(-747.4945, 880.5497, 60));

		// 'Bleakferret_Cannon_2' GenType 1018 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id19", "ep14_1_f_castle_3", Rectangle(-871.87805, 1289.319, 60));

		// 'Bleakferret_Cannon_2' GenType 1019 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id20", "ep14_1_f_castle_3", Rectangle(-1117.1243, 1278.8964, 60));

		// 'Bleakferret_Cannon_2' GenType 1020 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id21", "ep14_1_f_castle_3", Rectangle(-1308.8971, 766.09045, 60));

		// 'Bleakferret_Cannon_2' GenType 1021 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id22", "ep14_1_f_castle_3", Rectangle(-1632.0723, 848.8557, 60));

		// 'Bleakferret_Cannon_2' GenType 1022 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id23", "ep14_1_f_castle_3", Rectangle(-1898.686, 547.37885, 60));

		// 'Bleakferret_Cannon_2' GenType 1023 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id24", "ep14_1_f_castle_3", Rectangle(-1615.1388, 604.81586, 60));

		// 'Bleakferret_Cannon_2' GenType 1024 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id25", "ep14_1_f_castle_3", Rectangle(-1508.1119, -497.68457, 60));

		// 'Bleakferret_Cannon_2' GenType 1025 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id26", "ep14_1_f_castle_3", Rectangle(-1179.2285, -401.25256, 60));

		// 'Bleakferret_Cannon_2' GenType 1026 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id27", "ep14_1_f_castle_3", Rectangle(-1720.6512, -969.5817, 60));

		// 'Bleakferret_Cannon_2' GenType 1027 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id28", "ep14_1_f_castle_3", Rectangle(-1620.2012, -1156.9371, 60));

		// 'Bleakferret_Cannon_2' GenType 1028 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id29", "ep14_1_f_castle_3", Rectangle(-1123.9703, -1046.6764, 60));

		// 'Bleakferret_Cannon_2' GenType 1029 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id30", "ep14_1_f_castle_3", Rectangle(-687.58795, -899.9638, 60));

		// 'Bleakferret_Cannon_2' GenType 1030 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id31", "ep14_1_f_castle_3", Rectangle(-320.5538, -927.59033, 60));

		// 'Bleakferret_Cannon_2' GenType 1031 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id32", "ep14_1_f_castle_3", Rectangle(-90.77887, -1003.5157, 60));

		// 'Bleakferret_Cannon_2' GenType 1032 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id33", "ep14_1_f_castle_3", Rectangle(406.49542, -1587.8689, 60));

		// 'Bleakferret_Cannon_2' GenType 1033 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id34", "ep14_1_f_castle_3", Rectangle(104.851, -291.71997, 60));

		// 'Bleakferret_Cannon_2' GenType 1034 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id35", "ep14_1_f_castle_3", Rectangle(50.49206, 55.290718, 60));

		// 'Bleakferret_Cannon_2' GenType 1035 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id36", "ep14_1_f_castle_3", Rectangle(510.09396, -398.0886, 60));

		// 'Bleakferret_Cannon_2' GenType 1036 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id37", "ep14_1_f_castle_3", Rectangle(798.97986, -759.3476, 60));

		// 'Bleakferret_Cannon_2' GenType 1037 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id38", "ep14_1_f_castle_3", Rectangle(-684.7755, -361.10632, 60));

		// 'Bleakferret_Cannon_2' GenType 1038 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id39", "ep14_1_f_castle_3", Rectangle(-712.53546, 365.33063, 60));

		// 'Bleakferret_Cannon_2' GenType 1039 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id40", "ep14_1_f_castle_3", Rectangle(-1695.7328, -30.11911, 60));

		// 'Bleakferret_Swordman_2' GenType 1040 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id41", "ep14_1_f_castle_3", Rectangle(393.15857, -1447.6855, 60));

		// 'Bleakferret_Swordman_2' GenType 1041 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id42", "ep14_1_f_castle_3", Rectangle(603.83954, -1492.0039, 60));

		// 'Bleakferret_Swordman_2' GenType 1042 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id43", "ep14_1_f_castle_3", Rectangle(732.0559, -1286.7058, 60));

		// 'Bleakferret_Swordman_2' GenType 1043 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id44", "ep14_1_f_castle_3", Rectangle(404.50668, -1086.7511, 60));

		// 'Bleakferret_Swordman_2' GenType 1044 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id45", "ep14_1_f_castle_3", Rectangle(68.349434, -1101.5022, 60));

		// 'Bleakferret_Swordman_2' GenType 1045 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id46", "ep14_1_f_castle_3", Rectangle(922.1023, -1545.4769, 60));

		// 'Bleakferret_Swordman_2' GenType 1046 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id47", "ep14_1_f_castle_3", Rectangle(1190.832, -1588.6302, 60));

		// 'Bleakferret_Swordman_2' GenType 1047 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id48", "ep14_1_f_castle_3", Rectangle(883.8761, -1022.9765, 60));

		// 'Bleakferret_Swordman_2' GenType 1048 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id49", "ep14_1_f_castle_3", Rectangle(1417.5157, -1341.0336, 60));

		// 'Bleakferret_Swordman_2' GenType 1049 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id50", "ep14_1_f_castle_3", Rectangle(1479.1184, -1011.3987, 60));

		// 'Bleakferret_Swordman_2' GenType 1050 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id51", "ep14_1_f_castle_3", Rectangle(1584.5679, -756.87585, 60));

		// 'Bleakferret_Swordman_2' GenType 1051 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id52", "ep14_1_f_castle_3", Rectangle(1318.1204, -751.14307, 60));

		// 'Bleakferret_Swordman_2' GenType 1052 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id53", "ep14_1_f_castle_3", Rectangle(830.9223, -385.4909, 60));

		// 'Bleakferret_Swordman_2' GenType 1053 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id54", "ep14_1_f_castle_3", Rectangle(651.6932, -203.95905, 60));

		// 'Bleakferret_Swordman_2' GenType 1054 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id55", "ep14_1_f_castle_3", Rectangle(893.38336, 87.952484, 60));

		// 'Bleakferret_Swordman_2' GenType 1055 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id56", "ep14_1_f_castle_3", Rectangle(254.66739, 436.3788, 60));

		// 'Bleakferret_Swordman_2' GenType 1056 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id57", "ep14_1_f_castle_3", Rectangle(58.495575, 488.9725, 60));

		// 'Bleakferret_Swordman_2' GenType 1057 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id58", "ep14_1_f_castle_3", Rectangle(272.80527, 850.5045, 60));

		// 'Bleakferret_Swordman_2' GenType 1058 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id59", "ep14_1_f_castle_3", Rectangle(267.45093, 557.0976, 60));

		// 'Bleakferret_Swordman_2' GenType 1059 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id60", "ep14_1_f_castle_3", Rectangle(359.98325, 1205.1108, 60));

		// 'Bleakferret_Swordman_2' GenType 1060 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id61", "ep14_1_f_castle_3", Rectangle(378.5003, 1459.3911, 60));

		// 'Bleakferret_Swordman_2' GenType 1061 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id62", "ep14_1_f_castle_3", Rectangle(254.94217, 1637.8556, 60));

		// 'Bleakferret_Swordman_2' GenType 1062 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id63", "ep14_1_f_castle_3", Rectangle(430.21396, 1766.9391, 60));

		// 'Bleakferret_Swordman_2' GenType 1063 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id64", "ep14_1_f_castle_3", Rectangle(517.714, 1823.3325, 60));

		// 'Bleakferret_Swordman_2' GenType 1064 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id65", "ep14_1_f_castle_3", Rectangle(-130.02032, 953.897, 60));

		// 'Bleakferret_Swordman_2' GenType 1065 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id66", "ep14_1_f_castle_3", Rectangle(-126.65523, 1373.5938, 60));

		// 'Bleakferret_Swordman_2' GenType 1066 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id67", "ep14_1_f_castle_3", Rectangle(-188.10828, 632.0386, 60));

		// 'Bleakferret_Swordman_2' GenType 1067 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id68", "ep14_1_f_castle_3", Rectangle(-410.09235, 1350.9667, 60));

		// 'Bleakferret_Swordman_2' GenType 1068 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id69", "ep14_1_f_castle_3", Rectangle(-831.09674, 1174.7001, 60));

		// 'Bleakferret_Swordman_2' GenType 1069 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id70", "ep14_1_f_castle_3", Rectangle(-935.50494, 1420.4438, 60));

		// 'Bleakferret_Swordman_2' GenType 1070 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id71", "ep14_1_f_castle_3", Rectangle(-1001.4623, 1205.3883, 60));

		// 'Bleakferret_Swordman_2' GenType 1071 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id72", "ep14_1_f_castle_3", Rectangle(-1031.0637, 948.8157, 60));

		// 'Bleakferret_Swordman_2' GenType 1072 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id73", "ep14_1_f_castle_3", Rectangle(-632.333, 769.4035, 60));

		// 'Bleakferret_Swordman_2' GenType 1073 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id74", "ep14_1_f_castle_3", Rectangle(-699.18616, 1300.782, 60));

		// 'Bleakferret_Swordman_2' GenType 1074 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id75", "ep14_1_f_castle_3", Rectangle(-680.15216, 601.391, 60));

		// 'Bleakferret_Swordman_2' GenType 1075 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id76", "ep14_1_f_castle_3", Rectangle(-712.50336, 253.06984, 60));

		// 'Bleakferret_Swordman_2' GenType 1076 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id77", "ep14_1_f_castle_3", Rectangle(-573.1151, -383.82004, 60));

		// 'Bleakferret_Swordman_2' GenType 1077 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id78", "ep14_1_f_castle_3", Rectangle(-781.6285, -313.19565, 60));

		// 'Bleakferret_Swordman_2' GenType 1078 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id79", "ep14_1_f_castle_3", Rectangle(-289.74704, -295.56177, 60));

		// 'Bleakferret_Swordman_2' GenType 1079 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id80", "ep14_1_f_castle_3", Rectangle(55.142235, -148.7431, 60));

		// 'Bleakferret_Swordman_2' GenType 1080 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id81", "ep14_1_f_castle_3", Rectangle(-78.97064, -172.05536, 60));

		// 'Bleakferret_Swordman_2' GenType 1081 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id82", "ep14_1_f_castle_3", Rectangle(266.7944, -50.267338, 60));

		// 'Bleakferret_Swordman_2' GenType 1082 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id83", "ep14_1_f_castle_3", Rectangle(419.41708, -477.38876, 60));

		// 'Bleakferret_Swordman_2' GenType 1083 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id84", "ep14_1_f_castle_3", Rectangle(-977.0249, -1047.6753, 60));

		// 'Bleakferret_Swordman_2' GenType 1084 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id85", "ep14_1_f_castle_3", Rectangle(-1445.0127, -1152.0492, 60));

		// 'Bleakferret_Swordman_2' GenType 1085 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id86", "ep14_1_f_castle_3", Rectangle(-629.3256, -791.1347, 60));

		// 'Bleakferret_Swordman_2' GenType 1086 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id87", "ep14_1_f_castle_3", Rectangle(-1851.9165, -1136.573, 60));

		// 'Bleakferret_Swordman_2' GenType 1087 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id88", "ep14_1_f_castle_3", Rectangle(-1729.265, -1095.8696, 60));

		// 'Bleakferret_Swordman_2' GenType 1088 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id89", "ep14_1_f_castle_3", Rectangle(-1613.9233, -440.72925, 60));

		// 'Bleakferret_Swordman_2' GenType 1089 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id90", "ep14_1_f_castle_3", Rectangle(-1386.315, -469.48294, 60));

		// 'Bleakferret_Swordman_2' GenType 1090 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id91", "ep14_1_f_castle_3", Rectangle(-1150.6421, -296.66092, 60));

		// 'Bleakferret_Swordman_2' GenType 1091 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id92", "ep14_1_f_castle_3", Rectangle(-946.0752, -264.27185, 60));

		// 'Bleakferret_Swordman_2' GenType 1092 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id93", "ep14_1_f_castle_3", Rectangle(-1566.6466, -191.76245, 60));

		// 'Bleakferret_Swordman_2' GenType 1093 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id94", "ep14_1_f_castle_3", Rectangle(-1825.5387, 22.184584, 60));

		// 'Bleakferret_Swordman_2' GenType 1094 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id95", "ep14_1_f_castle_3", Rectangle(-1833.7594, 651.0658, 60));

		// 'Bleakferret_Swordman_2' GenType 1095 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id96", "ep14_1_f_castle_3", Rectangle(-1815.0458, 769.6038, 60));

		// 'Bleakferret_Swordman_2' GenType 1096 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id97", "ep14_1_f_castle_3", Rectangle(-1804.5996, 466.1199, 60));

		// 'Bleakferret_Swordman_2' GenType 1097 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id98", "ep14_1_f_castle_3", Rectangle(-1683.1583, 449.3557, 60));

		// 'Bleakferret_Swordman_2' GenType 1098 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id99", "ep14_1_f_castle_3", Rectangle(-1912.1372, 304.29288, 60));

		// 'Bleakferret_Swordman_2' GenType 1099 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id100", "ep14_1_f_castle_3", Rectangle(-1788.9618, 967.97217, 60));

		// 'Bleakferret_Swordman_2' GenType 1100 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id101", "ep14_1_f_castle_3", Rectangle(-1448.4502, 898.38617, 60));

		// 'Bleakferret_Swordman_2' GenType 1101 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id102", "ep14_1_f_castle_3", Rectangle(-1251.4368, 991.86633, 60));

		// 'Bleakferret_Swordman_2' GenType 1102 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id103", "ep14_1_f_castle_3", Rectangle(-796.3348, 995.3346, 60));

		// 'Bleakferret_Swordman_2' GenType 1103 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id104", "ep14_1_f_castle_3", Rectangle(-86.58857, -1144.9998, 60));

		// 'Bleakferret_Swordman_2' GenType 1104 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id105", "ep14_1_f_castle_3", Rectangle(76.96174, -1399.0592, 60));

		// 'Bleakferret_Swordman_2' GenType 1105 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id106", "ep14_1_f_castle_3", Rectangle(517.8004, 290.66174, 60));

		// 'Bleakferret_Spear_2' GenType 1106 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id107", "ep14_1_f_castle_3", Rectangle(198.75327, -1460.8965, 60));

		// 'Bleakferret_Spear_2' GenType 1107 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id108", "ep14_1_f_castle_3", Rectangle(-67.5433, -1277.4113, 60));

		// 'Bleakferret_Spear_2' GenType 1108 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id109", "ep14_1_f_castle_3", Rectangle(221.29555, -1112.7439, 60));

		// 'Bleakferret_Spear_2' GenType 1109 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id110", "ep14_1_f_castle_3", Rectangle(482.48566, -1221.9886, 60));

		// 'Bleakferret_Spear_2' GenType 1110 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id111", "ep14_1_f_castle_3", Rectangle(777.94403, -1132.6675, 60));

		// 'Bleakferret_Spear_2' GenType 1111 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id112", "ep14_1_f_castle_3", Rectangle(559.2075, -1654.978, 60));

		// 'Bleakferret_Spear_2' GenType 1112 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id113", "ep14_1_f_castle_3", Rectangle(744.70264, -1442.1154, 60));

		// 'Bleakferret_Spear_2' GenType 1113 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id114", "ep14_1_f_castle_3", Rectangle(888.05066, -1401.0448, 60));

		// 'Bleakferret_Spear_2' GenType 1114 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id115", "ep14_1_f_castle_3", Rectangle(990.8429, -1163.1476, 60));

		// 'Bleakferret_Spear_2' GenType 1115 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id116", "ep14_1_f_castle_3", Rectangle(979.80725, -1677.7488, 60));

		// 'Bleakferret_Spear_2' GenType 1116 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id117", "ep14_1_f_castle_3", Rectangle(1313.641, -1482.5712, 60));

		// 'Bleakferret_Spear_2' GenType 1117 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id118", "ep14_1_f_castle_3", Rectangle(1512.4019, -1147.6587, 60));

		// 'Bleakferret_Spear_2' GenType 1118 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id119", "ep14_1_f_castle_3", Rectangle(1375.0972, -902.16156, 60));

		// 'Bleakferret_Spear_2' GenType 1119 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id120", "ep14_1_f_castle_3", Rectangle(1651.5819, -864.6595, 60));

		// 'Bleakferret_Spear_2' GenType 1120 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id121", "ep14_1_f_castle_3", Rectangle(1704.6102, -707.4582, 60));

		// 'Bleakferret_Spear_2' GenType 1121 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id122", "ep14_1_f_castle_3", Rectangle(1272.2976, -630.66016, 60));

		// 'Bleakferret_Spear_2' GenType 1122 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id123", "ep14_1_f_castle_3", Rectangle(1097.6157, -414.96237, 60));

		// 'Bleakferret_Spear_2' GenType 1123 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id124", "ep14_1_f_castle_3", Rectangle(1007.5138, -264.73416, 60));

		// 'Bleakferret_Spear_2' GenType 1124 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id125", "ep14_1_f_castle_3", Rectangle(884.71704, -563.3157, 60));

		// 'Bleakferret_Spear_2' GenType 1125 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id126", "ep14_1_f_castle_3", Rectangle(656.6313, -352.5163, 60));

		// 'Bleakferret_Spear_2' GenType 1126 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id127", "ep14_1_f_castle_3", Rectangle(769.7518, -855.3506, 60));

		// 'Bleakferret_Spear_2' GenType 1127 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id128", "ep14_1_f_castle_3", Rectangle(535.41315, -617.0519, 60));

		// 'Bleakferret_Spear_2' GenType 1128 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id129", "ep14_1_f_castle_3", Rectangle(269.2312, -365.67828, 60));

		// 'Bleakferret_Spear_2' GenType 1129 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id130", "ep14_1_f_castle_3", Rectangle(-25.669516, -318.09418, 60));

		// 'Bleakferret_Spear_2' GenType 1130 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id131", "ep14_1_f_castle_3", Rectangle(-40.502163, -37.866425, 60));

		// 'Bleakferret_Spear_2' GenType 1131 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id132", "ep14_1_f_castle_3", Rectangle(128.0248, -49.421124, 60));

		// 'Bleakferret_Spear_2' GenType 1132 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id133", "ep14_1_f_castle_3", Rectangle(186.28639, -197.4275, 60));

		// 'Bleakferret_Spear_2' GenType 1133 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id134", "ep14_1_f_castle_3", Rectangle(-169.19998, -311.07028, 60));

		// 'Bleakferret_Spear_2' GenType 1134 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id135", "ep14_1_f_castle_3", Rectangle(-423.88104, -282.99286, 60));

		// 'Bleakferret_Spear_2' GenType 1135 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id136", "ep14_1_f_castle_3", Rectangle(-853.4221, -439.0359, 60));

		// 'Bleakferret_Spear_2' GenType 1136 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id137", "ep14_1_f_castle_3", Rectangle(-739.2474, -188.97443, 60));

		// 'Bleakferret_Spear_2' GenType 1137 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id138", "ep14_1_f_castle_3", Rectangle(-688.96436, -491.4278, 60));

		// 'Bleakferret_Spear_2' GenType 1138 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id139", "ep14_1_f_castle_3", Rectangle(-566.8305, -253.92154, 60));

		// 'Bleakferret_Spear_2' GenType 1139 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id140", "ep14_1_f_castle_3", Rectangle(-758.4005, -707.7127, 60));

		// 'Bleakferret_Spear_2' GenType 1140 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id141", "ep14_1_f_castle_3", Rectangle(-467.8417, -849.421, 60));

		// 'Bleakferret_Spear_2' GenType 1141 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id142", "ep14_1_f_castle_3", Rectangle(-246.33212, -1053.8652, 60));

		// 'Bleakferret_Spear_2' GenType 1142 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id143", "ep14_1_f_castle_3", Rectangle(-829.2718, -991.9398, 60));

		// 'Bleakferret_Spear_2' GenType 1143 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id144", "ep14_1_f_castle_3", Rectangle(-1255.139, -1111.7339, 60));

		// 'Bleakferret_Spear_2' GenType 1144 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id145", "ep14_1_f_castle_3", Rectangle(-1741.5032, -1213.0061, 60));

		// 'Bleakferret_Spear_2' GenType 1145 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id146", "ep14_1_f_castle_3", Rectangle(-1835.8109, -1016.2444, 60));

		// 'Bleakferret_Spear_2' GenType 1146 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id147", "ep14_1_f_castle_3", Rectangle(-1752.1984, -856.9941, 60));

		// 'Bleakferret_Spear_2' GenType 1147 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id148", "ep14_1_f_castle_3", Rectangle(-1607.5194, -1018.8883, 60));

		// 'Bleakferret_Spear_2' GenType 1148 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id149", "ep14_1_f_castle_3", Rectangle(-1839.1055, -1298.6476, 60));

		// 'Bleakferret_Spear_2' GenType 1149 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id150", "ep14_1_f_castle_3", Rectangle(-1744.7423, -709.67255, 60));

		// 'Bleakferret_Spear_2' GenType 1150 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id151", "ep14_1_f_castle_3", Rectangle(-1679.2827, -582.91815, 60));

		// 'Bleakferret_Spear_2' GenType 1151 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id152", "ep14_1_f_castle_3", Rectangle(-1499.9424, -620.12067, 60));

		// 'Bleakferret_Spear_2' GenType 1152 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id153", "ep14_1_f_castle_3", Rectangle(-1247.5098, -526.96857, 60));

		// 'Bleakferret_Spear_2' GenType 1153 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id154", "ep14_1_f_castle_3", Rectangle(-1055.9213, -126.93604, 60));

		// 'Bleakferret_Spear_2' GenType 1154 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id155", "ep14_1_f_castle_3", Rectangle(-1562.3007, -301.62442, 60));

		// 'Bleakferret_Spear_2' GenType 1155 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id156", "ep14_1_f_castle_3", Rectangle(-1610.3541, -71.22745, 60));

		// 'Bleakferret_Spear_2' GenType 1156 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id157", "ep14_1_f_castle_3", Rectangle(-1881.7457, 139.37064, 60));

		// 'Bleakferret_Spear_2' GenType 1157 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id158", "ep14_1_f_castle_3", Rectangle(-1792.064, 347.78232, 60));

		// 'Bleakferret_Spear_2' GenType 1158 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id159", "ep14_1_f_castle_3", Rectangle(-2009.3668, 576.5568, 60));

		// 'Bleakferret_Spear_2' GenType 1159 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id160", "ep14_1_f_castle_3", Rectangle(-1726.3729, 571.48016, 60));

		// 'Bleakferret_Spear_2' GenType 1160 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id161", "ep14_1_f_castle_3", Rectangle(-1934.2301, 741.58875, 60));

		// 'Bleakferret_Spear_2' GenType 1161 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id162", "ep14_1_f_castle_3", Rectangle(-1687.1267, 1036.8214, 60));

		// 'Bleakferret_Spear_2' GenType 1162 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id163", "ep14_1_f_castle_3", Rectangle(-1697.7288, 773.3302, 60));

		// 'Bleakferret_Spear_2' GenType 1163 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id164", "ep14_1_f_castle_3", Rectangle(-1515.0125, 1059.8737, 60));

		// 'Bleakferret_Spear_2' GenType 1164 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id165", "ep14_1_f_castle_3", Rectangle(-1427.6631, 782.7906, 60));

		// 'Bleakferret_Spear_2' GenType 1165 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id166", "ep14_1_f_castle_3", Rectangle(-1271.0415, 867.2807, 60));

		// 'Bleakferret_Spear_2' GenType 1166 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id167", "ep14_1_f_castle_3", Rectangle(-1126.069, 1108.6328, 60));

		// 'Bleakferret_Spear_2' GenType 1167 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id168", "ep14_1_f_castle_3", Rectangle(-1098.6327, 1414.1786, 60));

		// 'Bleakferret_Spear_2' GenType 1168 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id169", "ep14_1_f_castle_3", Rectangle(-807.1032, 1442.1218, 60));

		// 'Bleakferret_Spear_2' GenType 1169 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id170", "ep14_1_f_castle_3", Rectangle(-639.10187, 1163.7445, 60));

		// 'Bleakferret_Spear_2' GenType 1170 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id171", "ep14_1_f_castle_3", Rectangle(-944.45416, 1057.5812, 60));

		// 'Bleakferret_Spear_2' GenType 1171 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id172", "ep14_1_f_castle_3", Rectangle(-902.4047, 899.0888, 60));

		// 'Bleakferret_Spear_2' GenType 1172 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id173", "ep14_1_f_castle_3", Rectangle(-765.0595, 759.5832, 60));

		// 'Bleakferret_Spear_2' GenType 1173 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id174", "ep14_1_f_castle_3", Rectangle(-637.56903, 933.5938, 60));

		// 'Bleakferret_Spear_2' GenType 1174 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id175", "ep14_1_f_castle_3", Rectangle(-535.6699, 868.61743, 60));

		// 'Bleakferret_Spear_2' GenType 1175 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id176", "ep14_1_f_castle_3", Rectangle(-472.51428, 993.6598, 60));

		// 'Bleakferret_Spear_2' GenType 1176 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id177", "ep14_1_f_castle_3", Rectangle(-573.5582, 1339.902, 60));

		// 'Bleakferret_Spear_2' GenType 1177 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id178", "ep14_1_f_castle_3", Rectangle(-249.46974, 1354.3751, 60));

		// 'Bleakferret_Spear_2' GenType 1178 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id179", "ep14_1_f_castle_3", Rectangle(-144.07224, 1544.1079, 60));

		// 'Bleakferret_Spear_2' GenType 1179 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id180", "ep14_1_f_castle_3", Rectangle(-116.9119, 1122.68, 60));

		// 'Bleakferret_Spear_2' GenType 1180 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id181", "ep14_1_f_castle_3", Rectangle(-214.85455, 800.2461, 60));

		// 'Bleakferret_Spear_2' GenType 1181 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id182", "ep14_1_f_castle_3", Rectangle(-87.40869, 481.17844, 60));

		// 'Bleakferret_Spear_2' GenType 1182 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id183", "ep14_1_f_castle_3", Rectangle(153.33388, 386.6745, 60));

		// 'Bleakferret_Spear_2' GenType 1183 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id184", "ep14_1_f_castle_3", Rectangle(99.6239, 610.78357, 60));

		// 'Bleakferret_Spear_2' GenType 1184 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id185", "ep14_1_f_castle_3", Rectangle(298.87128, 688.79724, 60));

		// 'Bleakferret_Spear_2' GenType 1185 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id186", "ep14_1_f_castle_3", Rectangle(346.95853, 367.54163, 60));

		// 'Bleakferret_Spear_2' GenType 1186 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id187", "ep14_1_f_castle_3", Rectangle(167.13232, 787.1141, 60));

		// 'Bleakferret_Spear_2' GenType 1187 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id188", "ep14_1_f_castle_3", Rectangle(235.38374, 1209.4706, 60));

		// 'Bleakferret_Spear_2' GenType 1188 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id189", "ep14_1_f_castle_3", Rectangle(476.7333, 1178.6371, 60));

		// 'Bleakferret_Spear_2' GenType 1189 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id190", "ep14_1_f_castle_3", Rectangle(276.4414, 1391.8102, 60));

		// 'Bleakferret_Spear_2' GenType 1190 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id191", "ep14_1_f_castle_3", Rectangle(386.35522, 1635.7401, 60));

		// 'Bleakferret_Spear_2' GenType 1191 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id192", "ep14_1_f_castle_3", Rectangle(507.78302, 1667.6163, 60));

		// 'Bleakferret_Spear_2' GenType 1192 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id193", "ep14_1_f_castle_3", Rectangle(280.78177, 1761.7979, 60));

		// 'Bleakferret_Spear_2' GenType 1193 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id194", "ep14_1_f_castle_3", Rectangle(404.72485, 1919.5055, 60));

		// 'Bleakferret_Spear_2' GenType 1194 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id195", "ep14_1_f_castle_3", Rectangle(492.19098, 1372.9845, 60));

		// 'Bleakferret_Spear_2' GenType 1195 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id196", "ep14_1_f_castle_3", Rectangle(327.75403, 1093.7476, 60));

		// 'Bleakferret_Spear_2' GenType 1196 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id197", "ep14_1_f_castle_3", Rectangle(617.2897, 215.6085, 60));

		// 'Bleakferret_Spear_2' GenType 1197 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id198", "ep14_1_f_castle_3", Rectangle(709.93085, 26.272057, 60));

		// 'Bleakferret_Spear_2' GenType 1198 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id199", "ep14_1_f_castle_3", Rectangle(1007.4704, 153.6568, 60));

		// 'Bleakferret_Spear_2' GenType 1199 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id200", "ep14_1_f_castle_3", Rectangle(-696.4662, 70.93293, 60));

		// 'Bleakferret_Spear_2' GenType 1200 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_3.Id201", "ep14_1_f_castle_3", Rectangle(-697.73047, 457.63675, 60));
	}
}
