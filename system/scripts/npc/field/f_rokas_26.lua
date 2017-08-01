----- npc_low_lev_officer5_m ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_BIO -----
----- Dialog -----
----- QuestIDs: ROKAS26_SUB_Q01 | ROKAS26_SUB_Q12 -----
addnpc(20142, "QUEST_LV_0100_20150317_001278", "f_rokas_26", 42, 1739, -1171, -45, "npc_QUEST_LV_0100_20150317_001278")
function npc_QUEST_LV_0100_20150317_001278()
msg("ROKAS26_BIO_BASIC01")
msg("ROKAS26_BIO_BASIC02")
msg("ROKAS26_SUB_Q01_01")
msg("ROKAS26_SUB_Q01_02")
msg("ROKAS26_SUB_Q12_select_01")
msg("ROKAS26_SUB_Q12_succ_01")
end

----- soldier6 ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_EHTA -----
----- Dialog -----
----- QuestIDs: ROKAS26_SUB_Q08 | ROKAS26_SUB_Q09 | ROKAS26_SUB_Q10 | ROKAS26_SUB_Q11 | ROKAS26_SUB_Q12 -----
addnpc(20016, "QUEST_LV_0100_20150317_001281", "f_rokas_26", -406, 1837, -312, 45, "npc_QUEST_LV_0100_20150317_001281")
function npc_QUEST_LV_0100_20150317_001281()
msg("ROKAS26_EHTA_BASIC01")
msg("ROKAS26_SUB_Q08_01")
msg("ROKAS26_SUB_Q08_02")
msg("ROKAS26_SUB_Q09_02")
msg("ROKAS26_SUB_Q09_03")
msg("ROKAS26_SUB_Q10_01")
msg("ROKAS26_SUB_Q10_03")
msg("ROKAS26_SUB_Q11_01")
msg("ROKAS26_SUB_Q11_02")
msg("ROKAS26_SUB_Q11_03")
msg("ROKAS26_EHTA_basic1")
msg("ROKAS26_EHTA_after1")
msg("ROKAS26_SUB_Q08_04")
msg("ROKAS26_SUB_Q10_04")
end

----- soldier6 ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_LINT -----
----- Enter | Dialog -----
----- QuestIDs: ROKAS26_SUB_Q03 | ROKAS26_SUB_Q05 | ROKAS26_SUB_Q02 | ROKAS_26_HQ_01 -----
addnpc(20016, "QUEST_LV_0100_20150317_000372", "f_rokas_26", 923, 1670, -749, 45, "npc_QUEST_LV_0100_20150317_000372")
function npc_QUEST_LV_0100_20150317_000372()
msg("ROKAS_26_HQ01_NPC01")
msg("ROKAS26_LINT_basic2")
msg("ROKAS26_LINT_BASIC01")
msg("ROKAS26_SUB_Q02_01")
msg("ROKAS26_SUB_Q02_02")
msg("ROKAS26_SUB_Q02_03")
msg("ROKAS26_SUB_Q03_01")
msg("ROKAS26_SUB_Q03_02")
msg("ROKAS26_SUB_Q03_03")
msg("ROKAS26_SUB_Q05_01")
msg("ROKAS26_SUB_Q05_02")
msg("ROKAS26_SUB_Q05_03")
msg("ROKAS26_LINT_basic1")
msg("ROKAS_26_HQ_01_select01")
msg("ROKAS_26_HQ_01_succ01")
msg("ROKAS_26_HQ_01_W")
end

----- npc_village_uncle_2 ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_REXIPHER1 -----
----- Dialog -----
----- QuestIDs: ROKAS26_QUEST01 | ROKAS26_QUEST02 | ROKAS26_QUEST02_AFTER -----
addnpc(20118, "QUEST_LV_0100_20150317_001284", "f_rokas_26", -49, 1739, -1210, 45, "npc_QUEST_LV_0100_20150317_001284")
function npc_QUEST_LV_0100_20150317_001284()
msg("ROKAS26_REXIPHER1_basic1")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_SUB_Q10_TRIGGER -----
----- Dialog -----
----- QuestIDs: ROKAS26_SUB_Q10 -----
addnpc(147372, "ETC_20150804_014185", "f_rokas_26", -1117, 2168, 1549, 45, "npc_ETC_20150804_014185")
function npc_ETC_20150804_014185()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_paladin_follower2_3 ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_NPC -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 | ROKAS25_TO_26 -----
addnpc(147405, "QUEST_LV_0100_20150317_001286", "f_rokas_26", -340, 1738, -1440, 45, "npc_QUEST_LV_0100_20150317_001286")
function npc_QUEST_LV_0100_20150317_001286()
msg("ROKAS26_MQ1_NPC_BASIC01")
msg("ROKAS26_MQ1_NPC_BASIC02")
msg("ROKAS26_MQ1_select1")
msg("ROKAS26_MQ1_prog_startnpc")
msg("ROKAS26_MQ1_end1")
msg("ROKAS25_TO_26_COMP")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1090, 1670, -1431, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1232, 1670, -606, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1698, 1723, -70, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -530, 1762, -999, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -130, 1837, -343, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 57, 1837, 652, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -623, 1939, 453, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -1109, 2015, 298, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -1265, 2015, 350, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -1241, 2094, 866, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1124, 1670, -2283, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1270, 1670, -1807, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 976, 1670, -1913, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1133, 1670, -1892, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1037, 1670, -1165, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 953, 1670, -928, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1880, 1723, -235, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 1614, 1722, -371, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -623, 1805, -739, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 50, 1837, -173, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 235, 1837, 342, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 95, 1837, 427, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -1209, 2015, 132, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -1455, 2168, 1342, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -1120, 2168, 1643, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -1160, 2168, 1319, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", -958, 2168, 1500, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 43, 2141, 1783, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- blank_npc ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_MQ1_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_MQ1 -----
addnpc(147372, "ETC_20170313_027496", "f_rokas_26", 30, 2141, 1583, 45, "npc_ETC_20170313_027496")
function npc_ETC_20170313_027496()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_rokas_6 ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_QUEST03_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_QUEST03 -----
addnpc(47106, "ETC_20150317_005293", "f_rokas_26", -1504, 2015, 232, 45, "npc_ETC_20150317_005293")
function npc_ETC_20150317_005293()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_rokas_6 ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_QUEST04_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_QUEST04 -----
addnpc(47106, "ETC_20150317_005293", "f_rokas_26", -1360, 2168, 1180, 45, "npc_ETC_20150317_005293")
function npc_ETC_20150317_005293()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_rokas_6 ----- 
----- npcselectdialog.ies | ClassName: ROKAS26_QUEST05_STONE -----
----- Dialog -----
----- QuestIDs: ROKAS26_QUEST05 -----
addnpc(47106, "ETC_20150317_005293", "f_rokas_26", -144, 2140, 1497, 45, "npc_ETC_20150317_005293")
function npc_ETC_20150317_005293()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "f_rokas_26", 2048, 1723, 204, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

----- npc_village_uncle_4 ----- 
----- npcselectdialog.ies | ClassName: ROKAS24_RP_1_NPC -----
----- Dialog -----
----- QuestIDs: ROKAS26_RP_1 -----
addnpc(20139, "QUEST_LV_0100_20160718_015016", "f_rokas_26", -1024, 2168, 1910, -51, "npc_QUEST_LV_0100_20160718_015016")
function npc_QUEST_LV_0100_20160718_015016()
msg("ROKAS26_RP_1_1")
msg("ROKAS26_RP_1_2")
msg("ROKAS26_RP_1_3")
msg("ROKAS24_RP_1_NPC_basic_1")
end

