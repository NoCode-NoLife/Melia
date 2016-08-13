----- Statue of Goddess Vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "f_siauliai_out", 190.5049, 42.7921, -1214.24, -45, "npc_dummy")

----- Relief Box ----- 
addnpc(46212, "ETC_20150317_009510", "f_siauliai_out", -1086, 42, -1522, 130, "npc_dummy")

----- Relief Box ----- 
addnpc(46212, "ETC_20150317_009510", "f_siauliai_out", -1197, 42, -1627, 130, "npc_dummy")

----- Relief Box ----- 
addnpc(46212, "ETC_20150317_009510", "f_siauliai_out", -1237, 90, -1457, 130, "npc_dummy")

----- Relief Box ----- 
addnpc(46212, "ETC_20150317_009510", "f_siauliai_out", -1160, 171, -1225, 130, "npc_dummy")

----- Relief Box ----- 
addnpc(46212, "ETC_20150317_009510", "f_siauliai_out", -1364, 171, -1002, 130, "npc_dummy")

----- Relief Box ----- 
addnpc(46212, "ETC_20150317_009510", "f_siauliai_out", -1576.49, 42.83, -1673.1, 130, "npc_dummy")

----- Relief Box ----- 
addnpc(46212, "ETC_20150317_009510", "f_siauliai_out", -1807, 43, -1853, 130, "npc_dummy")

----- Relief Box ----- 
addnpc(46212, "ETC_20150317_009510", "f_siauliai_out", -2078.32, 42.83, -1782.61, 136, "npc_dummy")

----- Healer Lady ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_HEALER_B -----
----- Dialog -----
----- QuestIDs: SOUT_Q_09 | SOUT_Q_10 | SOUT_SUDD_PREBOSS -----
addnpc(20168, "QUEST_LV_0100_20150317_001221", "f_siauliai_out", -1913, 40, -1428, 91, "QUEST_LV_0100_20150317_001221_Call")
function QUEST_LV_0100_20150317_001221_Call()
msg("SIAULIAIOUT_HEALER_B_BASIC01")
msg("SIAULIAIOUT_HEALER_basic")
end

----- Healer Lady ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_HEALER_C -----
----- Dialog -----
----- QuestIDs: SOUT_Q_09 | SOUT_Q_10 -----
addnpc(20168, "QUEST_LV_0100_20150317_001221", "f_siauliai_out", -1913, 40, -1428, -100, "npc_dummy")

----- Kepa Wagon ----- 
----- Enter -----
addnpc(45315, "ETC_20150317_007048", "f_siauliai_out", -82, 156, -612, 16, "ETC_20150317_007048_Call")
function ETC_20150317_007048_Call()
msg("SIAULIAIOUT_CART")
end

----- Kepa Wagon ----- 
----- Enter -----
addnpc(45315, "ETC_20150317_007048", "f_siauliai_out", -41, 157, -608, -45, "ETC_20150317_007048_Call")
function ETC_20150317_007048_Call()
msg("SIAULIAIOUT_CART")
end

----- Kepa Wagon ----- 
----- Enter -----
addnpc(45315, "ETC_20150317_007048", "f_siauliai_out", -64, 161, -557, -45, "ETC_20150317_007048_Call")
function ETC_20150317_007048_Call()
msg("SIAULIAIOUT_CART")
end

----- Mine Manager Brinker ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_MINER_B -----
----- Dialog -----
----- QuestIDs: SOUT_Q_07 -----
addnpc(20109, "QUEST_LV_0100_20150317_001224", "f_siauliai_out", -1768.11, 170.55, -815.68, 225, "QUEST_LV_0100_20150317_001224_Call")
function QUEST_LV_0100_20150317_001224_Call()
msg("SIAULIAIOUT_MINER_B_BASIC01")
msg("SIAULIAIOUT_MINER_basic")
end

----- Mine Manager Brinker ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20109, "QUEST_LV_0100_20150317_001224", "f_siauliai_out", 355, 43, -1117, -45, "QUEST_LV_0100_20150317_001224_Call")
function QUEST_LV_0100_20150317_001224_Call()
msg("SIAULIAIOUT_MINER_A_TRADE")
end

----- Miners' Village Mayor ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_CHIEF_A -----
----- Dialog -----
----- QuestIDs: JOB_CRYOMANCER2_1 | JOB_CRYOMANCER2_2 | CMINE6_TO_KATYN7_3 | SOUT_Q_01 | SOUT_Q_11 | SOUT_Q_14 | SOUT_Q_13 | SOUT_Q_41 -----
addnpc(20118, "QUEST_LV_0100_20150317_000233", "f_siauliai_out", -87.64736, 145.2319, -802.0891, 45, "QUEST_LV_0100_20150317_000233_Call")
function QUEST_LV_0100_20150317_000233_Call()
msg("SIAULIAIOUT_CHIEF_basic01")
msg("SIAULIAIOUT_CHIEF_basic02")
end

