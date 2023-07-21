//--- Melia Script -----------------------------------------------------------
// Paupys Crossing Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'ep13_f_siauliai_3'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep13FSiauliai3MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Biblioteka_Keeper, Properties("MHP", 936401, "MINPATK", 12542, "MAXPATK", 15317, "MINMATK", 12542, "MAXMATK", 15317, "DEF", 403219, "MDEF", 403219));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Vynmedis, Properties("MHP", 940819, "MINPATK", 12599, "MAXPATK", 15387, "MINMATK", 12599, "MAXMATK", 15387, "DEF", 408225, "MDEF", 408225));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Darbas_Leader, Properties("MHP", 945463, "MINPATK", 12658, "MAXPATK", 15460, "MINMATK", 12658, "MAXMATK", 15460, "DEF", 413489, "MDEF", 413489));
		AddPropertyOverrides("ep13_f_siauliai_3", MonsterId.Darbas_Cleaner, Properties("MHP", 950323, "MINPATK", 12721, "MAXPATK", 15537, "MINMATK", 12721, "MAXMATK", 15537, "DEF", 418998, "MDEF", 418998));

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_f_siauliai_3.Id1", MonsterId.Rootcrystal_01, 13, 17, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id2", MonsterId.Biblioteka_Keeper, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id3", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id4", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id5", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id6", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id7", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id8", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id9", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id10", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id11", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id12", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id13", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id14", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id15", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id16", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id17", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id18", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id19", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id20", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id21", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id22", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id23", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id24", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id25", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id26", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id27", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id28", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id29", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id30", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id31", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id32", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id33", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id34", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id35", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id36", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id37", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id38", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id39", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id40", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id41", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id42", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id43", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id44", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id45", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id46", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id47", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id48", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id49", MonsterId.Biblioteka_Keeper, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id50", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id51", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id52", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id53", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id54", MonsterId.Darbas_Leader, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id55", MonsterId.Darbas_Cleaner, 45, 60, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id56", MonsterId.Biblioteka_Keeper, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id57", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id58", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id59", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id60", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id61", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id62", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id63", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id64", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id65", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id66", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id67", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id68", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id69", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id70", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id71", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id72", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id73", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id74", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id75", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id76", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id77", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id78", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id79", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id80", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id81", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id82", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id83", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id84", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id85", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id86", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("ep13_f_siauliai_3.Id87", MonsterId.Vynmedis, 1, 1, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(2380, -606, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(2198, -265, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(2102, -689, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1804, -221, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1358, -59, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1322, 348, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1696, 421, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(927, 737, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(954, 1588, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(288, 1470, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(707, 328, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(709, -593, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(1252, -542, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(-337, 144, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(-484, 699, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(-985, 191, 100));
		AddSpawnPoint("ep13_f_siauliai_3.Id1", "ep13_f_siauliai_3", Rectangle(-977, 834, 100));

		// 'Biblioteka_Keeper' GenType 1005 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2054, -939, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2109, -1039, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2173, -958, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2163, -847, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2068, -684, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2191, -695, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1939, -562, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2069, -563, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2200, -600, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1867, -414, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1840, -303, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2011, -430, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1985, -286, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2142, -557, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2097, -252, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2321, -360, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2348, -235, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2104, -2, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2207, -79, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2297, -45, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2410, -139, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2457, -34, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2229, -267, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2158, -761, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2254, -441, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(2171, -164, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1142, 1398, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(1254, 1446, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(809, 1315, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id2", "ep13_f_siauliai_3", Rectangle(-350, 216, 20));

		// 'Vynmedis' GenType 1006 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id3", "ep13_f_siauliai_3", Rectangle(1636, -69, 20));

		// 'Vynmedis' GenType 1007 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id4", "ep13_f_siauliai_3", Rectangle(1595, -128, 20));

		// 'Vynmedis' GenType 1008 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id5", "ep13_f_siauliai_3", Rectangle(1603, -285, 20));

		// 'Vynmedis' GenType 1009 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id6", "ep13_f_siauliai_3", Rectangle(1537, -286, 20));

		// 'Vynmedis' GenType 1010 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id7", "ep13_f_siauliai_3", Rectangle(1466, -227, 20));

		// 'Vynmedis' GenType 1011 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id8", "ep13_f_siauliai_3", Rectangle(1523, -52, 20));

		// 'Vynmedis' GenType 1012 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id9", "ep13_f_siauliai_3", Rectangle(1399, -169, 20));

		// 'Vynmedis' GenType 1013 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id10", "ep13_f_siauliai_3", Rectangle(1453, -58, 20));

		// 'Vynmedis' GenType 1014 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id11", "ep13_f_siauliai_3", Rectangle(1314, 24, 20));

		// 'Vynmedis' GenType 1015 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id12", "ep13_f_siauliai_3", Rectangle(1291, -58, 20));

		// 'Vynmedis' GenType 1016 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id13", "ep13_f_siauliai_3", Rectangle(1294, 177, 20));

		// 'Vynmedis' GenType 1017 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id14", "ep13_f_siauliai_3", Rectangle(1181, 223, 20));

		// 'Vynmedis' GenType 1018 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id15", "ep13_f_siauliai_3", Rectangle(1221, 302, 20));

		// 'Vynmedis' GenType 1019 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id16", "ep13_f_siauliai_3", Rectangle(1449, 139, 20));

		// 'Vynmedis' GenType 1020 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id17", "ep13_f_siauliai_3", Rectangle(1563, 98, 20));

		// 'Vynmedis' GenType 1021 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id18", "ep13_f_siauliai_3", Rectangle(1507, 302, 20));

		// 'Vynmedis' GenType 1022 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id19", "ep13_f_siauliai_3", Rectangle(1564, 240, 20));

		// 'Vynmedis' GenType 1023 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id20", "ep13_f_siauliai_3", Rectangle(1259, 367, 20));

		// 'Vynmedis' GenType 1024 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id21", "ep13_f_siauliai_3", Rectangle(1406, 285, 20));

		// 'Vynmedis' GenType 1025 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id22", "ep13_f_siauliai_3", Rectangle(1660, 187, 20));

		// 'Vynmedis' GenType 1026 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id23", "ep13_f_siauliai_3", Rectangle(1543, 421, 20));

		// 'Vynmedis' GenType 1027 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id24", "ep13_f_siauliai_3", Rectangle(1779, 235, 20));

		// 'Vynmedis' GenType 1028 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id25", "ep13_f_siauliai_3", Rectangle(1703, 357, 20));

		// 'Vynmedis' GenType 1029 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id26", "ep13_f_siauliai_3", Rectangle(1774, 394, 20));

		// 'Vynmedis' GenType 1030 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id27", "ep13_f_siauliai_3", Rectangle(1496, 528, 20));

		// 'Vynmedis' GenType 1031 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id28", "ep13_f_siauliai_3", Rectangle(1589, 555, 20));

		// 'Vynmedis' GenType 1032 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id29", "ep13_f_siauliai_3", Rectangle(1721, 604, 20));

		// 'Vynmedis' GenType 1033 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id30", "ep13_f_siauliai_3", Rectangle(1731, 490, 20));

		// 'Vynmedis' GenType 1034 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id31", "ep13_f_siauliai_3", Rectangle(1353, 452, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id31", "ep13_f_siauliai_3", Rectangle(1395, 467, 20));

		// 'Vynmedis' GenType 1035 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id32", "ep13_f_siauliai_3", Rectangle(1198, 450, 20));

		// 'Vynmedis' GenType 1036 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id33", "ep13_f_siauliai_3", Rectangle(1294, 495, 20));

		// 'Vynmedis' GenType 1037 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id34", "ep13_f_siauliai_3", Rectangle(1144, 509, 20));

		// 'Vynmedis' GenType 1038 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id35", "ep13_f_siauliai_3", Rectangle(1110, 624, 20));

		// 'Vynmedis' GenType 1039 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id36", "ep13_f_siauliai_3", Rectangle(1245, 515, 20));

		// 'Vynmedis' GenType 1040 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id37", "ep13_f_siauliai_3", Rectangle(1209, -15, 20));

		// 'Vynmedis' GenType 1041 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id38", "ep13_f_siauliai_3", Rectangle(1559, -202, 20));

		// 'Vynmedis' GenType 1042 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id39", "ep13_f_siauliai_3", Rectangle(1200, 160, 20));

		// 'Vynmedis' GenType 1043 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id40", "ep13_f_siauliai_3", Rectangle(1840, 327, 20));

		// 'Vynmedis' GenType 1044 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id41", "ep13_f_siauliai_3", Rectangle(1571, 317, 20));

		// 'Vynmedis' GenType 1045 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id42", "ep13_f_siauliai_3", Rectangle(1384, 179, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id42", "ep13_f_siauliai_3", Rectangle(1819, 277, 20));

		// 'Biblioteka_Keeper' GenType 1046 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id43", "ep13_f_siauliai_3", Rectangle(1248, 223, 20));

		// 'Biblioteka_Keeper' GenType 1047 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id44", "ep13_f_siauliai_3", Rectangle(1489, 197, 20));

		// 'Biblioteka_Keeper' GenType 1048 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id45", "ep13_f_siauliai_3", Rectangle(1283, 445, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id45", "ep13_f_siauliai_3", Rectangle(1483, 463, 20));

		// 'Biblioteka_Keeper' GenType 1049 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id46", "ep13_f_siauliai_3", Rectangle(1664, 531, 20));

		// 'Biblioteka_Keeper' GenType 1050 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id47", "ep13_f_siauliai_3", Rectangle(1659, 319, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id47", "ep13_f_siauliai_3", Rectangle(1365, -63, 20));

		// 'Biblioteka_Keeper' GenType 1051 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id48", "ep13_f_siauliai_3", Rectangle(1504, -136, 20));

		// 'Biblioteka_Keeper' GenType 1052 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id49", "ep13_f_siauliai_3", Rectangle(1429, 348, 20));

		// 'Vynmedis' GenType 1053 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id50", "ep13_f_siauliai_3", Rectangle(1842, -204, 20));

		// 'Vynmedis' GenType 1054 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id51", "ep13_f_siauliai_3", Rectangle(1783, -263, 20));

		// 'Vynmedis' GenType 1055 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id52", "ep13_f_siauliai_3", Rectangle(1912, -259, 20));

		// 'Vynmedis' GenType 1056 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id53", "ep13_f_siauliai_3", Rectangle(1827, -384, 20));

		// 'Darbas_Leader' GenType 1058 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(768, 375, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(873, 632, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(1470, -650, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(681, -467, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-425, 41, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-891, 103, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-1146, 984, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-276, 799, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(859, 1367, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(1075, 1058, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-233, 320, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-695, 571, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(860, -445, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(624, -53, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(1223, 1360, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-449, 842, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-911, 706, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(869, -11, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(674, 587, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-334, 534, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(-200, 1100, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id54", "ep13_f_siauliai_3", Rectangle(347, 1475, 20));

		// 'Darbas_Cleaner' GenType 1059 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1548, -734, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1564, -595, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1368, -478, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(632, -568, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(586, -416, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(813, 279, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(715, 498, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(682, 762, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(998, 619, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(976, 1045, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1117, 948, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(916, 1263, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1216, 1270, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(942, 1407, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(226, 1541, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(407, 1549, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-361, 912, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-172, 814, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-444, 174, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-297, 88, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-334, 358, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-115, 199, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1045, 173, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-817, 151, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-563, 436, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-782, 675, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1093, 1039, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1104, 879, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1043, -753, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(762, -654, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1184, -530, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1183, -370, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(733, -4, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(336, 18, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-517, 739, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-89, 1259, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(684, 321, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1016, 765, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1, 777, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(326, 779, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1359, -735, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(1360, -612, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(899, -136, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(128, 10, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(945, 504, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(687, 1415, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-931, 196, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-655, 325, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1282, 908, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id55", "ep13_f_siauliai_3", Rectangle(-1277, 999, 20));

		// 'Biblioteka_Keeper' GenType 1060 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-228, 170, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-441, 402, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-587, 646, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-1006, 274, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-1034, 946, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-288, 937, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(263, 1444, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(847, 796, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(997, 908, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(794, 482, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(1260, -660, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(1254, -479, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(942, -533, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(764, -337, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-416, 668, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(1140, -242, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(993, -145, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(-78, 1144, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id56", "ep13_f_siauliai_3", Rectangle(11, 1296, 20));

		// 'Vynmedis' GenType 1061 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id57", "ep13_f_siauliai_3", Rectangle(597, -684, 20));

		// 'Vynmedis' GenType 1062 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id58", "ep13_f_siauliai_3", Rectangle(-559, 17, 20));

		// 'Vynmedis' GenType 1063 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id59", "ep13_f_siauliai_3", Rectangle(863, -640, 20));

		// 'Vynmedis' GenType 1064 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id60", "ep13_f_siauliai_3", Rectangle(546, 56, 20));

		// 'Vynmedis' GenType 1065 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id61", "ep13_f_siauliai_3", Rectangle(624, -314, 20));

		// 'Vynmedis' GenType 1066 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id62", "ep13_f_siauliai_3", Rectangle(879, -334, 20));

		// 'Vynmedis' GenType 1067 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id63", "ep13_f_siauliai_3", Rectangle(1231, -729, 20));

		// 'Vynmedis' GenType 1068 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id64", "ep13_f_siauliai_3", Rectangle(1460, -568, 20));

		// 'Vynmedis' GenType 1069 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id65", "ep13_f_siauliai_3", Rectangle(-152, 313, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id65", "ep13_f_siauliai_3", Rectangle(1437, -776, 20));

		// 'Vynmedis' GenType 1070 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id66", "ep13_f_siauliai_3", Rectangle(1301, -371, 20));

		// 'Vynmedis' GenType 1071 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id67", "ep13_f_siauliai_3", Rectangle(436, 1320, 20));

		// 'Vynmedis' GenType 1072 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id68", "ep13_f_siauliai_3", Rectangle(-927, 878, 20));

		// 'Vynmedis' GenType 1073 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id69", "ep13_f_siauliai_3", Rectangle(1002, -60, 20));

		// 'Vynmedis' GenType 1074 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id70", "ep13_f_siauliai_3", Rectangle(771, -76, 20));

		// 'Vynmedis' GenType 1075 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id71", "ep13_f_siauliai_3", Rectangle(362, 78, 20));

		// 'Vynmedis' GenType 1076 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id72", "ep13_f_siauliai_3", Rectangle(635, 272, 20));

		// 'Vynmedis' GenType 1077 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id73", "ep13_f_siauliai_3", Rectangle(685, 420, 20));

		// 'Vynmedis' GenType 1078 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id74", "ep13_f_siauliai_3", Rectangle(539, 633, 20));

		// 'Vynmedis' GenType 1079 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id75", "ep13_f_siauliai_3", Rectangle(527, 438, 20));

		// 'Vynmedis' GenType 1080 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id76", "ep13_f_siauliai_3", Rectangle(800, 888, 20));

		// 'Vynmedis' GenType 1081 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id77", "ep13_f_siauliai_3", Rectangle(869, 1022, 20));

		// 'Vynmedis' GenType 1082 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id78", "ep13_f_siauliai_3", Rectangle(973, 735, 20));

		// 'Vynmedis' GenType 1083 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id79", "ep13_f_siauliai_3", Rectangle(1115, 1135, 20));

		// 'Vynmedis' GenType 1084 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id80", "ep13_f_siauliai_3", Rectangle(1026, 1362, 20));

		// 'Vynmedis' GenType 1085 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id81", "ep13_f_siauliai_3", Rectangle(867, 1195, 20));

		// 'Vynmedis' GenType 1086 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id82", "ep13_f_siauliai_3", Rectangle(-930, 3, 20));

		// 'Vynmedis' GenType 1087 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id83", "ep13_f_siauliai_3", Rectangle(-484, 270, 20));
		AddSpawnPoint("ep13_f_siauliai_3.Id83", "ep13_f_siauliai_3", Rectangle(815, 1495, 20));

		// 'Vynmedis' GenType 1088 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id84", "ep13_f_siauliai_3", Rectangle(-162, 1202, 20));

		// 'Vynmedis' GenType 1089 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id85", "ep13_f_siauliai_3", Rectangle(-229, 967, 20));

		// 'Vynmedis' GenType 1090 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id86", "ep13_f_siauliai_3", Rectangle(-289, 645, 20));

		// 'Vynmedis' GenType 1091 Spawn Points
		AddSpawnPoint("ep13_f_siauliai_3.Id87", "ep13_f_siauliai_3", Rectangle(-699, 451, 20));
	}
}
