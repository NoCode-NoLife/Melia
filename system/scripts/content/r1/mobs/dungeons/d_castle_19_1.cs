//--- Melia Script -----------------------------------------------------------
// Sajunga Road Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_castle_19_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCastle191MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_castle_19_1", MonsterId.Vilktis, Properties("MHP", 765642, "MINPATK", 10346, "MAXPATK", 12618, "MINMATK", 10346, "MAXMATK", 12618, "DEF", 240339, "MDEF", 240339));
		AddPropertyOverrides("d_castle_19_1", MonsterId.Trampled, Properties("MHP", 767254, "MINPATK", 10367, "MAXPATK", 12644, "MINMATK", 10367, "MAXMATK", 12644, "DEF", 241696, "MDEF", 241696));
		AddPropertyOverrides("d_castle_19_1", MonsterId.Tarnaite, Properties("MHP", 768911, "MINPATK", 10388, "MAXPATK", 12670, "MINMATK", 10388, "MAXMATK", 12670, "DEF", 243091, "MDEF", 243091));
		AddPropertyOverrides("d_castle_19_1", MonsterId.Sodininkas, Properties("MHP", 770612, "MINPATK", 10410, "MAXPATK", 12697, "MINMATK", 10410, "MAXMATK", 12697, "DEF", 244524, "MDEF", 244524));
		AddPropertyOverrides("d_castle_19_1", MonsterId.Viskal, Properties("MHP", 772356, "MINPATK", 10433, "MAXPATK", 12725, "MINMATK", 10433, "MAXMATK", 12725, "DEF", 245993, "MDEF", 245993));

		// Monster Spawners ---------------------------------

		AddSpawner("d_castle_19_1.Id1", MonsterId.Vilktis, min: 34, max: 45, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_castle_19_1.Id2", MonsterId.Trampled, min: 30, max: 40, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_castle_19_1.Id3", MonsterId.Tarnaite, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_castle_19_1.Id4", MonsterId.Sodininkas, min: 27, max: 35, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_castle_19_1.Id5", MonsterId.Viskal, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_castle_19_1.Id6", MonsterId.Tarnaite, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(60000));
		AddSpawner("d_castle_19_1.Id7", MonsterId.Rootcrystal_02, min: 19, max: 25, respawn: TimeSpan.FromMilliseconds(20000));

		// Monster Spawn Points -----------------------------

		// 'Vilktis' GenType 1 Spawn Points
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-39, -130, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(30, -62, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-87, 20, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(10, 62, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(72, 122, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(125, 25, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(146, -116, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(112, -213, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(2, -256, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-159, -174, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(95, -532, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(211, -532, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-111, -546, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-304, -503, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-431, -514, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-541, -510, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(476, -528, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(560, -477, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(700, -524, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-179, -57, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1058, 71, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1150, 50, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1010, -59, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(880, -67, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(909, 149, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(517, -16, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(559, 54, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(543, 318, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(510, 389, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(514, 666, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(798, 617, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(924, 675, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(997, 485, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1045, 640, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1062, 721, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1030, 584, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1112, 458, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1171, 501, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(869, -525, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(997, -660, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1095, -627, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1002, -566, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1138, -524, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1132, -405, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(941, -394, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(1021, -463, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-964, -547, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-487, -278, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-880, 736, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-1172, 166, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-1034, -56, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-1013, 89, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-1158, 8, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-1038, 619, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-1180, 645, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-1026, 739, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-906, 628, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-707, 652, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-523, 662, 25));
		AddSpawnPoint("d_castle_19_1.Id1", "d_castle_19_1", Rectangle(-487, 502, 25));

		// 'Trampled' GenType 2 Spawn Points
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(14, 791, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(-153, 758, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(127, 737, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(282, 829, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(530, 825, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(538, 511, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(493, 499, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(481, 260, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(489, 71, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(699, 56, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(788, 95, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(995, 147, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(1048, 179, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(991, 32, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(874, 497, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(963, 589, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(862, 750, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(1141, 721, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(1121, 592, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(724, 631, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(521, -217, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(520, -386, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(355, -533, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(628, -551, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(760, -524, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(427, 832, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(141, 846, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(119, -572, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(-116, -524, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(-237, -578, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(-447, -512, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(-724, -522, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(-41, -359, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(-52, -163, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(102, -84, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(138, 35, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(57, 128, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(940, -456, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(1063, -422, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(1095, -569, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(953, -590, 25));
		AddSpawnPoint("d_castle_19_1.Id2", "d_castle_19_1", Rectangle(-565, -525, 25));

		// 'Tarnaite' GenType 3 Spawn Points
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-1087, 594, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-898, 601, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-993, 703, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-948, 746, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-778, 633, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-583, 638, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-491, 384, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-544, 319, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-1197, 142, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-1113, 190, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-1005, 64, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-860, 98, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-632, 88, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-509, 129, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-501, 193, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-548, 485, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-504, 590, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-1136, 751, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-1081, 513, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-878, 676, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-1000, 616, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-947, 495, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-536, -140, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-570, -351, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-486, -441, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-627, -541, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-422, -570, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-341, -503, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-230, -561, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-172, -493, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(3, -574, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(28, -470, 25));
		AddSpawnPoint("d_castle_19_1.Id3", "d_castle_19_1", Rectangle(-27, -414, 25));

		// 'Sodininkas' GenType 4 Spawn Points
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1092, -417, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1144, -508, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1107, -613, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-932, -621, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-968, -533, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-961, -388, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-816, -537, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-655, -534, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-521, -564, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-510, -370, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-563, -331, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-504, -181, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-558, -43, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-536, 68, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-646, 50, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-575, 239, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1016, -575, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1014, -464, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-782, 37, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1068, 50, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1155, -47, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1323, -27, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1139, 60, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1283, 84, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-735, 96, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-253, -549, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-187, -490, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-20, -547, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-14, -363, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-874, -460, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-554, 349, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-537, 566, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-484, 654, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-628, 619, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-728, 674, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-871, 630, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-939, 781, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1045, 689, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1140, 615, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-948, 508, 25));
		AddSpawnPoint("d_castle_19_1.Id4", "d_castle_19_1", Rectangle(-1111, 808, 25));

		// 'Viskal' GenType 5 Spawn Points
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(-13, -30, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(-990, -528, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(-1182, 75, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(-540, 72, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(-1024, 673, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(545, 588, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(563, 61, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(1052, 44, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(1009, 670, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(1008, -527, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(499, -527, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(-5, -528, 100));
		AddSpawnPoint("d_castle_19_1.Id5", "d_castle_19_1", Rectangle(-438, -568, 100));

		// 'Tarnaite' GenType 6 Spawn Points
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(889, 588, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(975, 716, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(1042, 579, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(1074, 509, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(652, 609, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(539, 616, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(521, 118, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(745, 50, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(1118, -26, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(1114, 147, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(909, 1, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(843, 135, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(930, -593, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(1081, -575, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(1105, -435, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(901, -437, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(732, -535, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(482, -552, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(201, -497, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(508, -292, 30));
		AddSpawnPoint("d_castle_19_1.Id6", "d_castle_19_1", Rectangle(522, 35, 30));

		// 'Rootcrystal_02' GenType 22 Spawn Points
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(486, 842, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(523, 593, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(778, 617, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(1046, 494, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(1081, 744, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(510, 316, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(516, 71, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(857, 113, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(1099, 11, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(534, -204, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(538, -540, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(798, -520, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(1022, -414, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(1088, -627, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(319, -529, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-4, -495, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(65, -120, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-71, 64, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-285, -534, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-635, -512, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-948, -633, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-1086, -438, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-531, -221, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-539, 94, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-1255, 90, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-949, 56, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-503, 592, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-849, 556, 200));
		AddSpawnPoint("d_castle_19_1.Id7", "d_castle_19_1", Rectangle(-1080, 715, 200));
	}
}
