----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "f_rokas_24", 913, 123, -1882, -45, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_F_ROKAS_24")
end

----- npc_low_lev_officer_m ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_NEALS -----
----- Dialog -----
----- QuestIDs: ROKAS24_DIALOG1 | ROKAS24_QB_6 | ROKAS24_KILL1 | ROKAS24_DIALOG2 | ROKAS24_KILL3 -----
addnpc(20108, "QUEST_LV_0100_20150317_000042", "f_rokas_24", 476, 163, -2042, -45, "npc_QUEST_LV_0100_20150317_000042")
function npc_QUEST_LV_0100_20150317_000042()
msg("ROKAS24_DIALOG1_select1")
msg("ROKAS24_DIALOG1_prog_startnpc")
msg("ROKAS24_DIALOG1_AG")
msg("ROKAS24_KILL1_succ1")
msg("ROKAS24_DIALOG2_select1")
msg("ROKAS24_KILL3_succ1")
msg("ROKAS24_QB_6_select1")
msg("ROKAS24_QB_6_add")
msg("ROKAS24_QB_6_succ1_startnpc")
msg("ROKAS24_QB_6_prog1")
msg("ROKAS_24_NEALS_BASIC01")
msg("ROKAS_24_NEALS_basic1")
msg("ROKAS_24_NEALS_basic2")
end

----- npc_village_uncle_12 ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_BEARD -----
----- Dialog -----
----- QuestIDs: ROKAS24_KILL2 -----
addnpc(20158, "QUEST_LV_0100_20150317_000051", "f_rokas_24", 1598, 16, -185, 45, "npc_QUEST_LV_0100_20150317_000051")
function npc_QUEST_LV_0100_20150317_000051()
msg("ROKAS24_KILL2_start")
msg("ROKAS24_KILL2_succ1")
msg("ROKAS_24_BEARD_BASIC01")
msg("ROKAS_24_BEARD_BASIC02")
msg("ROKAS_24_BEARD_basic1")
end

----- npc_paladin_noinst3_2 ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_KEFEK -----
----- Dialog -----
----- QuestIDs: ROKAS24_KILL3 | ROKAS24_QB_15 | ROKAS24_RP_1 -----
addnpc(147422, "QUEST_LV_0100_20150317_000055", "f_rokas_24", -1041, 804, 1647, 45, "npc_QUEST_LV_0100_20150317_000055")
function npc_QUEST_LV_0100_20150317_000055()
msg("ROKAS24_KILL3_select1")
msg("ROKAS24_KILL3_prog1")
msg("ROKAS24_QB_15_succ1")
msg("ROKAS_24_KEFEK_BASIC01")
msg("ROKAS_24_KEFEK_BASIC02")
msg("ROKAS24_RP_1_1")
msg("ROKAS24_RP_1_2")
msg("ROKAS24_RP_1_3")
end

----- noshadow_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_BEACON_TRIGGER -----
----- Dialog -----
addnpc(147469, "ETC_20150317_005275", "f_rokas_24", -2909, 1342, -580, 45, "npc_ETC_20150317_005275")
function npc_ETC_20150317_005275()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_RELIC_TRIGGERGO -----
----- Dialog -----
----- QuestIDs: ROKAS24_KILL3 -----
addnpc(147372, "ETC_20150317_005277", "f_rokas_24", -168, 687, 2207, 45, "npc_ETC_20150317_005277")
function npc_ETC_20150317_005277()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_soldier_female_02 ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_MIRTA -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_15 | ROKAS24_DIALOG2 -----
addnpc(147415, "QUEST_LV_0100_20150317_000053", "f_rokas_24", 1138, 201, 998, 61, "npc_QUEST_LV_0100_20150317_000053")
function npc_QUEST_LV_0100_20150317_000053()
msg("ROKAS24_QB_15_select01")
msg("ROKAS24_QB_15_prognpc1")
msg("ROKAS24_MIRTA_BASIC01")
msg("ROKAS24_MIRTA_BASIC02")
msg("ROKAS24_MIRTA_basic1")
msg("ROKAS24_QB_15_start01")
end

----- npc_Florijonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_FLORIJONAS -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_5 -----
addnpc(147425, "QUEST_LV_0100_20150317_000046", "f_rokas_24", -985, 782, -3361, 45, "npc_QUEST_LV_0100_20150317_000046")
function npc_QUEST_LV_0100_20150317_000046()
msg("ROKAS24_KILL1_prog1")
msg("ROKAS24_QB_5_select1")
msg("ROKAS24_QB_5_Q")
msg("ROKAS24_QB_5_succ1")
msg("ROKAS24_QB_8_select1")
msg("ROKAS24_QB_8_prog1_startnpc")
msg("ROKAS24_QB_8_AC")
msg("ROKAS24_QB_8_END")
msg("ROKAS24_QB_10_prog1")
msg("ROKAS24_QB_10_succ1")
msg("ROKAS24_QB_10_ST")
msg("ROKAS24_QB_10_add")
msg("ROKAS24_QB_14_succ1")
msg("ROKAS24_QB_14_succ2")
msg("ROKAS24_QB_14_succ3")
msg("ROKAS_24_FLORIJONAS3_BASIC01")
msg("ROKAS24_KILL1_select01")
msg("ROKAS24_KILL1_select02")
msg("ROKAS_24_FLORIJONAS_basic1")
msg("ROKAS_24_FLORIJONAS_basic2")
msg("ROKAS_24_FLORIJONAS_basic4")
end

