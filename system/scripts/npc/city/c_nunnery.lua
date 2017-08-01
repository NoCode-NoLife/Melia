----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "c_nunnery", 105, -75, 4, 360, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_C_NUNNERY")
end

----- npc_nun_1 ----- 
----- npcselectdialog.ies | ClassName: REQUEST_MISSION_ABBEY -----
----- Enter | Dialog -----
----- QuestIDs: TUTO_SAALUS_NUNNERY -----
addnpc(153142, "QUEST_20160224_003616", "c_nunnery", 9, -56, -114, 360, "npc_QUEST_20160224_003616")
function npc_QUEST_20160224_003616()
msg("TUTO_SAALUS_NUNNERY_CHECK")
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_nun_2 ----- 
----- npcselectdialog.ies | ClassName: C_NUNNERY_NPC1 -----
----- Enter | Dialog -----
----- QuestIDs: TUTO_UPHILL_DEFENSE | TUTO_SAALUS_NUNNERY -----
addnpc(153143, "QUEST_20160224_003620", "c_nunnery", 201, -75, 37, 360, "npc_QUEST_20160224_003620")
function npc_QUEST_20160224_003620()
msg("TUTO_UPHILL_DEFENSE_CHECK")
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_ENC_master ----- 
----- npcselectdialog.ies | ClassName: ENCHANTER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_ENCHANTER_8_1 | NUNNERY_KQ_1 | NUNNERY_KQ_2 | CASTLE_ID2_KQ_1 | LSCAVE551_KQ_1 | PRISON81_KQ_1 -----
addnpc(153170, "ETC_20161005_025505", "c_nunnery", 321, -50, 283, -58, "npc_ETC_20161005_025505")
function npc_ETC_20161005_025505()
msg("JOB_ENCHANTER_8_1_START1")
msg("JOB_ENCHANTER_8_1_AGREE1")
msg("JOB_ENCHANTER_8_1_PROG1")
msg("JOB_ENCHANTER_8_1_SUCC1")
msg("ENCHANTER_MASTER_basic1")
msg("ENCHANTER_MASTER_basic2")
msg("CASTLE_ID2_KQ_1_3")
msg("PRISON81_KQ_1_3")
msg("LSCAVE551_KQ_1_3")
msg("NUNNERY_KQ_1_1")
msg("NUNNERY_KQ_2_3")
end

----- npc_combat_transport_section_2 ----- 
----- npcselectdialog.ies | ClassName: HT_ESCAPE_MERCHANT -----
----- Dialog -----
addnpc(20103, "QUEST_20161214_005130", "c_nunnery", 506, -29, -335, 45, "npc_QUEST_20161214_005130")
function npc_QUEST_20161214_005130()
msg("HT_ESCAPE_MERCHANT_BASIC04")
msg("HT_ESCAPE_MERCHANT_BASIC01")
msg("HT_ESCAPE_MERCHANT_BASIC02")
msg("HT_ESCAPE_MERCHANT_BASIC05")
msg("HT_ESCAPE_MERCHANT_BASIC03")
end

----- npc_village_uncle_10 ----- 
----- npcselectdialog.ies | ClassName: KEY_QUEST_NPC_NUNNERY -----
----- Dialog -----
----- QuestIDs: PILGRIM412_KQ_1 | LSCAVE521_KQ_1 -----
addnpc(20156, "QUEST_20170313_005781", "c_nunnery", 331, -76, -188, 45, "npc_QUEST_20170313_005781")
function npc_QUEST_20170313_005781()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

