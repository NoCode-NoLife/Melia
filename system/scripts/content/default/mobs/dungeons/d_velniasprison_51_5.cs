//--- Melia Script -----------------------------------------------------------
// d_velniasprison_51_5
//
//--- Description -----------------------------------------------------------
// Sets up the d_velniasprison_51_5 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison515MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_velniasprison_51_5", MonsterId.Mushroom_Boy_Green, Properties("MHP", 215332, "MINPATK", 3270, "MAXPATK", 3920, "MINMATK", 3270, "MAXMATK", 3920, "DEF", 8731, "MDEF", 8731));
		AddPropertyOverrides("d_velniasprison_51_5", MonsterId.Hohen_Mage, Properties("MHP", 217147, "MINPATK", 3293, "MAXPATK", 3949, "MINMATK", 3293, "MAXMATK", 3949, "DEF", 8896, "MDEF", 8896));
		AddPropertyOverrides("d_velniasprison_51_5", MonsterId.Hohen_Gulak, Properties("MHP", 218985, "MINPATK", 3317, "MAXPATK", 3978, "MINMATK", 3317, "MAXMATK", 3978, "DEF", 9064, "MDEF", 9064));

		// Monster Spawners --------------------------------

		AddSpawner("d_velniasprison_51_5.Id1", MonsterId.Rootcrystal_05, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_velniasprison_51_5.Id2", MonsterId.Mushroom_Boy_Green, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_5.Id3", MonsterId.Hohen_Mage, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_5.Id4", MonsterId.Mushroom_Boy_Green, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_5.Id5", MonsterId.Hohen_Gulak, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-814.6922, -648.5019, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-525.4225, -549.65405, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-706.11536, -147.82803, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-729.1777, 372.96655, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-786.5642, 727.1049, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-1454.0284, 95.74961, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-1171.5748, 170.48367, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-2136.0823, 13.962799, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-321.70187, 262.5287, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(209.90515, -29.174171, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-130.23447, -202.5314, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(50.705647, 585.8491, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(654.91907, 494.89944, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-73.13745, 1086.9779, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(1229.6688, 59.47628, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(1540.7826, 90.719444, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(506.42276, -623.6924, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(795.1105, -689.2903, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(-48.641468, -1060.5613, 200));
		AddSpawnPoint( "d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Spot(121.3564, -956.90076, 200));

		// Mushroom_Boy_Green Spawn Points
		AddSpawnPoint( "d_velniasprison_51_5.Id2", "d_velniasprison_51_5", Spot(-1355.4004, 156.91632, 9999));

		// Hohen_Mage Spawn Points
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(725.50415, -658.91095, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-101.51028, -1138.4396, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-102.40952, -972.72345, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(57.37429, -940.49786, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(513.9473, -908.90015, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(113.01478, -1099.3019, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(14.850477, -1054.8396, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(188.20108, -874.5185, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-409.22876, -96.45584, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-28.632633, 189.3689, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-1389.4153, -69.72764, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-1178.7601, 550.55536, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-1200.023, 124.5399, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-1513.3301, 109.863, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-164.18298, 928.87, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-6.5568123, 1174.8127, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(78.41969, 1009.8318, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(182.63696, 1218.31, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-145.35191, 1103.8838, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-913.7762, 631.81555, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-783.10205, 762.4324, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-703.74994, 557.87714, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(549.1936, 628.0715, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(700.47345, 734.11584, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(744.9802, 490.25327, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(637.0057, 419.51852, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(848.31445, 621.9521, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(-233.84262, 565.25586, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(92.691055, 582.3813, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(317.7819, 619.02576, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(618.109, -2.6664019, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(600.39856, -309.52597, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(525.19104, -591.87006, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(731.05615, -533.9468, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(319.34982, -624.63477, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(591.9547, -727.83093, 40));
		AddSpawnPoint( "d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Spot(36.919495, -18.204788, 40));

		// Mushroom_Boy_Green Spawn Points
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(38.15914, -1101.8695, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-124.23085, -1061.895, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-33.733627, -907.6876, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(98.68086, -963.3074, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(1316.3971, -25.814125, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(1534.6183, 137.7044, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(1259.3752, 121.71834, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(1528.0713, 3.02772, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(1393.289, 114.15061, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-233.69753, 601.4881, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(657.28357, 750.7043, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(614.5486, 190.55952, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(659.8117, 589.20557, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(586.9007, 906.20123, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(508.34506, 583.36615, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(891.0877, 628.25134, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(1294.0817, -178.10422, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(722.73737, -671.021, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-432.75485, -3.60571, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-263.27478, 130.0501, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(573.22546, -114.58746, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(618.31213, -549.25684, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-312.80444, 55.93512, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-260.35196, -163.086, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-139.57059, 206.09761, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-362.04346, -73.393326, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-646.1305, 521.3271, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-662.27686, 784.55756, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(521.5499, -617.38116, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-943.3656, 576.06793, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-948.8612, 717.6325, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-738.6897, 771.0056, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-796.2691, 613.4506, 35));
		AddSpawnPoint( "d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Spot(-400.43893, 85.16883, 35));

		// Hohen_Gulak Spawn Points
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(852.68994, 610.0126, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(1303.452, 163.72215, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(643.7933, 778.23236, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(1328.0875, -78.40262, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(255.45071, 1101.0487, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(540.3786, -488.4242, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-180.04211, 1092.3329, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(635.8544, 644.21826, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-930.52686, 705.42993, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(58.102562, 42.66407, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(77.59978, 150.21683, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(530.87146, -683.1301, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(1324.0264, 449.94275, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-765.2208, 496.75488, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-2057.4634, -22.544632, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-2039.7449, 141.70215, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-1453.12, 101.26764, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-632.4584, 715.6109, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-1219.9291, 200.50134, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-1280.9186, -44.02136, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(571.79596, 51.24309, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(788.37067, -676.2866, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(1539.8267, 91.448074, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-0.50064135, 1078.0773, 45));
		AddSpawnPoint( "d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Spot(-305.83057, -34.623367, 45));

	}
}