----- npc_Florijonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_FLORIJONAS2 -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_8 | ROKAS24_QB_14 -----
addnpc(147425, "QUEST_LV_0100_20150317_000046", "f_rokas_24", -484, 725, -1777, -45, "npc_QUEST_LV_0100_20150317_000046")
function npc_QUEST_LV_0100_20150317_000046()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_Florijonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_FLORIJONAS3 -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_10 | ROKAS24_KILL1 -----
addnpc(147425, "QUEST_LV_0100_20150317_000046", "f_rokas_24", -745, 1125, 216, 45, "npc_QUEST_LV_0100_20150317_000046")
function npc_QUEST_LV_0100_20150317_000046()
msg("ROKAS24_KILL1_prog1")
msg("ROKAS24_QB_5_select1")
msg("ROKAS24_QB_5_Q")
msg("ROKAS24_QB_5_succ1")
msg("ROKAS24_QB_8_select1")
msg("ROKAS24_QB_8_prog1_startnpc")
msg("ROKAS24_QB_8_AC")
msg("ROKAS24_QB_8_END")
msg("ROKAS24_QB_10_prog1")
msg("ROKAS24_QB_10_succ1")
msg("ROKAS24_QB_10_ST")
msg("ROKAS24_QB_10_add")
msg("ROKAS24_QB_14_succ1")
msg("ROKAS24_QB_14_succ2")
msg("ROKAS24_QB_14_succ3")
msg("ROKAS_24_FLORIJONAS3_BASIC01")
msg("ROKAS24_KILL1_select01")
msg("ROKAS24_KILL1_select02")
msg("ROKAS_24_FLORIJONAS_basic1")
msg("ROKAS_24_FLORIJONAS_basic2")
msg("ROKAS_24_FLORIJONAS_basic4")
end

----- npc_zachariel_cube_mini ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_DEVICE_1 -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_10 -----
addnpc(147475, "ETC_20150317_009439", "f_rokas_24", -695, 1125, 264, -31, "npc_ETC_20150317_009439")
function npc_ETC_20150317_009439()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_rokas_2 ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_DEVICE_2 -----
----- Dialog -----
addnpc(47102, "ETC_20150317_009440", "f_rokas_24", 1188, 201, 1014, 45, "npc_ETC_20150317_009440")
function npc_ETC_20150317_009440()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- Silvertransporter_m_Quest ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_SOLDIER -----
----- Dialog -----
addnpc(10033, "QUEST_LV_0100_20150317_001256", "f_rokas_24", 883, 123, -1505, -45, "npc_QUEST_LV_0100_20150317_001256")
function npc_QUEST_LV_0100_20150317_001256()
msg("FLASH61_SQ_01_01")
msg("FLASH61_SQ_01_02")
msg("FLASH61_SQ_01_03")
msg("FLASH61_SQ_02_01")
msg("FLASH61_SQ_02_02")
msg("FLASH61_SQ_02_03")
msg("FLASH61_SQ_04_01")
msg("FLASH61_SQ_04_02")
msg("FLASH61_SQ_04_03")
msg("FLASH61_SQ_06_01")
msg("FLASH61_SQ_06_02")
msg("FLASH61_SQ_06_03")
msg("FLASH61_SQ_02_01_add")
msg("FLASH61_SQ_04_01_add")
msg("FLASH61_SQ_06_01_add")
msg("FLASH61_SQ_06_01_01")
msg("REMAIN39_SQ04_02")
msg("REMAIN39_SQ04_04")
msg("FLASH60_SQ_01_01")
msg("FLASH60_GOFDEN_basic_01")
msg("FLASH60_SQ_01_02")
msg("FLASH60_SQ_01_03")
msg("FLASH60_SQ_02_01")
msg("FLASH60_SQ_02_02")
msg("FLASH60_SQ_02_03")
msg("FLASH60_SQ_03_01")
msg("FLASH60_SQ_03_02")
msg("FLASH60_SQ_03_03")
msg("FLASH61_LAIL_basic_01")
msg("FLASH61_NOBAVIS_basic_01")
msg("FLASH60_SQ_01_01_add")
msg("FLASH60_SQ_02_01_add")
msg("FLASH60_SQ_03_01_add")
msg("FLASH60_GOFDEN_basic_02")
msg("FLASH61_NOBAVIS_basic_02")
msg("FLASH61_LAIL_basic_02")
msg("ROKAS24_SOLDIER_BASIC01")
msg("ROKAS24_SOLDIER_BASIC02")
msg("ROKAS24_SOLDIER_basic01")
msg("ROKAS24_SOLDIER_basic02")
msg("ROKAS24_SOLDIER_basic03")
msg("ROKAS24_SOLDIER_basic04")
msg("FEDIMIAN_DETECTIVE_GUARD_basic01")
msg("FEDIMIAN_DETECTIVE_GUARD_basic02")
msg("FEDIMIAN_DETECTIVE_GUARD_basic03")
msg("CRIMINAL_basic01")
msg("FEDIMIAN_DETECTIVE_GUARD_basic04")
msg("FEDIMIAN_DETECTIVE_GUARD_basic05")
msg("ROKAS_25_HQ_01_prognpc")
msg("ROKAS_25_HQ_01_W")
msg("FLASH63_SQ13_select01")
msg("FLASH63_SQ13_agree01")
msg("FLASH63_SQ13_prog01")
msg("FLASH63_SQ13_succ01")
msg("FLASH63_SQ14_select01")
msg("FLASH63_SQ14_agree01")
msg("FLASH63_SQ14_prog01")
msg("FLASH63_SQ14_succ01")
msg("FLASH29_1_SQ_090_select01")
msg("FLASH29_1_SQ_090_agree01")
msg("FLASH29_1_SQ_090_prog01")
msg("FLASH29_1_SQ_090_succ01")
msg("FLASH29_1_SQ_100_select01")
msg("FLASH29_1_SQ_100_agree01")
msg("FLASH29_1_SQ_100_prog01")
msg("FLASH29_1_SQ_100_succ01")
msg("FLASH63_SQ13_basic01")
msg("FLASH63_SQ13_basic02")
msg("FLASH29_1_SQ_090_basic01")
msg("FLASH29_1_SQ_090_basic02")
end

