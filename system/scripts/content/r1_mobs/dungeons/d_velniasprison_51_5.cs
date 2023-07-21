//--- Melia Script -----------------------------------------------------------
// Demon Prison District 5 Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'd_velniasprison_51_5'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison515MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_velniasprison_51_5", MonsterId.Mushroom_Boy_Green, Properties("MHP", 215332, "MINPATK", 3270, "MAXPATK", 3920, "MINMATK", 3270, "MAXMATK", 3920, "DEF", 8731, "MDEF", 8731));
		AddPropertyOverrides("d_velniasprison_51_5", MonsterId.Hohen_Mage, Properties("MHP", 217147, "MINPATK", 3293, "MAXPATK", 3949, "MINMATK", 3293, "MAXMATK", 3949, "DEF", 8896, "MDEF", 8896));
		AddPropertyOverrides("d_velniasprison_51_5", MonsterId.Hohen_Gulak, Properties("MHP", 218985, "MINPATK", 3317, "MAXPATK", 3978, "MINMATK", 3317, "MAXMATK", 3978, "DEF", 9064, "MDEF", 9064));

		// Monster Spawners ---------------------------------

		AddSpawner("d_velniasprison_51_5.Id1", MonsterId.Rootcrystal_05, 14, 18, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_velniasprison_51_5.Id2", MonsterId.Mushroom_Boy_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_5.Id3", MonsterId.Hohen_Mage, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_5.Id4", MonsterId.Mushroom_Boy_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_51_5.Id5", MonsterId.Hohen_Gulak, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 12 Spawn Points
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-814, -648, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-525, -549, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-706, -147, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-729, 372, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-786, 727, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-1454, 95, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-1171, 170, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-2136, 13, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-321, 262, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(209, -29, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-130, -202, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(50, 585, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(654, 494, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-73, 1086, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(1229, 59, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(1540, 90, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(506, -623, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(795, -689, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(-48, -1060, 200));
		AddSpawnPoint("d_velniasprison_51_5.Id1", "d_velniasprison_51_5", Rectangle(121, -956, 200));

		// 'Mushroom_Boy_Green' GenType 17 Spawn Points
		AddSpawnPoint("d_velniasprison_51_5.Id2", "d_velniasprison_51_5", Rectangle(-1355, 156, 9999));

		// 'Hohen_Mage' GenType 18 Spawn Points
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(725, -658, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-101, -1138, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-102, -972, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(57, -940, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(513, -908, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(113, -1099, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(14, -1054, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(188, -874, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-409, -96, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-28, 189, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-1389, -69, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-1178, 550, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-1200, 124, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-1513, 109, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-164, 928, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-6, 1174, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(78, 1009, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(182, 1218, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-145, 1103, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-913, 631, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-783, 762, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-703, 557, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(549, 628, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(700, 734, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(744, 490, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(637, 419, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(848, 621, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(-233, 565, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(92, 582, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(317, 619, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(618, -2, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(600, -309, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(525, -591, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(731, -533, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(319, -624, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(591, -727, 40));
		AddSpawnPoint("d_velniasprison_51_5.Id3", "d_velniasprison_51_5", Rectangle(36, -18, 40));

		// 'Mushroom_Boy_Green' GenType 19 Spawn Points
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(38, -1101, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-124, -1061, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-33, -907, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(98, -963, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(1316, -25, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(1534, 137, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(1259, 121, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(1528, 3, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(1393, 114, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-233, 601, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(657, 750, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(614, 190, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(659, 589, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(586, 906, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(508, 583, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(891, 628, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(1294, -178, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(722, -671, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-432, -3, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-263, 130, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(573, -114, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(618, -549, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-312, 55, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-260, -163, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-139, 206, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-362, -73, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-646, 521, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-662, 784, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(521, -617, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-943, 576, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-948, 717, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-738, 771, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-796, 613, 35));
		AddSpawnPoint("d_velniasprison_51_5.Id4", "d_velniasprison_51_5", Rectangle(-400, 85, 35));

		// 'Hohen_Gulak' GenType 20 Spawn Points
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(852, 610, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(1303, 163, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(643, 778, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(1328, -78, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(255, 1101, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(540, -488, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-180, 1092, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(635, 644, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-930, 705, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(58, 42, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(77, 150, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(530, -683, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(1324, 449, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-765, 496, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-2057, -22, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-2039, 141, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-1453, 101, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-632, 715, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-1219, 200, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-1280, -44, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(571, 51, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(788, -676, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(1539, 91, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(0, 1078, 45));
		AddSpawnPoint("d_velniasprison_51_5.Id5", "d_velniasprison_51_5", Rectangle(-305, -34, 45));
	}
}
