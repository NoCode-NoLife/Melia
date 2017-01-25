----- Statue of Goddess Vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "f_rokas_24", 913, 123, -1882, -45, "npc_dummy")

----- Liaison Officer Niels ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_NEALS -----
----- Dialog -----
----- QuestIDs: ROKAS24_DIALOG1 | ROKAS24_QB_6 | ROKAS24_KILL1 | ROKAS24_DIALOG2 | ROKAS24_KILL3 -----
addnpc(20108, "QUEST_LV_0100_20150317_000042", "f_rokas_24", 476, 163, -2042, -45, "QUEST_LV_0100_20150317_000042_Call")
function QUEST_LV_0100_20150317_000042_Call()
msg("ROKAS_24_NEALS_BASIC01")
msg("ROKAS_24_NEALS_basic1")
msg("ROKAS_24_NEALS_basic2")
end

----- Historian Viode ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_BEARD -----
----- Dialog -----
----- QuestIDs: ROKAS24_KILL2 -----
addnpc(20158, "QUEST_LV_0100_20150317_000051", "f_rokas_24", 1598, 16, -185, 45, "QUEST_LV_0100_20150317_000051_Call")
function QUEST_LV_0100_20150317_000051_Call()
msg("ROKAS_24_BEARD_BASIC01")
msg("ROKAS_24_BEARD_basic1")
msg("ROKAS_24_BEARD_BASIC02")
end

----- Historian Kepeck ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_KEFEK -----
----- Dialog -----
----- QuestIDs: ROKAS24_KILL3 | ROKAS24_QB_15 | ROKAS24_RP_1 -----
addnpc(147422, "QUEST_LV_0100_20150317_000055", "f_rokas_24", -1041, 804, 1647, 45, "QUEST_LV_0100_20150317_000055_Call")
function QUEST_LV_0100_20150317_000055_Call()
msg("ROKAS_24_KEFEK_BASIC01")
msg("ROKAS_24_KEFEK_BASIC02")
end

----- Beacon ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_BEACON_TRIGGER -----
----- Dialog -----
addnpc(147469, "ETC_20150317_005275", "f_rokas_24", -2908.686, 1341.924, -579.5308, 45, "npc_dummy")

----- Royal Mausoleum Artifact ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_RELIC_TRIGGERGO -----
----- Dialog -----
----- QuestIDs: ROKAS24_KILL3 -----
addnpc(147372, "ETC_20150317_005277", "f_rokas_24", -168, 687, 2207, 45, "npc_dummy")

----- Mercenary Mirta ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_MIRTA -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_15 | ROKAS24_DIALOG2 -----
addnpc(147415, "QUEST_LV_0100_20150317_000053", "f_rokas_24", 1138, 201, 998, 61, "QUEST_LV_0100_20150317_000053_Call")
function QUEST_LV_0100_20150317_000053_Call()
msg("ROKAS24_MIRTA_BASIC01")
msg("ROKAS24_MIRTA_basic1")
msg("ROKAS24_MIRTA_BASIC02")
end

----- Archivist Jonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_FLORIJONAS -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_5 -----
addnpc(147425, "QUEST_LV_0100_20150317_000046", "f_rokas_24", -985, 782, -3361, 45, "QUEST_LV_0100_20150317_000046_Call")
function QUEST_LV_0100_20150317_000046_Call()
msg("ROKAS_24_FLORIJONAS3_BASIC01")
msg("ROKAS_24_FLORIJONAS_basic1")
msg("ROKAS_24_FLORIJONAS_basic2")
msg("ROKAS_24_FLORIJONAS_basic4")
end

----- Archivist Jonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_FLORIJONAS2 -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_8 | ROKAS24_QB_14 -----
addnpc(147425, "QUEST_LV_0100_20150317_000046", "f_rokas_24", -484, 725, -1777, -45, "npc_dummy")

