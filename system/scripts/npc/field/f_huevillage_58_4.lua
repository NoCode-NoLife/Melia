----- noshadow_npc ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_MQ01_NPC01 -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ02 -----
addnpc(147469, "ETC_20150317_009353", "f_huevillage_58_4", 43, 33, -343, 45, "npc_ETC_20150317_009353")
function npc_ETC_20150317_009353()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_saule_goddess ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_SAULE_BEFORE -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ02 | HUEVILLAGE_58_4_MQ05 | HUEVILLAGE_58_4_MQ06 | HUEVILLAGE_58_4_MQ07 | HUEVILLAGE_58_4_MQ08 | HUEVILLAGE_58_4_MQ01 -----
addnpc(147385, "QUEST_LV_0100_20150317_000586", "f_huevillage_58_4", 21, 34, -186, -45, "npc_QUEST_LV_0100_20150317_000586")
function npc_QUEST_LV_0100_20150317_000586()
msg("HUEVILLAGE_58_4_MQ09_PG")
msg("HUEVILLAGE_58_4_MQ01_select")
msg("HUEVILLAGE_58_4_MQ01_agree")
msg("HUEVILLAGE_58_4_MQ02_succ")
msg("HUEVILLAGE_58_4_MQ05_select")
msg("HUEVILLAGE_58_4_MQ05_agree")
msg("HUEVILLAGE_58_4_MQ05_succ")
msg("HUEVILLAGE_58_4_MQ06_select")
msg("HUEVILLAGE_58_4_MQ06_prog")
msg("HUEVILLAGE_58_4_MQ06_succ")
msg("HUEVILLAGE_58_4_MQ07_succ")
msg("HUEVILLAGE_58_4_MQ08_succ")
msg("HUEVILLAGE_58_4_MQ11_select")
msg("HUEVILLAGE_58_4_MQ11_TRACK2")
msg("HUEVILLAGE_58_4_MQ05_startnpc_prog")
msg("HUEVILLAGE_58_4_SAULE_BEFORE_basic01")
msg("HUEVILLAGE_58_4_SAULE_BEFORE_basic02")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic01")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic02")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic03")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic06")
msg("HIDDEN_RUNECASTER_saule_dlg1")
msg("HIDDEN_RUNECASTER_saule_dlg2")
msg("LIMESTONE_52_4_MQ_8_SUC01")
msg("PARTY_Q_060_startnpc01")
msg("PARTY_Q_060_startnpc02")
msg("PARTY_Q_060_startnpc_prog01")
msg("PARTY_Q_060_succ01")
msg("PARTY_Q_061_startnpc01")
msg("PARTY_Q_061_startnpc_prog01")
msg("PARTY_Q_061_succ01")
msg("LIMESTONE_52_4_MQ_8_succ")
msg("LIMESTONE_52_4_MQ_9_start")
msg("LIMESTONE_52_4_MQ_9_prog")
msg("LIMESTONE_52_4_MQ_9_succ")
msg("LIMESTONE_52_4_MQ_10_start")
end

----- npc_saule_goddess ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_SAULE_AFTER -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ08 | HUEVILLAGE_58_4_MQ11 | HUEVILLAGE_58_4_MQ09 | LIMESTONE_52_4_MQ_8 | LIMESTONE_52_4_MQ_9 | PARTY_Q_060 | PARTY_Q_061 | LIMESTONE_52_4_MQ_10 -----
addnpc(147385, "QUEST_LV_0100_20150317_000586", "f_huevillage_58_4", 21, 34, -186, -45, "npc_QUEST_LV_0100_20150317_000586")
function npc_QUEST_LV_0100_20150317_000586()
msg("HUEVILLAGE_58_4_MQ09_PG")
msg("HUEVILLAGE_58_4_MQ01_select")
msg("HUEVILLAGE_58_4_MQ01_agree")
msg("HUEVILLAGE_58_4_MQ02_succ")
msg("HUEVILLAGE_58_4_MQ05_select")
msg("HUEVILLAGE_58_4_MQ05_agree")
msg("HUEVILLAGE_58_4_MQ05_succ")
msg("HUEVILLAGE_58_4_MQ06_select")
msg("HUEVILLAGE_58_4_MQ06_prog")
msg("HUEVILLAGE_58_4_MQ06_succ")
msg("HUEVILLAGE_58_4_MQ07_succ")
msg("HUEVILLAGE_58_4_MQ08_succ")
msg("HUEVILLAGE_58_4_MQ11_select")
msg("HUEVILLAGE_58_4_MQ11_TRACK2")
msg("HUEVILLAGE_58_4_MQ05_startnpc_prog")
msg("HUEVILLAGE_58_4_SAULE_BEFORE_basic01")
msg("HUEVILLAGE_58_4_SAULE_BEFORE_basic02")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic01")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic02")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic03")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic06")
msg("HIDDEN_RUNECASTER_saule_dlg1")
msg("HIDDEN_RUNECASTER_saule_dlg2")
msg("LIMESTONE_52_4_MQ_8_SUC01")
msg("PARTY_Q_060_startnpc01")
msg("PARTY_Q_060_startnpc02")
msg("PARTY_Q_060_startnpc_prog01")
msg("PARTY_Q_060_succ01")
msg("PARTY_Q_061_startnpc01")
msg("PARTY_Q_061_startnpc_prog01")
msg("PARTY_Q_061_succ01")
msg("LIMESTONE_52_4_MQ_8_succ")
msg("LIMESTONE_52_4_MQ_9_start")
msg("LIMESTONE_52_4_MQ_9_prog")
msg("LIMESTONE_52_4_MQ_9_succ")
msg("LIMESTONE_52_4_MQ_10_start")
end

