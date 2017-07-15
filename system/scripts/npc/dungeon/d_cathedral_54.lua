----- npc_saule_female_1 ----- 
----- npcselectdialog.ies | ClassName: CHATHEDRAL54_SQ01_PART1 -----
----- Enter | Dialog -----
----- QuestIDs: CHATHEDRAL54_SQ03_PART1 | CHATHEDRAL54_SQ04_PART2 | CHATHEDRAL54_HQ1 -----
addnpc(147386, "QUEST_LV_0200_20150323_003366", "d_cathedral_54", 911, 5, -164, 15, "npc_QUEST_LV_0200_20150323_003366")
function npc_QUEST_LV_0200_20150323_003366()
msg("CHATHEDRAL54_SQ01_PART1_IN")
msg("CATHEDRAL54_SQ01_PART1_basic01")
msg("CHATHEDRAL54_SQ01_PART1_basic02")
msg("CHATHEDRAL54_HQ1_basic1")
msg("CHATHEDRAL54_HIDDEN_DLG1")
msg("CHATHEDRAL54_HQ1_start1")
msg("CHATHEDRAL54_HQ1_agree1")
msg("CHATHEDRAL54_HQ1_prog1")
msg("CHATHEDRAL54_HQ1_succ1")
msg("CHATHEDRAL54_SQ03_PART1_AG")
msg("CHATHEDRAL54_SQ03_PART1_select01")
msg("CHATHEDRAL54_SQ03_PART1_prog_startnpc01")
msg("CHATHEDRAL54_SQ03_PART1_succ01")
msg("CHATHEDRAL54_SQ04_PART2_select01")
msg("CHATHEDRAL54_SQ04_PART2_prog_startnpc01")
msg("CHATHEDRAL54_SQ04_PART2_succ01")
end

----- npc_saule_female_2 ----- 
----- npcselectdialog.ies | ClassName: CHATHEDRAL54_SQ03_PART1 -----
----- Dialog -----
----- QuestIDs: CHATHEDRAL54_SQ02_PART1 -----
addnpc(147397, "QUEST_LV_0200_20150323_003596", "d_cathedral_54", 1051, 5, -65, -14, "npc_QUEST_LV_0200_20150323_003596")
function npc_QUEST_LV_0200_20150323_003596()
msg("PRIST_REPORT01_LOG")
msg("CATHEDRAL54_SQ03_PART1_basic01")
msg("CATHEDRAL54_SQ03_PART1_basic02")
msg("CHATHEDRAL54_SQ02_PART1_prog01")
msg("CHATHEDRAL54_SQ02_PART1_select01")
msg("CHATHEDRAL54_SQ02_PART1_succ01")
end

----- npc_saule_male_2 ----- 
----- npcselectdialog.ies | ClassName: CHATHEDRAL54_SQ04_PART2 -----
----- Dialog -----
----- QuestIDs: CHATHEDRAL54_SQ01_PART1 | CHATHEDRAL53_SQ09 | CHATHEDRAL54_SQ06 | CHATHEDRAL54_SQ07 -----
addnpc(147398, "QUEST_LV_0200_20150323_003593", "d_cathedral_54", 927, 3, 495, 123, "npc_QUEST_LV_0200_20150323_003593")
function npc_QUEST_LV_0200_20150323_003593()
msg("CATHEDRAL54_SQ04_PART2_basic01")
msg("CATHEDRAL54_SQ04_PART2_basic02")
msg("CHATHEDRAL54_SQ01_PART1")
msg("CHATHEDRAL54_SQ01_PART1_prog_startnpc01")
msg("CHATHEDRAL54_SQ01_PART1_succ01")
msg("CHATHEDRAL53_SQ09_succ01")
msg("CHATHEDRAL54_SQ06_select01")
msg("CHATHEDRAL54_SQ06_prog01")
msg("CHATHEDRAL54_SQ06_succ01")
msg("CHATHEDRAL54_SQ07_select01")
msg("CHATHEDRAL54_SQ07_agree01")
msg("CHATHEDRAL54_SQ07_prog01")
end

