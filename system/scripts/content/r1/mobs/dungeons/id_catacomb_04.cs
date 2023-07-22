//--- Melia Script -----------------------------------------------------------
// Underground Grave of Ritinis Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'id_catacomb_04'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb04MobScript : GeneralScript
{
	public override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("id_catacomb_04.Id1", MonsterId.Rootcrystal_01, min: 9, max: 11, respawn: TimeSpan.FromMilliseconds(30000), tendency: TendencyType.Peaceful);
		AddSpawner("id_catacomb_04.Id2", MonsterId.Candlespider_Yellow, min: 57, max: 75, tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_04.Id3", MonsterId.Moyabu_Yellow, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("id_catacomb_04.Id4", MonsterId.Ticen_Mage, min: 9, max: 12, tendency: TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 5 Spawn Points
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(-389, -1535, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(-803, -1272, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(-7, -1217, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(-12, -640, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(945, -514, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(154, 0, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(-284, 642, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(-461, 1136, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(1581, 1034, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(2213, 1057, 100));
		AddSpawnPoint("id_catacomb_04.Id1", "id_catacomb_04", Rectangle(-1826, -707, 100));

		// 'Candlespider_Yellow' GenType 13 Spawn Points
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1029, -777, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1048, -506, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-737, -485, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-768, -810, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-772, -1531, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-756, -1234, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-36, -1563, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(15, -1530, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1574, -763, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1495, -729, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1394, -452, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1456, -481, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-971, -416, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1522, -791, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1583, -822, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1616, -795, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1630, -731, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1565, -708, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1539, -743, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1525, -851, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1523, -470, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1311, -465, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1029, -400, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1081, -445, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-986, -469, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-929, -493, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1069, -571, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-993, -527, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-802, -485, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-772, -416, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-762, -539, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-765, -749, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-826, -771, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1056, -731, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-996, -727, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-966, -782, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1006, -846, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-1070, -794, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-758, -1166, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-759, -1297, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-706, -1531, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-837, -1527, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-768, -1474, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-776, -1591, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-92, -1552, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-15, -1474, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(66, -1574, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(29, -746, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(21, -605, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(91, -640, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(238, -651, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-3, -648, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(21, -252, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-35, -188, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(7, -311, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(112, -81, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(117, 5, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(189, -5, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(4, 371, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-58, 385, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(1, 235, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-54, 267, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-2, 540, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-10, 610, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-83, 684, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-44, 736, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(0, 687, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(30, 746, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(89, 705, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(53, 630, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(44, 883, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(50, 968, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(42, 1024, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-26, 1013, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-54, 930, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-17, 854, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-89, 861, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-141, 833, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-389, 734, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-330, 701, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-308, 639, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-377, 594, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-446, 613, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-461, 679, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-451, 761, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-594, 618, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-569, 661, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-585, 727, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-642, 775, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-724, 698, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-677, 614, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-737, 629, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-702, 720, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-738, 907, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-704, 966, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-756, 1026, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-831, 1018, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-847, 952, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-798, 887, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-679, 1236, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-740, 1264, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-602, 1301, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-578, 1034, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-635, 1007, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-487, 960, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-533, 899, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-539, 900, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-515, 1023, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-411, 1221, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-463, 1297, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-333, 1301, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-335, 1224, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-264, 1261, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-467, 1197, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-24, 1277, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(52, 1273, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(99, 1215, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(31, 1156, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-35, 1173, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(-82, 1222, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(92, 1076, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(352, 1184, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(490, 1171, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(559, 1174, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(699, 1175, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(836, 1172, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(1048, 1192, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(1213, 1157, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(1266, 1184, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(600, -654, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(815, -653, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(880, -602, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(961, -570, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(939, -454, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(945, -315, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(969, -232, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(1060, -174, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(1167, -294, 30));
		AddSpawnPoint("id_catacomb_04.Id2", "id_catacomb_04", Rectangle(1192, -370, 30));

		// 'Moyabu_Yellow' GenType 14 Spawn Points
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(-39, -735, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(172, -635, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(2, -547, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(25, -180, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(62, -31, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(-20, 313, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(-75, 595, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(-562, 970, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(-652, 673, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(-682, 1292, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(17, 1219, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(936, -374, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(993, -180, 30));
		AddSpawnPoint("id_catacomb_04.Id3", "id_catacomb_04", Rectangle(738, -643, 30));

		// 'Ticen_Mage' GenType 15 Spawn Points
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(-393, 664, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(-777, 951, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(-398, 1278, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(7, 933, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(406, 1189, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(762, 1172, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(611, 1221, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(1111, 1169, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(1162, 1198, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(-5, 464, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(-52, -264, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(181, -77, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(527, -648, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(936, -636, 30));
		AddSpawnPoint("id_catacomb_04.Id4", "id_catacomb_04", Rectangle(1149, -233, 30));
	}
}
