//--- Melia Script -----------------------------------------------------------
// Sentry Bailey Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_underfortress_65'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress65MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_underfortress_65", MonsterId.Ticen_Blue, Properties("MHP", 284230, "MINPATK", 4156, "MAXPATK", 5010, "MINMATK", 4156, "MAXMATK", 5010, "DEF", 18382, "MDEF", 18382));
		AddPropertyOverrides("d_underfortress_65", MonsterId.Ticen_Bow_Blue, Properties("MHP", 285848, "MINPATK", 4177, "MAXPATK", 5035, "MINMATK", 4177, "MAXMATK", 5035, "DEF", 18682, "MDEF", 18682));
		AddPropertyOverrides("d_underfortress_65", MonsterId.Socket_Red, Properties("MHP", 287536, "MINPATK", 4199, "MAXPATK", 5062, "MINMATK", 4199, "MAXMATK", 5062, "DEF", 18995, "MDEF", 18995));
		AddPropertyOverrides("d_underfortress_65", MonsterId.Socket_Bow_Purple, Properties("MHP", 289290, "MINPATK", 4221, "MAXPATK", 5090, "MINMATK", 4221, "MAXMATK", 5090, "DEF", 19320, "MDEF", 19320));
		AddPropertyOverrides("d_underfortress_65", MonsterId.Silvertransporter_Qm, Properties("MHP", 291108, "MINPATK", 4244, "MAXPATK", 5118, "MINMATK", 4244, "MAXMATK", 5118, "DEF", 19657, "MDEF", 19657));

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_65.Id1", MonsterId.Silvertransporter_Qm, min: 3, max: 4, tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id2", MonsterId.Ticen_Blue, min: 30, max: 40, tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id3", MonsterId.Ticen_Bow_Blue, min: 12, max: 15, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_65.Id4", MonsterId.Socket_Red, min: 23, max: 30, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_65.Id5", MonsterId.Silvertransporter_Qm, amount: 1, tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id6", MonsterId.Silvertransporter_Qm, amount: 1, tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id7", MonsterId.Silvertransporter_Qm, amount: 1, tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id8", MonsterId.Silvertransporter_Qm, amount: 1, tendency: TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id9", MonsterId.Socket_Bow_Purple, min: 8, max: 10, tendency: TendencyType.Aggressive);
		AddSpawner("d_underfortress_65.Id10", MonsterId.Rootcrystal_05, min: 11, max: 14, respawn: TimeSpan.FromMilliseconds(20000), tendency: TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Silvertransporter_Qm' GenType 6 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id1", "d_underfortress_65", Rectangle(458, -709, 20));

		// 'Ticen_Blue' GenType 10 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(942, 50, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(853, -411, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-53, -447, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(652, -941, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-756, -36, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(50, -1078, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1280, 92, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(58, -157, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(462, 416, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-592, -560, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-678, -961, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-208, -936, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(781, -103, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1511, 653, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1927, 339, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-564, -253, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-61, -166, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(280, -721, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(626, -457, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(410, -71, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(355, -1132, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-601, -725, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-315, -624, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-968, -57, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1542, 379, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(424, 640, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1407, 226, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1748, 173, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1819, 243, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1844, 333, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1731, 460, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1526, 247, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1489, 175, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1652, 171, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1580, 233, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1574, 111, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1868, 431, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1776, 529, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1658, 470, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1744, 294, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1864, 165, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1669, 384, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1658, 280, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1527, 433, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1522, 551, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1550, 646, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1351, 841, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1344, 912, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1511, 966, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1463, 800, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1436, 949, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1521, 860, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1557, 912, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1572, 986, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1374, 996, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1620, 936, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-652, -1007, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-643, -880, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-576, -701, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-45, -625, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-22, -548, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(325, -739, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(240, -725, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(410, -732, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(588, -626, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(591, -590, 60));

		// 'Ticen_Bow_Blue' GenType 11 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(442, 743, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(460, 353, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(574, -331, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(639, -581, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(467, -720, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(195, -721, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-250, -649, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-454, -581, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-569, -935, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-596, -773, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-49, -591, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(307, -1099, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-123, -1073, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(867, -125, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(1059, -184, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(835, -385, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(595, 514, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(303, 545, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-1019, -18, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-739, 6, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-1792, 88, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-1470, 311, 30));

		// 'Socket_Red' GenType 12 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1528, 493, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-927, -2, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-623, -94, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-521, -565, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-611, -917, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-195, -933, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-59, -1249, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(253, -1047, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-85, -1097, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(175, -1151, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-49, -715, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(8, -466, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(154, -199, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-33, -132, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(273, -774, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(606, -339, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(378, -51, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(377, 468, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(582, 723, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(357, 627, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(990, 322, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(894, -157, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1044, -178, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(890, -385, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(844, 45, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1916, 253, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1600, 346, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1871, 509, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1624, 38, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-594, -745, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-231, -640, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-394, -953, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-723, -95, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1060, -10, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1769, 403, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(30, -263, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-109, -452, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-50, -657, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-57, -583, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-182, -448, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(422, -702, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(648, -516, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(130, -1039, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(644, -973, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(892, -801, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(860, -203, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(795, -869, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(900, -567, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(466, 252, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(506, 79, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(488, 675, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(550, 533, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(606, -575, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-648, -290, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1253, 63, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1433, 884, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1016, 374, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(959, 279, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(903, 321, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(959, 385, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(863, 364, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1026, 427, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1035, 494, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(992, 537, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(931, 540, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(838, 475, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(878, 268, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(790, 434, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(907, 436, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(949, 480, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(948, 335, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(868, -22, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(932, -63, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(814, -164, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(938, -131, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(914, -230, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1039, -231, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1120, -212, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1117, -133, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1047, -108, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(996, -170, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(943, -354, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(886, -317, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(813, -330, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(985, -308, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(988, -254, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(836, -245, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(913, -272, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1162, -161, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1101, -62, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(987, -63, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(924, -638, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(881, -851, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(834, -805, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(741, -876, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(771, -812, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(706, -966, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(697, -912, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(611, -919, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(603, -1000, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(636, -1017, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(318, -1149, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(346, -1051, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(300, -1047, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(251, -1119, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(269, -1181, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(201, -1223, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(118, -1181, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(127, -1114, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(203, -1092, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(92, -1064, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(17, -1131, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-62, -1179, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-140, -1181, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-44, -1088, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-69, -1025, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-165, -1046, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-148, -1132, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-155, -969, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-608, -1039, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-577, -981, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-678, -904, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-622, -971, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-406, -616, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-405, -577, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-282, -660, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-162, -408, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-188, -493, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-150, -370, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(145, -244, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(153, -137, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(88, -243, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(0, -209, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(20, -132, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(105, -117, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(123, -281, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(498, 298, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(426, 305, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(509, 372, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(521, 434, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(426, 405, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(282, 497, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(372, 553, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(304, 600, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(429, 589, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(363, 691, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(506, 725, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(428, 699, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(426, 793, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(510, 757, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(494, 48, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(464, 111, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(526, 126, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(434, 40, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(386, -100, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(397, -139, 30));

		// 'Silvertransporter_Qm' GenType 17 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id5", "d_underfortress_65", Rectangle(965, -746, 20));

		// 'Silvertransporter_Qm' GenType 18 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id6", "d_underfortress_65", Rectangle(-22, -446, 20));

		// 'Silvertransporter_Qm' GenType 19 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id7", "d_underfortress_65", Rectangle(-649, -107, 20));

		// 'Silvertransporter_Qm' GenType 21 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id8", "d_underfortress_65", Rectangle(550, -1030, 20));

		// 'Socket_Bow_Purple' GenType 33 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id9", "d_underfortress_65", Rectangle(-560, -256, 9999));

		// 'Rootcrystal_05' GenType 37 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(26, -1146, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(1009, -867, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(1022, -57, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(933, 410, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(-593, -1026, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(-767, -108, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(-1499, 170, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(-1530, 1015, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(105, -311, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(635, -742, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(488, 17, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(494, 606, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(263, 1151, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(28, 1564, 40));
	}
}