----- [Alchemist Master]{nl}Vaidotas ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_ALCHE -----
----- Dialog -----
----- QuestIDs: SOUT_Q_14 | SOUT_Q_15 -----
addnpc(20110, "ETC_20150317_009246", "f_siauliai_out", 1309.119, 147.3516, 331.726, -41, "ETC_20150317_009246_Call")
function ETC_20150317_009246_Call()
msg("SIAULIAIOUT_ALCHE_A_basic01")
msg("SIAULIAIOUT_ALCHE_basic")
msg("SIAULIAIOUT_ALCHE_BASIC01")
end

----- Hunter ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_HUNTER -----
----- Dialog -----
----- QuestIDs: SOUT_Q_05 -----
addnpc(47245, "QUEST_LV_0100_20150317_001534", "f_siauliai_out", -945, 39, -1812, 45, "QUEST_LV_0100_20150317_001534_Call")
function QUEST_LV_0100_20150317_001534_Call()
msg("SIAULIAIOUT_HUNTER_basic")
msg("SIAULIAIOUT_HUNTER_after")
end

----- [Alchemist Master]{nl}Vaidotas ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_ALCHE_A -----
----- Dialog -----
----- QuestIDs: SOUT_Q_16 | JOB_ALCHEMIST5_1 | JOB_ALCHEMIST_6_1 | PARTY_Q_010 | PARTY_Q_011 | SIAULIAI_35_1_SQ_9 -----
addnpc(20110, "ETC_20150317_009246", "f_siauliai_out", -38.88, 85.27, -1021.81, 45, "ETC_20150317_009246_Call")
function ETC_20150317_009246_Call()
msg("SIAULIAIOUT_ALCHE_A_basic01")
msg("SIAULIAIOUT_ALCHE_basic")
msg("SIAULIAIOUT_ALCHE_A_basic03")
end

----- Notice ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000560", "f_siauliai_out", -142, 153, -435, 45, "QUEST_20150317_000560_Call")
function QUEST_20150317_000560_Call()
msg("F_SIAULIA_OUT_BOARD01")
end

----- Village Aunt ----- 
----- npcselectdialog.ies | ClassName: F_SIAU_OUT_NPC01 -----
----- Dialog -----
addnpc(20114, "QUEST_LV_0100_20150317_000206", "f_siauliai_out", -54, 85, -1064, 45, "QUEST_LV_0100_20150317_000206_Call")
function QUEST_LV_0100_20150317_000206_Call()
msg("F_SIAU_OUT_NPC01_basic01")
msg("F_SIAU_OUT_NPC01_basic02")
msg("F_SIAU_OUT_NPC01_basic03")
end

----- Miner ----- 
----- npcselectdialog.ies | ClassName: F_SIAU_OUT_NPC02 -----
----- Dialog -----
addnpc(20150, "QUEST_LV_0100_20150317_000366", "f_siauliai_out", 36, 85, -968, 45, "QUEST_LV_0100_20150317_000366_Call")
function QUEST_LV_0100_20150317_000366_Call()
msg("F_SIAU_OUT_NPC02_basic01")
msg("F_SIAU_OUT_NPC02_basic02")
end

----- Village Girl ----- 
----- npcselectdialog.ies | ClassName: F_SIAU_OUT_NPC03 -----
----- Dialog -----
addnpc(147473, "QUEST_LV_0100_20150317_000209", "f_siauliai_out", 66, 88, -1083, 45, "QUEST_LV_0100_20150317_000209_Call")
function QUEST_LV_0100_20150317_000209_Call()
msg("F_SIAU_OUT_NPC03_basic01")
msg("F_SIAU_OUT_NPC03_basic02")
msg("F_SIAU_OUT_NPC03_basic03")
end

----- Lot 2 Closure Notice ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "ETC_20150317_005371", "f_siauliai_out", 129, 153, -18, 315, "ETC_20150317_005371_Call")
function ETC_20150317_005371_Call()
msg("F_SIAULIAI_OUT_BOARD02")
end

----- [Psychokino Submaster]{nl}Cielle Gudan ----- 
----- npcselectdialog.ies | ClassName: JOB_PSYCHOKINESIST2_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_PSYCHOKINESIST2_1 | JOB_PSYCHOKINESIST3_1 | JOB_PSYCHOKINESIST4_1 | JOB_PSYCHOKINESIST5_1 -----
addnpc(155072, "ETC_20151224_019975", "f_siauliai_out", 554.1078, 42.7921, -879.4257, 0, "ETC_20151224_019975_Call")
function ETC_20151224_019975_Call()
msg("JOB_PSYCHOKINESIST2_1_NPC_basic1")
msg("JOB_PSYCHOKINESIST2_1_NPC_basic2")
msg("JOB_PSYCHOKINESIST2_1_NPC_basic3")
msg("JOB_PSYCHOKINESIST2_1_NPC_basic4")
end