----- Huevillage_Altar ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_MQ03_NPC01 -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ03 -----
addnpc(147417, "ETC_20150317_005169", "f_huevillage_58_4", -879, 107, -737, 46, "npc_ETC_20150317_005169")
function npc_ETC_20150317_005169()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- Huevillage_Altar ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_MQ04_NPC01 -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ04 -----
addnpc(147417, "ETC_20150317_005169", "f_huevillage_58_4", 426, -6, 705, 45, "npc_ETC_20150317_005169")
function npc_ETC_20150317_005169()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_MQ07_NPC01 -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ07 -----
addnpc(147372, "ETC_20150317_009354", "f_huevillage_58_4", 1296, -22, -245, 45, "npc_ETC_20150317_009354")
function npc_ETC_20150317_009354()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- noshadow_npc ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147469, "ETC_20150317_005172", "f_huevillage_58_4", 28, 34, -189, 45, "npc_ETC_20150317_005172")
function npc_ETC_20150317_005172()
msg("HUEVILLAGE_58_4_PORTAL_AFTER")
end

----- huevill_mothtem_gray ----- 
----- Enter -----
addnpc(147388, "ETC_20150317_007035", "f_huevillage_58_4", 107, 34, -203, -133, "npc_ETC_20150317_007035")
function npc_ETC_20150317_007035()
msg("HUEVILLAGE_58_4_MQ01_STONE_STATUE01")
end

----- huevill_merge_gray ----- 
----- Enter -----
addnpc(147387, "ETC_20150317_007035", "f_huevillage_58_4", -53, 34, -201, 53, "npc_ETC_20150317_007035")
function npc_ETC_20150317_007035()
msg("HUEVILLAGE_58_4_MQ01_STONE_STATUE02")
end

----- npc_bramble_root_s ----- 
----- Enter -----
addnpc(153058, "ETC_20150714_013167", "f_huevillage_58_4", 893, -23, 749, 45, "npc_ETC_20150714_013167")
function npc_ETC_20150714_013167()
msg("PARTY_Q06_THORN02")
end

----- npc_bramble_root_m ----- 
----- Enter -----
addnpc(153039, "ETC_20150714_013167", "f_huevillage_58_4", 1063, -23, 721, 45, "npc_ETC_20150714_013167")
function npc_ETC_20150714_013167()
msg("PARTY_Q06_THORN02")
end

----- npc_bramble_root_m ----- 
----- Enter -----
addnpc(153039, "ETC_20150714_013167", "f_huevillage_58_4", 1013, -23, 925, 45, "npc_ETC_20150714_013167")
function npc_ETC_20150714_013167()
msg("PARTY_Q06_THORN02")
end

----- npc_bramble_root_m ----- 
----- Enter -----
addnpc(153039, "ETC_20150714_013167", "f_huevillage_58_4", 891, -23, 868, 45, "npc_ETC_20150714_013167")
function npc_ETC_20150714_013167()
msg("PARTY_Q06_THORN02")
end

----- npc_bramble_root_s ----- 
----- Enter -----
addnpc(153058, "ETC_20150714_013167", "f_huevillage_58_4", 1105, -23, 847, 45, "npc_ETC_20150714_013167")
function npc_ETC_20150714_013167()
msg("PARTY_Q06_THORN02")
end

----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "f_huevillage_58_4", 21, -9, -837, 45, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_F_HUEVILLAGE_58_4")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "f_huevillage_58_4", 240, -9, -735, 225, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

