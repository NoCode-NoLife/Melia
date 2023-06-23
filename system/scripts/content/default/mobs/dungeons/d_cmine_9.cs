//--- Melia Script -----------------------------------------------------------
// d_cmine_9
//
//--- Description -----------------------------------------------------------
// Sets up the d_cmine_9 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class DCmine9MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Populations
		AddMonsterPopulation("d_cmine_9", "population_rootcrystal_01_1", 2);
		AddMonsterPopulation("d_cmine_9", "population_fd_bubbe_fighter_2", 25);
		AddMonsterPopulation("d_cmine_9", "population_fd_bubbe_mage_ice_3", 5);
		AddMonsterPopulation("d_cmine_9", "population_fd_bubbe_fighter_4", 10);
		AddMonsterPopulation("d_cmine_9", "population_fd_stoulet_mage_5", 10);
		AddMonsterPopulation("d_cmine_9", "population_fd_bubbe_mage_ice_6", 7);
		AddMonsterPopulation("d_cmine_9", "population_fd_bat_big_7", 7);

		// RootCrystal Spawners
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(5000), "d_cmine_9", Spot(119, -1162, 30));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(5000), "d_cmine_9", Spot(-538, -70, 30));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(5000), "d_cmine_9", Spot(522, -24, 30));
		AddSpawner(MonsterId.Rootcrystal_01, "population_rootcrystal_01_1", TimeSpan.FromMilliseconds(5000), "d_cmine_9", Spot(-560, 521, 30));

		// Monster Spawners
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_2", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-616.2608, 443.92184, 9999));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_3", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(172.20529, -1077.0809, 9999));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-206.5415, -508.90207, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(1071.5046, 766.6145, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(917.5557, 970.4806, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(1106.2621, 875.75775, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(872.61426, 1128.3726, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(667.8915, 1164.6661, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(648.66675, 845.49255, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(594.5639, 1040.1616, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(703.48364, -172.1095, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(501.3455, -258.75122, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(509.78433, 41.15662, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(631.7754, 51.204727, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(741.29486, 43.77088, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(800.9222, 91.63241, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(855.0921, 38.639225, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(953.44446, -71.15471, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(478.81992, 107.14063, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(487.45828, 184.1847, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(589.3786, 229.77135, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(343.10135, -1129.07, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(306.46234, -1059.8109, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(298.76807, -991.92163, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(360.9561, -984.35333, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(372.4526, -1036.746, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(447.69464, -998.567, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(433.30453, -1067.3353, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(421.83093, -1134.4829, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(519.3585, -1082.9202, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(495.44214, -1152.444, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-320.9546, -473.77518, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-414.14386, -544.2868, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-321.12292, -577.25195, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-381.96353, -421.54874, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-259.7625, -423.6191, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-522.0448, -496.82797, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-471.95483, -385.2256, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-570.4529, -531.3519, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-470.0286, -480.88263, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-510.5634, -168.22903, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(62.884953, 617.51483, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(135.2448, 628.5844, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(127.47316, 542.9642, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(247.48442, 586.9903, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(446.24994, 485.14627, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(453.36615, 422.74985, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-183.22879, 812.6456, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-243.79285, 846.45544, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-247.3295, 943.32306, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-272.0965, 908.23004, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-507.83627, 402.316, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-458.19708, 269.42908, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-583.8815, 282.19214, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-491.36545, 192.56781, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-582.6676, 383.5692, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-604.23865, 150.11394, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-636.42065, 220.51974, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-675.6819, 421.19687, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-766.1562, 237.19559, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-821.4661, 349.49774, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-688.74225, 315.6416, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-620.44305, 508.9067, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-697.33514, 569.07007, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-748.25055, 631.6526, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-808.083, 654.49274, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-792.08984, 508.00955, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-776.57794, 418.22614, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-532.85016, 483.67578, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1363.2037, 756.15283, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1423.2189, 843.2156, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1318.1667, 894.9668, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1242.0096, 952.5597, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1062.0804, 865.3455, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-994.2605, 782.4506, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1029.1506, 721.697, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1781.0754, 601.857, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1717.3911, 548.226, 20));
		AddSpawner(MonsterId.FD_Bubbe_Fighter, "population_fd_bubbe_fighter_4", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1791.8239, 553.7099, 20));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(581.8846, -53.928596, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(712.7681, 121.09995, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(497.81497, 252.36337, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(667.276, 1049.0894, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(953.7011, 918.8063, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(758.5448, 1238.8519, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-460.31082, 742.7697, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-661.1375, 235.27374, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-591.3681, 509.03482, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(648.02716, 882.77075, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(557.02673, -225.40778, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-793.59064, 570.7559, 25));
		AddSpawner(MonsterId.FD_Stoulet_Mage, "population_fd_stoulet_mage_5", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-516.2969, 290.14365, 25));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(203.0057, -1106.1472, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(556.6473, -67.91645, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-646.57587, -556.39514, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-817.0719, -706.61505, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-568.4928, -113.0224, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-224.07562, -490.8087, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(710.0959, 1131.1138, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(914.6113, 740.6014, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-671.98303, 382.25314, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-467.12244, 417.56006, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-471.6967, 724.46204, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-163.39023, 849.58984, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(217.78745, 535.2691, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(654.65576, 178.58281, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1137.3793, 791.92, 30));
		AddSpawner(MonsterId.FD_Bubbe_Mage_Ice, "population_fd_bubbe_mage_ice_6", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(-1622.6915, 649.6454, 30));
		AddSpawner(MonsterId.FD_Bat_Big, "population_fd_bat_big_7", TimeSpan.FromMilliseconds(0), "d_cmine_9", Spot(556.5479, 115.57921, 9999));

	}
}
