//--- Melia Script -----------------------------------------------------------
// d_underfortress_59_2
//
//--- Description -----------------------------------------------------------
// Sets up the d_underfortress_59_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress592MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("d_underfortress_59_2.Id1", MonsterId.FD_Spectra, 45, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id2", MonsterId.FD_Spector_Gh_Purple, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id3", MonsterId.FD_Whip_Vine_Purple, 25, TimeSpan.FromMilliseconds(120000), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id4", MonsterId.FD_Boss_Canceril, 0, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id5", MonsterId.Rootcrystal_03, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_underfortress_59_2.Id6", MonsterId.FD_Spectra, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id7", MonsterId.FD_Spectra, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_59_2.Id8", MonsterId.FD_Colimen_Mage, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// FD_Spectra Spawn Points
		AddSpawnPoint( "d_underfortress_59_2.Id1", "d_underfortress_59_2", Spot(139.51884, -134.11427, 9999));

		// FD_Spector_Gh_Purple Spawn Points
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(340.55673, 238.17207, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-60.823086, 759.8757, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-197.97787, 763.1336, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-169.10129, -737.5157, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(423.89557, -762.64685, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-998.5559, -722.1073, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-902.8486, -211.18773, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-960.5439, 92.30168, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(978.69257, 220.60258, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(1277.834, 147.65298, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(141.8263, 124.59573, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-55.524277, 640.5997, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-39.493103, 117.10275, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-147.62552, -334.53522, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-1307.9105, -709.8705, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-676.741, -704.8032, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-1341.4844, -284.30243, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-1334.7975, 165.95631, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-144.96973, 606.4922, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-999.0816, -440.49744, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-649.37354, 144.53694, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-225.07205, 683.3138, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-569.8598, -281.30948, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-119.17797, -220.3817, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(-178.95058, -873.8124, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(162.70721, -701.1099, 200));
		AddSpawnPoint( "d_underfortress_59_2.Id2", "d_underfortress_59_2", Spot(121.01634, -836.7322, 200));

		// FD_Whip_Vine_Purple Spawn Points
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(50.517845, -793.1945, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-388.4199, -220.06633, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-391.51837, -245.8875, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-436.0191, -222.47586, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-435.93585, -247.00252, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-421.10297, -232.16742, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-477.6774, -223.82385, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-479.02505, -249.86284, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-471.61746, -239.1099, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-678.1193, -220.43758, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-691.0442, -264.8924, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-680.65826, -248.7748, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-729.3275, -218.30019, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-709.5823, -233.7485, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-731.2102, -251.69125, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-765.61273, -222.98979, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-775.95123, -247.98431, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-801.33215, -224.28778, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-975.1813, 400.51144, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-974.8497, 429.2291, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-967.7948, 455.01944, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-936.54095, 481.14365, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-942.08923, 451.90234, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-939.4942, 411.7155, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-954.23285, 395.35754, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(-968.1064, 496.6158, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(57.043045, -739.94653, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(90.33942, -730.65063, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(118.27634, -710.0026, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(155.26251, -731.1129, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(133.65689, -761.44226, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(170.28488, -758.79663, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(99.755745, -807.1928, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(64.36565, -772.98364, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(133.53436, -816.1074, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(93.692085, -759.1762, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(153.06477, -792.5037, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(113.4165, -785.52954, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(186.95984, -795.4781, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(591.41144, 220.11224, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(593.3176, 197.54906, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(591.8419, 165.05914, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(632.2816, 164.54028, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(625.4494, 192.26932, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(634.63586, 220.83987, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(661.57275, 217.56598, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(655.91724, 189.9058, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(663.1635, 166.72345, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(664.5953, 151.85812, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(700.4926, 162.53476, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(694.47107, 187.39188, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(701.4911, 215.87566, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(614.3148, 215.6689, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(734.4303, 224.11485, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(725.4278, 194.46196, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(721.67206, 170.72449, 10));
		AddSpawnPoint( "d_underfortress_59_2.Id3", "d_underfortress_59_2", Spot(717.4829, 155.29869, 10));

		// FD_Boss_Canceril Spawn Points
		AddSpawnPoint( "d_underfortress_59_2.Id4", "d_underfortress_59_2", Spot(811.27606, 1155.5443, 20));

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(124.10714, 206.3757, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(91.731735, -244.81479, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(148.20459, -766.10046, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(-174.95447, -770.6531, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(432.59933, -800.168, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(997.87823, -768.9081, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(975.2027, -211.37996, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(1292.9528, 183.50029, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(874.91345, 190.29285, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(395.21777, 188.67937, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(547.9796, 1115.206, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(737.6949, 921.71625, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(599.1155, 944.1111, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(89.61344, 1092.8253, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(-89.793915, 711.61584, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(328.1251, 684.3641, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(-977.9452, 161.35309, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(-953.755, -344.80048, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(-912.40265, -755.7433, 100));
		AddSpawnPoint( "d_underfortress_59_2.Id5", "d_underfortress_59_2", Spot(-459.6801, -243.60657, 100));

		// FD_Spectra Spawn Points
		AddSpawnPoint( "d_underfortress_59_2.Id6", "d_underfortress_59_2", Spot(-953.3658, -810.97205, 30));
		AddSpawnPoint( "d_underfortress_59_2.Id6", "d_underfortress_59_2", Spot(-951.06964, -584.24414, 30));
		AddSpawnPoint( "d_underfortress_59_2.Id6", "d_underfortress_59_2", Spot(-960.55566, -367.61887, 30));
		AddSpawnPoint( "d_underfortress_59_2.Id6", "d_underfortress_59_2", Spot(-967.99054, -70.88812, 30));
		AddSpawnPoint( "d_underfortress_59_2.Id6", "d_underfortress_59_2", Spot(-940.4217, 302.0641, 30));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(516.1197, -767.11224, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(325.00388, -760.46387, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(404.15985, -859.8547, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-243.39954, -780.1419, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-189.65193, -629.92816, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-153.8464, -878.4823, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-909.67926, -244.02621, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(864.27625, -781.9271, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(978.82336, -695.51105, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-765.45825, -246.83597, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(1093.9536, -853.4515, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(27.7275, 82.75385, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(320.9183, 741.3823, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-134.2289, 117.98389, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(1006.7863, -88.28281, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(867.4853, -194.17953, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(1065.657, -220.16422, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(1097.7762, 139.46048, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(1026.8994, 224.70503, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-97.63741, 697.466, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(1201.7281, 163.58766, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(722.5783, 1010.0231, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(433.511, 655.5601, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(916.80194, 220.8836, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(726.23315, 188.65424, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(77.06891, 543.8945, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(112.9369, 248.5613, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-1015.5995, 181.54837, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(111.38, 803.3512, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-165.2348, 1019.3268, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-33.406216, 1136.9779, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(442.50073, 950.6957, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(-189.80725, -299.29523, 25));
		AddSpawnPoint( "d_underfortress_59_2.Id7", "d_underfortress_59_2", Spot(373.71863, 200.29488, 25));

		// FD_Colimen_Mage Spawn Points
		AddSpawnPoint( "d_underfortress_59_2.Id8", "d_underfortress_59_2", Spot(-47.121292, -235.54626, 9999));

	}
}
