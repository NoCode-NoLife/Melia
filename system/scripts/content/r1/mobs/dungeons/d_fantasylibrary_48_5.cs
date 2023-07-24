//--- Melia Script -----------------------------------------------------------
// Valandis Room 91 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_fantasylibrary_48_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary485MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Cretobiang, Properties("MHP", 573536, "MINPATK", 7876, "MAXPATK", 9582, "MINMATK", 7876, "MAXMATK", 9582, "DEF", 114300, "MDEF", 114300));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Creto, Properties("MHP", 577074, "MINPATK", 7921, "MAXPATK", 9638, "MINMATK", 7921, "MAXMATK", 9638, "DEF", 116050, "MDEF", 116050));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Lapindion, Properties("MHP", 580692, "MINPATK", 7968, "MAXPATK", 9695, "MINMATK", 7968, "MAXMATK", 9695, "DEF", 117839, "MDEF", 117839));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Llapindal_Ribbon, Properties("MHP", 584390, "MINPATK", 8015, "MAXPATK", 9753, "MINMATK", 8015, "MAXMATK", 9753, "DEF", 119667, "MDEF", 119667));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Wis, Properties("MHP", 588166, "MINPATK", 8064, "MAXPATK", 9813, "MINMATK", 8064, "MAXMATK", 9813, "DEF", 121534, "MDEF", 121534));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Flamel, Properties("MHP", 592018, "MINPATK", 8114, "MAXPATK", 9874, "MINMATK", 8114, "MAXMATK", 9874, "DEF", 123439, "MDEF", 123439));
		AddPropertyOverrides("d_fantasylibrary_48_5", MonsterId.Boss_Warpulis_Q1, Properties("MHP", 4976141, "MINPATK", 25717, "MAXPATK", 31298, "MINMATK", 25717, "MAXMATK", 31298, "DEF", 394950, "MDEF", 394950));

		// Monster Spawners ---------------------------------

		AddSpawner("d_fantasylibrary_48_5.Id1", MonsterId.Rootcrystal_03, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_fantasylibrary_48_5.Id2", MonsterId.Cretobiang, min: 4, max: 5);
		AddSpawner("d_fantasylibrary_48_5.Id3", MonsterId.Creto, min: 23, max: 30);
		AddSpawner("d_fantasylibrary_48_5.Id4", MonsterId.Lapindion, min: 23, max: 30);
		AddSpawner("d_fantasylibrary_48_5.Id5", MonsterId.Llapindal_Ribbon, min: 23, max: 30);
		AddSpawner("d_fantasylibrary_48_5.Id6", MonsterId.Wis, min: 57, max: 75);
		AddSpawner("d_fantasylibrary_48_5.Id7", MonsterId.Flamel, min: 4, max: 5);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 5 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-2040, -862, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-2118, -682, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1862, -634, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1968, -732, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1509, -897, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1312, -880, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1537, -739, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1435, -779, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1330, -625, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1498, -593, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1699, -684, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1430, -436, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1436, -250, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1546, -24, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1612, 127, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1638, -53, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1400, -18, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-1336, -156, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-993, -94, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-729, -126, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-612, 169, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-380, 222, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-459, -52, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-517, -169, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-169, 77, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-207, 74, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-77, 220, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(189, 111, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-740, -742, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-629, -540, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-480, -649, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-117, -691, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(8, -565, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-201, -607, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-501, -428, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(839, -708, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(773, -443, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(974, -632, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1049, -421, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(922, -484, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(791, -89, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(833, 167, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1107, -25, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1581, 157, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1725, 302, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1713, 9, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1472, 25, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1643, 675, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1423, 734, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1549, 904, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1593, 660, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1018, 377, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(751, 493, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(888, 731, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1147, 590, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1047, 600, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(917, 1086, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(745, 1265, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(788, 1527, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1201, 1517, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(1200, 1191, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-608, 726, 100));
		AddSpawnPoint("d_fantasylibrary_48_5.Id1", "d_fantasylibrary_48_5", Rectangle(-481, 851, 100));

		// 'Cretobiang' GenType 17 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(1655, 84, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(908, -529, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(788, 114, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(1158, 1410, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id2", "d_fantasylibrary_48_5", Rectangle(777, 1415, 40));

		// 'Creto' GenType 18 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(-110, 325, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(-56, 402, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(81, 397, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1, 270, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(-175, 102, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(4, 166, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(29, 0, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(126, 181, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(240, 93, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(188, 434, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(290, 285, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(841, -696, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(738, -594, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(846, -481, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(981, -577, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(941, -712, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(916, -401, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(760, -488, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1029, -366, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1499, 5, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1591, 252, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1477, 193, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1739, 71, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1759, 285, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1608, 134, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(783, -112, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(928, -153, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(1034, -15, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(886, 54, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id3", "d_fantasylibrary_48_5", Rectangle(783, 251, 40));

		// 'Lapindion' GenType 19 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1485, -260, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1537, -199, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1319, -186, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1337, -89, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1470, -73, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1387, -14, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1524, -7, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1609, 83, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1540, 163, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-1376, 95, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-621, 205, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-522, 222, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-812, 109, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-803, 232, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-621, 78, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-496, 61, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-623, -1, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-554, -100, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-643, -170, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-734, -181, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-672, -245, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-672, -245, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-430, -166, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-291, 162, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(-562, 383, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(953, 186, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(1093, 81, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(835, 321, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(1048, 410, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id4", "d_fantasylibrary_48_5", Rectangle(938, 485, 40));

		// 'Llapindal_Ribbon' GenType 20 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-2091, -812, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-2051, -760, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-2038, -630, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1956, -653, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1907, -767, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1658, -790, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1610, -631, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1526, -684, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1573, -899, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1503, -834, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1413, -852, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1357, -798, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1300, -766, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1412, -719, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-1397, -607, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-731, 643, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-739, 731, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-601, 652, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-578, 790, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-726, 811, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-734, 881, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-567, 864, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-515, 686, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-412, 804, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(-417, 759, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(958, 599, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(851, 661, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(769, 597, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(1120, 629, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id5", "d_fantasylibrary_48_5", Rectangle(971, 389, 40));

		// 'Wis' GenType 21 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-2141, -754, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1985, -818, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-2020, -698, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1618, -712, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1577, -828, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1480, -658, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1338, -682, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1302, -835, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1437, -924, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1448, -536, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1489, -424, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1439, -344, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1529, -117, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1608, -13, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1467, 94, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1309, 41, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1412, -139, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1256, -95, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1162, -68, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-1027, -84, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-858, -124, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-700, 180, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-752, 116, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-680, -54, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-493, 154, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-401, 109, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-523, -42, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-48, 75, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-124, 199, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-36, 338, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(126, 83, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(215, 199, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(180, 342, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-703, 676, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-675, 837, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(-511, 793, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(382, 210, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(475, 228, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(571, 185, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(857, -311, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(775, -362, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(994, -483, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(841, -583, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(736, -676, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1024, -678, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(882, -51, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(811, 19, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(975, 87, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(880, 233, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(987, 299, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(874, 412, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(846, 570, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1048, 485, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(986, 671, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1484, 106, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1596, 32, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1676, 171, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1492, 635, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1544, 822, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1722, 714, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(815, 1198, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(711, 1352, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(819, 1416, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1089, 1401, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1020, 1288, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1103, 1173, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1641, 598, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1449, 734, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1552, 895, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1690, 822, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1589, 711, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1439, 845, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(1514, 521, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(972, 1500, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id6", "d_fantasylibrary_48_5", Rectangle(933, 1195, 40));

		// 'Flamel' GenType 22 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(1040, 227, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(815, 468, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(1581, 709, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(720, 1249, 40));
		AddSpawnPoint("d_fantasylibrary_48_5.Id7", "d_fantasylibrary_48_5", Rectangle(1136, 1177, 40));
	}
}
