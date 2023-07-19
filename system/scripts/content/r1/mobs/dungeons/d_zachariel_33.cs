//--- Melia Script -----------------------------------------------------------
// d_zachariel_33
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Royal Mausoleum 2F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DZachariel33MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_zachariel_33", MonsterId.Beetle, Properties("MHP", 64238, "MINPATK", 1327, "MAXPATK", 1533, "MINMATK", 1327, "MAXMATK", 1533, "DEF", 385, "MDEF", 385));
		AddPropertyOverrides("d_zachariel_33", MonsterId.Vesper, Properties("MHP", 65012, "MINPATK", 1337, "MAXPATK", 1545, "MINMATK", 1337, "MAXMATK", 1545, "DEF", 396, "MDEF", 396));
		AddPropertyOverrides("d_zachariel_33", MonsterId.Wolf_Statue, Properties("MHP", 65802, "MINPATK", 1347, "MAXPATK", 1557, "MINMATK", 1347, "MAXMATK", 1557, "DEF", 409, "MDEF", 409));
		AddPropertyOverrides("d_zachariel_33", MonsterId.Tombsinker, Properties("MHP", 66609, "MINPATK", 1357, "MAXPATK", 1570, "MINMATK", 1357, "MAXMATK", 1570, "DEF", 421, "MDEF", 421));
		AddPropertyOverrides("d_zachariel_33", MonsterId.Echad, Properties("MHP", 67431, "MINPATK", 1368, "MAXPATK", 1583, "MINMATK", 1368, "MAXMATK", 1583, "DEF", 433, "MDEF", 433));

		// Monster Spawners ---------------------------------

		AddSpawner("d_zachariel_33.Id1", MonsterId.Beetle, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id2", MonsterId.Vesper, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id3", MonsterId.Rootcrystal_05, 18, 24, TimeSpan.FromMilliseconds(15000), TendencyType.Peaceful);
		AddSpawner("d_zachariel_33.Id4", MonsterId.Wolf_Statue, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id5", MonsterId.Beetle, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id6", MonsterId.Vesper, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id7", MonsterId.Wolf_Statue, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id8", MonsterId.Tombsinker, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_zachariel_33.Id9", MonsterId.Wolf_Statue, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_zachariel_33.Id10", MonsterId.Beetle_Elite, 3, 3, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Beetle' GenType 17 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-607.34717, 97.7493, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-87.88245, 206.97668, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(325.4325, -667.24884, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-889.5011, 154.21944, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(121.51105, 294.69836, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-174.31946, 97.07669, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(59.41015, 514.8028, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-390.57675, 186.18051, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-1565.8252, 194.43768, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(33.232517, 191.97054, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(91.0258, 68.82915, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(22.359997, 696.9925, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(345.45068, 241.58507, 35));
		AddSpawnPoint("d_zachariel_33.Id1", "d_zachariel_33", Rectangle(-264.53436, 294.6566, 35));

		// 'Vesper' GenType 18 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-199.17828, -585.65155, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-76.69006, -1936.7725, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-217.89906, -1961.4061, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-99.5119, -2343.0981, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(16.384352, -1969.1212, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-256.4868, -849.82043, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-769.5882, -725.97736, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-200.41187, -270.0989, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-29.225384, -740.4992, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-126.10217, -1302.878, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1419.7164, -818.96466, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1652.979, -792.87506, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1377.0675, -667.0912, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1496.7145, -734.75104, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1639.218, 154.18367, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1507.5164, 342.831, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1729.9219, 301.46457, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1390.5787, 252.70755, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-671.28625, 279.53796, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-1033.6759, 263.67862, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-11.311556, 799.5594, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-98.26814, 39.21769, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(64.18728, 176.18375, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(47.40507, 375.32153, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(22.813488, 1000.0496, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-106.90759, -2189.012, 30));
		AddSpawnPoint("d_zachariel_33.Id2", "d_zachariel_33", Rectangle(-66.56488, -2253.7551, 30));

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-192.11725, -551.27045, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-133.60855, -1213.0259, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-95.379074, -2356.984, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-143.05077, -1979.6658, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(188.45097, -675.42224, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-494.5335, -754.5742, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-183.33069, 42.554276, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-397.76035, 302.46765, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(119.61187, 215.25539, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-734.12286, 123.08927, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1121.5378, 256.7022, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1548.2303, 248.24808, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1542.8635, 12.668365, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1575.3612, -563.7701, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1354.4824, -853.4372, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-1902.7871, -791.6988, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(1187.015, 252.57855, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(1952.6826, 243.46631, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(2025.9578, -337.9018, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(2282.9539, -36.923798, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(2243.2231, 448.43732, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(38.532936, 844.4344, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(219.05219, 1539.8232, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(-41.3052, 1403.7648, 30));
		AddSpawnPoint("d_zachariel_33.Id3", "d_zachariel_33", Rectangle(30.687029, 1848.7974, 30));

		// 'Wolf_Statue' GenType 3012 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id4", "d_zachariel_33", Rectangle(89.14456, 231.34334, 9999));

		// 'Beetle' GenType 3013 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-348.1272, -802.6368, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-132.99083, -889.836, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(34.433525, -779.27704, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(0.82768536, -652.5651, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-185.30598, -744.7231, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(37.578396, -891.86285, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-313.60522, -881.9189, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-122.20786, -1232.1848, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-142.3826, -1449.9619, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-234.13438, -2028.6395, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-16.261585, -1950.5613, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-189.83311, -1897.2931, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-108.93932, -2132.3418, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-1601.7528, 163.0997, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-1598.3063, 298.37427, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-1514.5774, 206.64459, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-1367.7711, 266.43475, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-903.2758, 252.3551, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-699.4359, 265.808, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-758.2356, 136.96135, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-888.9658, 78.36176, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-433.29376, 287.0969, 30));
		AddSpawnPoint("d_zachariel_33.Id5", "d_zachariel_33", Rectangle(-390.6117, 117.53767, 30));

		// 'Vesper' GenType 3014 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id6", "d_zachariel_33", Rectangle(76.492455, 1433.6903, 9999));

		// 'Wolf_Statue' GenType 3015 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-75.74352, -1878.7393, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-69.05628, 225.2522, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-245.12883, -1962.8, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-90.28173, -2053.0405, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-140.64053, -1967.2863, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-194.941, -2052.5276, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-263.30548, 162.72638, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-76.318924, 83.51516, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(68.03944, 324.99838, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-563.26514, 256.8812, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(30.663391, 535.30695, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(277.30908, 274.53174, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(81.85735, 88.43369, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-169.95137, -118.01586, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-187.65225, -1879.141, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-609.19086, -753.0277, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-411.22446, -594.01404, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-285.96567, -890.8473, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(70.73936, -926.98816, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(55.465805, -614.9232, 30));
		AddSpawnPoint("d_zachariel_33.Id7", "d_zachariel_33", Rectangle(-32.81743, -798.8869, 30));

		// 'Tombsinker' GenType 3018 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id8", "d_zachariel_33", Rectangle(26.158539, 274.57635, 9999));

		// 'Wolf_Statue' GenType 3019 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(341.99377, -665.3928, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(582.3442, -648.1564, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(823.098, -626.39294, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(1008.3204, -705.55554, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(1070.3743, -567.95154, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(689.5869, -545.56036, 35));
		AddSpawnPoint("d_zachariel_33.Id9", "d_zachariel_33", Rectangle(786.05084, -762.8019, 35));

		// 'Beetle_Elite' GenType 3022 Spawn Points
		AddSpawnPoint("d_zachariel_33.Id10", "d_zachariel_33", Rectangle(-22.074337, -713.6813, 9999));
	}
}
