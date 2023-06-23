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
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_velcoffer_1", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_kucarry_balzermancer_2", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_wastrel_3", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_ignas_4", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_asiomage_5", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_skiaclipse_6", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_moringponia_7", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_tantaliser_8", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_pbeta_9", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_glacier_10", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_froster_lord_11", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_skiaclipse_12", 1);
		AddMonsterPopulation("id_Unknownsanctuary_2", "population_fd_boss_skiaclipse_13", 1);

		// Monster Spawners
		AddSpawner(MonsterId.FD_Boss_Velcoffer, "population_fd_boss_velcoffer_1", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(86.288925, -17.487818, 20));
		AddSpawner(MonsterId.FD_Boss_Kucarry_Balzermancer, "population_fd_boss_kucarry_balzermancer_2", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-1055.728, -135.6764, 20));
		AddSpawner(MonsterId.FD_Boss_Wastrel, "population_fd_boss_wastrel_3", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(866.08954, 1069.8341, 20));
		AddSpawner(MonsterId.FD_Boss_Ignas, "population_fd_boss_ignas_4", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-426.4594, -1035.8777, 20));
		AddSpawner(MonsterId.FD_Boss_Asiomage, "population_fd_boss_asiomage_5", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(68.01238, -1364.7366, 20));
		AddSpawner(MonsterId.FD_Boss_Skiaclipse, "population_fd_boss_skiaclipse_6", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-372.66635, -435.87714, 20));
		AddSpawner(MonsterId.FD_Boss_Moringponia, "population_fd_boss_moringponia_7", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-1057.1002, -807.03094, 20));
		AddSpawner(MonsterId.FD_Boss_Tantaliser, "population_fd_boss_tantaliser_8", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(1055.4669, 561.7357, 20));
		AddSpawner(MonsterId.FD_Boss_Pbeta, "population_fd_boss_pbeta_9", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(541.70825, -1062.0155, 20));
		AddSpawner(MonsterId.FD_Boss_Glacier, "population_fd_boss_glacier_10", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-803.96027, 767.3518, 20));
		AddSpawner(MonsterId.FD_Boss_Froster_Lord, "population_fd_boss_froster_lord_11", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(198.3233, 1156.4188, 20));
		AddSpawner(MonsterId.FD_Boss_Skiaclipse, "population_fd_boss_skiaclipse_12", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(591.1201, -383.408, 20));
		AddSpawner(MonsterId.FD_Boss_Skiaclipse, "population_fd_boss_skiaclipse_13", TimeSpan.FromMilliseconds(15000), "id_Unknownsanctuary_2", Spot(-66.70287, 534.97064, 20));

	}
}
