//--- Melia Script -----------------------------------------------------------
// id_Unknownsanctuary_1
//
//--- Description -----------------------------------------------------------
// Sets up the id_Unknownsanctuary_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdUnknownsanctuary1MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("id_Unknownsanctuary_1.Id1", MonsterId.Boss_FD_Durahan, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id2", MonsterId.Boss_FD_NetherBovine, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id3", MonsterId.Boss_FD_Riteris, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id4", MonsterId.Boss_FD_Marionette, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id5", MonsterId.Boss_FD_Succubus, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id6", MonsterId.Boss_FD_Deathweaver, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id7", MonsterId.Boss_FD_SwordBallista, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id8", MonsterId.Boss_FD_Ginklas, 1, TimeSpan.FromMilliseconds(10000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id9", MonsterId.FD_Poncer, 76, TimeSpan.FromMilliseconds(5000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id10", MonsterId.FD_Yishoneer, 56, TimeSpan.FromMilliseconds(5000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_1.Id11", MonsterId.FD_Yishontorcher, 29, TimeSpan.FromMilliseconds(5000), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// Boss_FD_Durahan Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id1", "id_Unknownsanctuary_1", Spot(536.09546, -107.64157, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id1", "id_Unknownsanctuary_1", Spot(-1282.6643, -527.9896, 20));

		// Boss_FD_NetherBovine Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id2", "id_Unknownsanctuary_1", Spot(-643.59503, -63.43155, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id2", "id_Unknownsanctuary_1", Spot(-358.94553, -587.6076, 20));

		// Boss_FD_Riteris Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id3", "id_Unknownsanctuary_1", Spot(-418.65967, -1056.2793, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id3", "id_Unknownsanctuary_1", Spot(-197.29239, 929.7968, 20));

		// Boss_FD_Marionette Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id4", "id_Unknownsanctuary_1", Spot(-113.34427, 531.58923, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id4", "id_Unknownsanctuary_1", Spot(-1604.4329, -71.49671, 20));

		// Boss_FD_Succubus Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id5", "id_Unknownsanctuary_1", Spot(-1265.5168, 601.84174, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id5", "id_Unknownsanctuary_1", Spot(528.13153, 442.2587, 20));

		// Boss_FD_Deathweaver Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id6", "id_Unknownsanctuary_1", Spot(-741.82263, -724.79944, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id6", "id_Unknownsanctuary_1", Spot(-786.3187, 946.7786, 20));

		// Boss_FD_SwordBallista Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id7", "id_Unknownsanctuary_1", Spot(-1072.888, 55.57822, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id7", "id_Unknownsanctuary_1", Spot(-29.618427, -51.19048, 20));

		// Boss_FD_Ginklas Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id8", "id_Unknownsanctuary_1", Spot(-734.8415, 390.98242, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id8", "id_Unknownsanctuary_1", Spot(140.55176, -564.77454, 20));

		// FD_Poncer Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(444.71863, 557.39514, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(558.2567, 7.8674316, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(448.90622, 387.71774, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(628.63367, -89.74244, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(545.401, 365.9508, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(649.23926, -38.83462, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(615.38464, 461.66824, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(593.67175, 547.9082, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(435.89835, -37.91511, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(611.6961, 321.80533, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(265.56076, -580.3272, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(287.5045, -664.83685, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(187.48706, -699.4993, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(191.45795, -457.50223, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(124.87548, -479.31046, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(70.683685, -447.91476, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(50.91058, -640.706, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-315.231, -1025.9965, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-472.74802, -993.89923, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-316.97476, -1109.8357, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-445.10016, -1147.7637, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-785.0818, -836.23175, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-713.0705, -828.7382, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-822.9981, -657.6839, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-846.7006, -773.3874, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-633.8949, -722.0348, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-706.1409, -618.98615, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-382.9808, -714.8219, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-430.8835, -502.16348, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-284.52863, -480.32288, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-214.98758, -541.2803, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-236.06891, -648.5972, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-430.6972, -663.90857, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(6.8761826, 20.97865, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(55.744156, -106.49009, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-23.01701, -162.92842, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-142.84703, 589.24, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-111.72964, 416.24768, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-180.61234, 480.82678, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-41.561493, 503.63083, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-208.16476, 850.0726, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-106.48839, 928.8192, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-110.56169, 968.9201, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-818.2077, 856.35535, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-811.33856, 1059.803, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-743.0576, 523.8096, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-586.6171, 344.65747, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-698.85297, 513.8935, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-846.61993, 395.92667, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-631.6493, -141.14934, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-694.298, 61.747124, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-604.67145, 63.890434, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-755.47144, -77.01335, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-568.038, -221.66548, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-536.08215, -120.74355, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-428.20786, -12.89342, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1259.7144, -618.16406, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1386.4177, -537.524, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1246.3512, -469.5648, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1140.3446, -533.62476, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1171.653, -445.1146, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1709.2157, -159.18991, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1718.4976, -22.91338, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1663.0171, 36.374542, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1563.8856, -139.1361, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1513.7887, -29.245697, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1634.2467, 79.873276, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1146.3553, 105.30554, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1062.6342, 187.73143, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-982.1942, 100.64339, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1026.548, -0.67297363, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1113.0897, -37.957508, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1322.8307, 703.10266, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1231.1024, 688.92975, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1192.6619, 653.77747, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id9", "id_Unknownsanctuary_1", Spot(-1209.3579, 615.95825, 20));

		// FD_Yishoneer Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(469.96802, -159.08987, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(504.38205, -7.777007, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(539.7383, -229.76718, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(113.61963, -489.4178, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(134.09819, -694.5449, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(237.87576, -678.1177, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(266.0193, -505.69873, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-382.76346, -1164.1904, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-478.3041, -1090.6484, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-329.2967, -1066.3961, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-779.7312, -827.0872, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-843.73145, -727.4901, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-796.7291, -661.588, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-634.17566, -645.8181, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-287.19806, -681.6444, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-352.0393, -506.43787, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(68.69746, -3.222043, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-125.20406, -59.44737, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-81.19834, 2.147726, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-453.4765, -172.23172, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-678.49805, -204.78491, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-727.10077, 2.491952, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-482.2842, 50.736168, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(1.1819139, 404.2508, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-239.99603, 463.55252, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-203.23035, 527.4404, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-15.1311, 593.178, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-140.36942, 868.4768, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-274.3319, 1004.773, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-161.45758, 1022.4371, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-721.9573, 866.3718, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-895.1613, 891.63464, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-755.62415, 1050.2306, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-682.5381, 969.6834, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-800.1454, 471.4312, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-739.51154, 279.37506, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-562.89453, 400.5453, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-628.4884, 448.94266, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1301.0289, 519.69104, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1320.4977, 667.77563, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1235.9695, 665.86646, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1129.5168, 580.5287, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1205.9198, 96.47582, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1132.1011, 161.71155, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1634.1637, -185.8859, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1672.1187, -109.8446, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1558.1631, 25.582294, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1508.0698, -93.27274, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1183.5677, -581.39545, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1378.0221, -444.7555, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1304.1279, -433.65848, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1225.7106, -428.79932, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(-1346.8767, -633.88574, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(505.1253, 557.28925, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(435.31287, 563.0315, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id10", "id_Unknownsanctuary_1", Spot(411.5044, 474.10123, 20));

		// FD_Yishontorcher Spawn Points
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(537.90625, 373.7418, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(428.69226, 317.8123, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-167.46295, 411.06757, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-215.97942, 577.00415, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-264.99258, 870.9718, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-218.89633, 1011.0355, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-896.7431, 969.09314, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-699.3633, 1057.001, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-798.1462, 337.98532, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-635.5144, 325.9598, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-1200.279, 649.3929, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-1307.4398, 593.7525, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-1745.7721, -88.98014, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-1178.56, 1.289854, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-1207.1874, -663.3852, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-724.49554, -143.27426, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-537.7647, -42.44797, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-687.08936, -681.0142, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-640.4331, -806.18396, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-421.55997, -549.8775, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-262.91718, -588.1953, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-429.053, -968.4673, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-355.5294, -999.8813, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(55.071842, -565.3987, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(50.96721, -482.38, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-65.57414, -134.94223, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(-54.58812, 90.1761, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(679.8148, -104.47501, 20));
		AddSpawnPoint( "id_Unknownsanctuary_1.Id11", "id_Unknownsanctuary_1", Spot(612.07465, -219.03793, 20));

	}
}
