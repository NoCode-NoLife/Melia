//--- Melia Script -----------------------------------------------------------
// d_cathedral_78_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Neighport Church East Building' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCathedral781MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_cathedral_78_1.Id1", MonsterId.ERD_Pawndel, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id2", MonsterId.ERD_Pawnd, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id3", MonsterId.ERD_Zombiegirl2, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id4", MonsterId.ERD_Elet, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id5", MonsterId.ERD_Candlespider, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id6", MonsterId.ERD_Shredded, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id7", MonsterId.ERD_Fire_Dragon_Purple, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id8", MonsterId.ERD_Nuo, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id9", MonsterId.ERD_InfroRocktor, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id10", MonsterId.ERD_Egnome, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id11", MonsterId.ERD_Shtayim, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id12", MonsterId.ERD_Nuo, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id13", MonsterId.ERD_Elet, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id14", MonsterId.ERD_Glizardon, 3, 3, TimeSpan.FromMilliseconds(1200000), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id15", MonsterId.ERD_Galok, 3, 3, TimeSpan.FromMilliseconds(1200000), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id16", MonsterId.ERD_Malstatue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id17", MonsterId.ERD_Malstatue, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_cathedral_78_1.Id18", MonsterId.Rootcrystal_03, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Pawndel' GenType 2 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(749.19, 209.53, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(854.12994, 139.62529, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(931.4147, 162.038, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(830.89, 281.78, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(869.24866, 381.68698, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(969.2922, 388.6876, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(972.93, 234.39, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(798.91, 648.01, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(804.67, 785.41, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(729.87, 738.88, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(864.82, 690.05, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(856.27, 828.73, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(850.83, 894.87, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(963.28, 823.14, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(890.95056, 550.0597, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(986.64, 617.07, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1172.0066, 766.7015, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1292.643, 846.33527, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1443.2393, 877.01636, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1458.2382, 774.25806, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1390.83, 709.3, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1381.85, 612.12, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1489.55, 643.66, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1112.5111, 725.8702, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1287.6656, 701.68054, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(1274.5165, 629.2415, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(857.57697, 471.36404, 40));
		AddSpawnPoint("d_cathedral_78_1.Id1", "d_cathedral_78_1", Rectangle(766.18085, 365.4736, 40));

		// 'ERD_Pawnd' GenType 3 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(427.37, 787.34, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(387.48, 878.51, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(305.72205, 826.0316, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(311.34, 620.52, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(119.35, 608.5, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(138.23929, 834.71436, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(138.46, 926.68, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(329.36, 903.63, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(230.19, 806.93, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(200.96733, 726.2289, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(397.85, 612.91, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-1.88, 867.42, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-116.15213, 693.8165, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-49.2289, 629.2901, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-165.11, 624.04, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-334.85, 629.68, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-267.1985, 766.29126, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-287.83, 928.44, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-380.02292, 690.6388, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-423.2281, 607.2024, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-583.11, 616.43, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-567.02, 741.03, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-501.92, 940.32, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-530.98, 845, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-392.83542, 846.9244, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-49.9032, 507.123, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(616.28, -304.41, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(713.65, -320.2, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(669.69, -428.68, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(850.82, -418.43, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(858.08, -256.33, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1022.2, -230.85, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1089.97, -314.9, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1032.79, -412.88, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(967.09, -333.33, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(597.42, -690.13, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(674.84, -757.88, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(703.42, -617.39, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(845.06, -647.81, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(875.2, -745.68, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(955.99, -619.33, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(848.14, -521.97, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1078.48, -578.77, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1028.27, -775.75, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1009.4, -494.7, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(579.72, -527.24, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(581.37, -420.33, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(1030.6, -695.31, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(807.27, -154.08, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(897.76, -141.16, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-123.83382, 790.9817, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-79.92667, 879.0747, 40));
		AddSpawnPoint("d_cathedral_78_1.Id2", "d_cathedral_78_1", Rectangle(-39.696625, 363.8597, 40));

		// 'ERD_Zombiegirl2' GenType 4 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-269.37, 120.69, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-173.88, 271.39, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-151.75, 161.85, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-293.88092, 17.178474, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-114.6441, -680.1968, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-179.51, -116.04, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-18.835667, -165.90329, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(47.895695, -97.10208, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(-50.99, 200.33, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(130.65, 237.82, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(141.83228, 92.31797, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(197.61, -148.17, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(76.20857, -270.13303, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(143.48329, -86.69046, 40));
		AddSpawnPoint("d_cathedral_78_1.Id3", "d_cathedral_78_1", Rectangle(120.80214, -190.8444, 40));

		// 'ERD_Elet' GenType 5 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-165.1, -800.46, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-49.53, -807.91, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-148.06, -708.76, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-169.46, -604.49, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-135.24, -539.93, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-73.78, -696.09, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(29.01, -553.11, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(12.94, -695.58, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(61.81, -790.15, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-386.35, -1190.29, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-428.33, -1421.77, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-270.26, -1324.7, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-239.39, -1197.09, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-112.56, -1233.97, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-377.77, -1296.01, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(-42.93, -1426.14, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(60.813602, -1313.9106, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(48.48, -1110.41, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(187.31354, -1258.1755, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(217.11, -1401.06, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(276.79, -1285.33, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(268.398, -1128.7633, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(405.69, -1138.03, 40));
		AddSpawnPoint("d_cathedral_78_1.Id4", "d_cathedral_78_1", Rectangle(369.54, -1313.66, 40));

		// 'ERD_Candlespider' GenType 6 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-435.82, -1320.96, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-488.5, -1183.28, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-315.5, -1223.23, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-188.23, -1408.57, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-164.86, -1314.1, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-20.32, -1154.29, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-15.329962, -1230.9609, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(84.434265, -1231.0104, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(78.01, -1383, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(211.22, -1338.56, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(185.4, -1182.42, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(311.245, -1219.4698, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(431.29358, -1199.6886, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(386.53, -1416.47, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-219.97, -1136.33, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-73.96, -1294.78, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-149.57501, -747.90875, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-77.861015, -595.9261, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-16.019503, -664.52496, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(7.9816036, -780.3536, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(52.056168, -611.7815, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(622.70825, -1247.0453, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(781.5012, -1283.8119, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(841.0384, -1144.5114, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(861.9408, -1238.5437, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(567.1098, -1321.9598, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(836.05475, -1005.8954, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-517.8724, -1262.1267, 40));
		AddSpawnPoint("d_cathedral_78_1.Id5", "d_cathedral_78_1", Rectangle(-548.8129, -1425.8009, 40));

		// 'ERD_Shredded' GenType 7 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1294.3834, -747.9664, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1059.32, -713.43, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1021.5128, -610.39014, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1308.88, -399.13, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1218.37, -287.87, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1100.47, -372.81, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1020.27, -305.3, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-972.68, -522.36, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-923.7912, -649.6202, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1106.5276, -485.64645, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-801.58, -511.53, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-916.37836, -495.63043, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-859.12, -304.41, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1290.6709, -615.3275, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1090.4869, -786.9135, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-1181.3573, -663.1924, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-929.5151, -752.20807, 40));
		AddSpawnPoint("d_cathedral_78_1.Id6", "d_cathedral_78_1", Rectangle(-829.60284, -637.3868, 40));

		// 'ERD_Fire_Dragon_Purple' GenType 8 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-975.77, 97.66, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-876.8273, 136.36308, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-987.9, 210.84, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-905.31, 327.32, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-893.50244, 214.03671, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-818.77936, 95.93039, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-786.0636, 187.26134, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1138.0933, 200.5976, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1344.9583, 81.40841, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1496.8716, 98.51759, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1507.4875, 314.42587, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1271.3795, 325.45285, 40));
		AddSpawnPoint("d_cathedral_78_1.Id7", "d_cathedral_78_1", Rectangle(-1409.2653, 155.6789, 40));

		// 'ERD_Nuo' GenType 9 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1516.246, 199.09105, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1431.27, 73.98, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1385.4916, 229.16162, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1422.65, 336.15, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1326.7102, 310.3725, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1287.08, 144.82, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1222.03, 171.68, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1212.23, 228.41, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-980.09, 151.36, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-903.56146, 72.684975, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-840.11505, 272.13263, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-966.97, 275.04, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-794.7258, 278.76218, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1036.64, 319.53, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1060.8131, 814.9733, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1429.4143, 596.1158, 40));
		AddSpawnPoint("d_cathedral_78_1.Id8", "d_cathedral_78_1", Rectangle(-1038.1345, 681.33496, 40));

		// 'ERD_InfroRocktor' GenType 10 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-169.86563, -23.819641, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-288.33, -153.17, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-26.76, -260.29, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(5.4409447, -105.06087, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-203.67317, 175.90775, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(110.19648, 165.91362, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-66.47, 418.36, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-26.65799, 480.30142, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-531.21, 655.46, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-395.8767, 755.9425, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-404.88, 905.27, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-287.083, 697.8959, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-54.880478, 676.9034, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(-65.66045, 746.9136, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(80.62563, 756.0279, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(56.43, 636.52, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(142.75, 699.25, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(215.56, 886.98, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(264.80817, 699.01276, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(205.84, 611.07, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(365.37, 714.77, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(388.83, 804.3, 40));
		AddSpawnPoint("d_cathedral_78_1.Id9", "d_cathedral_78_1", Rectangle(89.36253, -7.87661, 40));

		// 'ERD_Egnome' GenType 11 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(711.52, -547.62, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(796.94, -723.17, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(1076.41, -515.62, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(871.01, -356.64, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(862.26, 187.74, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(738.15, 322.34, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(928.32, 289.77, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(861.16, -17.85, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(953.75, -717.05, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(939.68, -535.56, 40));
		AddSpawnPoint("d_cathedral_78_1.Id10", "d_cathedral_78_1", Rectangle(687.13, -363.7, 40));

		// 'ERD_Shtayim' GenType 12 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1288.0419, -375.693, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1130.29, -442.41, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1274.37, -613.73, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1311.35, -768.19, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1042.2013, -706.5558, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-924.02, -780.75, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-853.49, -630.58, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-875.13, -459.84, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-758.9, -389.21, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1078.08, -273.38, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-911.04, -183.52, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-890.44, 1.48, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1298.69, 195.51, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-1536.45, 153.32, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-881.33, 324.27, 40));
		AddSpawnPoint("d_cathedral_78_1.Id11", "d_cathedral_78_1", Rectangle(-868.88, 134.77, 40));

		// 'ERD_Nuo' GenType 13 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-1198.4215, 787.7492, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-944.743, 692.57086, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-1409.3148, 729.4248, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-952.33, 783.53, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-1351.2954, 809.12964, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-875.28, 909.4, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-1029.5747, 902.36414, 40));
		AddSpawnPoint("d_cathedral_78_1.Id12", "d_cathedral_78_1", Rectangle(-885.06, 683.06, 40));

		// 'ERD_Elet' GenType 14 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1064.89, 751.97, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-979.42, 674.07, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-918.76526, 856.6716, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1061.5952, 909.6495, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-903.2698, 722.83685, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1181.37, 824.55, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1306.26, 758.35, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1403.53, 784.23, 40));
		AddSpawnPoint("d_cathedral_78_1.Id13", "d_cathedral_78_1", Rectangle(-1381.15, 644.29, 40));

		// 'ERD_Glizardon' GenType 15 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id14", "d_cathedral_78_1", Rectangle(840.45184, -405.53876, 1200));

		// 'ERD_Galok' GenType 16 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id15", "d_cathedral_78_1", Rectangle(-1045.4431, -385.11932, 1500));

		// 'ERD_Malstatue' GenType 18 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(872.95, 91.05, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(805.71, 78.62, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(900.86, -209.83, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(788.54, -213.21, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(902.83, -798.72, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(791.56, -793.01, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(567.88, -502.42, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(1145.62, -558.83, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(1137.49, -460.79, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(107.65, -1398.02, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(101.46, -1139.18, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(270.24, -1144.05, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(269.11, -1405.35, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-226.02, -1137.74, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-219.32, -1405.66, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-401.44, -1403.05, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-400.3, -1137.81, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-105.04, -721.31, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(4.81, -630.32, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(765.24, -565.91, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(938.24, -423.14, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(767.47, -414.99, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(941.44, -570.72, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(49.43, -73.39, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-115.5, -60.86, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-124.16, 77.54, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(46.99, 79.67, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-294.52, -225.92, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-260.03, 211.49, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(83.29, 208.64, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(102.06, -245.7, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-119.83, -180.49, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-273.87607, 873.54486, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(125.45162, 866.5008, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(383.6689, 610.70966, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-1028.96, 731.01, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-912.26, 833.3, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-1019.19, 834.56, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-918.5, 736.26, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-526.6172, 608.1332, 20));
		AddSpawnPoint("d_cathedral_78_1.Id16", "d_cathedral_78_1", Rectangle(-1358.5325, -441.0491, 20));

		// 'ERD_Malstatue' GenType 19 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-785.0156, 309.2084, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-786.0232, 74.31836, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-993.83356, 76.857834, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-995.07, 312.91, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1444.5105, 152.2907, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1444.87, 233.13, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1355.5048, 233.81075, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1354.06, 152.58, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-946.07, -313.04, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1299.34, -324.75, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1152.73, -697.89, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-831.1, -748.33, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1347.2167, -553.3244, 20));
		AddSpawnPoint("d_cathedral_78_1.Id17", "d_cathedral_78_1", Rectangle(-1345.9346, -457.39246, 20));

		// 'Rootcrystal_03' GenType 21 Spawn Points
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(1365.7269, 741.6017, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(863.31085, -403.263, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(873.798, -744.4199, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(892.7545, 37.7395, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(835.0865, 753.2891, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(159.97641, 618.7647, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-292.33044, 697.5578, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-868.7254, 629.6542, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1503.2512, 85.35047, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-865.1537, -26.887112, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-977.0094, -671.0913, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1253.9657, -542.1189, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1088.8525, -988.32623, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-892.2625, -1245.4672, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-36.93842, -1288.2987, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-65.14191, -940.1152, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-72.57035, -716.6424, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(642.1941, -1281.28, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-55.881897, -105.69213, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-3.1626115, 230.99258, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1044.8804, 205.5074, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-1371.6018, 732.9059, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(304.6645, 872.2123, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(-511.57043, 763.4953, 200));
		AddSpawnPoint("d_cathedral_78_1.Id18", "d_cathedral_78_1", Rectangle(1235.2592, 261.03647, 200));
	}
}
