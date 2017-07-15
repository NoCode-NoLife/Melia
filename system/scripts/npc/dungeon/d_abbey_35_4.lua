----- npc_friar_04_2 ----- 
----- npcselectdialog.ies | ClassName: ABBEY_35_4_MONK -----
----- Dialog -----
----- QuestIDs: ABBEY_35_4_SQ_1 | ABBEY_35_4_SQ_2 | ABBEY_35_4_SQ_3 | ABBEY_35_4_SQ_8 -----
addnpc(156025, "QUEST_LV_0300_20160310_001113", "d_abbey_35_4", 1336, 105, 222, -45, "npc_QUEST_LV_0300_20160310_001113")
function npc_QUEST_LV_0300_20160310_001113()
msg("ABBEY_35_3_MONK_basic_03")
msg("ABBEY353_HQ1_start1")
msg("ABBEY353_HQ1_agree1")
msg("ABBEY353_HQ1_succ1")
msg("ABBEY353_HQ2_start1")
msg("ABBEY_35_4_SQ_2_HUNGER")
msg("ABBEY_35_3_SQ_9_start")
msg("ABBEY_35_3_SQ_10_progress")
msg("ABBEY_35_3_SQ_10_succ")
msg("ABBEY_35_3_SQ_9_succ_start")
msg("ABBEY_35_3_SQ_11_start")
msg("ABBEY_35_3_SQ_11_progress")
msg("ABBEY_35_3_SQ_11_succ")
msg("ABBEY_35_4_SQ_1_succ")
msg("ABBEY_35_4_SQ_2_start")
msg("ABBEY_35_4_SQ_2_agree")
msg("ABBEY_35_4_SQ_2_STUN")
msg("ABBEY_35_4_SQ_2_succ")
msg("ABBEY_35_4_SQ_3_start")
msg("ABBEY_35_4_SQ_3_agree")
msg("ABBEY_35_4_SQ_3_succ_start")
msg("ABBEY_35_4_SQ_8_start")
msg("ABBEY_35_4_SQ_8_agree")
msg("ABBEY_35_4_SQ_8_succ")
msg("ABBEY_35_3_SQ_9_agree")
msg("ABBEY_35_3_MONK_basic_01")
msg("ABBEY_35_3_MONK_basic_02")
msg("ABBEY_35_4_MONK_basic01")
msg("ABBEY_35_4_MONK_basic02")
end

----- npc_friar_01 ----- 
----- npcselectdialog.ies | ClassName: ABBEY_35_4_ELDER -----
----- Dialog -----
----- QuestIDs: ABBEY_35_4_SQ_4 | ABBEY_35_4_SQ_3 | ABBEY_35_4_SQ_5 | ABBEY_35_4_SQ_6 | ABBEY_35_4_SQ_7 -----
addnpc(155042, "QUEST_LV_0300_20160310_001252", "d_abbey_35_4", 1581, 0, -279, -46, "npc_QUEST_LV_0300_20160310_001252")
function npc_QUEST_LV_0300_20160310_001252()
msg("ABBEY_35_4_SQ_3_succ")
msg("ABBEY_35_4_SQ_4_start")
msg("ABBEY_35_4_SQ_4_succ")
msg("ABBEY_35_4_SQ_5_start")
msg("ABBEY_35_4_SQ_5_progress")
msg("ABBEY_35_4_SQ_5_succ")
msg("ABBEY_35_4_SQ_6_start")
msg("ABBEY_35_4_SQ_6_succ")
msg("ABBEY_35_4_SQ_7_start")
msg("ABBEY_35_4_SQ_7_prog_start")
msg("ABBEY_35_4_SQ_7_succ")
msg("ABBEY_35_4_SQ_4_progress")
msg("ABBEY_35_4_SQ_6_progress")
msg("ABBEY_35_4_SQ_9_start")
msg("ABBEY_35_4_SQ_10_start")
msg("ABBEY_35_4_SQ_10_progress")
msg("ABBEY_35_4_SQ_10_succ")
msg("ABBEY_35_4_ELDER_basic_01")
msg("ABBEY_35_4_ELDER_2_basic_01")
msg("ABBEY_35_4_ELDER_2_basic_02")
msg("ABBEY_35_4_SQ_7_add")
msg("ABBEY_35_4_SQ_10_AG")
end

----- npc_Obelisk ----- 
----- Enter -----
addnpc(147414, "ETC_20160310_021163", "d_abbey_35_4", 835, 68, -1202, 45, "npc_ETC_20160310_021163")
function npc_ETC_20160310_021163()
msg("ABBEY_35_4_UNHOLY")
end

----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_abbey_35_4", 1284, 0, -1021, 32, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_D_ABBEY_35_4")
end

----- npc_gintas ----- 
----- Enter -----
----- QuestIDs: ABBEY_35_4_SQ_7 -----
addnpc(156000, "ETC_20160310_020914", "d_abbey_35_4", 262, 68, -1185, 45, "npc_ETC_20160310_020914")
function npc_ETC_20160310_020914()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_friar_01 ----- 
----- npcselectdialog.ies | ClassName: ABBEY_35_4_ELDER_2 -----
----- Dialog -----
----- QuestIDs: ABBEY_35_4_SQ_7 | ABBEY_35_4_SQ_9 | ABBEY_35_4_SQ_10 -----
addnpc(155042, "QUEST_LV_0300_20160310_001252", "d_abbey_35_4", 191, 68, -1190, 45, "npc_QUEST_LV_0300_20160310_001252")
function npc_QUEST_LV_0300_20160310_001252()
msg("ABBEY_35_4_SQ_3_succ")
msg("ABBEY_35_4_SQ_4_start")
msg("ABBEY_35_4_SQ_4_succ")
msg("ABBEY_35_4_SQ_5_start")
msg("ABBEY_35_4_SQ_5_progress")
msg("ABBEY_35_4_SQ_5_succ")
msg("ABBEY_35_4_SQ_6_start")
msg("ABBEY_35_4_SQ_6_succ")
msg("ABBEY_35_4_SQ_7_start")
msg("ABBEY_35_4_SQ_7_prog_start")
msg("ABBEY_35_4_SQ_7_succ")
msg("ABBEY_35_4_SQ_4_progress")
msg("ABBEY_35_4_SQ_6_progress")
msg("ABBEY_35_4_SQ_9_start")
msg("ABBEY_35_4_SQ_10_start")
msg("ABBEY_35_4_SQ_10_progress")
msg("ABBEY_35_4_SQ_10_succ")
msg("ABBEY_35_4_ELDER_basic_01")
msg("ABBEY_35_4_ELDER_2_basic_01")
msg("ABBEY_35_4_ELDER_2_basic_02")
msg("ABBEY_35_4_SQ_7_add")
msg("ABBEY_35_4_SQ_10_AG")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "d_abbey_35_4", -1481, 125, -703, 135, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

