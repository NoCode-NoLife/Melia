//--- Melia Script -----------------------------------------------------------
// Gateway of the Great King Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_rokas_24'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRokas24MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_rokas_24.Id1", MonsterId.Rootcrystal_05, min: 12, max: 16, respawn: TimeSpan.FromMilliseconds(5000));
		AddSpawner("f_rokas_24.Id2", MonsterId.Tontus, min: 12, max: 15);
		AddSpawner("f_rokas_24.Id3", MonsterId.Dandel, min: 27, max: 35);
		AddSpawner("f_rokas_24.Id4", MonsterId.Tontus, min: 8, max: 10);
		AddSpawner("f_rokas_24.Id5", MonsterId.Pino, min: 9, max: 12);
		AddSpawner("f_rokas_24.Id6", MonsterId.Geppetto, min: 15, max: 20);
		AddSpawner("f_rokas_24.Id7", MonsterId.Dandel, min: 6, max: 7);
		AddSpawner("f_rokas_24.Id8", MonsterId.Tontus, min: 12, max: 15);
		AddSpawner("f_rokas_24.Id9", MonsterId.Dandel, min: 8, max: 10);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 600 Spawn Points
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-424, -3381, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-1389, -1593, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-150, -39, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-2093, -17, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(685, -935, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(963, 72, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-178, 1294, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-457, -2061, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-368, -2650, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(219, -2952, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(747, -2240, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(1653, -106, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(1138, 750, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(791, 728, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-453, 89, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-831, -27, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-1209, -530, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-1817, -946, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(-934, -2266, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(481, 450, 30));
		AddSpawnPoint("f_rokas_24.Id1", "f_rokas_24", Rectangle(296, -1911, 30));

		// 'Tontus' GenType 627 Spawn Points
		AddSpawnPoint("f_rokas_24.Id2", "f_rokas_24", Rectangle(-716, -217, 9999));

		// 'Dandel' GenType 628 Spawn Points
		AddSpawnPoint("f_rokas_24.Id3", "f_rokas_24", Rectangle(-48, 1338, 9999));

		// 'Tontus' GenType 631 Spawn Points
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-213, -612, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-633, 68, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-967, -737, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-779, -368, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-80, -111, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-137, -2029, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-465, -3324, 200));
		AddSpawnPoint("f_rokas_24.Id4", "f_rokas_24", Rectangle(-476, -2671, 200));

		// 'Pino' GenType 632 Spawn Points
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-230, -1756, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-623, -2666, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-251, -2695, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-136, -2115, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(294, -125, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-809, -2620, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-486, -2473, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-432, -2892, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-247, -2864, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-384, -2704, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-376, -2107, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-517, -1914, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-350, -1727, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(51, -2084, 25));
		AddSpawnPoint("f_rokas_24.Id5", "f_rokas_24", Rectangle(-26, -1739, 25));

		// 'Geppetto' GenType 633 Spawn Points
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-210, -1973, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-486, -3301, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-436, -2692, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(982, -922, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(653, -756, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(679, -314, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-658, -2608, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-571, -2822, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-271, -2865, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-209, -2641, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-422, -2452, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-895, -2006, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-829, -2184, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-632, -1983, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-394, -1824, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(34, -1837, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(54, -2152, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-102, -2252, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-256, -1682, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(-438, -2092, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(791, -1140, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(1210, -877, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(1140, -532, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(561, -574, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(720, -983, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(947, -1049, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(962, -476, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(1098, -700, 20));
		AddSpawnPoint("f_rokas_24.Id6", "f_rokas_24", Rectangle(868, -671, 20));

		// 'Dandel' GenType 634 Spawn Points
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-459, -1904, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-19, -1822, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-50, -2170, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-736, -2705, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-722, -2635, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-542, -2867, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-458, -2591, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-285, -2792, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-281, -2641, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-120, -2754, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-885, -2163, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-253, -2165, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-253, -1638, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-284, -1827, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(106, -2109, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1309, -1486, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1710, -1346, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1465, -1275, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1651, -1109, 25));
		AddSpawnPoint("f_rokas_24.Id7", "f_rokas_24", Rectangle(-1221, -1254, 25));

		// 'Tontus' GenType 701 Spawn Points
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-118, -66, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-57, -356, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-921, -261, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(151, -57, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-401, 12, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-452, -306, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-662, 13, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-582, -773, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-267, -631, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-701, -466, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-2123, -294, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1976, 118, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1542, -185, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1527, -175, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1532, -145, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-2057, -92, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1786, -199, 40));
		AddSpawnPoint("f_rokas_24.Id8", "f_rokas_24", Rectangle(-1785, -2, 40));

		// 'Dandel' GenType 706 Spawn Points
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(722, -591, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(1092, -963, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(878, -954, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(985, -488, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(1113, -654, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(665, -847, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(743, -348, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(754, -1174, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(498, -681, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(1256, -847, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(900, 0, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(931, -829, 30));
		AddSpawnPoint("f_rokas_24.Id9", "f_rokas_24", Rectangle(738, -749, 30));
	}
}
