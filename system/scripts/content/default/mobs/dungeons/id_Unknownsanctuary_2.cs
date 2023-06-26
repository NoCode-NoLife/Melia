//--- Melia Script -----------------------------------------------------------
// id_Unknownsanctuary_2
//
//--- Description -----------------------------------------------------------
// Sets up the id_Unknownsanctuary_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class IdUnknownsanctuary2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Velcoffer, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Kucarry_Balzermancer, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Wastrel, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Ignas, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Asiomage, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Skiaclipse, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Moringponia, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Tantaliser, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Pbeta, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Glacier, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Froster_Lord, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Populations
		var FdBossVelcoffer_1_1 = AddMonsterGenerator(MonsterId.FD_Boss_Velcoffer, "id_Unknownsanctuary_2", 1);
		var FdBossKucarryBalzermancer_2_1 = AddMonsterGenerator(MonsterId.FD_Boss_Kucarry_Balzermancer, "id_Unknownsanctuary_2", 1);
		var FdBossWastrel_3_1 = AddMonsterGenerator(MonsterId.FD_Boss_Wastrel, "id_Unknownsanctuary_2", 1);
		var FdBossIgnas_4_1 = AddMonsterGenerator(MonsterId.FD_Boss_Ignas, "id_Unknownsanctuary_2", 1);
		var FdBossAsiomage_5_1 = AddMonsterGenerator(MonsterId.FD_Boss_Asiomage, "id_Unknownsanctuary_2", 1);
		var FdBossSkiaclipse_6_1 = AddMonsterGenerator(MonsterId.FD_Boss_Skiaclipse, "id_Unknownsanctuary_2", 1);
		var FdBossMoringponia_7_1 = AddMonsterGenerator(MonsterId.FD_Boss_Moringponia, "id_Unknownsanctuary_2", 1);
		var FdBossTantaliser_8_1 = AddMonsterGenerator(MonsterId.FD_Boss_Tantaliser, "id_Unknownsanctuary_2", 1);
		var FdBossPbeta_9_1 = AddMonsterGenerator(MonsterId.FD_Boss_Pbeta, "id_Unknownsanctuary_2", 1);
		var FdBossGlacier_10_1 = AddMonsterGenerator(MonsterId.FD_Boss_Glacier, "id_Unknownsanctuary_2", 1);
		var FdBossFrosterLord_11_1 = AddMonsterGenerator(MonsterId.FD_Boss_Froster_Lord, "id_Unknownsanctuary_2", 1);
		var FdBossSkiaclipse_12_1 = AddMonsterGenerator(MonsterId.FD_Boss_Skiaclipse, "id_Unknownsanctuary_2", 1);
		var FdBossSkiaclipse_13_1 = AddMonsterGenerator(MonsterId.FD_Boss_Skiaclipse, "id_Unknownsanctuary_2", 1);

		// Monster Spawners
		AddSpawnPoint(FdBossVelcoffer_1_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(86.288925, -17.487818, 20));
		AddSpawnPoint(FdBossKucarryBalzermancer_2_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-1055.728, -135.6764, 20));
		AddSpawnPoint(FdBossWastrel_3_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(866.08954, 1069.8341, 20));
		AddSpawnPoint(FdBossIgnas_4_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-426.4594, -1035.8777, 20));
		AddSpawnPoint(FdBossAsiomage_5_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(68.01238, -1364.7366, 20));
		AddSpawnPoint(FdBossSkiaclipse_6_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-372.66635, -435.87714, 20));
		AddSpawnPoint(FdBossMoringponia_7_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-1057.1002, -807.03094, 20));
		AddSpawnPoint(FdBossTantaliser_8_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(1055.4669, 561.7357, 20));
		AddSpawnPoint(FdBossPbeta_9_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(541.70825, -1062.0155, 20));
		AddSpawnPoint(FdBossGlacier_10_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-803.96027, 767.3518, 20));
		AddSpawnPoint(FdBossFrosterLord_11_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(198.3233, 1156.4188, 20));
		AddSpawnPoint(FdBossSkiaclipse_12_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(591.1201, -383.408, 20));
		AddSpawnPoint(FdBossSkiaclipse_13_1, TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-66.70287, 534.97064, 20));

	}
}
