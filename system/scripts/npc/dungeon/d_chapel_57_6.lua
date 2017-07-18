----- npc_paladin_follower1_3 ----- 
----- npcselectdialog.ies | ClassName: CHAPEL_VIRGINIJA -----
----- Dialog -----
----- QuestIDs: CHAPLE575_MQ_09 | CHAPLE576_MQ_01 | CHAPLE576_MQ_02 | CHAPLE576_MQ_04 | CHAPLE576_RP_1 -----
addnpc(147400, "QUEST_LV_0100_20150317_000864", "d_chapel_57_6", 961, -79, -114, -45, "npc_QUEST_LV_0100_20150317_000864")
function npc_QUEST_LV_0100_20150317_000864()
msg("CHAPLE575_MQ_09_03")
msg("CHAPLE576_MQ_01_01")
msg("CHAPLE576_MQ_01_02")
msg("CHAPLE576_MQ_01_03")
msg("CHAPLE576_MQ_02_01")
msg("CHAPLE576_MQ_02_02")
msg("CHAPLE576_MQ_03_01")
msg("CHAPLE576_MQ_03_02")
msg("CHAPLE576_MQ_04_03")
msg("CHAPEL_VIRGINIJA_BASIC01")
msg("CHAPEL_VIRGINIJA_BASIC03")
msg("CHAPLE576_RP_1_1")
msg("CHAPLE576_RP_1_2")
msg("CHAPLE576_RP_1_3")
msg("CHAPLE576_RP_1_1_AG")
end

----- npc_paladin_follower1_2 ----- 
----- npcselectdialog.ies | ClassName: CHAPEL576_DONATAS -----
----- Dialog -----
----- QuestIDs: CHAPLE576_MQ_04_1 | CHAPLE576_MQ_05 | CHAPLE576_MQ_06 | CHAPLE576_MQ_07 | CHAPLE576_MQ_08 | CHAPLE576_MQ_09 -----
addnpc(147399, "QUEST_LV_0100_20150317_000797", "d_chapel_57_6", -1674, 1, 374, 65.14, "npc_QUEST_LV_0100_20150317_000797")
function npc_QUEST_LV_0100_20150317_000797()
msg("CHAPLE576_MQ_05_03")
msg("CHAPLE576_MQ_06_01")
msg("CHAPLE576_MQ_06_02")
msg("CHAPLE576_MQ_07_03")
msg("CHAPLE576_MQ_08_01")
msg("CHAPLE576_MQ_08_02")
msg("CHAPEL576_DONATAS_basic01")
msg("CHAPLE576_MQ_06_AG")
msg("CHAPLE576_MQ_04_03_1")
msg("CHAPLE576_MQ_05_01")
msg("CHAPLE576_MQ_05_02")
msg("CHAPLE576_MQ_06_03")
msg("CHAPLE576_MQ_07_01")
msg("CHAPLE576_MQ_07_02")
msg("CHAPLE576_MQ_08_03")
msg("CHAPLE576_MQ_09_01")
msg("CHAPLE576_MQ_09_02")
msg("CHAPLE576_MQ_09_03")
msg("CHAPLE576_MQ_09_add")
end

----- holly_sphere_chapel_02 ----- 
----- npcselectdialog.ies | ClassName: CHAPLE576_MQ_09 -----
----- Enter | Dialog -----
----- QuestIDs: CHAPLE576_MQ_09 -----
addnpc(147358, "ETC_20150317_005079", "d_chapel_57_6", -523, 10, 446, 0, "npc_ETC_20150317_005079")
function npc_ETC_20150317_005079()
msg("CHAPEL576_BASIC_3")
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- holly_sphere_chapel_01 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Enter | Dialog -----
addnpc(147357, "ETC_20150317_006693", "d_chapel_57_6", -523, 13, 1948, 0, "npc_ETC_20150317_006693")
function npc_ETC_20150317_006693()
msg("CHAPEL576_BASIC_1")
msg("CHAPEL576_NORTH")
end

----- holly_sphere_chapel_01 ----- 
----- Enter -----
addnpc(147357, "ETC_20150317_006692", "d_chapel_57_6", -526, 11, -1092, 0, "npc_ETC_20150317_006692")
function npc_ETC_20150317_006692()
msg("CHAPEL576_BASIC_2")
end

----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_chapel_57_6", 1322, 0, 435, 225, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_D_CHAPEL_57_6")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "d_chapel_57_6", -661, 1, 117, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

