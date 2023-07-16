//--- Melia Script -----------------------------------------------------------
// d_limestonecave_55_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_limestonecave_55_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave551MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_limestonecave_55_1.Id1", MonsterId.Charog_Green, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id2", MonsterId.Charcoal_Walker_Green, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id3", MonsterId.Blindlem_Green, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id4", MonsterId.Charog_Green, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id5", MonsterId.RavineLerva_Cave, 20, TimeSpan.FromMilliseconds(2500), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_55_1.Id6", MonsterId.Rootcrystal_04, 15, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Charog_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1798.18, 47.21, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1607.48, 261.74, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1613.5, 84.25, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1090.34, -19.42, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1023.58, -175.24, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-793.47, -283.12, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-740.58, -62.53, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-572.03, -734.12, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-550.85, -931.79, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-356.72, -985.85, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-178.7, -813.09, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-321.29, -819.91, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1032.84, 806.4, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-884.03, 982.94, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-673.35, 826.79, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-880.19, 689.95, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1006.65, 621.63, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1441.01, 593.69, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id1", "d_limestonecave_55_1", Spot(-1824.55, 255.63, 40));

		// Charcoal_Walker_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(-45.96, 85.5, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(177.65, 437.77, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(458.9, 186.74, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(326.29, -146.27, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(144.4, 42.78, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(23.17, 320.58, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(-140.41, 233.09, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(496.82, -443.52, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(662.07, -784.5, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(806.65, -940.86, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(1022.41, -802.64, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(767.79, -635.81, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(823.29, -781.93, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(803.14, -62.46, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(1173.49, -210.69, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(1355.22, -157.94, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(1487.95, -321.6, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(1254.94, -452.59, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(1343.89, -414.01, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(1493.11, -537.25, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id2", "d_limestonecave_55_1", Spot(1602.37, -397.27, 40));

		// Blindlem_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(1344.498, 1007.9312, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(1394.47, 615.39, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(1520.84, 784.33, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(1458.37, 921.42, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(636.75, 1518.48, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(701.37, 1757.82, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(799.64, 1595.29, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(53.11, 1606.37, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(-246.88869, 1342.3561, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(-109.39433, 1644.4663, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(181.04, 1346.09, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(57.76, -115.07, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(-100.44139, 180.14159, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(100.75, 510.26, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(532.29, 356.25, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(310.98, 249.92, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(581.74, 54.01, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(413.37518, -96.69928, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(15.993752, 1278.0281, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(128.50851, 54.663963, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(46.03, 393.94, 40));
		AddSpawnPoint( "d_limestonecave_55_1.Id3", "d_limestonecave_55_1", Spot(1278.7457, 749.1864, 40));

		// Charog_Green Spawn Points
		AddSpawnPoint( "d_limestonecave_55_1.Id4", "d_limestonecave_55_1", Spot(371.23688, 278.51974, 9999));

		// RavineLerva_Cave Spawn Points
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(843.28, -1032.12, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(648.1, -794.22, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(649.8, -619.92, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(901.75, -576.88, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1117.95, -783.76, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1014.67, -851.78, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(830.6, -769.23, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(894.88, -934.98, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(962.16, -753.02, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(489.49, -546.79, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(449.75, -410.56, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1710.19, -426.09, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1654.99, -268.33, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1541.98, -330.66, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1348.94, -445.89, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1182.73, -432.57, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1433.83, -587.21, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1510.54, -618.26, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1691.83, -472.73, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1377.46, -189.26, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1150.45, -171.14, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1264.83, -548.27, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id5", "d_limestonecave_55_1", Spot(1155.3, -331.5, 100));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-1824.36, 225.4, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-1510.55, 104.27, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-1304.43, 681.01, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-834.63, 826.2, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-991.7, 931.14, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-298.02, 1402.75, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(6.9, 1634.57, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(53.02, 1285.66, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(698.19, 1808.27, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(953.44, 1658.6, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(677.18, 1502.76, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1113.84, 1217.24, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(207.72, 882.63, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1459.13, 1059.6, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1563.18, 699.25, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1345.56, 729.46, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(157.46, 452.78, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(90.55, 42.48, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(284.96, -59.92, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(678.14, 324.53, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(593.32, 21.31, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1657.45, -399.48, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1372.89, -523.82, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1207.25, -344.91, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1409.16, -213.94, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(1132.38, -835.94, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(895.76, -610.05, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(646.98, -683.52, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(866.05, -1007.95, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-184.14, -890.11, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-269.68, -999.86, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-523.41, -1036.93, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-539.39, -728.7, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-371.77, -843.05, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-735.98, -174.06, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-835.05, -334.19, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-1032.99, -145.18, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-811.47, -79.95, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-362.59, 184.03, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-618.03, -462.58, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(954.38, -142.61, 100));
		AddSpawnPoint( "d_limestonecave_55_1.Id6", "d_limestonecave_55_1", Spot(-544.59, 1216.9, 100));

	}
}