----- Silvertransporter_m_Quest ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_SOLDIER -----
----- Dialog -----
addnpc(10033, "QUEST_LV_0100_20150317_001256", "f_rokas_24", 665, 123, -2449, -45, "npc_QUEST_LV_0100_20150317_001256")
function npc_QUEST_LV_0100_20150317_001256()
msg("FLASH61_SQ_01_01")
msg("FLASH61_SQ_01_02")
msg("FLASH61_SQ_01_03")
msg("FLASH61_SQ_02_01")
msg("FLASH61_SQ_02_02")
msg("FLASH61_SQ_02_03")
msg("FLASH61_SQ_04_01")
msg("FLASH61_SQ_04_02")
msg("FLASH61_SQ_04_03")
msg("FLASH61_SQ_06_01")
msg("FLASH61_SQ_06_02")
msg("FLASH61_SQ_06_03")
msg("FLASH61_SQ_02_01_add")
msg("FLASH61_SQ_04_01_add")
msg("FLASH61_SQ_06_01_add")
msg("FLASH61_SQ_06_01_01")
msg("REMAIN39_SQ04_02")
msg("REMAIN39_SQ04_04")
msg("FLASH60_SQ_01_01")
msg("FLASH60_GOFDEN_basic_01")
msg("FLASH60_SQ_01_02")
msg("FLASH60_SQ_01_03")
msg("FLASH60_SQ_02_01")
msg("FLASH60_SQ_02_02")
msg("FLASH60_SQ_02_03")
msg("FLASH60_SQ_03_01")
msg("FLASH60_SQ_03_02")
msg("FLASH60_SQ_03_03")
msg("FLASH61_LAIL_basic_01")
msg("FLASH61_NOBAVIS_basic_01")
msg("FLASH60_SQ_01_01_add")
msg("FLASH60_SQ_02_01_add")
msg("FLASH60_SQ_03_01_add")
msg("FLASH60_GOFDEN_basic_02")
msg("FLASH61_NOBAVIS_basic_02")
msg("FLASH61_LAIL_basic_02")
msg("ROKAS24_SOLDIER_BASIC01")
msg("ROKAS24_SOLDIER_BASIC02")
msg("ROKAS24_SOLDIER_basic01")
msg("ROKAS24_SOLDIER_basic02")
msg("ROKAS24_SOLDIER_basic03")
msg("ROKAS24_SOLDIER_basic04")
msg("FEDIMIAN_DETECTIVE_GUARD_basic01")
msg("FEDIMIAN_DETECTIVE_GUARD_basic02")
msg("FEDIMIAN_DETECTIVE_GUARD_basic03")
msg("CRIMINAL_basic01")
msg("FEDIMIAN_DETECTIVE_GUARD_basic04")
msg("FEDIMIAN_DETECTIVE_GUARD_basic05")
msg("ROKAS_25_HQ_01_prognpc")
msg("ROKAS_25_HQ_01_W")
msg("FLASH63_SQ13_select01")
msg("FLASH63_SQ13_agree01")
msg("FLASH63_SQ13_prog01")
msg("FLASH63_SQ13_succ01")
msg("FLASH63_SQ14_select01")
msg("FLASH63_SQ14_agree01")
msg("FLASH63_SQ14_prog01")
msg("FLASH63_SQ14_succ01")
msg("FLASH29_1_SQ_090_select01")
msg("FLASH29_1_SQ_090_agree01")
msg("FLASH29_1_SQ_090_prog01")
msg("FLASH29_1_SQ_090_succ01")
msg("FLASH29_1_SQ_100_select01")
msg("FLASH29_1_SQ_100_agree01")
msg("FLASH29_1_SQ_100_prog01")
msg("FLASH29_1_SQ_100_succ01")
msg("FLASH63_SQ13_basic01")
msg("FLASH63_SQ13_basic02")
msg("FLASH29_1_SQ_090_basic01")
msg("FLASH29_1_SQ_090_basic02")
end

