//--- Melia Script -----------------------------------------------------------
// d_velniasprison_51_4
//
//--- Description -----------------------------------------------------------
// Sets up the d_velniasprison_51_4 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison514MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("d_velniasprison_51_4", MonsterId.Elma, Properties("MHP", 197011, "MINPATK", 3035, "MAXPATK", 3631, "MINMATK", 3035, "MAXMATK", 3631, "DEF", 7061, "MDEF", 7061));
		AddPropertyOverrides("d_velniasprison_51_4", MonsterId.Nuo, Properties("MHP", 198545, "MINPATK", 3054, "MAXPATK", 3655, "MINMATK", 3054, "MAXMATK", 3655, "DEF", 7201, "MDEF", 7201));
		AddPropertyOverrides("d_velniasprison_51_4", MonsterId.Socket, Properties("MHP", 200107, "MINPATK", 3074, "MAXPATK", 3680, "MINMATK", 3074, "MAXMATK", 3680, "DEF", 7343, "MDEF", 7343));
		AddPropertyOverrides("d_velniasprison_51_4", MonsterId.Mushroom_Ent_Green, Properties("MHP", 201695, "MINPATK", 3095, "MAXPATK", 3705, "MINMATK", 3095, "MAXMATK", 3705, "DEF", 7488, "MDEF", 7488));

		// Monster Spawners --------------------------------

		AddSpawner("d_velniasprison_51_4.Id1", MonsterId.Elma, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_4.Id2", MonsterId.Elma, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_4.Id3", MonsterId.Nuo, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_4.Id4", MonsterId.Nuo, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_4.Id5", MonsterId.Socket, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_4.Id6", MonsterId.Rootcrystal_05, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_velniasprison_51_4.Id7", MonsterId.Mushroom_Ent_Green, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Elma Spawn Points
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2583.8076, 1556.6132, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2715.589, 1757.0829, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2524.6106, 1821.2877, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-3137.3806, 120.57536, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2842.7947, 183.98528, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2621.496, -3.7042542, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2407.2842, 151.22885, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-3488.552, 326.8302, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2844.7703, 844.2487, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2828.5383, 649.87244, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-3071.7046, 1507.2888, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-3396.6636, 1201.2802, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2748.8452, 1620.45, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2570.81, 140.49579, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2585.897, 899.78796, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2637.6467, 764.44165, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-3385.1711, 113.28514, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-3449.7346, 689.7196, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2488.495, 1667.844, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2355.8655, 1417.6771, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2102.9993, 1282.3986, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2065.83, 1147.7372, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-1986.1913, 1472.8085, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-1889.94, 1354.8298, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-1922.882, 1225.2579, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2976.4148, 744.84546, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-3414.7925, 842.4666, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id1", "d_velniasprison_51_4", Spot(-2495.586, 657.12354, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id2", "d_velniasprison_51_4", Spot(-2001.285, 1308.0178, 9999));

		// Nuo Spawn Points
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(3.9382935, 358.87976, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-786.0669, -422.0078, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-293.51273, 364.2795, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(105.01861, -103.19573, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-782.0235, -1041.4836, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-1437.7452, -963.6655, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-1464.2874, 74.83621, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-1300.4888, 418.50653, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-600.3486, -287.92798, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-400.95624, -148.94943, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-1580.3741, -596.4536, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-1045.9, -1011.2415, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-853.656, -858.8666, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-601.8528, -1009.9019, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-681.629, -1241.059, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(122.99674, -332.1906, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(345.19916, -267.43137, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(200.18243, -882.9022, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(21.317663, -931.6382, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-66.48964, -876.64886, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-640.56146, -132.80466, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-559.0872, -566.3495, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(217.56868, 338.79654, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(-399.7639, -365.7445, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id3", "d_velniasprison_51_4", Spot(240.11765, -195.64117, 40));
		AddSpawnPoint( "d_velniasprison_51_4.Id4", "d_velniasprison_51_4", Spot(240.5922, -175.0587, 9999));

		// Socket Spawn Points
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-569.99445, -472.6038, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-525.19604, -218.81741, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-767.4848, -465.81042, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-1278.662, -987.5856, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(135.03275, -268.4286, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-789.0919, -1020.5643, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-58.798664, -888.599, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(225.38943, -828.61584, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-847.54913, -156.92206, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(35.004185, -43.04605, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-51.84138, 377.37692, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(203.89862, 380.0603, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(293.44775, -243.3931, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-485.35922, -1066.7212, 50));
		AddSpawnPoint( "d_velniasprison_51_4.Id5", "d_velniasprison_51_4", Spot(-641.0351, -1242.2255, 50));

		// Rootcrystal_05 Spawn Points
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-1012.9388, 1079.6501, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-831.6456, -398.00482, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-458.57077, -313.7949, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-1602.5121, -281.656, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-786.5263, -1125.0985, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(328.20712, -830.86096, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(240.88234, -235.33849, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-589.36755, 366.3603, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-1498.482, -964.65106, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-2023.7513, 657.91516, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-1985.977, 1308.8323, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-2483.3623, 1748.9608, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-2708.0068, 1662.8514, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-3522.5146, 949.561, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-3407.4946, 663.2566, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-3264.1943, 66.08033, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-2809.7954, 76.94168, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-2875.9448, 645.83136, 200));
		AddSpawnPoint( "d_velniasprison_51_4.Id6", "d_velniasprison_51_4", Spot(-2593.476, 851.0609, 200));

		// Mushroom_Ent_Green Spawn Points
		AddSpawnPoint( "d_velniasprison_51_4.Id7", "d_velniasprison_51_4", Spot(-1360.7897, 368.35495, 9999));

	}
}