----- npc_zacharial_desk ----- 
----- npcselectdialog.ies | ClassName: CHATHEDRAL54_MQ04_PART2 -----
----- Dialog -----
----- QuestIDs: CHATHEDRAL54_MQ04_PART2 | CHATHEDRAL54_SQ05_PART2 -----
addnpc(47254, "ETC_20150317_006371", "d_cathedral_54", 826, 14, 1201, -48, "npc_ETC_20150317_006371")
function npc_ETC_20150317_006371()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_aurelius ----- 
----- npcselectdialog.ies | ClassName: CHATHEDRAL54_PART1_BISHOP -----
----- Dialog -----
----- QuestIDs: CHATHEDRAL54_MQ01_PART1 -----
addnpc(151033, "QUEST_LV_0200_20150317_000875", "d_cathedral_54", -970, 4, -619, 71, "npc_QUEST_LV_0200_20150317_000875")
function npc_QUEST_LV_0200_20150317_000875()
msg("CHATHEDRAL53_MQ_BISHOP_basic01")
msg("CHATHEDRAL53_MQ_BISHOP_basic02")
msg("CHATHEDRAL54_PART1_BISHOP_basic01")
msg("CHATHEDRAL54_PART1_BISHOP_basic02")
msg("CHATHEDRAL56_MQ_BISHOP_AFTER_basic01")
msg("CHATHEDRAL53_MQ01_select")
msg("CHATHEDRAL53_MQ01_prog_startnpc")
msg("CHATHEDRAL53_MQ01_succ01")
msg("CHATHEDRAL53_MQ02_select")
msg("CHATHEDRAL53_MQ02_prog_startnpc")
msg("CHATHEDRAL53_MQ03_select01")
msg("CHATHEDRAL53_MQ03_succ01")
msg("CHATHEDRAL53_MQ01_startnpc01")
msg("CHATHEDRAL53_MQ02_startnpc01")
msg("CHATHEDRAL53_MQ03_startnpc01")
msg("CHATHEDRAL53_MQ01_add")
msg("CHATHEDRAL53_MQ05_select01")
msg("CHATHEDRAL53_MQ06_select01")
msg("CHATHEDRAL53_MQ05_AG")
msg("CHATHEDRAL53_MQ04_select01")
msg("CHATHEDRAL53_MQ06_AG")
msg("CHATHEDRAL53_BISHOP_DIALOG")
msg("CHATHEDRAL53_MQ_BISHOP_DIALOG_01")
msg("CHATHEDRAL53_MQ_BISHOP_DIALOG_02")
msg("CHATHEDRAL53_MQ_BISHOP_DIALOG_03")
msg("CHATHEDRAL53_MQ_BISHOP_DIALOG_04")
msg("CHATHEDRAL56_MQ04_AG")
msg("CHATHEDRAL56_MQ05_select01")
msg("CHATHEDRAL54_MQ05_PART3_AG")
msg("CHATHEDRAL54_MQ04_PART2_add")
msg("CHATHEDRAL54_MQ04_PART2_AG")
msg("CHATHEDRAL54_MQ05_PART3_select01")
msg("CHATHEDRAL53_BISHOP_DIALOG02")
msg("CHATHEDRAL53_MQ_BISHOP_DIALOG_05")
msg("CHATHEDRAL54_MQ03_PART2_select")
msg("CHATHEDRAL54_MQ03_PART2_prog_startnpc01")
msg("CHATHEDRAL54_MQ04_PART2_select01")
msg("CHATHEDRAL56_MQ01_select01")
msg("CHATHEDRAL56_MQ01_prog_startnpc01")
msg("CHATHEDRAL56_MQ01_succ01")
msg("CHATHEDRAL56_MQ02_1_select01")
msg("CHATHEDRAL56_MQ02_1_prog_startnpc01")
msg("CHATHEDRAL56_MQ02_1_succ01")
msg("CHATHEDRAL56_MQ02_select01")
msg("CHATHEDRAL56_MQ02_prog_startnpc01")
msg("CHATHEDRAL56_MQ04_select01")
msg("CHATHEDRAL56_MQ01_startnpc01")
msg("CHATHEDRAL56_MQ03")
msg("CHATHEDRAL56_MQ06_select01")
msg("CHATHEDRAL56_BISHOP_DIALOG01")
msg("CHATHEDRAL56_BISHOP_DIALOG02")
msg("CHATHEDRAL56_BISHOP_DIALOG03")
msg("CHATHEDRAL56_BISHOP_DIALOG04")
msg("CHATHEDRAL56_BISHOP_DIALOG05")
msg("CHATHEDRAL56_BISHOP_DIALOG06")
msg("CHATHEDRAL56_BISHOP_DIALOG08")
msg("BISHOP_TRACK_DLG")
end