----- Silvertransporter_m_Quest ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_SOLDIER -----
----- Dialog -----
addnpc(10033, "QUEST_LV_0100_20150317_001256", "f_rokas_24", 811, 123, -1499, -45, "npc_QUEST_LV_0100_20150317_001256")
function npc_QUEST_LV_0100_20150317_001256()
msg("FLASH61_SQ_01_01")
msg("FLASH61_SQ_01_02")
msg("FLASH61_SQ_01_03")
msg("FLASH61_SQ_02_01")
msg("FLASH61_SQ_02_02")
msg("FLASH61_SQ_02_03")
msg("FLASH61_SQ_04_01")
msg("FLASH61_SQ_04_02")
msg("FLASH61_SQ_04_03")
msg("FLASH61_SQ_06_01")
msg("FLASH61_SQ_06_02")
msg("FLASH61_SQ_06_03")
msg("FLASH61_SQ_02_01_add")
msg("FLASH61_SQ_04_01_add")
msg("FLASH61_SQ_06_01_add")
msg("FLASH61_SQ_06_01_01")
msg("REMAIN39_SQ04_02")
msg("REMAIN39_SQ04_04")
msg("FLASH60_SQ_01_01")
msg("FLASH60_GOFDEN_basic_01")
msg("FLASH60_SQ_01_02")
msg("FLASH60_SQ_01_03")
msg("FLASH60_SQ_02_01")
msg("FLASH60_SQ_02_02")
msg("FLASH60_SQ_02_03")
msg("FLASH60_SQ_03_01")
msg("FLASH60_SQ_03_02")
msg("FLASH60_SQ_03_03")
msg("FLASH61_LAIL_basic_01")
msg("FLASH61_NOBAVIS_basic_01")
msg("FLASH60_SQ_01_01_add")
msg("FLASH60_SQ_02_01_add")
msg("FLASH60_SQ_03_01_add")
msg("FLASH60_GOFDEN_basic_02")
msg("FLASH61_NOBAVIS_basic_02")
msg("FLASH61_LAIL_basic_02")
msg("ROKAS24_SOLDIER_BASIC01")
msg("ROKAS24_SOLDIER_BASIC02")
msg("ROKAS24_SOLDIER_basic01")
msg("ROKAS24_SOLDIER_basic02")
msg("ROKAS24_SOLDIER_basic03")
msg("ROKAS24_SOLDIER_basic04")
msg("FEDIMIAN_DETECTIVE_GUARD_basic01")
msg("FEDIMIAN_DETECTIVE_GUARD_basic02")
msg("FEDIMIAN_DETECTIVE_GUARD_basic03")
msg("CRIMINAL_basic01")
msg("FEDIMIAN_DETECTIVE_GUARD_basic04")
msg("FEDIMIAN_DETECTIVE_GUARD_basic05")
msg("ROKAS_25_HQ_01_prognpc")
msg("ROKAS_25_HQ_01_W")
msg("FLASH63_SQ13_select01")
msg("FLASH63_SQ13_agree01")
msg("FLASH63_SQ13_prog01")
msg("FLASH63_SQ13_succ01")
msg("FLASH63_SQ14_select01")
msg("FLASH63_SQ14_agree01")
msg("FLASH63_SQ14_prog01")
msg("FLASH63_SQ14_succ01")
msg("FLASH29_1_SQ_090_select01")
msg("FLASH29_1_SQ_090_agree01")
msg("FLASH29_1_SQ_090_prog01")
msg("FLASH29_1_SQ_090_succ01")
msg("FLASH29_1_SQ_100_select01")
msg("FLASH29_1_SQ_100_agree01")
msg("FLASH29_1_SQ_100_prog01")
msg("FLASH29_1_SQ_100_succ01")
msg("FLASH63_SQ13_basic01")
msg("FLASH63_SQ13_basic02")
msg("FLASH29_1_SQ_090_basic01")
msg("FLASH29_1_SQ_090_basic02")
end

