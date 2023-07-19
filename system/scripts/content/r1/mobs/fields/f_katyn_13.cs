//--- Melia Script -----------------------------------------------------------
// f_katyn_13
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Poslinkis Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn13MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_13.Id1", MonsterId.Rootcrystal_02, 15, 20, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_katyn_13.Id2", MonsterId.HighBube_Spear, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_13.Id3", MonsterId.HighBube_Archer, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_13.Id4", MonsterId.Arburn_Pokubu_Green, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_13.Id5", MonsterId.HighBube_Spear, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_13.Id6", MonsterId.HighBube_Archer, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_13.Id7", MonsterId.Arburn_Pokubu_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_02' GenType 514 Spawn Points
		AddSpawnPoint("f_katyn_13.Id1", "f_katyn_13", Rectangle(803, -786, 30));
		AddSpawnPoint("f_katyn_13.Id1", "f_katyn_13", Rectangle(-2186, 1225, 30));
		AddSpawnPoint("f_katyn_13.Id1", "f_katyn_13", Rectangle(-1117, 2238, 30));
		AddSpawnPoint("f_katyn_13.Id1", "f_katyn_13", Rectangle(804, -1065, 30));

		// 'HighBube_Spear' GenType 755 Spawn Points
		AddSpawnPoint("f_katyn_13.Id2", "f_katyn_13", Rectangle(-675.63, -1798.16, 9999));

		// 'HighBube_Archer' GenType 756 Spawn Points
		AddSpawnPoint("f_katyn_13.Id3", "f_katyn_13", Rectangle(1124.9183, -549.06915, 9999));

		// 'Arburn_Pokubu_Green' GenType 763 Spawn Points
		AddSpawnPoint("f_katyn_13.Id4", "f_katyn_13", Rectangle(-1253.2235, 674.02423, 9999));

		// 'HighBube_Spear' GenType 770 Spawn Points
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(2044.3396, -214.25099, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(2083.8665, -414.76767, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(2000.1478, -308.78018, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(1253.8816, -483.29022, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(1221.7079, -741.56537, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(765.47296, -906.77734, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(669.7098, -532.639, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(924.6692, -522.8367, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(1037.0074, -769.9332, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(954.45636, 935.0531, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(1025.2554, 1225.8115, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(1320.3303, 1190.4275, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(1154.5493, 1051.2932, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(11.578529, 1592.0885, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-54.143646, 1404.92, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-728.1484, 1328.3705, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-1240.7185, 1267.6648, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-1233.1464, 917.5042, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-898.96277, 1004.6326, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-955.5301, 1327.3964, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-689.5718, -561.1899, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-877.8196, -861.5189, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-686.86456, -1004.149, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-563.40106, -746.49927, 30));
		AddSpawnPoint("f_katyn_13.Id5", "f_katyn_13", Rectangle(-1334.719, 1309.357, 30));

		// 'HighBube_Archer' GenType 771 Spawn Points
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(-757.49365, -990.56226, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(-580.6348, -506.78174, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(-1289.8776, 949.8948, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(-1143.4098, 1445.6191, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(55.765697, 1611.047, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(-344.413, 1118.9153, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(-1094.4408, 2271.5935, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1237.7386, 1921.6249, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1304.6035, 1385.8605, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1148.1184, 846.5193, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1018.9855, 1162.0392, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(788.9736, -560.13776, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(785.34216, -937.52405, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1168.0038, -428.5335, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1135.6616, -756.8121, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1992.2373, -279.8505, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(2215.2395, -342.0517, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1833.8232, -621.2147, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1180.3434, -7.2697983, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(12.740934, -796.9503, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(-2193.0051, 1136.4519, 30));
		AddSpawnPoint("f_katyn_13.Id6", "f_katyn_13", Rectangle(1343.1027, 1129.5361, 30));

		// 'Arburn_Pokubu_Green' GenType 772 Spawn Points
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-981.56335, 1040.9324, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1339.1394, 1451.2869, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1624.1354, 1025.1886, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1242.9059, 526.2934, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1325.6705, 316.21274, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1027.5164, 177.12007, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-541.6761, -222.24135, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-766.07526, -627.98444, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-610.5096, -859.3058, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-362.62616, -758.42865, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-834.5446, 1424.9874, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-630.1446, 1042.7513, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-943.144, 2237.5874, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1158.8075, 2331.1514, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(146.71872, 1442.8618, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-240.48427, 1176.0818, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1099.93, 839.9297, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1214.045, 1188.8977, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-835.2306, 1195.6986, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-1260.0199, 856.6307, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(32.550755, 1479.7162, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-893.7981, -838.3811, 30));
		AddSpawnPoint("f_katyn_13.Id7", "f_katyn_13", Rectangle(-653.51715, 78.71954, 30));
	}
}
