//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_36_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Fasika Plateau' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad362MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_36_2.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_36_2.Id2", MonsterId.Sec_Ticen, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_36_2.Id3", MonsterId.Sec_Tucen, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_36_2.Id4", MonsterId.Sec_Gravegolem, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_36_2.Id5", MonsterId.Sec_Hogma_Sorcerer, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 6 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(1388.0112, -581.14716, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(722.12524, -237.97394, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(1085.0261, 610.73566, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(466.08612, 1221.1254, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-271.91696, 601.0784, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-346.56433, 42.264492, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-807.5399, -463.2469, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-1262.2585, -948.1954, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-982.80414, 321.60434, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-324.23532, 1016.1082, 20));
		AddSpawnPoint("f_pilgrimroad_36_2.Id1", "f_pilgrimroad_36_2", Rectangle(-1124.9716, 1163.2952, 20));

		// 'Sec_Ticen' GenType 24 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-212.00851, 53.247078, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-30.736866, 19.678185, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(39.240997, 580.2941, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-17.875626, 212.87978, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(229.04414, 377.7615, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(203.02303, 527.28534, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(295.57623, 162.81772, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-361.66827, 172.70143, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-326.50952, 521.7851, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-183.05945, 650.2332, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-141.81638, 456.11243, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(218.6575, 681.82245, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(48.909927, 726.15216, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-207.2297, 224.1925, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(79.24426, 332.98593, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(156.61612, 158.00221, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(-366.17444, 339.26257, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(388.68146, 959.5155, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(486.3385, 1157.0671, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(575.86, 992.4436, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(746.3176, 1222.7179, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(549.441, 1331.4749, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(354.55316, 1194.5339, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id2", "f_pilgrimroad_36_2", Rectangle(719.4612, 1095.7017, 30));

		// 'Sec_Tucen' GenType 27 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(1223.3135, -528.719, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(479.81796, -36.21132, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(580.6133, -148.01929, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(456.33994, -185.5879, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(727.37866, -289.4054, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(1172.8362, -399.97882, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(619.4259, -46.600544, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(782.8339, -187.10378, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(953.4009, -193.4875, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(827.24133, -87.01315, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(610.037, 81.66259, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(732.03906, 86.371994, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(711.63654, 216.44429, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(1068.8182, -321.57785, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(814.6856, -322.77734, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(560.52716, -333.57635, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(381.66583, -235.68517, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(106.68105, -691.5493, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(10.532742, -599.97614, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(189.46204, -557.3037, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(29.718481, -450.50314, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(-74.116615, -331.635, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(161.3989, -308.57928, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(203.68512, -409.1887, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(310.02, -287.47723, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(444.39462, 1037.0864, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(490.2738, 1285.6421, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(621.4783, 1128.0607, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(705.7915, 1341.7222, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(806.9931, 1108.9244, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id3", "f_pilgrimroad_36_2", Rectangle(736.1879, 973.41284, 30));

		// 'Sec_Gravegolem' GenType 28 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1062.4688, -370.56302, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-877.32996, -200.21849, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-905.3995, -321.27875, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-948.927, -477.23242, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-874.7583, -557.2076, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-641.506, -359.49887, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-695.1687, -232.8483, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-771.6671, -482.61026, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1036.9293, -152.35793, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-828.74316, -58.48993, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1112.1887, -506.03598, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-229.47249, 344.0149, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-78.83968, 139.58206, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-36.77133, 362.65436, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-30.191841, 577.058, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(69.73029, 438.38834, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(171.41878, 497.73907, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(183.68767, 251.45256, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(63.41464, 123.29394, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-565.7781, 1072.6655, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-366.26825, 1220.4623, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-443.48428, 949.6082, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-501.96484, 887.0721, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-274.7243, 1124.1954, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-888.09875, 452.14462, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1097.8104, 374.8953, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id4", "f_pilgrimroad_36_2", Rectangle(-1048.6371, 200.12076, 30));

		// 'Sec_Hogma_Sorcerer' GenType 29 Spawn Points
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-463.69632, 1016.1151, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-390.0095, 1099.4647, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1018.4885, 371.75314, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1031.8823, 472.1533, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1042.4753, 298.95883, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1015.853, -290.44284, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-944.1004, -594.10876, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-804.19525, -380.91095, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-788.2269, -216.16292, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-863.3198, 314.8627, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-507.51233, 1166.1248, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-337.6412, 924.20374, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-875.105, 542.8474, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1083.2468, 996.70776, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1234.2106, 989.472, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1378.7408, 1013.819, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1292.574, 1180.4297, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1191.8364, 1078.7219, 30));
		AddSpawnPoint("f_pilgrimroad_36_2.Id5", "f_pilgrimroad_36_2", Rectangle(-1129.1859, 1161.7943, 30));
	}
}
