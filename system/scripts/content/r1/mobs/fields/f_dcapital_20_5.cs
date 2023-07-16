//--- Melia Script -----------------------------------------------------------
// f_dcapital_20_5
//
//--- Description -----------------------------------------------------------
// Sets up the f_dcapital_20_5 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital205MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("f_dcapital_20_5.Id1", MonsterId.Pumpkin_Dog, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_5.Id2", MonsterId.Scare_Crow, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_5.Id3", MonsterId.Straw_Walker, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_5.Id4", MonsterId.Straw_Walker, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_20_5.Id5", MonsterId.Rootcrystal_04, 20, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Pumpkin_Dog Spawn Points
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(38.47001, -110.94524, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-71.43217, -205.37366, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-55.58428, -388.55106, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(153.24817, -466.59003, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(271.8788, -349.47028, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(193.9971, -191.18567, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-101.94913, -719.5457, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-328.24774, -129.51067, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(80.109665, 187.74968, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(396.2021, 114.26312, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(753.3884, 23.943798, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(916.0183, -95.38948, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(942.1395, 41.493, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(1100.7363, 180.89346, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(1181.1862, -15.425499, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(1310.6848, 174.94069, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(512.77954, 651.0207, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(641.8392, 701.461, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(574.5669, 766.31555, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(407.64288, 414.83972, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(446.67984, 278.17075, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-109.49352, 254.85754, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-368.35922, 459.767, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-423.70123, 687.22296, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-542.66797, 836.2118, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-884.5493, 588.0666, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-1131.0723, 573.48096, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-1274.733, 36.075573, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-1140.364, -281.5204, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-1294.6064, -275.17914, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-1064.0975, 54.18234, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-826.6283, -245.50093, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-599.2234, -138.22212, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(487.69012, -603.06305, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(117.72, -738.8922, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(573.8171, -123.11333, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(1107.6135, -686.1883, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(1312.347, -703.0462, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(582.0554, -335.32547, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-592.5204, 644.55975, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-1230.2628, -736.8051, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-1106.8505, -824.50543, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-764.6504, -637.0905, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-592.6356, -754.4438, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-543.5796, -578.8785, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-395.95575, -300.0312, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(618.87286, 581.25757, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-1107.3893, -675.792, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-977.2235, -589.24994, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-955.1045, -767.36426, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id1", "f_dcapital_20_5", Spot(-627.8422, -636.5713, 35));

		// Scare_Crow Spawn Points
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-976.0157, 453.30167, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-217.51463, 58.66938, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-1062.769, 529.8857, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-604.22363, 662.0564, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-587.69586, 765.6152, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-458.7319, 610.0005, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-314.33337, 326.62903, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-223.00845, 417.97394, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-203.25775, 252.4286, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(9.229497, -454.91263, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(-89.37536, -305.3427, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(158.9732, -390.87848, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(253.94955, -440.6212, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(243.87462, -744.9081, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id2", "f_dcapital_20_5", Spot(103.32618, -347.24893, 35));

		// Straw_Walker Spawn Points
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(718.7726, -101.00171, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(846.5835, -14.929859, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(716.6678, 76.88615, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(955.47565, 139.9497, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(1118.5574, -0.20929885, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(1275.2773, 149.90724, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(1255.3485, 49.02716, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(1200.2184, 253.95071, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(1177.8019, 92.21939, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(434.42688, -50.094566, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(224.46361, 164.48903, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(301.6587, 222.6604, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(531.2678, -408.83298, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(363.71304, -691.1746, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(175.23398, -787.4711, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-232.92447, -708.1207, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-239.86278, -540.6614, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-435.73114, -151.03326, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-703.1263, -214.04463, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-360.33658, -467.2041, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-108.83886, -290.62384, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(257.81992, -603.13873, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(304.46988, -238.67067, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-16.669712, -126.29921, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(211.24182, -74.23169, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(145.86386, -95.532, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(19.22136, -263.71008, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-101.80489, -497.47403, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-1240.0972, -290.80197, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-1028.539, -233.64217, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-1367.2079, -5.3065133, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-1139.6885, -3.0967069, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(119.93357, -437.45584, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id3", "f_dcapital_20_5", Spot(-434.0322, -638.8492, 35));
		AddSpawnPoint( "f_dcapital_20_5.Id4", "f_dcapital_20_5", Spot(308.03485, -380.10712, 9999));

		// Rootcrystal_04 Spawn Points
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-1061.62, -802.12, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-694.4, -618, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-440.35, -720.71, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-331.7, -316.33, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-653.73, -189.48, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-1217.78, -90.01, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-87.95, 159.69, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(8.08, -364.43, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(262.8, -165.63, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(326.49, -725.85, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(596.04, -272.57, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(794.34, 94.92, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(1212.38, -43.71, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(537.65, 314.71, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(511.32, 748.65, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-515.55, 719.86, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-1013.59, 537.44, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(1227.0546, -665.6789, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-379.78, 411.36, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(339.17, 94.3, 15));
		AddSpawnPoint( "f_dcapital_20_5.Id5", "f_dcapital_20_5", Spot(-75.49, -733.64, 15));

	}
}
