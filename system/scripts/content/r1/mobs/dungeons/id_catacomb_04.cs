//--- Melia Script -----------------------------------------------------------
// id_catacomb_04
//
//--- Description -----------------------------------------------------------
// Sets up the id_catacomb_04 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb04MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner("id_catacomb_04.Id1", MonsterId.Candlespider_Yellow, 75, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_04.Id2", MonsterId.Moyabu_Yellow, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_04.Id3", MonsterId.Ticen_Mage, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_04.Id4", MonsterId.Rootcrystal_01, 11, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Candlespider_Yellow Spawn Points
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1029.2566, -777.85315, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1048.3164, -506.81946, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-737.4233, -485.41452, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-768.9715, -810.7538, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-772.9297, -1531.7451, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-756.4796, -1234.483, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-36.219513, -1563.086, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(15.409626, -1530.4116, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1574.0306, -763.67334, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1495.6072, -729.1464, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1394.7289, -452.4297, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1456.2443, -481.00793, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-971.66583, -416.09454, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1522.6473, -791.58734, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1583.3445, -822.0342, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1616.4291, -795.8076, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1630.852, -731.40717, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1565.4426, -708.231, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1539.8341, -743.9912, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1525.7347, -851.9189, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1523.4814, -470.79163, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1311.5839, -465.51498, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1029.2361, -400.85104, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1081.0894, -445.44058, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-986.6624, -469.32852, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-929.42554, -493.0628, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1069.7186, -571.3655, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-993.3022, -527.3082, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-802.28796, -485.93015, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-772.2199, -416.95517, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-762.2072, -539.20026, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-765.2674, -749.9998, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-826.2143, -771.9539, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1056.5168, -731.19385, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-996.44275, -727.5816, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-966.6148, -782.5506, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1006.0824, -846.4204, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-1070.8794, -794.60913, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-758.621, -1166.0243, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-759.1169, -1297.5131, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-706.4041, -1531.3887, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-837.37445, -1527.7966, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-768.65515, -1474.1256, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-776.7011, -1591.999, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-92.45434, -1552.4618, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-15.168272, -1474.7062, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(66.34531, -1574.8951, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(29.910158, -746.47784, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(21.96237, -605.62573, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(91.409645, -640.9061, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(238.193, -651.9298, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-3.3586006, -648.56555, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(21.330383, -252.43195, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-35.6091, -188.16628, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(7.300329, -311.81143, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(112.73412, -81.13002, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(117.4933, 5.648467, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(189.52716, -5.6495, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(4.567234, 371.00424, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-58.73732, 385.2973, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(1.9602013, 235.94064, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-54.46336, 267.77402, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-2.108612, 540.3653, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-10.751041, 610.4309, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-83.615234, 684.65094, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-44.11133, 736.6127, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-0.42967987, 687.7578, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(30.761982, 746.62274, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(89.6448, 705.31616, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(53.93481, 630.1189, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(44.98453, 883.6685, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(50.948914, 968.81116, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(42.400436, 1024.073, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-26.600447, 1013.2036, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-54.08381, 930.79395, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-17.354355, 854.19055, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-89.281555, 861.32654, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-141.52194, 833.6912, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-389.91135, 734.40344, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-330.45486, 701.3595, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-308.8265, 639.6656, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-377.39236, 594.21716, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-446.7343, 613.11334, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-461.28326, 679.2598, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-451.2467, 761.39154, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-594.73114, 618.8837, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-569.0295, 661.75714, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-585.1746, 727.56085, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-642.75433, 775.21765, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-724.10547, 698.9329, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-677.41425, 614.50305, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-737.9795, 629.4671, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-702.42834, 720.28076, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-738.5591, 907.5124, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-704.1394, 966.05133, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-756.2614, 1026.176, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-831.93164, 1018.5901, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-847.93854, 952.78015, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-798.7032, 887.7215, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-679.75867, 1236.7681, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-740.8108, 1264.2924, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-602.29395, 1301.6477, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-578.9862, 1034.8684, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-635.0239, 1007.1373, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-487.0706, 960.5066, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-533.79175, 899.2096, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-539.67694, 900.75494, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-515.9718, 1023.5547, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-411.02454, 1221.4575, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-463.24313, 1297.6852, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-333.0863, 1301.5961, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-335.94754, 1224.7511, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-264.14322, 1261.4036, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-467.86417, 1197.5226, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-24.589676, 1277.8495, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(52.44674, 1273.4398, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(99.238075, 1215.6587, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(31.089645, 1156.9143, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-35.520973, 1173.0858, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(-82.84793, 1222.5994, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(92.51751, 1076.041, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(352.3888, 1184.7056, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(490.96625, 1171.5945, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(559.72864, 1174.2579, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(699.91736, 1175.8215, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(836.79816, 1172.5298, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(1048.2052, 1192.8124, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(1213.3579, 1157.1165, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(1266.7789, 1184.7113, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(600.6136, -654.17676, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(815.1191, -653.4839, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(880.78253, -602.64417, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(961.6382, -570.4733, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(939.2209, -454.233, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(945.5284, -315.73932, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(969.60095, -232.23407, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(1060.7084, -174.14975, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(1167.2981, -294.35727, 30));
		AddSpawnPoint( "id_catacomb_04.Id1", "id_catacomb_04", Spot(1192.4828, -370.20206, 30));

		// Moyabu_Yellow Spawn Points
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(-39.02728, -735.7073, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(172.83566, -635.85724, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(2.486473, -547.6205, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(25.598595, -180.95891, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(62.978092, -31.98759, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(-20.392426, 313.08206, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(-75.61022, 595.2877, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(-562.8945, 970.7822, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(-652.55884, 673.3268, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(-682.9481, 1292.0686, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(17.01374, 1219.6868, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(936.9818, -374.90195, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(993.7746, -180.37065, 30));
		AddSpawnPoint( "id_catacomb_04.Id2", "id_catacomb_04", Spot(738.31323, -643.98486, 30));

		// Ticen_Mage Spawn Points
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(-393.17935, 664.6756, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(-777.0447, 951.34015, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(-398.28928, 1278.6414, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(7.0198975, 933.4533, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(406.29236, 1189.223, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(762.0242, 1172.4496, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(611.3837, 1221.2953, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(1111.5, 1169.4213, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(1162.2565, 1198.2839, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(-5.162483, 464.95148, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(-52.6895, -264.86856, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(181.08148, -77.911964, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(527.448, -648.8202, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(936.3756, -636.3021, 30));
		AddSpawnPoint( "id_catacomb_04.Id3", "id_catacomb_04", Spot(1149.6759, -233.77591, 30));

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(-389.3933, -1535.1357, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(-803.8687, -1272.4419, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(-7.08634, -1217.0548, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(-12.05747, -640.3467, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(945.51746, -514.2242, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(154.24081, 0.80984735, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(-284.56848, 642.86816, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(-461.16595, 1136.0928, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(1581.5367, 1034.5483, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(2213.529, 1057.8691, 100));
		AddSpawnPoint( "id_catacomb_04.Id4", "id_catacomb_04", Spot(-1826.5198, -707.15674, 100));

	}
}
