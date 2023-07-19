//--- Melia Script -----------------------------------------------------------
// ep14_1_f_castle_5
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Delmore Garden' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep141FCastle5MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("ep14_1_f_castle_5.Id1", MonsterId.Rootcrystal_05, 15, 19, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id2", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id3", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id4", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id5", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id6", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id7", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id8", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id9", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id10", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id11", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id12", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id13", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id14", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id15", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id16", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id17", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id18", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id19", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id20", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id21", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id22", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id23", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id24", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id25", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id26", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id27", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id28", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id29", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id30", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id31", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id32", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id33", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id34", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id35", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id36", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id37", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id38", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id39", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id40", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id41", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id42", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id43", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id44", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id45", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id46", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id47", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id48", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id49", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id50", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id51", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id52", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id53", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id54", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id55", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id56", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id57", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id58", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id59", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id60", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id61", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id62", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id63", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id64", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id65", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id66", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id67", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id68", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id69", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id70", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id71", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id72", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id73", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id74", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id75", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id76", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id77", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id78", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id79", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id80", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id81", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id82", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id83", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id84", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id85", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id86", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id87", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id88", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id89", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id90", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id91", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id92", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id93", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id94", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id95", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id96", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id97", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id98", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id99", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id100", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id101", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id102", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id103", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id104", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id105", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id106", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id107", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id108", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id109", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id110", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id111", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id112", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id113", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id114", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id115", MonsterId.TransmutationPeople, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id116", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id117", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id118", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id119", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id120", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id121", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id122", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id123", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id124", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id125", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id126", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id127", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id128", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id129", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id130", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id131", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id132", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id133", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id134", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id135", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id136", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id137", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id138", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id139", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id140", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id141", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id142", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id143", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id144", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id145", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id146", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id147", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id148", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id149", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id150", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id151", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id152", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id153", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id154", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id155", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id156", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id157", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id158", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id159", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id160", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id161", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id162", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id163", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id164", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id165", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id166", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id167", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id168", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id169", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id170", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id171", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id172", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id173", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id174", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id175", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id176", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id177", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id178", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id179", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id180", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id181", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id182", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id183", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id184", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id185", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id186", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id187", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id188", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id189", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id190", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id191", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id192", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id193", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id194", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id195", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id196", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id197", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id198", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id199", MonsterId.TransmutationMerchant, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id200", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id201", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id202", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id203", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id204", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id205", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id206", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id207", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id208", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id209", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id210", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id211", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id212", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id213", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id214", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id215", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id216", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id217", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id218", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id219", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id220", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id221", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id222", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id223", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id224", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id225", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id226", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id227", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id228", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id229", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id230", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id231", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id232", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id233", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id234", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id235", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id236", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id237", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id238", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id239", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id240", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id241", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id242", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id243", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id244", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id245", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id246", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id247", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id248", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id249", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("ep14_1_f_castle_5.Id250", MonsterId.TransmutationSoldier, 1, 1, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 16 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(1554.3754, -362.3692, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(1510.7968, 421.0712, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(1025.8295, 1200.8743, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(1755.3195, 1148.319, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(124.80705, 1283.4001, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(-778.4519, 1252.1609, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(-862.28925, 403.9703, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(-872.1693, -370.97144, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(-773.8568, -1261.324, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(9.686436, -1016.2645, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(881.7107, -1316.9004, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(1435.6998, -1319.4265, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(-20.186813, -1577.873, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(-75.95358, -324.94794, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(673.1997, -368.54004, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(7.915333, 516.33264, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(642.3908, 530.9823, 200));
		AddSpawnPoint("ep14_1_f_castle_5.Id1", "ep14_1_f_castle_5", Rectangle(333.01538, 84.61632, 200));

		// 'TransmutationPeople' GenType 1001 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id2", "ep14_1_f_castle_5", Rectangle(1345.7987, -168.09361, 20));

		// 'TransmutationPeople' GenType 1002 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id3", "ep14_1_f_castle_5", Rectangle(1307.0013, -340.34253, 20));

		// 'TransmutationPeople' GenType 1003 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id4", "ep14_1_f_castle_5", Rectangle(1645.036, -674.0991, 20));

		// 'TransmutationPeople' GenType 1004 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id5", "ep14_1_f_castle_5", Rectangle(1631.9474, -530.14294, 20));

		// 'TransmutationPeople' GenType 1005 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id6", "ep14_1_f_castle_5", Rectangle(1485.7336, -371.77972, 20));

		// 'TransmutationPeople' GenType 1006 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id7", "ep14_1_f_castle_5", Rectangle(1644.9064, -408.2417, 20));

		// 'TransmutationPeople' GenType 1007 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id8", "ep14_1_f_castle_5", Rectangle(1592.4517, -185.28648, 20));

		// 'TransmutationPeople' GenType 1008 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id9", "ep14_1_f_castle_5", Rectangle(1465.0315, -90.132065, 20));

		// 'TransmutationPeople' GenType 1009 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id10", "ep14_1_f_castle_5", Rectangle(1442.994, 139.82275, 20));

		// 'TransmutationPeople' GenType 1010 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id11", "ep14_1_f_castle_5", Rectangle(1313.6459, 229.53487, 20));

		// 'TransmutationPeople' GenType 1011 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id12", "ep14_1_f_castle_5", Rectangle(1333.9314, 407.7618, 20));

		// 'TransmutationPeople' GenType 1012 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id13", "ep14_1_f_castle_5", Rectangle(1402.6045, 492.35196, 20));

		// 'TransmutationPeople' GenType 1013 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id14", "ep14_1_f_castle_5", Rectangle(1491.9996, 277.4975, 20));

		// 'TransmutationPeople' GenType 1014 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id15", "ep14_1_f_castle_5", Rectangle(1530.5786, 537.3483, 20));

		// 'TransmutationPeople' GenType 1015 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id16", "ep14_1_f_castle_5", Rectangle(1610.4481, 683.3446, 20));

		// 'TransmutationPeople' GenType 1016 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id17", "ep14_1_f_castle_5", Rectangle(1663.8765, 229.91554, 20));

		// 'TransmutationPeople' GenType 1017 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id18", "ep14_1_f_castle_5", Rectangle(1757.912, 427.36237, 20));

		// 'TransmutationPeople' GenType 1018 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id19", "ep14_1_f_castle_5", Rectangle(1799.1243, 527.70325, 20));

		// 'TransmutationPeople' GenType 1019 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id20", "ep14_1_f_castle_5", Rectangle(1578.4207, 142.79141, 20));

		// 'TransmutationPeople' GenType 1020 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id21", "ep14_1_f_castle_5", Rectangle(1769.277, 907.84894, 20));

		// 'TransmutationPeople' GenType 1021 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id22", "ep14_1_f_castle_5", Rectangle(1751.3933, 1235.4143, 20));

		// 'TransmutationPeople' GenType 1022 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id23", "ep14_1_f_castle_5", Rectangle(1575.5856, 1324.2113, 20));

		// 'TransmutationPeople' GenType 1023 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id24", "ep14_1_f_castle_5", Rectangle(847.0274, 1463.6774, 20));

		// 'TransmutationPeople' GenType 1024 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id25", "ep14_1_f_castle_5", Rectangle(832.23663, 1334.986, 20));

		// 'TransmutationPeople' GenType 1025 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id26", "ep14_1_f_castle_5", Rectangle(995.3799, 1415.4786, 20));

		// 'TransmutationPeople' GenType 1026 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id27", "ep14_1_f_castle_5", Rectangle(1027.6886, 1278.4496, 20));

		// 'TransmutationPeople' GenType 1027 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id28", "ep14_1_f_castle_5", Rectangle(1196.0804, 1362.5417, 20));

		// 'TransmutationPeople' GenType 1028 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id29", "ep14_1_f_castle_5", Rectangle(796.1704, 1100.522, 20));

		// 'TransmutationPeople' GenType 1029 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id30", "ep14_1_f_castle_5", Rectangle(983.7007, 973.596, 20));

		// 'TransmutationPeople' GenType 1030 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id31", "ep14_1_f_castle_5", Rectangle(1015.1919, 1122.157, 20));

		// 'TransmutationPeople' GenType 1031 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id32", "ep14_1_f_castle_5", Rectangle(1233.1962, 1087.6993, 20));

		// 'TransmutationPeople' GenType 1032 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id33", "ep14_1_f_castle_5", Rectangle(366.92743, 1073.3794, 20));

		// 'TransmutationPeople' GenType 1033 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id34", "ep14_1_f_castle_5", Rectangle(143.1227, 1029.8198, 20));

		// 'TransmutationPeople' GenType 1034 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id35", "ep14_1_f_castle_5", Rectangle(8.980595, 1202.1055, 20));

		// 'TransmutationPeople' GenType 1035 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id36", "ep14_1_f_castle_5", Rectangle(9.784599, 1415.4011, 20));

		// 'TransmutationPeople' GenType 1036 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id37", "ep14_1_f_castle_5", Rectangle(72.44333, 1602.422, 20));

		// 'TransmutationPeople' GenType 1037 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id38", "ep14_1_f_castle_5", Rectangle(268.65738, 1595.013, 20));

		// 'TransmutationPeople' GenType 1038 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id39", "ep14_1_f_castle_5", Rectangle(391.65588, 1371.7749, 20));

		// 'TransmutationPeople' GenType 1039 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id40", "ep14_1_f_castle_5", Rectangle(408.3462, 1235.1223, 20));

		// 'TransmutationPeople' GenType 1040 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id41", "ep14_1_f_castle_5", Rectangle(-926.86163, 1106.1469, 20));

		// 'TransmutationPeople' GenType 1041 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id42", "ep14_1_f_castle_5", Rectangle(-820.08966, 961.6974, 20));

		// 'TransmutationPeople' GenType 1042 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id43", "ep14_1_f_castle_5", Rectangle(-517.4932, 932.37427, 20));

		// 'TransmutationPeople' GenType 1043 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id44", "ep14_1_f_castle_5", Rectangle(-488.52808, 1094.5833, 20));

		// 'TransmutationPeople' GenType 1044 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id45", "ep14_1_f_castle_5", Rectangle(-636.80566, 1163.0137, 20));

		// 'TransmutationPeople' GenType 1045 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id46", "ep14_1_f_castle_5", Rectangle(-566.9806, 1270.8218, 20));

		// 'TransmutationPeople' GenType 1046 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id47", "ep14_1_f_castle_5", Rectangle(-836.0458, 1254.84, 20));

		// 'TransmutationPeople' GenType 1047 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id48", "ep14_1_f_castle_5", Rectangle(-808.4964, 1427.7019, 20));

		// 'TransmutationPeople' GenType 1048 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id49", "ep14_1_f_castle_5", Rectangle(-1043.6384, 1432.8911, 20));

		// 'TransmutationPeople' GenType 1049 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id50", "ep14_1_f_castle_5", Rectangle(-779.79785, 1569.3713, 20));

		// 'TransmutationPeople' GenType 1050 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id51", "ep14_1_f_castle_5", Rectangle(-522.37036, 1563.1814, 20));

		// 'TransmutationPeople' GenType 1051 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id52", "ep14_1_f_castle_5", Rectangle(-537.70374, 1387.1521, 20));

		// 'TransmutationPeople' GenType 1052 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id53", "ep14_1_f_castle_5", Rectangle(-1088.5249, 536.7305, 20));

		// 'TransmutationPeople' GenType 1053 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id54", "ep14_1_f_castle_5", Rectangle(-1045.692, 341.0797, 20));

		// 'TransmutationPeople' GenType 1054 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id55", "ep14_1_f_castle_5", Rectangle(-769.968, 332.36234, 20));

		// 'TransmutationPeople' GenType 1055 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id56", "ep14_1_f_castle_5", Rectangle(-683.4362, 579.10315, 20));

		// 'TransmutationPeople' GenType 1056 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id57", "ep14_1_f_castle_5", Rectangle(-858.508, 293.22726, 20));

		// 'TransmutationPeople' GenType 1057 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id58", "ep14_1_f_castle_5", Rectangle(-674.39905, 268.95703, 20));

		// 'TransmutationPeople' GenType 1058 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id59", "ep14_1_f_castle_5", Rectangle(-946.65375, 161.38533, 20));

		// 'TransmutationPeople' GenType 1059 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id60", "ep14_1_f_castle_5", Rectangle(-738.06854, 97.74202, 20));

		// 'TransmutationPeople' GenType 1060 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id61", "ep14_1_f_castle_5", Rectangle(-980.08905, -0.8702736, 20));

		// 'TransmutationPeople' GenType 1061 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id62", "ep14_1_f_castle_5", Rectangle(-737.3264, -28.94051, 20));

		// 'TransmutationPeople' GenType 1062 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id63", "ep14_1_f_castle_5", Rectangle(-975.61096, -226.72604, 20));

		// 'TransmutationPeople' GenType 1063 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id64", "ep14_1_f_castle_5", Rectangle(-904.3404, -137.12193, 20));

		// 'TransmutationPeople' GenType 1064 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id65", "ep14_1_f_castle_5", Rectangle(-677.8204, -134.80722, 20));

		// 'TransmutationPeople' GenType 1065 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id66", "ep14_1_f_castle_5", Rectangle(-1108.5568, -361.71933, 20));

		// 'TransmutationPeople' GenType 1066 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id67", "ep14_1_f_castle_5", Rectangle(-851.2201, -302.2162, 20));

		// 'TransmutationPeople' GenType 1067 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id68", "ep14_1_f_castle_5", Rectangle(-710.6433, -397.94934, 20));

		// 'TransmutationPeople' GenType 1068 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id69", "ep14_1_f_castle_5", Rectangle(-1003.0852, -488.50327, 20));

		// 'TransmutationPeople' GenType 1069 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id70", "ep14_1_f_castle_5", Rectangle(-795.4857, -615.5266, 20));

		// 'TransmutationPeople' GenType 1070 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id71", "ep14_1_f_castle_5", Rectangle(-890.0699, -1149.4746, 20));

		// 'TransmutationPeople' GenType 1071 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id72", "ep14_1_f_castle_5", Rectangle(-764.91296, -1480.9479, 20));

		// 'TransmutationPeople' GenType 1072 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id73", "ep14_1_f_castle_5", Rectangle(-574.8328, -1437.0383, 20));

		// 'TransmutationPeople' GenType 1073 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id74", "ep14_1_f_castle_5", Rectangle(-743.732, -1206.9182, 20));

		// 'TransmutationPeople' GenType 1074 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id75", "ep14_1_f_castle_5", Rectangle(-543.8993, -1098.2756, 20));

		// 'TransmutationPeople' GenType 1075 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id76", "ep14_1_f_castle_5", Rectangle(-724.833, -1011.6462, 20));

		// 'TransmutationPeople' GenType 1076 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id77", "ep14_1_f_castle_5", Rectangle(-991.21796, -1270.5613, 20));

		// 'TransmutationPeople' GenType 1077 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id78", "ep14_1_f_castle_5", Rectangle(-273.36328, -1090.3141, 20));

		// 'TransmutationPeople' GenType 1078 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id79", "ep14_1_f_castle_5", Rectangle(-36.39753, -1252.8282, 20));

		// 'TransmutationPeople' GenType 1079 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id80", "ep14_1_f_castle_5", Rectangle(147.37546, -1143.5873, 20));

		// 'TransmutationPeople' GenType 1080 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id81", "ep14_1_f_castle_5", Rectangle(15.438932, -1056.6754, 20));

		// 'TransmutationPeople' GenType 1081 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id82", "ep14_1_f_castle_5", Rectangle(-128.87039, -844.1609, 20));

		// 'TransmutationPeople' GenType 1082 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id83", "ep14_1_f_castle_5", Rectangle(245.46155, -921.51355, 20));

		// 'TransmutationPeople' GenType 1083 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id84", "ep14_1_f_castle_5", Rectangle(12.8269, -1591.2627, 20));

		// 'TransmutationPeople' GenType 1084 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id85", "ep14_1_f_castle_5", Rectangle(233.3581, -1586.5769, 20));

		// 'TransmutationPeople' GenType 1085 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id86", "ep14_1_f_castle_5", Rectangle(693.6211, -1411.3689, 20));

		// 'TransmutationPeople' GenType 1086 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id87", "ep14_1_f_castle_5", Rectangle(1012.2281, -1584.9072, 20));

		// 'TransmutationPeople' GenType 1087 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id88", "ep14_1_f_castle_5", Rectangle(1120.7552, -1461.1506, 20));

		// 'TransmutationPeople' GenType 1088 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id89", "ep14_1_f_castle_5", Rectangle(875.8266, -1347.7255, 20));

		// 'TransmutationPeople' GenType 1089 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id90", "ep14_1_f_castle_5", Rectangle(1057.4958, -1269.5538, 20));

		// 'TransmutationPeople' GenType 1090 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id91", "ep14_1_f_castle_5", Rectangle(797.2758, -1134.2355, 20));

		// 'TransmutationPeople' GenType 1091 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id92", "ep14_1_f_castle_5", Rectangle(1069.5463, -1028.4492, 20));

		// 'TransmutationPeople' GenType 1092 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id93", "ep14_1_f_castle_5", Rectangle(853.3128, -949.2759, 20));

		// 'TransmutationPeople' GenType 1093 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id94", "ep14_1_f_castle_5", Rectangle(1371.5012, -1404.1617, 20));

		// 'TransmutationPeople' GenType 1094 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id95", "ep14_1_f_castle_5", Rectangle(1592.8231, -916.6498, 20));

		// 'TransmutationPeople' GenType 1095 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id96", "ep14_1_f_castle_5", Rectangle(-131.97156, -271.41275, 20));

		// 'TransmutationPeople' GenType 1096 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id97", "ep14_1_f_castle_5", Rectangle(58.736618, -451.96558, 20));

		// 'TransmutationPeople' GenType 1097 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id98", "ep14_1_f_castle_5", Rectangle(196.74182, -287.7089, 20));

		// 'TransmutationPeople' GenType 1098 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id99", "ep14_1_f_castle_5", Rectangle(430.41776, -480.8084, 20));

		// 'TransmutationPeople' GenType 1099 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id100", "ep14_1_f_castle_5", Rectangle(576.8218, -339.79407, 20));

		// 'TransmutationPeople' GenType 1100 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id101", "ep14_1_f_castle_5", Rectangle(797.13477, -416.08618, 20));

		// 'TransmutationPeople' GenType 1101 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id102", "ep14_1_f_castle_5", Rectangle(-40.358936, 100.07184, 20));

		// 'TransmutationPeople' GenType 1102 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id103", "ep14_1_f_castle_5", Rectangle(212.74313, -93.1736, 20));

		// 'TransmutationPeople' GenType 1103 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id104", "ep14_1_f_castle_5", Rectangle(464.43945, 31.945826, 20));

		// 'TransmutationPeople' GenType 1104 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id105", "ep14_1_f_castle_5", Rectangle(559.04785, -84.60374, 20));

		// 'TransmutationPeople' GenType 1105 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id106", "ep14_1_f_castle_5", Rectangle(873.83435, -290.9208, 20));

		// 'TransmutationPeople' GenType 1106 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id107", "ep14_1_f_castle_5", Rectangle(53.104588, 367.84903, 20));

		// 'TransmutationPeople' GenType 1107 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id108", "ep14_1_f_castle_5", Rectangle(314.98386, 590.12494, 20));

		// 'TransmutationPeople' GenType 1108 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id109", "ep14_1_f_castle_5", Rectangle(445.81836, 329.48294, 20));

		// 'TransmutationPeople' GenType 1109 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id110", "ep14_1_f_castle_5", Rectangle(501.8589, 620.9164, 20));

		// 'TransmutationPeople' GenType 1110 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id111", "ep14_1_f_castle_5", Rectangle(723.61237, 527.3648, 20));

		// 'TransmutationPeople' GenType 1111 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id112", "ep14_1_f_castle_5", Rectangle(676.6723, 370.75558, 20));

		// 'TransmutationPeople' GenType 1112 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id113", "ep14_1_f_castle_5", Rectangle(944.1284, 476.2444, 20));

		// 'TransmutationPeople' GenType 1113 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id114", "ep14_1_f_castle_5", Rectangle(-701.1064, -1388.8422, 20));

		// 'TransmutationPeople' GenType 1114 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id115", "ep14_1_f_castle_5", Rectangle(-458.8507, -1225.3308, 20));

		// 'TransmutationMerchant' GenType 1115 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id116", "ep14_1_f_castle_5", Rectangle(1479.56, -273.74915, 20));

		// 'TransmutationMerchant' GenType 1116 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id117", "ep14_1_f_castle_5", Rectangle(1492.101, -462.35724, 20));

		// 'TransmutationMerchant' GenType 1117 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id118", "ep14_1_f_castle_5", Rectangle(1289.009, -458.30066, 20));

		// 'TransmutationMerchant' GenType 1118 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id119", "ep14_1_f_castle_5", Rectangle(1525.2233, -690.9953, 20));

		// 'TransmutationMerchant' GenType 1119 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id120", "ep14_1_f_castle_5", Rectangle(1679.8008, -295.28018, 20));

		// 'TransmutationMerchant' GenType 1120 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id121", "ep14_1_f_castle_5", Rectangle(1412.219, 38.05313, 20));

		// 'TransmutationMerchant' GenType 1121 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id122", "ep14_1_f_castle_5", Rectangle(1636.1462, 385.24048, 20));

		// 'TransmutationMerchant' GenType 1122 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id123", "ep14_1_f_castle_5", Rectangle(1482.2688, 668.78534, 20));

		// 'TransmutationMerchant' GenType 1123 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id124", "ep14_1_f_castle_5", Rectangle(1270.4705, 506.06442, 20));

		// 'TransmutationMerchant' GenType 1124 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id125", "ep14_1_f_castle_5", Rectangle(1791.7701, 658.95215, 20));

		// 'TransmutationMerchant' GenType 1125 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id126", "ep14_1_f_castle_5", Rectangle(1673.2786, 547.87646, 20));

		// 'TransmutationMerchant' GenType 1126 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id127", "ep14_1_f_castle_5", Rectangle(1785.5216, 1017.2719, 20));

		// 'TransmutationMerchant' GenType 1127 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id128", "ep14_1_f_castle_5", Rectangle(1210.465, 1196.4974, 20));

		// 'TransmutationMerchant' GenType 1129 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id129", "ep14_1_f_castle_5", Rectangle(922.8616, 1040.8579, 20));

		// 'TransmutationMerchant' GenType 1130 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id130", "ep14_1_f_castle_5", Rectangle(781.9779, 1259.0172, 20));

		// 'TransmutationMerchant' GenType 1131 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id131", "ep14_1_f_castle_5", Rectangle(850.7196, 953.28076, 20));

		// 'TransmutationMerchant' GenType 1132 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id132", "ep14_1_f_castle_5", Rectangle(1122.3834, 1507.4058, 20));

		// 'TransmutationMerchant' GenType 1133 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id133", "ep14_1_f_castle_5", Rectangle(260.43292, 1282.0752, 20));

		// 'TransmutationMerchant' GenType 1134 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id134", "ep14_1_f_castle_5", Rectangle(-17.341957, 1564.2322, 20));

		// 'TransmutationMerchant' GenType 1135 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id135", "ep14_1_f_castle_5", Rectangle(25.087189, 1086.9637, 20));

		// 'TransmutationMerchant' GenType 1136 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id136", "ep14_1_f_castle_5", Rectangle(262.9131, 1454.8793, 20));

		// 'TransmutationMerchant' GenType 1137 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id137", "ep14_1_f_castle_5", Rectangle(416.3446, 1538.7483, 20));

		// 'TransmutationMerchant' GenType 1138 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id138", "ep14_1_f_castle_5", Rectangle(310.67947, 1008.8478, 20));

		// 'TransmutationMerchant' GenType 1139 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id139", "ep14_1_f_castle_5", Rectangle(-767.3459, 1075.2828, 20));

		// 'TransmutationMerchant' GenType 1140 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id140", "ep14_1_f_castle_5", Rectangle(-679.3303, 878.9469, 20));

		// 'TransmutationMerchant' GenType 1141 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id141", "ep14_1_f_castle_5", Rectangle(-985.0051, 1272.6578, 20));

		// 'TransmutationMerchant' GenType 1142 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id142", "ep14_1_f_castle_5", Rectangle(-887.3801, 1379.802, 20));

		// 'TransmutationMerchant' GenType 1143 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id143", "ep14_1_f_castle_5", Rectangle(-894.15765, 1570.611, 20));

		// 'TransmutationMerchant' GenType 1144 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id144", "ep14_1_f_castle_5", Rectangle(-667.5653, 1572.2777, 20));

		// 'TransmutationMerchant' GenType 1145 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id145", "ep14_1_f_castle_5", Rectangle(-632.7634, 1384.335, 20));

		// 'TransmutationMerchant' GenType 1146 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id146", "ep14_1_f_castle_5", Rectangle(-443.22244, 1202.8723, 20));

		// 'TransmutationMerchant' GenType 1147 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id147", "ep14_1_f_castle_5", Rectangle(-897.0159, 592.99445, 20));

		// 'TransmutationMerchant' GenType 1148 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id148", "ep14_1_f_castle_5", Rectangle(-1112.4689, 457.42908, 20));

		// 'TransmutationMerchant' GenType 1149 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id149", "ep14_1_f_castle_5", Rectangle(-893.3406, 381.05258, 20));

		// 'TransmutationMerchant' GenType 1150 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id150", "ep14_1_f_castle_5", Rectangle(-651.23596, 417.97406, 20));

		// 'TransmutationMerchant' GenType 1151 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id151", "ep14_1_f_castle_5", Rectangle(-1058.8481, 244.47893, 20));

		// 'TransmutationMerchant' GenType 1152 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id152", "ep14_1_f_castle_5", Rectangle(-915.52686, 53.792465, 20));

		// 'TransmutationMerchant' GenType 1153 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id153", "ep14_1_f_castle_5", Rectangle(-667.392, 166.97014, 20));

		// 'TransmutationMerchant' GenType 1154 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id154", "ep14_1_f_castle_5", Rectangle(-738.469, -242.95334, 20));

		// 'TransmutationMerchant' GenType 1155 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id155", "ep14_1_f_castle_5", Rectangle(-1019.9087, -90.57913, 20));

		// 'TransmutationMerchant' GenType 1156 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id156", "ep14_1_f_castle_5", Rectangle(-980.0528, -353.60156, 20));

		// 'TransmutationMerchant' GenType 1157 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id157", "ep14_1_f_castle_5", Rectangle(-771.419, -523.29504, 20));

		// 'TransmutationMerchant' GenType 1158 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id158", "ep14_1_f_castle_5", Rectangle(-966.1876, -606.8803, 20));

		// 'TransmutationMerchant' GenType 1159 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id159", "ep14_1_f_castle_5", Rectangle(-1115.2372, -472.55682, 20));

		// 'TransmutationMerchant' GenType 1160 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id160", "ep14_1_f_castle_5", Rectangle(-610.3623, -641.55963, 20));

		// 'TransmutationMerchant' GenType 1161 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id161", "ep14_1_f_castle_5", Rectangle(-918.3445, -1031.0344, 20));

		// 'TransmutationMerchant' GenType 1162 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id162", "ep14_1_f_castle_5", Rectangle(-841.6549, -1281.3083, 20));

		// 'TransmutationMerchant' GenType 1163 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id163", "ep14_1_f_castle_5", Rectangle(-547.4491, -1293.8984, 20));

		// 'TransmutationMerchant' GenType 1164 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id164", "ep14_1_f_castle_5", Rectangle(-673.9718, -1128.8815, 20));

		// 'TransmutationMerchant' GenType 1165 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id165", "ep14_1_f_castle_5", Rectangle(-971.4408, -1467.2504, 20));

		// 'TransmutationMerchant' GenType 1166 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id166", "ep14_1_f_castle_5", Rectangle(-768.383, -1602.4146, 20));

		// 'TransmutationMerchant' GenType 1167 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id167", "ep14_1_f_castle_5", Rectangle(-209.23837, -1259.2927, 20));

		// 'TransmutationMerchant' GenType 1168 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id168", "ep14_1_f_castle_5", Rectangle(-196.55197, -1004.5456, 20));

		// 'TransmutationMerchant' GenType 1169 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id169", "ep14_1_f_castle_5", Rectangle(47.4379, -904.31464, 20));

		// 'TransmutationMerchant' GenType 1170 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id170", "ep14_1_f_castle_5", Rectangle(48.130253, -1183.6962, 20));

		// 'TransmutationMerchant' GenType 1171 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id171", "ep14_1_f_castle_5", Rectangle(308.53986, -1165.9185, 20));

		// 'TransmutationMerchant' GenType 1172 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id172", "ep14_1_f_castle_5", Rectangle(679.6654, -1232.3413, 20));

		// 'TransmutationMerchant' GenType 1173 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id173", "ep14_1_f_castle_5", Rectangle(918.24396, -1478.3741, 20));

		// 'TransmutationMerchant' GenType 1174 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id174", "ep14_1_f_castle_5", Rectangle(1159.893, -1324.3059, 20));

		// 'TransmutationMerchant' GenType 1175 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id175", "ep14_1_f_castle_5", Rectangle(1158.522, -1132.0394, 20));

		// 'TransmutationMerchant' GenType 1176 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id176", "ep14_1_f_castle_5", Rectangle(951.99677, -1207.8788, 20));

		// 'TransmutationMerchant' GenType 1177 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id177", "ep14_1_f_castle_5", Rectangle(730.6356, -995.8251, 20));

		// 'TransmutationMerchant' GenType 1178 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id178", "ep14_1_f_castle_5", Rectangle(-204.75754, -1585.8777, 20));

		// 'TransmutationMerchant' GenType 1179 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id179", "ep14_1_f_castle_5", Rectangle(411.2089, -1583.4152, 20));

		// 'TransmutationMerchant' GenType 1180 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id180", "ep14_1_f_castle_5", Rectangle(1470.9799, -1331.8691, 20));

		// 'TransmutationMerchant' GenType 1181 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id181", "ep14_1_f_castle_5", Rectangle(1584.364, -1091.4712, 20));

		// 'TransmutationMerchant' GenType 1182 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id182", "ep14_1_f_castle_5", Rectangle(142.9932, -178.34566, 20));

		// 'TransmutationMerchant' GenType 1183 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id183", "ep14_1_f_castle_5", Rectangle(288.3374, -511.69043, 20));

		// 'TransmutationMerchant' GenType 1184 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id184", "ep14_1_f_castle_5", Rectangle(436.56744, -252.29858, 20));

		// 'TransmutationMerchant' GenType 1185 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id185", "ep14_1_f_castle_5", Rectangle(672.1973, -483.25864, 20));

		// 'TransmutationMerchant' GenType 1186 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id186", "ep14_1_f_castle_5", Rectangle(264.18198, 249.76588, 20));

		// 'TransmutationMerchant' GenType 1187 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id187", "ep14_1_f_castle_5", Rectangle(-187.22607, 407.99835, 20));

		// 'TransmutationMerchant' GenType 1188 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id188", "ep14_1_f_castle_5", Rectangle(129.15134, 585.05914, 20));

		// 'TransmutationMerchant' GenType 1189 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id189", "ep14_1_f_castle_5", Rectangle(463.45966, 792.29803, 20));

		// 'TransmutationMerchant' GenType 1190 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id190", "ep14_1_f_castle_5", Rectangle(549.2038, 418.96875, 20));

		// 'TransmutationMerchant' GenType 1191 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id191", "ep14_1_f_castle_5", Rectangle(758.83954, 672.1558, 20));

		// 'TransmutationMerchant' GenType 1192 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id192", "ep14_1_f_castle_5", Rectangle(515.2618, 164.75005, 20));

		// 'TransmutationMerchant' GenType 1193 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id193", "ep14_1_f_castle_5", Rectangle(784.0689, -201.78964, 20));

		// 'TransmutationMerchant' GenType 1194 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id194", "ep14_1_f_castle_5", Rectangle(-74.62452, -426.2796, 20));

		// 'TransmutationMerchant' GenType 1195 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id195", "ep14_1_f_castle_5", Rectangle(145.63611, 76.77599, 20));

		// 'TransmutationMerchant' GenType 1196 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id196", "ep14_1_f_castle_5", Rectangle(884.5069, 58.12854, 20));

		// 'TransmutationMerchant' GenType 1197 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id197", "ep14_1_f_castle_5", Rectangle(-454.25995, -1482.3712, 20));

		// 'TransmutationMerchant' GenType 1198 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id198", "ep14_1_f_castle_5", Rectangle(-777.93866, -873.8666, 20));

		// 'TransmutationMerchant' GenType 1199 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id199", "ep14_1_f_castle_5", Rectangle(-1160.2719, -1320.3416, 20));

		// 'TransmutationSoldier' GenType 1200 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id200", "ep14_1_f_castle_5", Rectangle(956.9224, -1077.2021, 20));

		// 'TransmutationSoldier' GenType 1201 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id201", "ep14_1_f_castle_5", Rectangle(774.0844, -1533.1287, 20));

		// 'TransmutationSoldier' GenType 1202 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id202", "ep14_1_f_castle_5", Rectangle(1289.9379, -180.70918, 20));

		// 'TransmutationSoldier' GenType 1203 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id203", "ep14_1_f_castle_5", Rectangle(1084.8693, -1197.1808, 20));

		// 'TransmutationSoldier' GenType 1204 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id204", "ep14_1_f_castle_5", Rectangle(1422.4257, -527.0022, 20));

		// 'TransmutationSoldier' GenType 1205 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id205", "ep14_1_f_castle_5", Rectangle(1489.5864, -280.50763, 20));

		// 'TransmutationSoldier' GenType 1206 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id206", "ep14_1_f_castle_5", Rectangle(1292.6392, 372.9492, 20));

		// 'TransmutationSoldier' GenType 1207 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id207", "ep14_1_f_castle_5", Rectangle(1385.0599, 615.00507, 20));

		// 'TransmutationSoldier' GenType 1208 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id208", "ep14_1_f_castle_5", Rectangle(1598.2311, -55.968727, 20));

		// 'TransmutationSoldier' GenType 1209 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id209", "ep14_1_f_castle_5", Rectangle(1510.2834, 412.2675, 20));

		// 'TransmutationSoldier' GenType 1210 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id210", "ep14_1_f_castle_5", Rectangle(1023.0215, -1375.3811, 20));

		// 'TransmutationSoldier' GenType 1211 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id211", "ep14_1_f_castle_5", Rectangle(1748.249, 1117.7549, 20));

		// 'TransmutationSoldier' GenType 1212 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id212", "ep14_1_f_castle_5", Rectangle(1522.628, -1244.9366, 20));

		// 'TransmutationSoldier' GenType 1213 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id213", "ep14_1_f_castle_5", Rectangle(1142.2028, 1011.6145, 20));

		// 'TransmutationSoldier' GenType 1214 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id214", "ep14_1_f_castle_5", Rectangle(721.9871, 954.008, 20));

		// 'TransmutationSoldier' GenType 1215 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id215", "ep14_1_f_castle_5", Rectangle(790.791, -1242.6869, 20));

		// 'TransmutationSoldier' GenType 1216 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id216", "ep14_1_f_castle_5", Rectangle(915.17413, 1255.5504, 20));

		// 'TransmutationSoldier' GenType 1217 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id217", "ep14_1_f_castle_5", Rectangle(222.11143, -1291.3296, 20));

		// 'TransmutationSoldier' GenType 1218 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id218", "ep14_1_f_castle_5", Rectangle(977.4375, 1527.8126, 20));

		// 'TransmutationSoldier' GenType 1219 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id219", "ep14_1_f_castle_5", Rectangle(1072.0879, 1436.8177, 20));

		// 'TransmutationSoldier' GenType 1220 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id220", "ep14_1_f_castle_5", Rectangle(-92.22447, -993.41864, 20));

		// 'TransmutationSoldier' GenType 1221 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id221", "ep14_1_f_castle_5", Rectangle(223.77206, 1142.8241, 20));

		// 'TransmutationSoldier' GenType 1222 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id222", "ep14_1_f_castle_5", Rectangle(-37.89743, 1305.8922, 20));

		// 'TransmutationSoldier' GenType 1223 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id223", "ep14_1_f_castle_5", Rectangle(147.78793, 1458.2119, 20));

		// 'TransmutationSoldier' GenType 1224 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id224", "ep14_1_f_castle_5", Rectangle(149.91682, 1691.3748, 20));

		// 'TransmutationSoldier' GenType 1225 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id225", "ep14_1_f_castle_5", Rectangle(201.22064, -1034.8562, 20));

		// 'TransmutationSoldier' GenType 1226 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id226", "ep14_1_f_castle_5", Rectangle(-655.01587, -1308.2164, 20));

		// 'TransmutationSoldier' GenType 1227 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id227", "ep14_1_f_castle_5", Rectangle(-704.1737, 1261.561, 20));

		// 'TransmutationSoldier' GenType 1228 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id228", "ep14_1_f_castle_5", Rectangle(-862.73724, 1169.6332, 20));

		// 'TransmutationSoldier' GenType 1229 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id229", "ep14_1_f_castle_5", Rectangle(-1008.4017, 1530.1685, 20));

		// 'TransmutationSoldier' GenType 1230 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id230", "ep14_1_f_castle_5", Rectangle(-570.1323, 1506.8773, 20));

		// 'TransmutationSoldier' GenType 1231 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id231", "ep14_1_f_castle_5", Rectangle(-580.3668, 1015.7845, 20));

		// 'TransmutationSoldier' GenType 1232 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id232", "ep14_1_f_castle_5", Rectangle(-1049.1384, -284.48605, 20));

		// 'TransmutationSoldier' GenType 1233 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id233", "ep14_1_f_castle_5", Rectangle(-1081.3499, -567.3323, 20));

		// 'TransmutationSoldier' GenType 1234 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id234", "ep14_1_f_castle_5", Rectangle(-832.7848, -711.9325, 20));

		// 'TransmutationSoldier' GenType 1235 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id235", "ep14_1_f_castle_5", Rectangle(-640.7094, -514.49835, 20));

		// 'TransmutationSoldier' GenType 1236 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id236", "ep14_1_f_castle_5", Rectangle(-845.08594, -432.8488, 20));

		// 'TransmutationSoldier' GenType 1237 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id237", "ep14_1_f_castle_5", Rectangle(-1067.1023, 169.5325, 20));

		// 'TransmutationSoldier' GenType 1238 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id238", "ep14_1_f_castle_5", Rectangle(615.41644, -215.3699, 20));

		// 'TransmutationSoldier' GenType 1239 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id239", "ep14_1_f_castle_5", Rectangle(-839.49347, 463.60425, 20));

		// 'TransmutationSoldier' GenType 1240 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id240", "ep14_1_f_castle_5", Rectangle(-780.4117, 630.6355, 20));

		// 'TransmutationSoldier' GenType 1241 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id241", "ep14_1_f_castle_5", Rectangle(-1074.7611, 617.984, 20));

		// 'TransmutationSoldier' GenType 1242 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id242", "ep14_1_f_castle_5", Rectangle(-657.4642, 326.2996, 20));

		// 'TransmutationSoldier' GenType 1243 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id243", "ep14_1_f_castle_5", Rectangle(16.071442, -176.19292, 20));

		// 'TransmutationSoldier' GenType 1244 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id244", "ep14_1_f_castle_5", Rectangle(287.93152, 396.02176, 20));

		// 'TransmutationSoldier' GenType 1245 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id245", "ep14_1_f_castle_5", Rectangle(-854.91254, -76.14726, 20));

		// 'TransmutationSoldier' GenType 1246 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id246", "ep14_1_f_castle_5", Rectangle(-601.553, -955.0876, 20));

		// 'TransmutationSoldier' GenType 1247 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id247", "ep14_1_f_castle_5", Rectangle(-1004.3536, -1110.2548, 20));

		// 'TransmutationSoldier' GenType 1248 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id248", "ep14_1_f_castle_5", Rectangle(-596.14197, -1554.8156, 20));

		// 'TransmutationSoldier' GenType 1249 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id249", "ep14_1_f_castle_5", Rectangle(-868.05835, -1377.7311, 20));

		// 'TransmutationSoldier' GenType 1250 Spawn Points
		AddSpawnPoint("ep14_1_f_castle_5.Id250", "ep14_1_f_castle_5", Rectangle(-112.23296, -1163.5977, 20));
	}
}