----- Archivist Jonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_FLORIJONAS3 -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_10 | ROKAS24_KILL1 -----
addnpc(147425, "QUEST_LV_0100_20150317_000046", "f_rokas_24", -745, 1125, 216, 45, "QUEST_LV_0100_20150317_000046_Call")
function QUEST_LV_0100_20150317_000046_Call()
msg("ROKAS_24_FLORIJONAS3_BASIC01")
msg("ROKAS_24_FLORIJONAS_basic1")
msg("ROKAS_24_FLORIJONAS_basic2")
msg("ROKAS_24_FLORIJONAS_basic4")
end

----- Eyes of the Great King ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_DEVICE_1 -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_10 -----
addnpc(147475, "ETC_20150317_009439", "f_rokas_24", -695, 1125, 264, -31, "npc_dummy")

----- Gorge Area Device ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_DEVICE_2 -----
----- Dialog -----
addnpc(47102, "ETC_20150317_009440", "f_rokas_24", 1188, 201, 1014, 45, "npc_dummy")

----- Security Guard ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_SOLDIER -----
----- Dialog -----
addnpc(10033, "QUEST_LV_0100_20150317_001256", "f_rokas_24", 883, 123, -1505, -45, "QUEST_LV_0100_20150317_001256_Call")
function QUEST_LV_0100_20150317_001256_Call()
msg("ROKAS24_SOLDIER_BASIC01")
msg("ROKAS24_SOLDIER_basic01")
msg("ROKAS24_SOLDIER_basic02")
msg("ROKAS24_SOLDIER_basic03")
msg("ROKAS24_SOLDIER_basic04")
msg("ROKAS24_SOLDIER_BASIC02")
end

----- Security Guard ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_SOLDIER -----
----- Dialog -----
addnpc(10033, "QUEST_LV_0100_20150317_001256", "f_rokas_24", 665, 123, -2449, -45, "QUEST_LV_0100_20150317_001256_Call")
function QUEST_LV_0100_20150317_001256_Call()
msg("ROKAS24_SOLDIER_BASIC01")
msg("ROKAS24_SOLDIER_basic01")
msg("ROKAS24_SOLDIER_basic02")
msg("ROKAS24_SOLDIER_basic03")
msg("ROKAS24_SOLDIER_basic04")
msg("ROKAS24_SOLDIER_BASIC02")
end

----- Security Guard ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_SOLDIER -----
----- Dialog -----
addnpc(10033, "QUEST_LV_0100_20150317_001256", "f_rokas_24", 811, 123, -1499, -45, "QUEST_LV_0100_20150317_001256_Call")
function QUEST_LV_0100_20150317_001256_Call()
msg("ROKAS24_SOLDIER_BASIC01")
msg("ROKAS24_SOLDIER_basic01")
msg("ROKAS24_SOLDIER_basic02")
msg("ROKAS24_SOLDIER_basic03")
msg("ROKAS24_SOLDIER_basic04")
msg("ROKAS24_SOLDIER_BASIC02")
end

----- Security Guard ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_SOLDIER -----
----- Dialog -----
addnpc(10033, "QUEST_LV_0100_20150317_001256", "f_rokas_24", 584, 123, -2449, -45, "QUEST_LV_0100_20150317_001256_Call")
function QUEST_LV_0100_20150317_001256_Call()
msg("ROKAS24_SOLDIER_BASIC01")
msg("ROKAS24_SOLDIER_basic01")
msg("ROKAS24_SOLDIER_basic02")
msg("ROKAS24_SOLDIER_basic03")
msg("ROKAS24_SOLDIER_basic04")
msg("ROKAS24_SOLDIER_BASIC02")
end

----- Merchant Davio ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_DABIO -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_13 | ROKAS24_QB_14 | ROKAS24_QB_6 -----
addnpc(20154, "QUEST_LV_0100_20150317_000181", "f_rokas_24", 955, 124, -1829, -45, "QUEST_LV_0100_20150317_000181_Call")
function QUEST_LV_0100_20150317_000181_Call()
msg("ROKAS24_DABIO_BASIC01")
msg("ROKAS24_DABIO_basic01")
msg("ROKAS24_DABIO_basic02")
end

