//--- Melia Script -----------------------------------------------------------
// f_dcapital_104
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Path of Desition' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital104MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_104", MonsterId.Orc_Cannon, Properties("MHP", 820054, "MINPATK", 11046, "MAXPATK", 13478, "MINMATK", 11046, "MAXMATK", 13478, "DEF", 286164, "MDEF", 286164));
		AddPropertyOverrides("f_dcapital_104", MonsterId.Orc_Flag, Properties("MHP", 822595, "MINPATK", 11079, "MAXPATK", 13518, "MINMATK", 11079, "MAXMATK", 13518, "DEF", 288304, "MDEF", 288304));
		AddPropertyOverrides("f_dcapital_104", MonsterId.Orc_Glaive, Properties("MHP", 825165, "MINPATK", 11112, "MAXPATK", 13559, "MINMATK", 11112, "MAXMATK", 13559, "DEF", 290468, "MDEF", 290468));
		AddPropertyOverrides("f_dcapital_104", MonsterId.Boss_Kabad_Q1, Properties("MHP", 7193260, "MINPATK", 25931, "MAXPATK", 31643, "MINMATK", 25931, "MAXMATK", 31643, "DEF", 1021369, "MDEF", 1021369));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_104.Id1", MonsterId.Orc_Cannon, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_104.Id2", MonsterId.Orc_Flag, 53, 70, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_104.Id3", MonsterId.Orc_Glaive, 8, 10, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_104.Id4", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Orc_Cannon' GenType 1 Spawn Points
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1039.1886, -2110.5735, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1099.6993, -1837.0471, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(980.5539, -1805.3705, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(859.3569, -1974.4475, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(841.26605, -1741.1914, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(896.7743, -1531.3895, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1174.1636, -1958.0052, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(282.89374, -1119.288, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(164.26338, -1170.6729, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(57.3624, -1198.7174, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(492.61166, -302.89954, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(445.23047, -373.23907, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(593.1196, -354.18622, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(795.02014, -414.2367, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(620.2451, -521.61365, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(236.31517, -1019.9068, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(536.45917, -581.798, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-50.07053, -1743.6995, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(23.186348, -1603.5338, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(154.37802, -1765.8239, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-23.648005, -1662.7842, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(96.119995, -1821.9065, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(211.99579, -1680.932, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(283.64694, -1795.1655, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(331.05435, -1712.5795, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(843.1843, -1859.8638, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(993.44794, -1920.2177, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1206.8287, -2157.9927, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1327.1528, -1852.4014, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1374.7002, -2060.1416, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(916.5807, -1612.9237, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(645.2827, -614.5078, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-701.1055, 126.45499, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-711.46533, 269.64313, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-511.94077, 27.506268, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-487.91223, 155.19653, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-583.8012, 254.8868, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-397.3779, 138.79234, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-59.552017, 640.31226, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(-47.52272, 828.4318, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(61.33325, 817.4296, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(96.50669, 687.354, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(944.1366, 104.17574, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1074.1586, 232.0119, 30));
		AddSpawnPoint("f_dcapital_104.Id1", "f_dcapital_104", Rectangle(1096.8191, 69.12353, 30));

		// 'Orc_Flag' GenType 2 Spawn Points
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1337.2489, 43.81954, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1563.0453, 208.44794, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1633.2626, 141.40335, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1426.1747, 166.31664, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(599.8768, 1379.4114, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(908.6665, 199.4432, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1012.0439, 264.6591, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1024.5544, 51.828655, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(429.12497, -491.83118, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(521.9617, -430.25085, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(727.5055, -335.09622, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(751.2189, -526.0418, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(645.718, -430.53024, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(244.06946, -1210.2742, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(190.79028, -1063.5413, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(108.26447, -1106.0334, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(721.88794, -1215.3131, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(713.6349, -1119.0447, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(907.62775, -1152.8763, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(859.77167, -1243.3785, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-32.995415, -1830.2902, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-100.95226, -1676.8569, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(35.018314, -1545.1279, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(80.08129, -1667.6849, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(297.05252, -1735.557, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(795.7646, -2074.7808, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1009.7676, -1624.1248, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(969.6202, -2076.3306, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1153.288, -1740.7253, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1234.0085, -2075.6804, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1309.5424, -1975.3959, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(915.01355, -1821.8848, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1073.275, -2018.2245, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(711.31213, -773.51624, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(461.32196, -1151.0382, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-699.68207, 27.49971, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-775.35284, 205.75327, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-461.18762, 270.812, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-594.5166, 129.90335, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1180.6423, 177.91496, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(39.054863, 547.2862, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-113.77829, 782.539, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(132.90002, 866.0043, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(32.47454, 753.4077, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(273.5395, 1003.0256, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(544.5516, 1252.3828, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(835.4955, 137.43835, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1031.7365, 157.36864, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(769.0274, -1067.7595, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(814.57715, -1173.33, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(807.7145, -1043.5103, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1555.5477, 58.438885, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1313.2225, 222.50603, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1245.0806, 91.5914, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(-1757.628, 119.78697, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1112.166, 133.77536, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(698.25586, 1285.6061, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(1023.4344, 1258.9995, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(755.48145, 1122.7256, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(887.2198, 1122.4595, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(977.7899, 1184.0475, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(613.0551, 1141.1516, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(791.8573, 1353.9103, 35));
		AddSpawnPoint("f_dcapital_104.Id2", "f_dcapital_104", Rectangle(890.8113, 1315.0582, 35));

		// 'Orc_Glaive' GenType 3 Spawn Points
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(592.69867, -452.60056, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(214.2729, -1106.8724, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(795.50146, -1149.7175, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(899.5102, -1760.783, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(1280.3503, -2013.7454, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(117.21061, -1746.761, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(1024.9355, 167.48596, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(-1652.5802, 56.31115, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(-587.672, 120.42915, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(-2.909212, 735.4627, 100));
		AddSpawnPoint("f_dcapital_104.Id3", "f_dcapital_104", Rectangle(835.11383, 1235.4519, 100));

		// 'Rootcrystal_01' GenType 5 Spawn Points
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-45.13243, -1579.5784, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(37.30869, -1803.908, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(238.13846, -1724.3823, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(69.593544, -1262.7466, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(269.25314, -1119.276, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(600.7152, -1184.6293, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(813.9481, -1030.6311, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(850.225, -1238.5432, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(846.4176, -1510.0986, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(831.89166, -1927.0426, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1134.5947, -2143.9233, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(930.90295, -1721.2539, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1086.1063, -1893.6097, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1387.3776, -1951.7245, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1347.0149, -2119.2075, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(703.15, -800.42285, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(817.4906, -427.6789, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(424.03735, -322.67422, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(426.59064, -550.7901, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(625.22296, -497.49005, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(335.48102, -111.72792, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(68.16823, 65.35379, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(74.63782, 293.69177, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(288.57123, 122.46581, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(328.77032, 352.02896, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(502.20154, 144.81525, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(778.69763, 159.14514, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(997.2436, 201.83951, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1190.0117, 137.59697, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(495.04086, 1664.7446, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(610.50134, 1492.7744, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(773.69434, 1458.6252, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(659.99677, 1245.6992, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(922.4784, 1110.7299, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(1092.4117, 1219.3134, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(413.4118, 1164.4308, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(262.84357, 933.9888, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-99.704796, 798.4242, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-244.76207, 186.04294, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-708.9194, 93.04462, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-746.5778, 327.69992, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-443.8095, 324.69897, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-518.4764, 140.5899, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-1100.305, 163.82591, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-1495.089, 99.49533, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-1768.53, 211.1699, 100));
		AddSpawnPoint("f_dcapital_104.Id4", "f_dcapital_104", Rectangle(-1312.4514, 183.68036, 100));
	}
}
