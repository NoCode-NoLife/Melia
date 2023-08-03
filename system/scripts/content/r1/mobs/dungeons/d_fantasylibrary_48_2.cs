//--- Melia Script -----------------------------------------------------------
// Sausis Room 10 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_fantasylibrary_48_2'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary482MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Levada, Properties("MHP", 534014, "MINPATK", 7368, "MAXPATK", 8957, "MINMATK", 7368, "MAXMATK", 8957, "DEF", 94757, "MDEF", 94757));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Marte_Book, Properties("MHP", 536103, "MINPATK", 7395, "MAXPATK", 8990, "MINMATK", 7395, "MAXMATK", 8990, "DEF", 95790, "MDEF", 95790));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Aclis_Angel, Properties("MHP", 538326, "MINPATK", 7423, "MAXPATK", 9025, "MINMATK", 7423, "MAXMATK", 9025, "DEF", 96890, "MDEF", 96890));
		AddPropertyOverrides("d_fantasylibrary_48_2", MonsterId.Luna_Angel, Properties("MHP", 540677, "MINPATK", 7454, "MAXPATK", 9062, "MINMATK", 7454, "MAXMATK", 9062, "DEF", 98052, "MDEF", 98052));

		// Monster Spawners ---------------------------------

		AddSpawner("d_fantasylibrary_48_2.Id1", MonsterId.Rootcrystal_03, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_fantasylibrary_48_2.Id2", MonsterId.Levada, min: 45, max: 60);
		AddSpawner("d_fantasylibrary_48_2.Id3", MonsterId.Marte_Book, min: 27, max: 35);
		AddSpawner("d_fantasylibrary_48_2.Id4", MonsterId.Aclis_Angel, min: 19, max: 25);
		AddSpawner("d_fantasylibrary_48_2.Id5", MonsterId.Luna_Angel, min: 15, max: 20);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 8 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-70, -912, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-155, -668, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(97, -697, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(6, -781, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-150, -235, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(86, -233, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-828, -133, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-778, -326, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-530, -180, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-1317, 368, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-1450, 588, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-1250, 625, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-1467, 419, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-725, 293, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-869, 521, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-673, 601, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-526, 479, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-709, 461, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(60, 475, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(121, 820, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(220, 807, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(466, 645, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(399, 479, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(900, 519, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(776, 597, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(883, 727, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(1000, 704, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(258, 1358, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(77, 1301, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(120, 1501, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(363, 1468, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-637, 1801, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-662, 1558, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-551, 1417, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-367, 1491, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-384, 1812, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(-550, 1664, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(883, -394, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(962, -117, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(1044, -333, 100));
		AddSpawnPoint("d_fantasylibrary_48_2.Id1", "d_fantasylibrary_48_2", Rectangle(1450, -306, 100));

		// 'Levada' GenType 21 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(822, 663, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(820, 556, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(941, 557, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(919, 750, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1339, -199, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1358, -333, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1452, -327, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1566, -254, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-140, -263, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-72, -157, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(39, -217, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(49, -114, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(114, 1460, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(157, 1357, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(268, 1321, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(391, 1451, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(786, -166, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(845, -364, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(958, -305, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(1072, -403, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(996, -130, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-136, -650, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-78, -749, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(35, -749, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-131, -861, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(32, -862, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-820, -97, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-634, -160, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-759, -211, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-771, -345, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-636, -306, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1441, 575, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1513, 458, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1412, 426, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1263, 369, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-1258, 551, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-867, 517, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-890, 381, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-752, 325, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-608, 396, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-575, 535, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-692, 600, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-715, 1472, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-664, 1573, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-616, 1487, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-530, 1563, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-470, 1468, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-643, 1819, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-607, 1736, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-536, 1812, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-370, 1779, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-45, 707, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-2, 886, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(117, 863, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(-16, 534, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(125, 463, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(296, 741, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(369, 829, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(282, 533, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id2", "d_fantasylibrary_48_2", Rectangle(344, 443, 20));

		// 'Marte_Book' GenType 22 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(962, -402, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(1064, -315, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(949, -214, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(1089, -138, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(895, -120, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(779, -245, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(736, -136, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(711, -374, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(877, -443, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(880, -278, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-62, -958, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-168, -780, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(117, -875, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(125, -715, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(8, -698, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(118, -609, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-189, -611, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-34, -522, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-28, -1043, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-185, -909, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-807, 1384, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-745, 1536, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-638, 1392, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-518, 1374, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-387, 1381, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-350, 1552, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-737, 1757, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-711, 1887, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-656, 1656, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-506, 1907, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-605, 1896, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-524, 1651, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-355, 1863, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-329, 1658, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id3", "d_fantasylibrary_48_2", Rectangle(-480, 1778, 20));

		// 'Aclis_Angel' GenType 23 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-849, -160, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-792, -12, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-712, -140, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-597, 20, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-544, -134, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-591, -234, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-563, -361, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-696, -383, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-830, -239, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-855, -354, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1500, 365, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1430, 299, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1313, 439, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1201, 454, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1154, 572, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1258, 672, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1358, 547, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1424, 682, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1504, 622, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-1431, 490, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-814, 438, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-761, 539, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-653, 511, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-711, 389, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id4", "d_fantasylibrary_48_2", Rectangle(-647, 271, 20));

		// 'Luna_Angel' GenType 24 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(141, 735, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(124, 592, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(192, 561, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(236, 826, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(351, 903, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(-41, 413, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(218, 470, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(422, 522, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(473, 654, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(63, 513, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(168, 1255, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(79, 1379, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(241, 1094, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(366, 1330, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(203, 1484, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(418, 1536, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(63, 1536, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(-39, -272, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(-130, -102, 20));
		AddSpawnPoint("d_fantasylibrary_48_2.Id5", "d_fantasylibrary_48_2", Rectangle(-23, -109, 20));
	}
}
