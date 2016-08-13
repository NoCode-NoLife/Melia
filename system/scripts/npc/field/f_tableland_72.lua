----- Statue of Goddess Vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "f_tableland_72", -272.5474, 406.1369, -74.31588, 0, "npc_dummy")

----- Unidentified Pillar ----- 
addnpc(155051, "QUEST_20151224_003281", "f_tableland_72", -509.8205, 406.1369, 18.53086, -19, "npc_dummy")

----- Cursed Statue ----- 
----- npcselectdialog.ies | ClassName: TABLE72_ARTIFACT -----
----- Enter | Dialog -----
----- QuestIDs: TABLELAND_72_SQ1 | TABLELAND_72_SQ9 -----
addnpc(153155, "ETC_20160718_022193", "f_tableland_72", -576.3289, 406.1362, -1222.547, 19, "ETC_20160718_022193_Call")
function ETC_20160718_022193_Call()
msg("TABLE72_ARTIFACT_MSG")
end

----- Village Priest Chaleims ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE1_1 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ1 | TABLELAND_72_SQ2 | TABLELAND_72_SQ4 | TABLELAND_72_SQ5 | TABLELAND_72_SQ6 | TABLELAND_72_SQ7 | TABLELAND_72_SQ9 -----
addnpc(155043, "QUEST_LV_0300_20160718_001991", "f_tableland_72", -425.4432, 406.1369, 69.7235, -49, "QUEST_LV_0300_20160718_001991_Call")
function QUEST_LV_0300_20160718_001991_Call()
msg("TABLE72_PEAPLE1_1_BASIC01")
msg("TABLE72_PEAPLE1_1_BASIC02")
msg("TABLE72_PEAPLE1_1_BASIC03")
end

----- Villager Argis ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE2 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ2 | TABLELAND_72_SQ3 | TABLELAND_72_SQ4 -----
addnpc(155035, "QUEST_LV_0300_20160718_001996", "f_tableland_72", -46.39484, 406.1369, -42.08913, -116, "QUEST_LV_0300_20160718_001996_Call")
function QUEST_LV_0300_20160718_001996_Call()
msg("TABLE72_PEAPLE2_BASIC01")
end

----- Villager Deailan ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE3 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ10 -----
addnpc(155038, "QUEST_LV_0300_20160718_001994", "f_tableland_72", -73.00058, 406.1369, 23.92019, 218, "QUEST_LV_0300_20160718_001994_Call")
function QUEST_LV_0300_20160718_001994_Call()
msg("TABLE72_PEAPLE3_BASIC01")
end

----- Villager Emils ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE4 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ11 -----
addnpc(152065, "QUEST_LV_0300_20160718_001998", "f_tableland_72", -97.83647, 406.1369, 112.7138, -107, "QUEST_LV_0300_20160718_001998_Call")
function QUEST_LV_0300_20160718_001998_Call()
msg("TABLE72_PEAPLE4_BASIC01")
end

----- Observation Orb ----- 
----- npcselectdialog.ies | ClassName: TABLE72_MONITORING -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ4 -----
addnpc(153157, "ETC_20160718_022195", "f_tableland_72", -422.2, 406.14, -61.51, -17, "npc_dummy")

----- Village Priest Chaleims ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE1_2 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ3 | TABLELAND_72_SQ8 | TABLELAND_72_SQ9 | TABLELAND_72_SQ2 -----
addnpc(155043, "QUEST_LV_0300_20160718_001991", "f_tableland_72", -1319.971, 411.2191, 473.3506, 188, "npc_dummy")

----- Village Priest Arntas ----- 
addnpc(155046, "QUEST_20160718_003944", "f_tableland_72", -394.346, 406.1369, 83.38422, -67, "npc_dummy")

----- Village Priest Chaleims ----- 
----- npcselectdialog.ies | ClassName: TABLE72_PEAPLE1_3 -----
----- Dialog -----
----- QuestIDs: TABLELAND_72_SQ1 | TABLELAND_72_SQ2 -----
addnpc(155043, "QUEST_LV_0300_20160718_001991", "f_tableland_72", -462.7413, 406.1362, -665.2462, -33, "npc_dummy")

----- Village Priest Arntas ----- 
----- Enter -----
addnpc(155046, "QUEST_20160718_003944", "f_tableland_72", -440.1138, 406.1362, -644.0313, -49, "QUEST_20160718_003944_Call")
function QUEST_20160718_003944_Call()
msg("TABLE72_PEAPLE5_2")
end