----- Silvertransporter_m_Quest ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_SOLDIER -----
----- Dialog -----
addnpc(10033, "QUEST_LV_0100_20150317_001256", "f_rokas_24", 584, 123, -2449, -45, "npc_QUEST_LV_0100_20150317_001256")
function npc_QUEST_LV_0100_20150317_001256()
msg("FLASH61_SQ_01_01")
msg("FLASH61_SQ_01_02")
msg("FLASH61_SQ_01_03")
msg("FLASH61_SQ_02_01")
msg("FLASH61_SQ_02_02")
msg("FLASH61_SQ_02_03")
msg("FLASH61_SQ_04_01")
msg("FLASH61_SQ_04_02")
msg("FLASH61_SQ_04_03")
msg("FLASH61_SQ_06_01")
msg("FLASH61_SQ_06_02")
msg("FLASH61_SQ_06_03")
msg("FLASH61_SQ_02_01_add")
msg("FLASH61_SQ_04_01_add")
msg("FLASH61_SQ_06_01_add")
msg("FLASH61_SQ_06_01_01")
msg("REMAIN39_SQ04_02")
msg("REMAIN39_SQ04_04")
msg("FLASH60_SQ_01_01")
msg("FLASH60_GOFDEN_basic_01")
msg("FLASH60_SQ_01_02")
msg("FLASH60_SQ_01_03")
msg("FLASH60_SQ_02_01")
msg("FLASH60_SQ_02_02")
msg("FLASH60_SQ_02_03")
msg("FLASH60_SQ_03_01")
msg("FLASH60_SQ_03_02")
msg("FLASH60_SQ_03_03")
msg("FLASH61_LAIL_basic_01")
msg("FLASH61_NOBAVIS_basic_01")
msg("FLASH60_SQ_01_01_add")
msg("FLASH60_SQ_02_01_add")
msg("FLASH60_SQ_03_01_add")
msg("FLASH60_GOFDEN_basic_02")
msg("FLASH61_NOBAVIS_basic_02")
msg("FLASH61_LAIL_basic_02")
msg("ROKAS24_SOLDIER_BASIC01")
msg("ROKAS24_SOLDIER_BASIC02")
msg("ROKAS24_SOLDIER_basic01")
msg("ROKAS24_SOLDIER_basic02")
msg("ROKAS24_SOLDIER_basic03")
msg("ROKAS24_SOLDIER_basic04")
msg("FEDIMIAN_DETECTIVE_GUARD_basic01")
msg("FEDIMIAN_DETECTIVE_GUARD_basic02")
msg("FEDIMIAN_DETECTIVE_GUARD_basic03")
msg("CRIMINAL_basic01")
msg("FEDIMIAN_DETECTIVE_GUARD_basic04")
msg("FEDIMIAN_DETECTIVE_GUARD_basic05")
msg("ROKAS_25_HQ_01_prognpc")
msg("ROKAS_25_HQ_01_W")
msg("FLASH63_SQ13_select01")
msg("FLASH63_SQ13_agree01")
msg("FLASH63_SQ13_prog01")
msg("FLASH63_SQ13_succ01")
msg("FLASH63_SQ14_select01")
msg("FLASH63_SQ14_agree01")
msg("FLASH63_SQ14_prog01")
msg("FLASH63_SQ14_succ01")
msg("FLASH29_1_SQ_090_select01")
msg("FLASH29_1_SQ_090_agree01")
msg("FLASH29_1_SQ_090_prog01")
msg("FLASH29_1_SQ_090_succ01")
msg("FLASH29_1_SQ_100_select01")
msg("FLASH29_1_SQ_100_agree01")
msg("FLASH29_1_SQ_100_prog01")
msg("FLASH29_1_SQ_100_succ01")
msg("FLASH63_SQ13_basic01")
msg("FLASH63_SQ13_basic02")
msg("FLASH29_1_SQ_090_basic01")
msg("FLASH29_1_SQ_090_basic02")
end

----- npc_village_uncle_8 ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_DABIO -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_13 | ROKAS24_QB_14 | ROKAS24_QB_6 -----
addnpc(20154, "QUEST_LV_0100_20150317_000181", "f_rokas_24", 955, 124, -1829, -45, "npc_QUEST_LV_0100_20150317_000181")
function npc_QUEST_LV_0100_20150317_000181()
msg("ROKAS24_QB_13_select1")
msg("ROKAS24_QB_13_add")
msg("ROKAS24_QB_13_prog1")
msg("ROKAS24_QB_14_select1")
msg("ROKAS24_QB_14_prog1_startnpc")
msg("ROKAS24_QB_14_Q")
msg("ROKAS24_DABIO_BASIC01")
msg("ROKAS24_DABIO_basic01")
msg("ROKAS24_DABIO_basic02")
msg("ROKAS24_QB_13_PRST")
end

----- npc_Florijonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_FLORIJONAS4 -----
----- Dialog -----
addnpc(147425, "QUEST_LV_0100_20150317_000046", "f_rokas_24", 603, 238, -1883, -45, "npc_QUEST_LV_0100_20150317_000046")
function npc_QUEST_LV_0100_20150317_000046()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_miner ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_PHARMACIST -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_11 | ROKAS24_QB_13 -----
addnpc(20109, "QUEST_LV_0100_20150317_000176", "f_rokas_24", 444, 124, -605, -45, "npc_QUEST_LV_0100_20150317_000176")
function npc_QUEST_LV_0100_20150317_000176()
msg("ROKAS24_QB_11_select1")
msg("ROKAS24_QB_11_prog1_startnpc")
msg("ROKAS24_QB_11_succ1")
msg("ROKAS24_QB_13_succ1")
msg("ROKAS_24_PHARMACIST_BASIC01")
msg("ROKAS_24_PHARMACIST_basic1")
end

----- npc_miner ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_NEWCOMER -----
----- Dialog -----
----- QuestIDs: ROKAS24_QB_1 | ROKAS24_QB_2 | ROKAS24_QB_3 | ROKAS24_QB_4 -----
addnpc(20109, "QUEST_LV_0100_20150317_000147", "f_rokas_24", 596, 123, -2326, -45, "npc_QUEST_LV_0100_20150317_000147")
function npc_QUEST_LV_0100_20150317_000147()
msg("ROKAS24_QB_1_select1")
msg("ROKAS24_QB_1_prog1")
msg("ROKAS24_QB_1_AG")
msg("ROKAS24_QB_1_add")
msg("ROKAS24_QB_2_prog1")
msg("ROKAS24_QB_3_prog1")
msg("ROKAS24_QB_4_prog1_startnpc")
msg("ROKAS24_QB_4_succ1")
msg("ROKAS_24_NEWCOMER_BASIC01")
msg("ROKAS_24_NEWCOMER_CAT")
msg("ROKAS_24_NEWCOMER_basic1")
end

