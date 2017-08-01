----- npc_village_uncle_8 ----- 
----- npcselectdialog.ies | ClassName: CATACOMB_38_1_NPC_01 -----
----- Dialog -----
----- QuestIDs: CATACOMB_38_1_SQ_01 -----
addnpc(20154, "QUEST_20150317_001310", "id_catacomb_38_1", 1522, -114, -2, 45, "npc_QUEST_20150317_001310")
function npc_QUEST_20150317_001310()
msg("CATACOMB_38_1_SQ_01_select")
msg("CATACOMB_38_1_NPC_01_basic01")
end

----- npc_kupole_6 ----- 
----- npcselectdialog.ies | ClassName: CATACOMB_38_1_NPC_02 -----
----- Dialog -----
----- QuestIDs: CATACOMB_38_1_SQ_01 | CATACOMB_38_1_SQ_02 | CATACOMB_38_1_SQ_03 | CATACOMB_38_1_SQ_04 | CATACOMB_38_1_SQ_05 -----
addnpc(154016, "QUEST_LV_0200_20150714_007517", "id_catacomb_38_1", 1026, -67, -337, 45, "npc_QUEST_LV_0200_20150714_007517")
function npc_QUEST_LV_0200_20150714_007517()
msg("CATACOMB_38_1_SQ_01_succ")
msg("CATACOMB_38_1_SQ_02_select")
msg("CATACOMB_38_1_SQ_02_agree")
msg("CATACOMB_38_1_SQ_02_prog_start")
msg("CATACOMB_38_1_SQ_03_select")
msg("CATACOMB_38_1_SQ_03_agree")
msg("CATACOMB_38_1_SQ_03_prog_start")
msg("CATACOMB_38_1_SQ_04_succ")
msg("CATACOMB_38_1_SQ_05_select")
msg("CATACOMB_38_1_SQ_05_prog_start")
msg("CATACOMB_38_1_SQ_03_add")
msg("CATACOMB_38_1_NPC_02_basic01")
msg("CATACOMB_38_1_NPC_02_basic02")
msg("CATACOMB_38_1_NPC_02_basic03")
end

----- npc_village_uncle_1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20117, "ETC_20150714_013182", "id_catacomb_38_1", 120, -110, -495, 45, "npc_ETC_20150714_013182")
function npc_ETC_20150714_013182()
msg("CATACOMB_38_1_GHOST_01")
end

----- npc_matron2 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20145, "ETC_20150714_013182", "id_catacomb_38_1", 346, -110, -789, 45, "npc_ETC_20150714_013182")
function npc_ETC_20150714_013182()
msg("CATACOMB_38_1_GHOST_02")
end

----- npc_village_uncle_3 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20138, "ETC_20150714_013182", "id_catacomb_38_1", -466, 0, -634, 45, "npc_ETC_20150714_013182")
function npc_ETC_20150714_013182()
msg("CATACOMB_38_1_GHOST_03")
end

----- npc_matron4 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20147, "ETC_20150714_013182", "id_catacomb_38_1", -657, 18, -788, 45, "npc_ETC_20150714_013182")
function npc_ETC_20150714_013182()
msg("CATACOMB_38_1_GHOST_04")
end

----- rokas_pot1 ----- 
----- npcselectdialog.ies | ClassName: CATACOMB_38_1_OBJ_01 -----
----- Dialog -----
----- QuestIDs: CATACOMB_38_1_SQ_02 | CATACOMB_38_1_SQ_03 | CATACOMB_38_1_SQ_04 -----
addnpc(47256, "ETC_20150714_011781", "id_catacomb_38_1", -1156, 135, -1468, 45, "npc_ETC_20150714_011781")
function npc_ETC_20150714_011781()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_village_uncle_11 ----- 
----- npcselectdialog.ies | ClassName: CATACOMB_38_1_NPC_03 -----
----- Dialog -----
----- QuestIDs: CATACOMB_38_1_SQ_05 | CATACOMB_38_1_SQ_06 | CATACOMB_38_1_SQ_07 -----
addnpc(20157, "QUEST_LV_0200_20150714_007532", "id_catacomb_38_1", 266, 0, 134, 45, "npc_QUEST_LV_0200_20150714_007532")
function npc_QUEST_LV_0200_20150714_007532()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- farm47_circle_01 ----- 
----- npcselectdialog.ies | ClassName: CATACOMB_38_1_OBJ_03 -----
----- Dialog -----
----- QuestIDs: CATACOMB_38_1_SQ_06 -----
addnpc(153047, "ETC_20150714_011783", "id_catacomb_38_1", -836, 166, -3, 45, "npc_ETC_20150714_011783")
function npc_ETC_20150714_011783()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "id_catacomb_38_1", -1782, 202, -1355, 90, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

