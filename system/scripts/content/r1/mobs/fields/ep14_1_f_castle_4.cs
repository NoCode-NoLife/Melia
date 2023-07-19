//--- Melia Script -----------------------------------------------------------
// ep14_1_f_castle_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Delmore Citadel' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep141FCastle4MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("ep14_1_f_castle_4.Id1", MonsterId.Rootcrystal_05, 21, 28, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id2", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id3", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id4", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id5", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id6", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id7", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id8", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id9", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id10", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id11", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id12", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id13", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id14", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id15", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id16", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id17", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id18", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id19", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id20", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id21", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id22", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id23", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id24", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id25", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id26", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id27", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id28", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id29", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id30", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id31", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id32", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id33", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id34", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id35", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id36", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id37", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id38", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id39", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id40", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id41", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id42", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id43", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id44", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id45", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id46", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id47", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id48", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id49", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id50", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id51", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id52", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id53", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id54", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id55", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id56", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id57", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id58", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id59", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id60", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id61", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id62", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id63", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id64", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id65", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id66", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id67", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id68", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id69", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id70", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id71", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id72", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id73", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id74", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id75", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id76", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id77", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id78", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id79", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id80", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id81", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id82", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id83", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id84", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id85", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id86", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id87", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id88", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id89", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id90", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id91", MonsterId.GresmeBird, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id92", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id93", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id94", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id95", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id96", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id97", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id98", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id99", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id100", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id101", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id102", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id103", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id104", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id105", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id106", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id107", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id108", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id109", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id110", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id111", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id112", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id113", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id114", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id115", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id116", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id117", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id118", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id119", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id120", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id121", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id122", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id123", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id124", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id125", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id126", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id127", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id128", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id129", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id130", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id131", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id132", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id133", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id134", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id135", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id136", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id137", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id138", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id139", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id140", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id141", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id142", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id143", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id144", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id145", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id146", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id147", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id148", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id149", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id150", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id151", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id152", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id153", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id154", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id155", MonsterId.GresmeCrow, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id156", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id157", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id158", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id159", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id160", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id161", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id162", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id163", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id164", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id165", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id166", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id167", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id168", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id169", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id170", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id171", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id172", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id173", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id174", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id175", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id176", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id177", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id178", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id179", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id180", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id181", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id182", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id183", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id184", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id185", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id186", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id187", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id188", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id189", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id190", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id191", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id192", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id193", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id194", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id195", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_4.Id196", MonsterId.GresmeRaven, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 85 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(1218.1619, -1851.4009, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(1246.3615, -1195.3518, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(1234.2327, -519.7438, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(1410.119, 67.12918, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(939.56885, 146.45876, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(538.6161, 1063.0505, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(892.373, 1179.193, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(7.8551636, 1099.4384, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(1037.4742, 1841.1958, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(830.47656, 2215.8167, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(17.45279, 1936.0037, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-328.48746, 2281.1545, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-718.60156, 1978.5138, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-973.51025, 1269.4785, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-567.50867, 838.2515, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-163.21214, -11.351681, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(234.61845, -429.56747, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(421.31204, 20.934204, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-1501.9094, 20.041122, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-738.3306, -159.99475, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-1198.0477, -423.5151, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(635.124, -1223.6453, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-188.65897, -1228.8434, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-419.0977, -1555.6774, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-399.70853, -1997.1599, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-46.48325, -758.7736, 100));
		AddSpawnPoint("ep14_1_f_castle_4.Id1", "ep14_1_f_castle_4", Rectangle(-555.4846, -725.0929, 100));

		// 'GresmeBird' GenType 1001 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id2", "ep14_1_f_castle_4", Rectangle(1056.9158, -1936.7806, 60));

		// 'GresmeBird' GenType 1002 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id3", "ep14_1_f_castle_4", Rectangle(1210.7198, -2022.2087, 60));

		// 'GresmeBird' GenType 1003 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id4", "ep14_1_f_castle_4", Rectangle(1215.0547, -1712.9622, 60));

		// 'GresmeBird' GenType 1004 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id5", "ep14_1_f_castle_4", Rectangle(1081.9761, -1575.8491, 60));

		// 'GresmeBird' GenType 1005 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id6", "ep14_1_f_castle_4", Rectangle(1364.1769, -1676.4839, 60));

		// 'GresmeBird' GenType 1006 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id7", "ep14_1_f_castle_4", Rectangle(1116.6521, -1426.9708, 60));

		// 'GresmeBird' GenType 1007 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id8", "ep14_1_f_castle_4", Rectangle(1373.3292, -1289.3577, 60));

		// 'GresmeBird' GenType 1008 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id9", "ep14_1_f_castle_4", Rectangle(1102.093, -1062.4246, 60));

		// 'GresmeBird' GenType 1009 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id10", "ep14_1_f_castle_4", Rectangle(1258.1724, -1114.028, 60));

		// 'GresmeBird' GenType 1010 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id11", "ep14_1_f_castle_4", Rectangle(828.1999, -1386.7102, 60));

		// 'GresmeBird' GenType 1011 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id12", "ep14_1_f_castle_4", Rectangle(546.3999, -1377.5974, 60));

		// 'GresmeBird' GenType 1012 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id13", "ep14_1_f_castle_4", Rectangle(523.7598, -1096.8328, 60));

		// 'GresmeBird' GenType 1013 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id14", "ep14_1_f_castle_4", Rectangle(821.4623, -1077.9979, 60));

		// 'GresmeBird' GenType 1014 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id15", "ep14_1_f_castle_4", Rectangle(1019.5629, -202.25917, 60));

		// 'GresmeBird' GenType 1015 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id16", "ep14_1_f_castle_4", Rectangle(1192.5658, -89.589005, 60));

		// 'GresmeBird' GenType 1016 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id17", "ep14_1_f_castle_4", Rectangle(1395.5017, -178.7736, 60));

		// 'GresmeBird' GenType 1017 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id18", "ep14_1_f_castle_4", Rectangle(1536.6447, -35.15356, 60));

		// 'GresmeBird' GenType 1018 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id19", "ep14_1_f_castle_4", Rectangle(1324.529, 174.62286, 60));

		// 'GresmeBird' GenType 1019 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id20", "ep14_1_f_castle_4", Rectangle(960.6165, 106.20978, 60));

		// 'GresmeBird' GenType 1020 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id21", "ep14_1_f_castle_4", Rectangle(998.4382, 330.65967, 60));

		// 'GresmeBird' GenType 1021 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id22", "ep14_1_f_castle_4", Rectangle(178.1124, -1203.9137, 60));

		// 'GresmeBird' GenType 1022 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id23", "ep14_1_f_castle_4", Rectangle(-227.54297, -1219.883, 60));

		// 'GresmeBird' GenType 1023 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id24", "ep14_1_f_castle_4", Rectangle(-704.1415, -1790.9424, 60));

		// 'GresmeBird' GenType 1024 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id25", "ep14_1_f_castle_4", Rectangle(-391.79474, -1916.5599, 60));

		// 'GresmeBird' GenType 1025 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id26", "ep14_1_f_castle_4", Rectangle(-346.86386, -2157.6938, 60));

		// 'GresmeBird' GenType 1026 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id27", "ep14_1_f_castle_4", Rectangle(-137.26009, -1895.3108, 60));

		// 'GresmeBird' GenType 1027 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id28", "ep14_1_f_castle_4", Rectangle(-420.9196, -1718.7551, 60));

		// 'GresmeBird' GenType 1028 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id29", "ep14_1_f_castle_4", Rectangle(-502.6975, -1518.7144, 60));

		// 'GresmeBird' GenType 1029 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id30", "ep14_1_f_castle_4", Rectangle(-134.77844, -1621.2823, 60));

		// 'GresmeBird' GenType 1030 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id31", "ep14_1_f_castle_4", Rectangle(-102.97002, -487.3057, 60));

		// 'GresmeBird' GenType 1031 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id32", "ep14_1_f_castle_4", Rectangle(156.67343, -414.79922, 60));

		// 'GresmeBird' GenType 1032 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id33", "ep14_1_f_castle_4", Rectangle(-59.074726, -186.63046, 60));

		// 'GresmeBird' GenType 1033 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id34", "ep14_1_f_castle_4", Rectangle(373.13242, -315.89853, 60));

		// 'GresmeBird' GenType 1034 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id35", "ep14_1_f_castle_4", Rectangle(485.97275, -7.5648394, 60));

		// 'GresmeBird' GenType 1035 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id36", "ep14_1_f_castle_4", Rectangle(49.9832, 179.01378, 60));

		// 'GresmeBird' GenType 1036 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id37", "ep14_1_f_castle_4", Rectangle(351.15182, 178.71957, 60));

		// 'GresmeBird' GenType 1037 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id38", "ep14_1_f_castle_4", Rectangle(-200.7112, 26.884432, 60));

		// 'GresmeBird' GenType 1038 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id39", "ep14_1_f_castle_4", Rectangle(291.01965, -105.5854, 60));

		// 'GresmeBird' GenType 1039 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id40", "ep14_1_f_castle_4", Rectangle(821.43115, 901.1813, 60));

		// 'GresmeBird' GenType 1040 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id41", "ep14_1_f_castle_4", Rectangle(624.8167, 979.65314, 60));

		// 'GresmeBird' GenType 1041 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id42", "ep14_1_f_castle_4", Rectangle(836.391, 1164.0917, 60));

		// 'GresmeBird' GenType 1042 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id43", "ep14_1_f_castle_4", Rectangle(892.9994, 1344.4418, 60));

		// 'GresmeBird' GenType 1043 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id44", "ep14_1_f_castle_4", Rectangle(392.82904, 902.68896, 60));

		// 'GresmeBird' GenType 1044 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id45", "ep14_1_f_castle_4", Rectangle(577.33685, 1186.1223, 60));

		// 'GresmeBird' GenType 1045 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id46", "ep14_1_f_castle_4", Rectangle(-23.419174, 1010.3171, 60));

		// 'GresmeBird' GenType 1046 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id47", "ep14_1_f_castle_4", Rectangle(172.77122, 1308.5947, 60));

		// 'GresmeBird' GenType 1047 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id48", "ep14_1_f_castle_4", Rectangle(900.8683, 1758.7428, 60));

		// 'GresmeBird' GenType 1048 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id49", "ep14_1_f_castle_4", Rectangle(1124.6205, 1903.4387, 60));

		// 'GresmeBird' GenType 1049 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id50", "ep14_1_f_castle_4", Rectangle(879.09076, 2108.6064, 60));

		// 'GresmeBird' GenType 1050 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id51", "ep14_1_f_castle_4", Rectangle(1168.4617, 2236.5972, 60));

		// 'GresmeBird' GenType 1051 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id52", "ep14_1_f_castle_4", Rectangle(902.70605, 2453.1348, 60));

		// 'GresmeBird' GenType 1052 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id53", "ep14_1_f_castle_4", Rectangle(317.57062, 2236.281, 60));

		// 'GresmeBird' GenType 1053 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id54", "ep14_1_f_castle_4", Rectangle(578.16113, 2230.1191, 60));

		// 'GresmeBird' GenType 1054 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id55", "ep14_1_f_castle_4", Rectangle(94.38864, 1991.0259, 60));

		// 'GresmeBird' GenType 1055 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id56", "ep14_1_f_castle_4", Rectangle(43.815018, 2289.6316, 60));

		// 'GresmeBird' GenType 1056 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id57", "ep14_1_f_castle_4", Rectangle(-168.4364, 2344.3032, 60));

		// 'GresmeBird' GenType 1057 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id58", "ep14_1_f_castle_4", Rectangle(-239.30783, 1993.1887, 60));

		// 'GresmeBird' GenType 1058 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id59", "ep14_1_f_castle_4", Rectangle(-440.85574, 1929.7712, 60));

		// 'GresmeBird' GenType 1059 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id60", "ep14_1_f_castle_4", Rectangle(-702.9498, 1944.5447, 60));

		// 'GresmeBird' GenType 1060 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id61", "ep14_1_f_castle_4", Rectangle(-480.65515, 2346.368, 60));

		// 'GresmeBird' GenType 1061 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id62", "ep14_1_f_castle_4", Rectangle(-808.5063, 2172.977, 60));

		// 'GresmeBird' GenType 1062 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id63", "ep14_1_f_castle_4", Rectangle(-506.14868, 2175.3086, 60));

		// 'GresmeBird' GenType 1063 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id64", "ep14_1_f_castle_4", Rectangle(-118.46906, 2129.871, 60));

		// 'GresmeBird' GenType 1064 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id65", "ep14_1_f_castle_4", Rectangle(7.0645905, 1873.3586, 60));

		// 'GresmeBird' GenType 1065 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id66", "ep14_1_f_castle_4", Rectangle(-1043.3632, 1331.4104, 60));

		// 'GresmeBird' GenType 1066 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id67", "ep14_1_f_castle_4", Rectangle(-674.9671, 1395.0187, 60));

		// 'GresmeBird' GenType 1067 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id68", "ep14_1_f_castle_4", Rectangle(-1122.0527, 1093.622, 60));

		// 'GresmeBird' GenType 1068 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id69", "ep14_1_f_castle_4", Rectangle(-795.5184, 1227.4716, 60));

		// 'GresmeBird' GenType 1069 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id70", "ep14_1_f_castle_4", Rectangle(-471.2256, 1279.1809, 60));

		// 'GresmeBird' GenType 1070 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id71", "ep14_1_f_castle_4", Rectangle(-446.7659, 967.8954, 60));

		// 'GresmeBird' GenType 1071 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id72", "ep14_1_f_castle_4", Rectangle(-541.7638, 719.42847, 60));

		// 'GresmeBird' GenType 1072 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id73", "ep14_1_f_castle_4", Rectangle(-788.82, 711.44257, 60));

		// 'GresmeBird' GenType 1073 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id74", "ep14_1_f_castle_4", Rectangle(-645.2445, 977.861, 60));

		// 'GresmeBird' GenType 1074 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id75", "ep14_1_f_castle_4", Rectangle(-947.3303, 819.8593, 60));

		// 'GresmeBird' GenType 1075 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id76", "ep14_1_f_castle_4", Rectangle(-603.1465, -520.3189, 60));

		// 'GresmeBird' GenType 1076 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id77", "ep14_1_f_castle_4", Rectangle(-534.502, -864.7512, 60));

		// 'GresmeBird' GenType 1077 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id78", "ep14_1_f_castle_4", Rectangle(-433.90692, -150.58527, 60));

		// 'GresmeBird' GenType 1078 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id79", "ep14_1_f_castle_4", Rectangle(-668.9022, -273.09027, 60));

		// 'GresmeBird' GenType 1079 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id80", "ep14_1_f_castle_4", Rectangle(-677.17786, -60.10843, 60));

		// 'GresmeBird' GenType 1080 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id81", "ep14_1_f_castle_4", Rectangle(-981.81165, -362.19797, 60));

		// 'GresmeBird' GenType 1081 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id82", "ep14_1_f_castle_4", Rectangle(-921.14905, 126.8953, 60));

		// 'GresmeBird' GenType 1082 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id83", "ep14_1_f_castle_4", Rectangle(-1234.6632, 101.74474, 60));

		// 'GresmeBird' GenType 1083 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id84", "ep14_1_f_castle_4", Rectangle(-1455.2006, 120.65737, 60));

		// 'GresmeBird' GenType 1084 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id85", "ep14_1_f_castle_4", Rectangle(-1735.1064, -57.21306, 60));

		// 'GresmeBird' GenType 1085 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id86", "ep14_1_f_castle_4", Rectangle(-1522.0658, -280.2739, 60));

		// 'GresmeBird' GenType 1086 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id87", "ep14_1_f_castle_4", Rectangle(-1227.9648, -379.04794, 60));

		// 'GresmeBird' GenType 1087 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id88", "ep14_1_f_castle_4", Rectangle(-1364.9435, -32.972042, 60));

		// 'GresmeBird' GenType 1088 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id89", "ep14_1_f_castle_4", Rectangle(-795.4321, -148.40878, 60));

		// 'GresmeBird' GenType 1089 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id90", "ep14_1_f_castle_4", Rectangle(-40.223732, -921.00543, 60));

		// 'GresmeBird' GenType 1090 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id91", "ep14_1_f_castle_4", Rectangle(33.410934, 1601.2578, 60));

		// 'GresmeCrow' GenType 1091 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id92", "ep14_1_f_castle_4", Rectangle(1185.7139, -1876.2886, 60));

		// 'GresmeCrow' GenType 1092 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id93", "ep14_1_f_castle_4", Rectangle(1067.9625, -1728.66, 60));

		// 'GresmeCrow' GenType 1093 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id94", "ep14_1_f_castle_4", Rectangle(1223.3381, -1544.3967, 60));

		// 'GresmeCrow' GenType 1094 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id95", "ep14_1_f_castle_4", Rectangle(1242.5297, -1345.6947, 60));

		// 'GresmeCrow' GenType 1095 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id96", "ep14_1_f_castle_4", Rectangle(1390.4972, -1083.087, 60));

		// 'GresmeCrow' GenType 1096 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id97", "ep14_1_f_castle_4", Rectangle(1194.4872, -917.91583, 60));

		// 'GresmeCrow' GenType 1097 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id98", "ep14_1_f_castle_4", Rectangle(1336.7378, -1840.8398, 60));

		// 'GresmeCrow' GenType 1098 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id99", "ep14_1_f_castle_4", Rectangle(1225.6791, -701.74445, 60));

		// 'GresmeCrow' GenType 1099 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id100", "ep14_1_f_castle_4", Rectangle(1348.959, -15.237089, 60));

		// 'GresmeCrow' GenType 1100 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id101", "ep14_1_f_castle_4", Rectangle(1134.8444, 157.76372, 60));

		// 'GresmeCrow' GenType 1101 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id102", "ep14_1_f_castle_4", Rectangle(1421.6292, 306.44333, 60));

		// 'GresmeCrow' GenType 1102 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id103", "ep14_1_f_castle_4", Rectangle(1647.4319, 112.97453, 60));

		// 'GresmeCrow' GenType 1103 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id104", "ep14_1_f_castle_4", Rectangle(999.338, -58.04226, 60));

		// 'GresmeCrow' GenType 1104 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id105", "ep14_1_f_castle_4", Rectangle(824.854, 237.81941, 60));

		// 'GresmeCrow' GenType 1105 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id106", "ep14_1_f_castle_4", Rectangle(489.67758, -174.99403, 60));

		// 'GresmeCrow' GenType 1106 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id107", "ep14_1_f_castle_4", Rectangle(244.7081, 62.41691, 60));

		// 'GresmeCrow' GenType 1107 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id108", "ep14_1_f_castle_4", Rectangle(174.19897, -238.51657, 60));

		// 'GresmeCrow' GenType 1108 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id109", "ep14_1_f_castle_4", Rectangle(-16.808662, -340.4972, 60));

		// 'GresmeCrow' GenType 1109 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id110", "ep14_1_f_castle_4", Rectangle(-145.13782, 200.2896, 60));

		// 'GresmeCrow' GenType 1110 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id111", "ep14_1_f_castle_4", Rectangle(-240.40247, -125.49824, 60));

		// 'GresmeCrow' GenType 1111 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id112", "ep14_1_f_castle_4", Rectangle(529.7316, 798.2602, 60));

		// 'GresmeCrow' GenType 1112 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id113", "ep14_1_f_castle_4", Rectangle(139.84314, 846.21265, 60));

		// 'GresmeCrow' GenType 1113 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id114", "ep14_1_f_castle_4", Rectangle(456.97012, 1079.0193, 60));

		// 'GresmeCrow' GenType 1114 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id115", "ep14_1_f_castle_4", Rectangle(35.298073, 1193.7761, 60));

		// 'GresmeCrow' GenType 1115 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id116", "ep14_1_f_castle_4", Rectangle(750.97906, 1066.9563, 60));

		// 'GresmeCrow' GenType 1116 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id117", "ep14_1_f_castle_4", Rectangle(756.81775, 1300.174, 60));

		// 'GresmeCrow' GenType 1117 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id118", "ep14_1_f_castle_4", Rectangle(867.03436, 1918.4757, 60));

		// 'GresmeCrow' GenType 1118 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id119", "ep14_1_f_castle_4", Rectangle(1074.9722, 1752.0288, 60));

		// 'GresmeCrow' GenType 1119 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id120", "ep14_1_f_castle_4", Rectangle(1154.8771, 2070.6462, 60));

		// 'GresmeCrow' GenType 1120 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id121", "ep14_1_f_castle_4", Rectangle(832.30035, 2318.3242, 60));

		// 'GresmeCrow' GenType 1121 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id122", "ep14_1_f_castle_4", Rectangle(1088.2959, 2421.0574, 60));

		// 'GresmeCrow' GenType 1122 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id123", "ep14_1_f_castle_4", Rectangle(451.6791, 2252.986, 60));

		// 'GresmeCrow' GenType 1123 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id124", "ep14_1_f_castle_4", Rectangle(63.56273, 2132.1184, 60));

		// 'GresmeCrow' GenType 1124 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id125", "ep14_1_f_castle_4", Rectangle(-84.77965, 1993.1735, 60));

		// 'GresmeCrow' GenType 1125 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id126", "ep14_1_f_castle_4", Rectangle(-289.67532, 2199.917, 60));

		// 'GresmeCrow' GenType 1126 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id127", "ep14_1_f_castle_4", Rectangle(-582.708, 2032.756, 60));

		// 'GresmeCrow' GenType 1127 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id128", "ep14_1_f_castle_4", Rectangle(-673.18536, 2316.1094, 60));

		// 'GresmeCrow' GenType 1128 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id129", "ep14_1_f_castle_4", Rectangle(-983.67206, 1170.4496, 60));

		// 'GresmeCrow' GenType 1129 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id130", "ep14_1_f_castle_4", Rectangle(-893.5842, 948.10376, 60));

		// 'GresmeCrow' GenType 1130 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id131", "ep14_1_f_castle_4", Rectangle(-589.49866, 844.84753, 60));

		// 'GresmeCrow' GenType 1131 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id132", "ep14_1_f_castle_4", Rectangle(-561.87164, 1064.6956, 60));

		// 'GresmeCrow' GenType 1132 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id133", "ep14_1_f_castle_4", Rectangle(-943.0122, 666.57446, 60));

		// 'GresmeCrow' GenType 1133 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id134", "ep14_1_f_castle_4", Rectangle(-767.0742, 64.43366, 60));

		// 'GresmeCrow' GenType 1134 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id135", "ep14_1_f_castle_4", Rectangle(-1556.6554, -12.525414, 60));

		// 'GresmeCrow' GenType 1135 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id136", "ep14_1_f_castle_4", Rectangle(-1346.5424, -287.73383, 60));

		// 'GresmeCrow' GenType 1136 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id137", "ep14_1_f_castle_4", Rectangle(-1110.9116, -295.3029, 60));

		// 'GresmeCrow' GenType 1137 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id138", "ep14_1_f_castle_4", Rectangle(-836.4953, -307.2932, 60));

		// 'GresmeCrow' GenType 1138 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id139", "ep14_1_f_castle_4", Rectangle(-583.5338, -181.60101, 60));

		// 'GresmeCrow' GenType 1139 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id140", "ep14_1_f_castle_4", Rectangle(-533.9594, -392.80093, 60));

		// 'GresmeCrow' GenType 1140 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id141", "ep14_1_f_castle_4", Rectangle(-337.06454, -24.506767, 60));

		// 'GresmeCrow' GenType 1141 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id142", "ep14_1_f_castle_4", Rectangle(32.41497, -14.307816, 60));

		// 'GresmeCrow' GenType 1142 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id143", "ep14_1_f_castle_4", Rectangle(-71.39638, -682.3864, 60));

		// 'GresmeCrow' GenType 1143 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id144", "ep14_1_f_castle_4", Rectangle(-9.732216, -1180.3691, 60));

		// 'GresmeCrow' GenType 1144 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id145", "ep14_1_f_castle_4", Rectangle(403.403, -1297.4749, 60));

		// 'GresmeCrow' GenType 1145 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id146", "ep14_1_f_castle_4", Rectangle(661.7572, -1242.8573, 60));

		// 'GresmeCrow' GenType 1146 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id147", "ep14_1_f_castle_4", Rectangle(855.60565, -1238.4331, 60));

		// 'GresmeCrow' GenType 1147 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id148", "ep14_1_f_castle_4", Rectangle(-188.10799, -2032.2885, 60));

		// 'GresmeCrow' GenType 1148 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id149", "ep14_1_f_castle_4", Rectangle(-532.1016, -1892.0626, 60));

		// 'GresmeCrow' GenType 1149 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id150", "ep14_1_f_castle_4", Rectangle(-616.0241, -1626.2793, 60));

		// 'GresmeCrow' GenType 1150 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id151", "ep14_1_f_castle_4", Rectangle(-199.33243, -1744.3356, 60));

		// 'GresmeCrow' GenType 1151 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id152", "ep14_1_f_castle_4", Rectangle(-351.34442, -1591.8513, 60));

		// 'GresmeCrow' GenType 1152 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id153", "ep14_1_f_castle_4", Rectangle(-276.70184, -1383.2246, 60));

		// 'GresmeCrow' GenType 1153 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id154", "ep14_1_f_castle_4", Rectangle(-427.19052, -1238.8743, 60));

		// 'GresmeCrow' GenType 1154 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id155", "ep14_1_f_castle_4", Rectangle(-565.99414, -1055.829, 60));

		// 'GresmeRaven' GenType 1155 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id156", "ep14_1_f_castle_4", Rectangle(1371.6664, -1460.1437, 60));

		// 'GresmeRaven' GenType 1157 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id157", "ep14_1_f_castle_4", Rectangle(1373.4401, -929.45685, 60));

		// 'GresmeRaven' GenType 1158 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id158", "ep14_1_f_castle_4", Rectangle(659.8345, -1021.8817, 60));

		// 'GresmeRaven' GenType 1159 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id159", "ep14_1_f_castle_4", Rectangle(695.3453, -1469.5186, 60));

		// 'GresmeRaven' GenType 1161 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id160", "ep14_1_f_castle_4", Rectangle(1253.2134, -225.57089, 60));

		// 'GresmeRaven' GenType 1162 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id161", "ep14_1_f_castle_4", Rectangle(1200.699, 318.89853, 60));

		// 'GresmeRaven' GenType 1164 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id162", "ep14_1_f_castle_4", Rectangle(789.6564, -158.3276, 60));

		// 'GresmeRaven' GenType 1165 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id163", "ep14_1_f_castle_4", Rectangle(675.6174, 841.8155, 60));

		// 'GresmeRaven' GenType 1166 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id164", "ep14_1_f_castle_4", Rectangle(935.44836, 999.27203, 60));

		// 'GresmeRaven' GenType 1167 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id165", "ep14_1_f_castle_4", Rectangle(982.83435, 1206.9583, 60));

		// 'GresmeRaven' GenType 1169 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id166", "ep14_1_f_castle_4", Rectangle(238.16919, 981.71674, 60));

		// 'GresmeRaven' GenType 1171 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id167", "ep14_1_f_castle_4", Rectangle(1013.0522, 2290.8428, 60));

		// 'GresmeRaven' GenType 1172 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id168", "ep14_1_f_castle_4", Rectangle(806.42236, 1602.2744, 60));

		// 'GresmeRaven' GenType 1173 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id169", "ep14_1_f_castle_4", Rectangle(182.47415, 2238.8088, 60));

		// 'GresmeRaven' GenType 1174 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id170", "ep14_1_f_castle_4", Rectangle(-70.22723, 2238.6753, 60));

		// 'GresmeRaven' GenType 1175 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id171", "ep14_1_f_castle_4", Rectangle(-324.9787, 2391.189, 60));

		// 'GresmeRaven' GenType 1177 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id172", "ep14_1_f_castle_4", Rectangle(-576.89355, 1843.355, 60));

		// 'GresmeRaven' GenType 1178 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id173", "ep14_1_f_castle_4", Rectangle(-820.53375, 2025.6597, 60));

		// 'GresmeRaven' GenType 1179 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id174", "ep14_1_f_castle_4", Rectangle(-883.73145, 1366.9971, 60));

		// 'GresmeRaven' GenType 1180 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id175", "ep14_1_f_castle_4", Rectangle(-623.7116, 1223.6865, 60));

		// 'GresmeRaven' GenType 1182 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id176", "ep14_1_f_castle_4", Rectangle(-1110.3501, 919.1161, 60));

		// 'GresmeRaven' GenType 1183 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id177", "ep14_1_f_castle_4", Rectangle(-756.6554, 857.45447, 60));

		// 'GresmeRaven' GenType 1184 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id178", "ep14_1_f_castle_4", Rectangle(-434.14777, 806.4052, 60));

		// 'GresmeRaven' GenType 1185 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id179", "ep14_1_f_castle_4", Rectangle(-232.99734, 1108.4637, 60));

		// 'GresmeRaven' GenType 1186 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id180", "ep14_1_f_castle_4", Rectangle(-145.41513, -266.44843, 60));

		// 'GresmeRaven' GenType 1187 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id181", "ep14_1_f_castle_4", Rectangle(92.96254, -151.63843, 60));

		// 'GresmeRaven' GenType 1188 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id182", "ep14_1_f_castle_4", Rectangle(184.3137, 252.01541, 60));

		// 'GresmeRaven' GenType 1189 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id183", "ep14_1_f_castle_4", Rectangle(384.18008, -39.828846, 60));

		// 'GresmeRaven' GenType 1190 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id184", "ep14_1_f_castle_4", Rectangle(281.19342, -382.63312, 60));

		// 'GresmeRaven' GenType 1191 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id185", "ep14_1_f_castle_4", Rectangle(436.91922, -463.4295, 60));

		// 'GresmeRaven' GenType 1192 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id186", "ep14_1_f_castle_4", Rectangle(33.855206, -544.59656, 60));

		// 'GresmeRaven' GenType 1193 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id187", "ep14_1_f_castle_4", Rectangle(343.68317, -1128.6981, 60));

		// 'GresmeRaven' GenType 1194 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id188", "ep14_1_f_castle_4", Rectangle(49.075935, -1345.4387, 60));

		// 'GresmeRaven' GenType 1196 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id189", "ep14_1_f_castle_4", Rectangle(-321.89505, -2032.7856, 60));

		// 'GresmeRaven' GenType 1197 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id190", "ep14_1_f_castle_4", Rectangle(-545.4945, -1759.7478, 60));

		// 'GresmeRaven' GenType 1198 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id191", "ep14_1_f_castle_4", Rectangle(-256.061, -1513.2173, 60));

		// 'GresmeRaven' GenType 1199 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id192", "ep14_1_f_castle_4", Rectangle(-1464.0632, -144.02338, 60));

		// 'GresmeRaven' GenType 1200 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id193", "ep14_1_f_castle_4", Rectangle(-1045.899, 35.31711, 60));

		// 'GresmeRaven' GenType 1201 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id194", "ep14_1_f_castle_4", Rectangle(-1083.8942, -452.7702, 60));

		// 'GresmeRaven' GenType 1202 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id195", "ep14_1_f_castle_4", Rectangle(-699.186, -416.2738, 60));

		// 'GresmeRaven' GenType 1203 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_4.Id196", "ep14_1_f_castle_4", Rectangle(-520.59247, -36.379044, 60));
	}
}