----- npc_village_uncle_1 ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_GORATH -----
----- Dialog -----
----- QuestIDs: ROKAS24_SQ_02 | ROKAS24_QB_9 -----
addnpc(20117, "ETC_20150317_009441", "f_rokas_24", -1468, 895, -1328, 45, "npc_ETC_20150317_009441")
function npc_ETC_20150317_009441()
msg("ROKAS_24_GORATH_BASIC01")
msg("ROKAS24_QB_9_ST")
msg("ROKAS_24_GORATH_basic02")
msg("ROKAS24_SQ_02_select01")
msg("ROKAS24_SQ_02_prog_startnpc01")
msg("ROKAS_24_GORATH_basic01")
end

----- npc_miner ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_ARCHAEOLOGIST -----
----- Dialog -----
----- QuestIDs: ROKAS24_SQ_02 | ROKAS24_SQ_03 -----
addnpc(20109, "ETC_20150317_009442", "f_rokas_24", -574, 886, -770, -45, "npc_ETC_20150317_009442")
function npc_ETC_20150317_009442()
msg("ROKAS_24_ARCHAEOLOGIST_BASIC01")
msg("ROKAS24_SQ_03_select01")
msg("ROKAS24_SQ_03_startnpc01")
msg("ROKAS24_SQ_03_prog_startnpc01")
msg("ROKAS24_SQ_03_succ01")
msg("ROKAS24_SQ_03_add")
msg("ROKAS_24_ARCHAEOLOGIST_basic_01")
end

----- npc_miner ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_PIPOTI -----
----- Dialog -----
----- QuestIDs: ROKAS29_VACYS7 | ROKAS29_VACYS8 | ROKAS29_VACYS9 -----
addnpc(20109, "QUEST_LV_0100_20150317_001266", "f_rokas_24", 478, 163, -2085, 45, "npc_QUEST_LV_0100_20150317_001266")
function npc_QUEST_LV_0100_20150317_001266()
msg("ROKAS24_PIPOTI_BASIC01")
msg("ROKAS24_PIPOTI_BASIC02")
msg("ROKAS30_PIPOTI_BASIC01")
msg("ROKAS30_PIPOTI_BASIC02")
msg("ROKAS30_PIPOTI01_select1")
msg("ROKAS30_PIPOTI01_prog_startnpc")
msg("ROKAS30_PIPOTI01_succ1")
msg("ROKAS29_VACYS7_select1")
msg("ROKAS29_VACYS7_prog1")
msg("ROKAS29_VACYS8_succ1")
msg("ROKAS29_VACYS8_succ2")
msg("ROKAS29_VACYS9_prog1")
end

----- npc_intermediate_officer_men2 ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_ALCHEMIST -----
----- Dialog -----
----- QuestIDs: ROKAS24_MQ_1 | ROKAS24_MQ_2 | ROKAS25_REXIPHER1 -----
addnpc(20125, "QUEST_LV_0100_20150317_000059", "f_rokas_24", 640, 123, -2123, 45, "npc_QUEST_LV_0100_20150317_000059")
function npc_QUEST_LV_0100_20150317_000059()
msg("ROKAS25_REXIPHER1_select1")
msg("ROKAS25_REXIPHER1_prog1")
msg("ROKAS24_ALCHEMIST_BASIC01")
msg("ROKAS25_REXIPHER1_AC")
msg("ROKAS25_REXIPHER1_SUCCST")
msg("ROKAS24_MQ_1_select01")
msg("ROKAS24_MQ_1_prog_startnpc01")
msg("ROKAS24_MQ_1_succ01")
msg("ROKAS24_MQ_2_select01")
msg("ROKAS24_MQ_2_startnpc01")
msg("ROKAS24_MQ_2_prog01")
msg("ROKAS24_MQ_2_succ01")
msg("ROKAS24_MQ_1_add")
msg("ROKAS24_MQ_1_startnpc01")
msg("ROKAS24_ALCHEMIST_basic01")
msg("HIDDEN_RUNECASTER_npc1_dlg1")
msg("HIDDEN_RUNECASTER_npc1_dlg2")
end

----- rokas_pot3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1520, 895, -1531, 134, "npc_ETC_20150317_009443")
function npc_ETC_20150317_009443()
msg("ROKAS24_BOX1")
end

----- rokas_pot3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1221, 895, -1522, 134, "npc_ETC_20150317_009443")
function npc_ETC_20150317_009443()
msg("ROKAS24_BOX1")
end

----- rokas_pot3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1699, 895, -1201, 134, "npc_ETC_20150317_009443")
function npc_ETC_20150317_009443()
msg("ROKAS24_BOX1")
end

----- rokas_pot3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1515, 895, -994, 134, "npc_ETC_20150317_009443")
function npc_ETC_20150317_009443()
msg("ROKAS24_BOX1")
end

----- rokas_pot3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47258, "ETC_20150317_009443", "f_rokas_24", -1398, 895, -1079, 134, "npc_ETC_20150317_009443")
function npc_ETC_20150317_009443()
msg("ROKAS24_BOX1")
end

----- noshadow_npc ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147469, "ETC_20150317_005172", "f_rokas_24", 1155, 123, -1979, 0, "npc_ETC_20150317_005172")
function npc_ETC_20150317_005172()
msg("ROKAS_24_PORTAL")
end