----- BOOK_01 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147311, "ETC_20150317_009230", "d_cathedral_54", 184, 3, 1075, 39, "npc_ETC_20150317_009230")
function npc_ETC_20150317_009230()
msg("CHATHEDRAL54_SQ01_PART1_BOOK1")
end

----- BOOK_02 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(153014, "ETC_20150323_010348", "d_cathedral_54", 109, 3, 1367, 103, "npc_ETC_20150323_010348")
function npc_ETC_20150323_010348()
msg("CHATHEDRAL54_SQ01_PART1_BOOK2")
end

----- BOOK_02 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(153014, "ETC_20150323_010348", "d_cathedral_54", 371, 3, 1333, 45, "npc_ETC_20150323_010348")
function npc_ETC_20150323_010348()
msg("CHATHEDRAL54_SQ01_PART1_BOOK3")
end

----- npc_aurelius ----- 
----- npcselectdialog.ies | ClassName: CHATHEDRAL54_BISHOP_AFTER -----
----- Dialog -----
----- QuestIDs: CHATHEDRAL54_MQ02_PART2 | CHATHEDRAL54_MQ03_PART2 | CHATHEDRAL54_MQ04_PART2 -----
addnpc(151033, "QUEST_LV_0200_20150317_000875", "d_cathedral_54", -1204, 4, 993, 41, "npc_QUEST_LV_0200_20150317_000875")
function npc_QUEST_LV_0200_20150317_000875()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_zacharial_desk ----- 
----- npcselectdialog.ies | ClassName: CHATHEDRAL54_MQ01_PUZZLE -----
----- Dialog -----
----- QuestIDs: CHATHEDRAL54_MQ01_PART1 -----
addnpc(47254, "ETC_20150323_010347", "d_cathedral_54", -1501, 25, -1050, 133, "npc_ETC_20150323_010347")
function npc_ETC_20150323_010347()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_zacharial_desk ----- 
----- npcselectdialog.ies | ClassName: CHATHEDRAL54_MQ06_BOOK -----
----- Dialog -----
----- QuestIDs: CHATHEDRAL54_MQ05_PART3 -----
addnpc(47254, "QUEST_LV_0200_20150323_003895", "d_cathedral_54", 1514, 0, -1900, 43, "npc_QUEST_LV_0200_20150323_003895")
function npc_QUEST_LV_0200_20150323_003895()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- noshadow_npc_16 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(151019, "ETC_20150317_005172", "d_cathedral_54", 1543, 0, -2296, 45, "npc_ETC_20150317_005172")
function npc_ETC_20150317_005172()
msg("CHATHEDRAL54_POTAL")
end

----- BOOK_02 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(153014, "ETC_20150323_010348", "d_cathedral_54", 334, 3, 855, 45, "npc_ETC_20150323_010348")
function npc_ETC_20150323_010348()
msg("CHATHEDRAL54_SQ01_PART1_BOOK4")
end

----- npc_paladinmaster_gate ----- 
----- npcselectdialog.ies | ClassName: MQ05_PROOF_PRIST -----
----- Dialog -----
----- QuestIDs: CHATHEDRAL54_MQ05_PART3 | CHATHEDRAL54_MQ06_PART3 | CATHEDRAL_TO_VELNIASPRISON -----
addnpc(103046, "QUEST_LV_0200_20150317_000953", "d_cathedral_54", 1590, 0, -1935, -47, "npc_QUEST_LV_0200_20150317_000953")
function npc_QUEST_LV_0200_20150317_000953()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "d_cathedral_54", -1354, 4, -736, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