----- [Linker Submaster]{nl}Roddie Kuska ----- 
----- npcselectdialog.ies | ClassName: JOB_LINKER2_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_LINKER2_1 | JOB_LINKER2_2 | JOB_LINKER3_1 | JOB_LINKER4_1 | JOB_LINKER5_1 -----
addnpc(155073, "ETC_20151224_019976", "f_siauliai_out", 312, 88, -1010, -85, "ETC_20151224_019976_Call")
function ETC_20151224_019976_Call()
msg("JOB_LINKER2_1_NPC_basic1")
msg("JOB_LINKER2_1_NPC_BASIC01")
msg("JOB_LINKER2_1_NPC_basic2")
msg("JOB_LINKER2_1_NPC_basic3")
end

----- Lv1 Treasure Chest ----- 
----- npcselectdialog.ies | ClassName: TREASUREBOX_BUBE -----
----- Dialog -----
----- QuestIDs: SOUT_Q_15 -----
addnpc(147392, "ETC_20150317_009100", "f_siauliai_out", 1651.87, 147.35, 427.34, 45, "npc_dummy")

----- Statue of Goddess Zemyna ----- 
----- Enter -----
addnpc(40110, "ETC_20150317_007030", "f_siauliai_out", -2194, 40, -2055, 38.6, "ETC_20150317_007030_Call")
function ETC_20150317_007030_Call()
msg("F_SIAULIAI_OUT_EV_55_001")
end

----- Refugee ----- 
----- npcselectdialog.ies | ClassName: SOUT_REFUGEE01 -----
----- Dialog -----
----- QuestIDs: SOUT_Q_09 -----
addnpc(152000, "ETC_20150317_005361", "f_siauliai_out", -2242.07, 42.83, -1971.59, 27, "ETC_20150317_005361_Call")
function ETC_20150317_005361_Call()
msg("SOUT_REFUGEE01_1_BASIC01")
msg("SOUT_REFUGEE01_BASIC01")
end

----- Safety Instructions ----- 
----- npcselectdialog.ies | ClassName: F_SIAULIAI_OUT_BOARD03 -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000114", "f_siauliai_out", -58, 150, -133, 0, "QUEST_20150317_000114_Call")
function QUEST_20150317_000114_Call()
msg("F_SIAULIAI_OUT_BOARD03")
end

----- Mine Manager Brinker ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_MINER_C -----
----- Dialog -----
----- QuestIDs: SOUT_Q_08 -----
addnpc(20109, "ETC_20150317_009516", "f_siauliai_out", -1768.11, 170.55, -810.68, -30, "npc_dummy")

----- Pharmacist Lady ----- 
----- npcselectdialog.ies | ClassName: SOUT_PHARMACY -----
----- Dialog -----
----- QuestIDs: SOUT_Q_20 | SOUT_Q_21 | SOUT_Q_22 | SOUT_Q_23 | SOUT_Q_24 -----
addnpc(147493, "QUEST_LV_0100_20150317_000215", "f_siauliai_out", -47.84776, 85.2688, -1212.506, 45, "QUEST_LV_0100_20150317_000215_Call")
function QUEST_LV_0100_20150317_000215_Call()
msg("SOUT_PHARMACY_basic01")
msg("SOUT_PHARMACY_basic02")
msg("SOUT_PHARMACY_basic03")
end

----- Soldier Jace ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_SOLDIRE_SQ31 -----
----- Dialog -----
----- QuestIDs: SOUT_Q_31 -----
addnpc(20016, "QUEST_LV_0100_20150317_000218", "f_siauliai_out", 90.9569, 50.21651, -1225.092, 45, "QUEST_LV_0100_20150317_000218_Call")
function QUEST_LV_0100_20150317_000218_Call()
msg("SIAULIAIOUT_SOLDIRE_SQ31_basic01")
msg("SIAULIAIOUT_SOLDIRE_SQ31_basic02")
end

----- Soldier Edgar ----- 
----- npcselectdialog.ies | ClassName: SIAULIAIOUT_SOLDIRE_SQ32 -----
----- Dialog -----
----- QuestIDs: SOUT_Q_32 -----
addnpc(20019, "QUEST_LV_0100_20150317_000221", "f_siauliai_out", 429.0146, 42.7921, -1201.718, 45, "QUEST_LV_0100_20150317_000221_Call")
function QUEST_LV_0100_20150317_000221_Call()
msg("SIAULIAIOUT_SOLDIRE_SQ32_basic01")
msg("SIAULIAIOUT_SOLDIRE_SQ32_basic02")
end

----- Lv1 Treasure Chest ----- 
addnpc(147392, "ETC_20150317_009100", "f_siauliai_out", 1224.35, 198.02, 279.95, 45, "npc_dummy")