----- Board1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000081", "f_rokas_24", 754, 124, -2075, 0, "npc_QUEST_20150317_000081")
function npc_QUEST_20150317_000081()
msg("ROKAS24_BOARD_BASIC01")
end

----- siauliai_grass_1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", -146, 594, 1560, 45, "npc_ETC_20150317_009444")
function npc_ETC_20150317_009444()
msg("ROKAS24_MQFLOWER")
end

----- siauliai_grass_1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", -398, 594, 1199, 45, "npc_ETC_20150317_009444")
function npc_ETC_20150317_009444()
msg("ROKAS24_MQFLOWER")
end

----- siauliai_grass_1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", -130, 594, 1105, 45, "npc_ETC_20150317_009444")
function npc_ETC_20150317_009444()
msg("ROKAS24_MQFLOWER")
end

----- siauliai_grass_1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", -459, 602, 1448, 45, "npc_ETC_20150317_009444")
function npc_ETC_20150317_009444()
msg("ROKAS24_MQFLOWER")
end

----- siauliai_grass_1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47200, "ETC_20150317_009444", "f_rokas_24", 140, 592, 1243, 45, "npc_ETC_20150317_009444")
function npc_ETC_20150317_009444()
msg("ROKAS24_MQFLOWER")
end

----- rokas_beacon ----- 
----- Enter -----
addnpc(147468, "ETC_20150317_005275", "f_rokas_24", -2958, 1342, -566, -45, "npc_ETC_20150317_005275")
function npc_ETC_20150317_005275()
msg("ROKAS_24_BEACON_REAL")
end

----- npc_village_uncle_12 ----- 
----- npcselectdialog.ies | ClassName: ROKAS_24_BEARD_AFTER -----
----- Dialog -----
----- QuestIDs: ROKAS24_KILL2 -----
addnpc(20158, "QUEST_LV_0100_20150317_000051", "f_rokas_24", 1551, 17, -88, 45, "npc_QUEST_LV_0100_20150317_000051")
function npc_QUEST_LV_0100_20150317_000051()
msg("ROKAS24_KILL2_start")
msg("ROKAS24_KILL2_succ1")
msg("ROKAS_24_BEARD_BASIC01")
msg("ROKAS_24_BEARD_BASIC02")
msg("ROKAS_24_BEARD_basic1")
end

----- Board1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000566", "f_rokas_24", 821, 124, -2989, 45, "npc_QUEST_20150317_000566")
function npc_QUEST_20150317_000566()
msg("UPPER_WARNING_F_ROKAS_24")
end

----- npc_ROD_sub_master ----- 
----- npcselectdialog.ies | ClassName: JOB_RODELERO3_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_RODELERO3_1 | JOB_RODELERO4_1 | JOB_ARCHER3_2 | JOB_ARCHER3_1 | JOB_RODELERO5_1 -----
addnpc(155067, "ETC_20151224_019961", "f_rokas_24", 1089, 124, -1883, -45, "npc_ETC_20151224_019961")
function npc_ETC_20151224_019961()
msg("JOB_RODELERO3_1_NPC_BASIC03")
msg("JOB_RODELERO3_1_agree1")
msg("JOB_RODELERO3_1_succ1")
msg("JOB_RODELERO4_1_01")
msg("JOB_RODELERO4_1_02")
msg("JOB_RODELERO4_1_03")
msg("JOB_RODELERO3_1_NPC_BASIC01")
msg("JOB_RODELERO3_1_NPC_BASIC04")
msg("JOB_RODELERO3_1_NPC_BASIC05")
msg("JOB_RODELERO5_1_select")
msg("JOB_RODELERO5_1_prog")
msg("JOB_RODELERO5_1_succ")
msg("JOB_RODELERO5_1_AG")
end

----- npc_CAT_sub_master ----- 
----- npcselectdialog.ies | ClassName: MASTER_CATAPHRACT -----
----- Dialog -----
----- QuestIDs: JOB_CATAPHRACT3_1 | JOB_CATAPHRACT4_1 | JOB_CATAPHRACT5_1 -----
addnpc(155068, "ETC_20170330_027668", "f_rokas_24", 487, 124, -2265, 45, "npc_ETC_20170330_027668")
function npc_ETC_20170330_027668()
msg("MASTER_CATAPHRACT_normal")
msg("JOB_CATAPHRACT3_1_select1")
msg("JOB_CATAPHRACT3_1_agree1")
msg("JOB_CATAPHRACT3_1_succ1")
msg("JOB_CATAPHRACT4_1_select")
msg("JOB_CATAPHRACT4_1_agree")
msg("JOB_CATAPHRACT4_1_succ")
msg("JOB_CATAPHRACT3_1_PG")
msg("MASTER_CATAPHRACT_basic01")
msg("MASTER_CATAPHRACT_basic02")
msg("JOB_CATAPHRACT5_1_select")
msg("JOB_CATAPHRACT5_1_prog")
msg("JOB_CATAPHRACT5_1_succ")
end

