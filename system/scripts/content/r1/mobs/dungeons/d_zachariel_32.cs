//--- Melia Script -----------------------------------------------------------
// d_zachariel_32
//
//--- Description -----------------------------------------------------------
// Sets up the d_zachariel_32 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel32MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_zachariel_32", MonsterId.Zinutekas, Properties("MHP", 60625, "MINPATK", 1281, "MAXPATK", 1476, "MINMATK", 1281, "MAXMATK", 1476, "DEF", 329, "MDEF", 329));
		AddPropertyOverrides("d_zachariel_32", MonsterId.Varv, Properties("MHP", 61312, "MINPATK", 1289, "MAXPATK", 1486, "MINMATK", 1289, "MAXMATK", 1486, "DEF", 340, "MDEF", 340));
		AddPropertyOverrides("d_zachariel_32", MonsterId.Moving_Trap, Properties("MHP", 62017, "MINPATK", 1298, "MAXPATK", 1498, "MINMATK", 1298, "MAXMATK", 1498, "DEF", 351, "MDEF", 351));
		AddPropertyOverrides("d_zachariel_32", MonsterId.Karas, Properties("MHP", 63480, "MINPATK", 1317, "MAXPATK", 1521, "MINMATK", 1317, "MAXMATK", 1521, "DEF", 373, "MDEF", 373));
		AddPropertyOverrides("d_zachariel_32", MonsterId.Zinutekas_Elite, Properties("MHP", 62740, "MINPATK", 1308, "MAXPATK", 1509, "MINMATK", 1308, "MAXMATK", 1509, "DEF", 362, "MDEF", 362));

		// Monster Spawners --------------------------------

		AddSpawner("d_zachariel_32.Id1", MonsterId.Rootcrystal_05, 16, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_zachariel_32.Id2", MonsterId.Zinutekas, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id3", MonsterId.Zinutekas, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id4", MonsterId.Varv, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id5", MonsterId.Moving_Trap, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id6", MonsterId.Moving_Trap, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id7", MonsterId.Varv, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_32.Id8", MonsterId.Karas, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_32.Id9", MonsterId.Zinutekas_Elite, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_zachariel_32.Id1", "d_zachariel_32", Spot(-42, -1123, 30));
		AddSpawnPoint( "d_zachariel_32.Id1", "d_zachariel_32", Spot(1230, 72, 30));
		AddSpawnPoint( "d_zachariel_32.Id1", "d_zachariel_32", Spot(-872, 75, 30));
		AddSpawnPoint( "d_zachariel_32.Id1", "d_zachariel_32", Spot(52, 1357, 30));

		// Zinutekas Spawn Points
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(-122, 171, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(-105.33216, 1393.9225, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(1262.8569, 51.245697, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(-41.13156, 25.679314, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(-4.644928, -86.01132, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(203.94325, 86.41452, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(22.607986, 256.62106, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(914.2411, 95.27472, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(1115.7257, -27.62833, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(1208.5851, 188.43477, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(1075.3568, 251.45845, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(1100.1234, 131.51218, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(979.3739, -8.070076, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(15.068802, 102.52118, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(73.303024, 1453.0802, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(47.256424, 1404.1146, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(47.91625, 1678.6211, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(215.48892, 1407.3418, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(56.131214, 1154.1517, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(-250.52768, 1408.245, 350));
		AddSpawnPoint( "d_zachariel_32.Id2", "d_zachariel_32", Spot(371.32224, 1410.116, 350));
		AddSpawnPoint( "d_zachariel_32.Id3", "d_zachariel_32", Spot(49, 1420, 9999));

		// Varv Spawn Points
		AddSpawnPoint( "d_zachariel_32.Id4", "d_zachariel_32", Spot(62.891552, 1415.3289, 9999));

		// Moving_Trap Spawn Points
		AddSpawnPoint( "d_zachariel_32.Id5", "d_zachariel_32", Spot(41.6494, 187.01646, 9999));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(56.74465, 145.61552, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(1133.5869, 129.34186, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(-192.91193, 97.47426, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(49.13401, -89.0266, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(947.60345, 72.714, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(1157.1138, -99.5071, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(1257.5588, 260.45337, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(1049.3365, 293.16034, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(-992.6977, 269.15347, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(-1080.3595, -55.21635, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(-797.54663, 58.654945, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(-1136.6224, 125.22794, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(-789.12286, 197.14664, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(35.453423, 367.00534, 350));
		AddSpawnPoint( "d_zachariel_32.Id6", "d_zachariel_32", Spot(272.7172, 108.74696, 350));

		// Varv Spawn Points
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-895.0793, 1393.7487, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-982.53577, -880.54266, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-1084.4537, -1109.3551, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-1099.928, -927.9132, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-936.432, -1029.7673, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-959.81445, 22.791117, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-937.8673, 269.2441, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-1090.4355, 154.05995, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-776.70984, 122.34263, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-978.74133, 1229.5714, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-955.7805, 1583.9581, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-1068.6033, 1501.5187, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1089.3579, 1333.9666, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1180.8627, 1562.3514, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(991.9826, 1426.9382, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1086.2177, 246.06798, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(981.9042, 31.272274, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1086.5222, -111.84035, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1124.0707, 124.06465, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1045.571, -837.3882, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(966.13745, -981.2001, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1095.9869, -1150.2074, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1237.3439, -979.94543, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(1113.9506, -1011.0974, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(560.14923, -936.29126, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(64.385895, -1279.7394, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(25.440794, -45.486538, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-161.06964, 108.46146, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(75.721115, 1392.3959, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(318.451, 1456.3618, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(46.73441, 729.4699, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-377.77594, 1411.6149, 350));
		AddSpawnPoint( "d_zachariel_32.Id7", "d_zachariel_32", Spot(-439.1945, -990.77106, 350));

		// Karas Spawn Points
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(37.607677, 943.5803, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(450.78674, 1388.285, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(-427.6086, 1398.524, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(1215.1661, 1290.5748, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(979.7895, 84.12612, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(1115.1082, 1343.8842, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(-898.6503, 1292.6226, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(-925.0941, 1507.7754, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(35.962864, 1145.4248, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(-1108.5132, 1277.6677, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(1001.6533, 1525.965, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(-1109.7665, 1520.059, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(-638.8298, 1388.4912, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(645.59186, 1386.638, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(1012.8887, 1281.082, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(1205.7726, 1517.4321, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(-1000.6447, 1446.2314, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(1136.9761, 1451.7065, 40));
		AddSpawnPoint( "d_zachariel_32.Id8", "d_zachariel_32", Spot(-1002.3246, 1341.4025, 40));

		// Zinutekas_Elite Spawn Points
		AddSpawnPoint( "d_zachariel_32.Id9", "d_zachariel_32", Spot(56.303253, 94.40272, 9999));

	}
}
