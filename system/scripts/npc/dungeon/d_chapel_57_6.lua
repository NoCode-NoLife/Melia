----- Follower Vaidutis ----- 
----- npcselectdialog.ies | ClassName: CHAPEL_VIRGINIJA -----
----- Dialog -----
----- QuestIDs: CHAPLE575_MQ_09 | CHAPLE576_MQ_01 | CHAPLE576_MQ_02 | CHAPLE576_MQ_04 | CHAPLE576_RP_1 -----
addnpc(147400, "QUEST_LV_0100_20150317_000864", "d_chapel_57_6", 961, -79, -114, -45, "QUEST_LV_0100_20150317_000864_Call")
function QUEST_LV_0100_20150317_000864_Call()
msg("CHAPEL_VIRGINIJA_BASIC01")
msg("CHAPEL_VIRGINIJA_BASIC03")
end

----- Follower Donatas ----- 
----- npcselectdialog.ies | ClassName: CHAPEL576_DONATAS -----
----- Dialog -----
----- QuestIDs: CHAPLE576_MQ_04_1 | CHAPLE576_MQ_05 | CHAPLE576_MQ_06 | CHAPLE576_MQ_07 | CHAPLE576_MQ_08 | CHAPLE576_MQ_09 -----
addnpc(147399, "QUEST_LV_0100_20150317_000797", "d_chapel_57_6", -1674, 1, 374, 65.14, "QUEST_LV_0100_20150317_000797_Call")
function QUEST_LV_0100_20150317_000797_Call()
msg("CHAPEL576_DONATAS_basic01")
end

----- Central Altar ----- 
----- npcselectdialog.ies | ClassName: CHAPLE576_MQ_09 -----
----- Enter | Dialog -----
----- QuestIDs: CHAPLE576_MQ_09 -----
addnpc(147358, "ETC_20150317_005079", "d_chapel_57_6", -523, 10, 446, 0, "ETC_20150317_005079_Call")
function ETC_20150317_005079_Call()
msg("CHAPEL576_BASIC_3")
msg("CHAPLE576_MQ_09_01")
end

----- Globejas Altar ----- 
----- Enter -----
addnpc(147357, "ETC_20150317_006693", "d_chapel_57_6", -523, 13.19, 1948, 0, "ETC_20150317_006693_Call")
function ETC_20150317_006693_Call()
msg("CHAPEL576_BASIC_1")
end

----- Apsauga Altar ----- 
----- Enter -----
addnpc(147357, "ETC_20150317_006692", "d_chapel_57_6", -526.1256, 10.9683, -1091.657, 0, "ETC_20150317_006692_Call")
function ETC_20150317_006692_Call()
msg("CHAPEL576_BASIC_2")
end

----- Statue of Goddess Vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_chapel_57_6", 1322.36, 0.16, 435.09, 225, "npc_dummy")

----- Lv1 Treasure Chest ----- 
addnpc(147392, "ETC_20150317_009100", "d_chapel_57_6", -660.85, 0.59, 117.06, 45, "npc_dummy")

