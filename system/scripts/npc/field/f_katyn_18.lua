----- npc_ghost_soldier ----- 
----- npcselectdialog.ies | ClassName: KATYN_18_RE_SQ_NPC_1 -----
----- Dialog -----
----- QuestIDs: KATYN_18_RE_SQ_1 | KATYN_18_RE_SQ_2 -----
addnpc(154017, "QUEST_LV_0300_20161005_005064", "f_katyn_18", 1940, 373, -2120, 45, "npc_QUEST_LV_0300_20161005_005064")
function npc_QUEST_LV_0300_20161005_005064()
msg("KATYN_18_RE_SQ_1_select")
msg("KATYN_18_RE_SQ_1_agree")
msg("KATYN_18_RE_SQ_1_prog_strat")
msg("KATYN_18_RE_SQ_1_succ")
msg("KATYN_18_RE_SQ_2_select")
msg("KATYN_18_RE_SQ_2_agree")
msg("KATYN_18_RE_SQ_2_prog_start")
msg("KATYN_18_RE_SQ_2_succ")
msg("KATYN_18_RE_SQ_NPC_1_basic1")
end

----- npc_ghost_soldier2 ----- 
----- npcselectdialog.ies | ClassName: KATYN_18_RE_SQ_NPC_2 -----
----- Dialog -----
----- QuestIDs: KATYN_18_RE_SQ_3 | KATYN_18_RE_SQ_4 | KATYN_18_RE_SQ_5 -----
addnpc(155131, "QUEST_LV_0300_20161005_005082", "f_katyn_18", 840, 525, -565, 45, "npc_QUEST_LV_0300_20161005_005082")
function npc_QUEST_LV_0300_20161005_005082()
msg("KATYN_18_RE_SQ_3_select")
msg("KATYN_18_RE_SQ_3_agree")
msg("KATYN_18_RE_SQ_3_prog_start")
msg("KATYN_18_RE_SQ_3_succ")
msg("KATYN_18_RE_SQ_4_select")
msg("KATYN_18_RE_SQ_4_agree")
msg("KATYN_18_RE_SQ_4_prog_start")
msg("KATYN_18_RE_SQ_5_succ")
msg("KATYN_18_RE_SQ_NPC_2_basic1")
end

----- npc_ghost_soldier3 ----- 
----- npcselectdialog.ies | ClassName: KATYN_18_RE_SQ_NPC_3 -----
----- Dialog -----
----- QuestIDs: KATYN_18_RE_SQ_6 | KATYN_18_RE_SQ_7 | KATYN_18_RE_SQ_8 -----
addnpc(155132, "QUEST_LV_0300_20161005_005101", "f_katyn_18", 721, 373, -2327, 45, "npc_QUEST_LV_0300_20161005_005101")
function npc_QUEST_LV_0300_20161005_005101()
msg("KATYN_18_RE_SQ_6_select")
msg("KATYN_18_RE_SQ_6_agree")
msg("KATYN_18_RE_SQ_6_prog_start")
msg("KATYN_18_RE_SQ_6_succ")
msg("KATYN_18_RE_SQ_7_select")
msg("KATYN_18_RE_SQ_7_agree")
msg("KATYN_18_RE_SQ_7_prog_start")
msg("KATYN_18_RE_SQ_7_succ")
msg("KATYN_18_RE_SQ_8_select")
msg("KATYN_18_RE_SQ_8_agree")
msg("KATYN_18_RE_SQ_8_prog_start")
msg("KATYN_18_RE_SQ_NPC_3_basic1")
end

----- Huevillage_Altar ----- 
----- npcselectdialog.ies | ClassName: KATYN_18_RE_SQ_OBJ_5 -----
----- Dialog -----
----- QuestIDs: KATYN_18_RE_SQ_8 -----
addnpc(147417, "ETC_20161005_025526", "f_katyn_18", -1039, 500, -183, -45, "npc_ETC_20161005_025526")
function npc_ETC_20161005_025526()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "f_katyn_18", 1899, 373, -1207, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