----- Archivist Jonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_FLORIJONAS4 -----
----- Dialog -----
addnpc(147425, "QUEST_LV_0100_20150317_000046", "f_rokas_24", 603, 238, -1883, -45, "npc_dummy")

----- Medicine Dealer ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_PHARMACIST -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_11 | ROKAS24_QB_13 -----
addnpc(20109, "QUEST_LV_0100_20150317_000176", "f_rokas_24", 443.74, 123.93, -604.91, -45, "QUEST_LV_0100_20150317_000176_Call")
function QUEST_LV_0100_20150317_000176_Call()
msg("ROKAS_24_PHARMACIST_BASIC01")
msg("ROKAS_24_PHARMACIST_basic1")
end

----- New Researcher ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_NEWCOMER -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_1 | ROKAS24_QB_2 | ROKAS24_QB_3 | ROKAS24_QB_4 -----
addnpc(20109, "QUEST_LV_0100_20150317_000147", "f_rokas_24", 596, 123, -2326, -45, "QUEST_LV_0100_20150317_000147_Call")
function QUEST_LV_0100_20150317_000147_Call()
msg("ROKAS_24_NEWCOMER_BASIC01")
msg("ROKAS_24_NEWCOMER_basic1")
end

----- Historian Gorath ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_GORATH -----
----- Dialog -----
----- QuestIDs: ROKAS24_SQ_02 | ROKAS24_QB_9 -----
addnpc(20117, "ETC_20150317_009441", "f_rokas_24", -1468, 895, -1328, 45, "ETC_20150317_009441_Call")
function ETC_20150317_009441_Call()
msg("ROKAS_24_GORATH_BASIC01")
msg("ROKAS_24_GORATH_basic01")
msg("ROKAS_24_GORATH_basic02")
end

----- Historian Badat ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_ARCHAEOLOGIST -----
----- Dialog -----
----- QuestIDs: ROKAS24_SQ_02 | ROKAS24_SQ_03 -----
addnpc(20109, "ETC_20150317_009442", "f_rokas_24", -574, 886, -770, -45, "ETC_20150317_009442_Call")
function ETC_20150317_009442_Call()
msg("ROKAS_24_ARCHAEOLOGIST_BASIC01")
msg("ROKAS_24_ARCHAEOLOGIST_basic_01")
end

----- Stonemason Pipoti ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_PIPOTI -----
----- Dialog -----
----- QuestIDs: ROKAS29_VACYS7 | ROKAS29_VACYS8 | ROKAS29_VACYS9 -----
addnpc(20109, "QUEST_LV_0100_20150317_001266", "f_rokas_24", 478, 163, -2085, 45, "QUEST_LV_0100_20150317_001266_Call")
function QUEST_LV_0100_20150317_001266_Call()
msg("ROKAS24_PIPOTI_BASIC01")
msg("ROKAS24_PIPOTI_BASIC02")
end

----- Ahylas Jonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_ALCHEMIST -----
----- Dialog -----
----- QuestIDs: ROKAS24_MQ_1 | ROKAS24_MQ_2 | ROKAS25_REXIPHER1 -----
addnpc(20125, "QUEST_LV_0100_20150317_000059", "f_rokas_24", 640, 123, -2123, 45, "QUEST_LV_0100_20150317_000059_Call")
function QUEST_LV_0100_20150317_000059_Call()
msg("ROKAS24_ALCHEMIST_BASIC01")
msg("ROKAS24_ALCHEMIST_basic01")
end

----- Tree Sap Pot ----- 
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1520, 895, -1531, 134, "npc_dummy")

----- Tree Sap Pot ----- 
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1221, 895, -1522, 134, "npc_dummy")

----- Tree Sap Pot ----- 
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1699, 895, -1201, 134, "npc_dummy")

----- Tree Sap Pot ----- 
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1515, 895, -994, 134, "npc_dummy")