----- npc_THA_master ----- 
----- npcselectdialog.ies | ClassName: JOB_THAUMATURGE3_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_THAUMATURGE3_1 | JOB_THAUMATURGE4_1 | JOB_THAUMATURGE5_1 | FIRETOWER_45_HQ_01 -----
addnpc(147435, "ETC_20151224_019963", "f_rokas_24", 521, 124, -2179, 45, "npc_ETC_20151224_019963")
function npc_ETC_20151224_019963()
msg("JOB_THAUMATURGE3_1_select1")
msg("JOB_THAUMATURGE3_1_agree1")
msg("JOB_THAUMATURGE3_1_succ1")
msg("JOB_THAUMATURGE4_1_select")
msg("JOB_THAUMATURGE4_1_agree")
msg("JOB_THAUMATURGE4_1_succ")
msg("FIRETOWER_45_HQ_01_ST")
msg("FIRETOWER_45_HQ_01_AC")
msg("JOB_THAUMATURGE3_1_NPC_BASIC01")
msg("JOB_THAUMATURGE5_1_ST")
msg("JOB_THAUMATURGE5_1_AC")
msg("JOB_THAUMATURGE5_1_COMP")
msg("JOB_THAUMATURGE3_1_NPC_BASIC02")
msg("JOB_THAUMATURGE3_1_NPC_BASIC03")
msg("JOB_THAUMATURGE3_1_NPC_BASIC04")
end

----- npc_SCT_master ----- 
----- npcselectdialog.ies | ClassName: JOB_SCOUT3_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_SCOUT3_1 | JOB_SCOUT4_1 | JOB_SCOUT5_1 -----
addnpc(57234, "ETC_20151224_019964", "f_rokas_24", 579, 239, -1665, -45, "npc_ETC_20151224_019964")
function npc_ETC_20151224_019964()
msg("JOB_SCOUT3_1_select1")
msg("JOB_SCOUT3_1_agree1")
msg("JOB_SCOUT3_1_succ1")
msg("JOB_SCOUT3_1_PG")
msg("JOB_SCOUT4_1_01")
msg("JOB_SCOUT4_1_02")
msg("JOB_SCOUT4_1_03")
msg("JOB_SCOUT4_1_01_AG")
msg("JOB_SCOUT5_1_01")
msg("JOB_SCOUT5_1_02")
msg("JOB_SCOUT5_1_03")
msg("JOB_SCOUT5_1_04")
msg("JOB_SCOUT3_1_NPC_BASIC01")
msg("JOB_SCOUT3_1_NPC_BASIC02")
msg("JOB_SCOUT3_1_NPC_BASIC03")
msg("JOB_SCOUT3_1_NPC_BASIC04")
msg("JOB_ROGUE_6_1_ITEM_MSG3")
msg("JOB_SHINOBI_HIDDEN_SCOUT_MASTER_dlg1")
end

----- npc_WUG_sub_master ----- 
----- npcselectdialog.ies | ClassName: JOB_WUGU3_1_NPC -----
----- Dialog -----
----- QuestIDs: JOB_WUGU3_1 | JOB_WUGU4_1 | JOB_WUGU5_1 -----
addnpc(155081, "ETC_20151224_019965", "f_rokas_24", 481, 239, -1726, 45, "npc_ETC_20151224_019965")
function npc_ETC_20151224_019965()
msg("JOB_WUGU3_1_select1")
msg("JOB_WUGU3_1_agree1")
msg("JOB_WUGU3_1_succ1")
msg("JOB_WUGU3_1_PG")
msg("JOB_WUGU4_1_01")
msg("JOB_WUGU4_1_02")
msg("JOB_WUGU4_1_03")
msg("JOB_WUGU4_1_AG")
msg("JOB_WUGU5_1_01")
msg("JOB_WUGU5_1_02")
msg("JOB_WUGU5_1_03")
msg("JOB_WUGU3_1_NPC_BASIC01")
msg("JOB_WUGU3_1_NPC_BASIC02")
msg("JOB_WUGU3_1_NPC_BASIC03")
msg("JOB_WUGU3_1_NPC_BASIC04")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "f_rokas_24", -678, 724, -2528, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

----- npc_village_uncle_4 ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_RP_2_NPC -----
----- Dialog -----
----- QuestIDs: ROKAS24_RP_2 -----
addnpc(20139, "QUEST_LV_0100_20160718_015054", "f_rokas_24", -1593, 1334, 53, -64, "npc_QUEST_LV_0100_20160718_015054")
function npc_QUEST_LV_0100_20160718_015054()
msg("ROKAS24_RP_2_1")
msg("ROKAS24_RP_2_2")
msg("ROKAS24_RP_2_3")
msg("ROKAS24_RP_2_NPC_basic1")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2115, 1334, -266, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1701, 1334, -198, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1989, 1334, 108, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2166, 1334, -31, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2292, 1334, -245, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -3058, 1342, -548, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2857, 1342, -616, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -954, 1125, -318, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -676, 1125, -573, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -347, 1125, -489, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -732, 1125, 164, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -890, 1125, 9, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -355, 1125, 181, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -493, 1125, -171, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -704, 1125, -271, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -170, 1125, 37, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", 126, 1125, -10, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", 55, 1125, -205, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -108, 1125, -157, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -483, 1125, 69, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1807, 1334, 177, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1823, 1334, 51, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -1709, 1334, 7, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2280, 1334, 42, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

----- dirt_heal_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155026, "ETC_20150317_004961", "f_rokas_24", -2173, 1334, -177, 45, "npc_ETC_20150317_004961")
function npc_ETC_20150317_004961()
msg("ROKAS24_RP_2_OBJ")
end

