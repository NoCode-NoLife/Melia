----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "f_tableland_72", -273, 406, -74, 0, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_F_TABLELAND_72")
end

----- npc_circle_trigger ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155051, "QUEST_20151224_003281", "f_tableland_72", -510, 406, 19, -19, "npc_QUEST_20151224_003281")
function npc_QUEST_20151224_003281()
msg("TABLELAND72_BASE_BALL")
end

----- npc_figurine ----- 
----- npcselectdialog.ies | ClassName: TABLE72_ARTIFACT -----
----- Enter | Dialog -----
----- QuestIDs: TABLELAND_72_SQ1 | TABLELAND_72_SQ9 -----
addnpc(153155, "ETC_20160718_022193", "f_tableland_72", -576, 406, -1223, 19, "npc_ETC_20160718_022193")
function npc_ETC_20160718_022193()
msg("TABLE72_ARTIFACT_MSG")
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_friar_02 ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE1_1 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ1 | TABLELAND_72_SQ2 | TABLELAND_72_SQ4 | TABLELAND_72_SQ5 | TABLELAND_72_SQ6 | TABLELAND_72_SQ7 | TABLELAND_72_SQ9 -----
addnpc(155043, "QUEST_LV_0300_20160718_001991", "f_tableland_72", -425, 406, 70, -49, "npc_QUEST_LV_0300_20160718_001991")
function npc_QUEST_LV_0300_20160718_001991()
msg("TABLE72_PEAPLE1_1_BASIC01")
msg("TABLE72_PEAPLE1_1_BASIC02")
msg("TABLE72_PEAPLE1_1_BASIC03")
msg("TABLELAND_72_SQ2_startnpc1")
msg("TABLELAND_72_SQ1_succ1")
msg("TABLELAND_72_SQ4_succ1")
msg("TABLELAND_72_SQ4_succ2")
msg("TABLELAND_72_SQ5_startnpc1")
msg("TABLELAND_72_SQ5_prog1")
msg("TABLELAND_72_SQ5_succ1")
msg("TABLELAND_72_SQ6_startnpc1")
msg("TABLELAND_72_SQ6_startnpc2")
msg("TABLELAND_72_SQ6_prog1")
msg("TABLELAND_72_SQ6_succ1")
msg("TABLELAND_72_SQ7_startnpc1")
msg("TABLELAND_72_SQ7_prog1")
msg("TABLELAND_72_SQ7_succ1")
msg("TABLELAND_72_SQ8_startnpc1")
msg("TABLELAND_72_SQ8_startnpc2")
msg("TABLELAND_72_SQ8_succ1")
msg("TABLELAND_72_SQ9_startnpc1")
msg("TABLELAND_72_SQ9_startnpc2")
msg("TABLELAND_72_SQ9_succ1")
msg("TABLELAND_72_SQ2_startnpc2")
end

----- npc_pilgrim_m_2 ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE2 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ2 | TABLELAND_72_SQ3 | TABLELAND_72_SQ4 -----
addnpc(155035, "QUEST_LV_0300_20160718_001996", "f_tableland_72", -46, 406, -42, -116, "npc_QUEST_LV_0300_20160718_001996")
function npc_QUEST_LV_0300_20160718_001996()
msg("TABLE72_PEAPLE2_BASIC01")
msg("TABLELAND_72_SQ3_startnpc1")
msg("TABLELAND_72_SQ3_startnpc2")
msg("TABLELAND_72_SQ3_prog1")
msg("TABLELAND_72_SQ3_succ01")
msg("TABLELAND_72_SQ3_succ02")
msg("TABLELAND_72_SQ4_startnpc1")
msg("TABLELAND_72_SQ4_startnpc_prog1")
msg("TABLELAND_72_SQ2_succ1")
end

----- npc_pilgrim_m_5 ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE3 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ10 -----
addnpc(155038, "QUEST_LV_0300_20160718_001994", "f_tableland_72", -73, 406, 24, 218, "npc_QUEST_LV_0300_20160718_001994")
function npc_QUEST_LV_0300_20160718_001994()
msg("TABLE72_PEAPLE3_BASIC01")
msg("TABLELAND_72_SQ10_startnpc1")
msg("TABLELAND_72_SQ10_startnpc2")
msg("TABLELAND_72_SQ10_prog1")
msg("TABLELAND_72_SQ10_succ1")
end

----- npc_pilgrim_f_3 ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE4 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ11 -----
addnpc(152065, "QUEST_LV_0300_20160718_001998", "f_tableland_72", -98, 406, 113, -107, "npc_QUEST_LV_0300_20160718_001998")
function npc_QUEST_LV_0300_20160718_001998()
msg("TABLE72_PEAPLE4_BASIC01")
msg("TABLELAND_72_SQ11_startnpc1")
msg("TABLELAND_72_SQ11_startnpc2")
msg("TABLELAND_72_SQ11_prog1")
msg("TABLELAND_72_SQ11_succ1")
end

----- npc_figurine_device ----- 
----- npcselectdialog.ies | ClassName: TABLE72_MONITORING -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ4 -----
addnpc(153157, "ETC_20160718_022195", "f_tableland_72", -422, 406, -62, -17, "npc_ETC_20160718_022195")
function npc_ETC_20160718_022195()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_friar_02 ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE1_2 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ3 | TABLELAND_72_SQ8 | TABLELAND_72_SQ9 | TABLELAND_72_SQ2 -----
addnpc(155043, "QUEST_LV_0300_20160718_001991", "f_tableland_72", -1320, 411, 473, 188, "npc_QUEST_LV_0300_20160718_001991")
function npc_QUEST_LV_0300_20160718_001991()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_friar_05 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155046, "QUEST_20160718_003944", "f_tableland_72", -394, 406, 83, -67, "npc_QUEST_20160718_003944")
function npc_QUEST_20160718_003944()
msg("TABLE72_PEAPLE5_DLG1")
end

----- npc_friar_02 ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE1_3 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ1 | TABLELAND_72_SQ2 -----
addnpc(155043, "QUEST_LV_0300_20160718_001991", "f_tableland_72", -463, 406, -665, -33, "npc_QUEST_LV_0300_20160718_001991")
function npc_QUEST_LV_0300_20160718_001991()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_friar_05 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Enter | Dialog -----
addnpc(155046, "QUEST_20160718_003944", "f_tableland_72", -440, 406, -644, -49, "npc_QUEST_20160718_003944")
function npc_QUEST_20160718_003944()
msg("TABLE72_PEAPLE5_2")
msg("TABLE72_PEAPLE5_1")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "f_tableland_72", -581, 487, 150, 0, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