----- Tree Sap Pot ----- 
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1398, 895, -1079, 134, "npc_dummy")

----- Portal ----- 
addnpc(147469, "ETC_20150317_005172", "f_rokas_24", 1155, 123, -1979, 0, "npc_dummy")

----- Bulletin Board ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000081", "f_rokas_24", 754, 124, -2075, 0, "QUEST_20150317_000081_Call")
function QUEST_20150317_000081_Call()
msg("ROKAS24_BOARD_BASIC01")
end

----- Canyon Amalas ----- 
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", -146.105, 594.2194, 1559.776, 45, "npc_dummy")

----- Canyon Amalas ----- 
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", -398.4764, 594.2194, 1199.003, 45, "npc_dummy")

----- Canyon Amalas ----- 
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", -130.4322, 594.2073, 1105.329, 45, "npc_dummy")

----- Canyon Amalas ----- 
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", -459.3198, 601.6253, 1448.075, 45, "npc_dummy")

----- Canyon Amalas ----- 
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", 140.0401, 591.7532, 1243.412, 45, "npc_dummy")

----- Beacon ----- 
----- Enter -----
addnpc(147468, "ETC_20150317_005275", "f_rokas_24", -2958.149, 1341.999, -565.7328, -45, "ETC_20150317_005275_Call")
function ETC_20150317_005275_Call()
msg("ROKAS_24_BEACON_REAL")
end

----- Historian Viode ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_BEARD_AFTER -----
----- Dialog -----
----- QuestIDs: ROKAS24_KILL2 -----
addnpc(20158, "QUEST_LV_0100_20150317_000051", "f_rokas_24", 1550.67, 16.63921, -87.88715, 45, "QUEST_LV_0100_20150317_000051_Call")
function QUEST_LV_0100_20150317_000051_Call()
msg("ROKAS_24_BEARD_basic1")
msg("ROKAS_24_BEARD_BASIC01")
msg("ROKAS_24_BEARD_BASIC02")
end

----- Warning ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000566", "f_rokas_24", 821.3983, 123.8668, -2989.329, 45, "QUEST_20150317_000566_Call")
function QUEST_20150317_000566_Call()
msg("UPPER_WARNING_F_ROKAS_24")
end

----- [Rodelero Submaster]{nl}Trogen ----- 
----- npcselectdialog.ies | ClassName: JOB_RODELERO3_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_RODELERO3_1 | JOB_RODELERO4_1 | JOB_ARCHER3_2 | JOB_ARCHER3_1 | JOB_RODELERO5_1 -----
addnpc(155067, "ETC_20151224_019961", "f_rokas_24", 1088.881, 123.9268, -1882.805, -45, "ETC_20151224_019961_Call")
function ETC_20151224_019961_Call()
msg("JOB_RODELERO3_1_NPC_BASIC03")
msg("JOB_RODELERO3_1_NPC_BASIC01")
msg("JOB_RODELERO3_1_NPC_BASIC04")
msg("JOB_RODELERO3_1_NPC_BASIC05")
end

----- [Cataphract Master]{nl} Dirk Drigg ----- 
----- npcselectdialog.ies | ClassName: MASTER_CATAPHRACT -----
----- Dialog -----
----- QuestIDs: JOB_CATAPHRACT3_1 | JOB_CATAPHRACT4_1 | JOB_CATAPHRACT5_1 -----
addnpc(155068, "ETC_20151224_019962", "f_rokas_24", 487.1851, 123.9266, -2265.154, 45, "ETC_20151224_019962_Call")
function ETC_20151224_019962_Call()
msg("MASTER_CATAPHRACT_normal")
msg("MASTER_CATAPHRACT_basic01")
msg("MASTER_CATAPHRACT_basic02")
end

----- [Thaumaturge Master]{nl} Larisa ----- 
----- npcselectdialog.ies | ClassName: JOB_THAUMATURGE3_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_THAUMATURGE3_1 | JOB_THAUMATURGE4_1 | JOB_THAUMATURGE5_1 | FIRETOWER_45_HQ_01 -----
addnpc(147435, "ETC_20151224_019963", "f_rokas_24", 520.5836, 123.9266, -2178.955, 45, "ETC_20151224_019963_Call")
function ETC_20151224_019963_Call()
msg("JOB_THAUMATURGE3_1_NPC_BASIC01")
msg("JOB_THAUMATURGE3_1_NPC_BASIC02")
msg("JOB_THAUMATURGE3_1_NPC_BASIC03")
msg("JOB_THAUMATURGE3_1_NPC_BASIC04")
end

----- [Scout Master]{nl}Recon Rimgaile ----- 
----- npcselectdialog.ies | ClassName: JOB_SCOUT3_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_SCOUT3_1 | JOB_SCOUT4_1 | JOB_SCOUT5_1 -----
addnpc(57234, "ETC_20151224_019964", "f_rokas_24", 578.6595, 238.9312, -1665.212, -45, "ETC_20151224_019964_Call")
function ETC_20151224_019964_Call()
msg("JOB_SCOUT3_1_NPC_BASIC01")
msg("JOB_SCOUT3_1_NPC_BASIC02")
msg("JOB_SCOUT3_1_NPC_BASIC03")
msg("JOB_SCOUT3_1_NPC_BASIC04")
end

----- [Wugushi Submaster]{nl}May Patt ----- 
----- npcselectdialog.ies | ClassName: JOB_WUGU3_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_WUGU3_1 | JOB_WUGU4_1 | JOB_WUGU5_1 -----
addnpc(155081, "ETC_20151224_019965", "f_rokas_24", 480.5107, 238.9312, -1726.219, 45, "ETC_20151224_019965_Call")
function ETC_20151224_019965_Call()
msg("JOB_WUGU3_1_NPC_BASIC01")
msg("JOB_WUGU3_1_NPC_BASIC02")
msg("JOB_WUGU3_1_NPC_BASIC03")
msg("JOB_WUGU3_1_NPC_BASIC04")
end

----- Lv1 Treasure Chest ----- 
addnpc(147392, "ETC_20150317_009100", "f_rokas_24", -677.85, 724.39, -2528, 45, "npc_dummy")

----- Historian Grenus ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_RP_2_NPC -----
----- Dialog -----
----- QuestIDs: ROKAS24_RP_2 -----
addnpc(20139, "QUEST_LV_0100_20160718_015054", "f_rokas_24", -1592.778, 1334.012, 53.1868, -64, "QUEST_LV_0100_20160718_015054_Call")
function QUEST_LV_0100_20160718_015054_Call()
msg("ROKAS24_RP_2_NPC_basic1")
end

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2114.674, 1334.028, -266.3214, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1701.33, 1334.028, -197.8739, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1989.249, 1334.028, 108.0278, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2166.124, 1334.028, -30.55168, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2291.87, 1334.028, -244.5067, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -3057.812, 1341.924, -548.2903, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2856.678, 1341.934, -615.9852, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -954.3198, 1125.39, -318.3118, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -676.2686, 1125.39, -573.4998, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -346.7755, 1125.39, -488.8585, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -731.9576, 1125.39, 163.6929, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -889.7312, 1125.39, 9.140024, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -354.7265, 1125.39, 181.0275, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -492.7345, 1125.39, -170.5854, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -704.1367, 1125.39, -271.1846, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -170.3177, 1125.39, 37.31058, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", 125.5263, 1125.39, -9.773265, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", 55.09503, 1125.39, -204.5904, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -108.3296, 1125.39, -157.0428, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -483.3802, 1125.39, 68.81656, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1807.342, 1334.021, 177.3881, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1822.939, 1334.028, 50.62574, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1708.908, 1334.028, 6.836369, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2279.535, 1334.028, 42.23286, 45, "npc_dummy")

----- Exploration Site ----- 
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2172.895, 1334.495, -176.6066, 45, "npc_dummy")

