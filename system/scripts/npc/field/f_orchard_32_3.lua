----- npc_druid_leja ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_LEJA -----
----- Dialog -----
----- QuestIDs: ORCHARD_323_MQ_01 | ORCHARD_323_MQ_03 | ORCHARD_323_MQ_02 -----
addnpc(156003, "ETC_20151001_014956", "f_orchard_32_3", -1283, 1, -977, 0, "npc_ETC_20151001_014956")
function npc_ETC_20151001_014956()
msg("ORCHARD_323_MQ_01_start")
msg("ORCHARD_323_MQ_01_prog_start")
msg("ORCHARD_323_MQ_02_succ")
msg("ORCHARD_323_MQ_03_start")
msg("ORCHARD_323_MQ_03_agree")
msg("ORCHARD_323_MQ_01_AG")
msg("ORCHARD_342_MQ_01_succ")
msg("ORCHARD_342_MQ_02_start")
msg("ORCHARD_342_MQ_02_prog_start")
msg("ORCHARD_342_MQ_03_succ")
msg("ORCHARD_342_MQ_04_prog_start")
msg("ORCHARD_342_MQ_04_start")
msg("ORCHARD_342_MQ_04_succ")
msg("ORCHARD_342_MQ_05_prog_start")
msg("ORCHARD_342_MQ_05_start")
msg("ORCHARD_342_MQ_05_AG")
msg("ORCHARD_342_MQ_05_start_agree")
msg("ORCHARD323_LEJA_basic01")
msg("ORCHARD323_LEJA_basic02")
msg("ORCHARD342_LEJA_basic01")
msg("ORCHARD342_LEJA_basic02")
msg("ORCHARD342_LEJA_basic03")
msg("ORCHARD342_LEJA_basic04")
end

----- npc_village_male_b1 ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_GRANDSON -----
----- Dialog -----
----- QuestIDs: ORCHARD_323_SQ_04 -----
addnpc(147484, "ETC_20151001_015248", "f_orchard_32_3", -220, 1, 876, -45, "npc_ETC_20151001_015248")
function npc_ETC_20151001_015248()
msg("ORCHARD_323_SQ_04_start")
msg("ORCHARD_323_SQ_04_succ_start")
msg("ORCHARD323_GRANDSON_basic01")
msg("ORCHARD323_GRANDSON_basic02")
msg("ORCHARD323_GRANDSON_basic03")
msg("ORCHARD323_GRANDSON_basic04")
end

----- npc_oldman_1 ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_MAYOR -----
----- Enter | Dialog -----
----- QuestIDs: ORCHARD_323_MQ_04 | ORCHARD_323_MQ_05 | ORCHARD_323_MQ_06 | ORCHARD32_3_HQ1 -----
addnpc(152002, "ETC_20151001_015249", "f_orchard_32_3", -269, 1, 854, 45, "npc_ETC_20151001_015249")
function npc_ETC_20151001_015249()
msg("ORCHARD323_MAYOR_TRIGGER")
msg("ORCHARD323_HIDDENQ1_DLG1")
msg("ORCHARD323_HIDDENQ1_DLG2")
msg("ORCHARD32_3_HQ1_prog1")
msg("ORCHARD32_3_HQ1_succ1")
msg("ORCHARD32_3_HQ1_start1")
msg("ORCHARD_323_MQ_04_succ")
msg("ORCHARD_323_MQ_05_start")
msg("ORCHARD_323_MQ_05_prog_start")
msg("ORCHARD_323_MQ_05_succ")
msg("ORCHARD_323_MQ_06_start")
msg("ORCHARD_323_MQ_06_prog_start")
msg("ORCHARD_323_MQ_05_AG")
msg("ORCHARD_323_MQ_06_add")
msg("ORCHARD323_MAYOR_basic01")
msg("ORCHARD323_MAYOR_basic02")
msg("ORCHARD323_MAYOR_basic03")
msg("ORCHARD323_MAYOR_basic04")
msg("ORCHARD323_MAYOR_basic05")
msg("ORCHARD323_MAYOR_basic06")
msg("ORCHARD323_MAYOR_basic07")
msg("ORCHARD323_MAYOR_basic08")
end

----- old_well ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_WELL -----
----- Dialog -----
----- QuestIDs: ORCHARD_323_SQ_02 -----
addnpc(155009, "ETC_20150317_009351", "f_orchard_32_3", 179, 1, 621, 45, "npc_ETC_20150317_009351")
function npc_ETC_20150317_009351()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_village_female ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_PEOPLE -----
----- Dialog -----
----- QuestIDs: ORCHARD_323_SQ_03 | ORCHARD_323_SQ_01 | ORCHARD_323_SQ_02 -----
addnpc(147473, "ETC_20151001_015250", "f_orchard_32_3", -777, 1, 1068, 45, "npc_ETC_20151001_015250")
function npc_ETC_20151001_015250()
msg("TABLE72_PEAPLE3_BASIC01")
msg("TABLE72_PEAPLE2_BASIC01")
msg("TABLE72_PEAPLE4_BASIC01")
msg("TABLELAND_72_SQ3_startnpc1")
msg("TABLELAND_72_SQ3_startnpc2")
msg("TABLELAND_72_SQ3_prog1")
msg("TABLELAND_72_SQ3_succ01")
msg("TABLELAND_72_SQ3_succ02")
msg("TABLELAND_72_SQ4_startnpc1")
msg("TABLELAND_72_SQ4_startnpc_prog1")
msg("TABLELAND_72_SQ2_succ1")
msg("TABLELAND_72_SQ10_startnpc1")
msg("TABLELAND_72_SQ10_startnpc2")
msg("TABLELAND_72_SQ10_prog1")
msg("TABLELAND_72_SQ10_succ1")
msg("TABLELAND_72_SQ11_startnpc1")
msg("TABLELAND_72_SQ11_startnpc2")
msg("TABLELAND_72_SQ11_prog1")
msg("TABLELAND_72_SQ11_succ1")
msg("ABBEY353_HQ2_succ1")
msg("ORCHARD_323_SQ_01_start")
msg("ORCHARD_323_SQ_01_prog_start")
msg("ORCHARD_323_SQ_01_succ")
msg("ORCHARD_323_SQ_02_start")
msg("ORCHARD_323_SQ_02_prog_start")
msg("ORCHARD_323_SQ_03_start")
msg("ORCHARD_323_SQ_03_prog_start")
msg("ORCHARD_323_SQ_03_succ")
msg("ORCHARD_323_SQ_01_add")
msg("ORCHARD323_PEOPLE_basic01")
msg("ORCHARD323_PEOPLE_basic02")
msg("ORCHARD323_PEOPLE_basic03")
msg("ORCHARD323_PEOPLE_basic04")
msg("ABBEY_35_3_SQ_4_TRACK_1")
msg("SIAULIAI_35_1_SQ_13_start")
msg("SIAULIAI_35_1_SQ_13_progress")
msg("SIAULIAI_35_1_SQ_13_succ")
msg("ABBEY_35_3_SQ_3_start")
msg("ABBEY_35_3_SQ_3_progress")
msg("ABBEY_35_3_SQ_3_succ")
msg("ABBEY_35_3_SQ_4_start")
msg("ABBEY_35_3_SQ_4_succ")
msg("ABBEY_35_3_SQ_5_start")
msg("ABBEY_35_3_SQ_5_succ")
msg("ABBEY_35_3_SQ_5_progress")
msg("ABBEY_35_3_SQ_4_agree")
msg("SIAULIAI_35_1_VILLAGE_A_basic_01")
msg("SIAULIAI_35_1_VILLAGE_A_basic_02")
msg("ABBEY_35_3_SQ_5_add")
msg("ABBEY_35_3_VILLAGE_B_2_basic_1")
msg("ABBEY_35_3_VILLAGE_B_2_basic_2")
msg("SIAULIAI_35_1_VILLAGE_C_basic_01")
msg("SIAULIAI_35_1_VILLAGE_C_basic_02")
msg("SIAULIAI_35_1_VILLAGE_B_basic_01")
msg("SIAULIAI_35_1_VILLAGE_B_basic_02")
end

----- npc_dievdirbys_m ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_VYDAS -----
----- Dialog -----
----- QuestIDs: ORCHARD_323_SQ_04 | ORCHARD_323_SQ_05 -----
addnpc(156005, "ETC_20151001_015251", "f_orchard_32_3", -780, 1, 931, -45, "npc_ETC_20151001_015251")
function npc_ETC_20151001_015251()
msg("ORCHARD_323_SQ_04_succ")
msg("ORCHARD_323_SQ_05_start")
msg("ORCHARD_323_SQ_05_prog_start")
msg("ORCHARD_323_SQ_05_succ")
msg("ORCHARD323_VYDAS_basic01")
msg("ORCHARD323_VYDAS_basic02")
msg("ORCHARD323_VYDAS_basic03")
msg("ORCHARD323_VYDAS_basic04")
end

----- bube_flag1 ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_EVIL -----
----- Dialog -----
----- QuestIDs: ORCHARD_323_MQ_05 -----
addnpc(47150, "ETC_20151001_014711", "f_orchard_32_3", 392, 1, -252, 45, "npc_ETC_20151001_014711")
function npc_ETC_20151001_014711()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_huevill_male_1 ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_PRIEST -----
----- Dialog -----
addnpc(147407, "ETC_20151001_014705", "f_orchard_32_3", -537, 1, 919, 45, "npc_ETC_20151001_014705")
function npc_ETC_20151001_014705()
msg("TABLE72_PEAPLE1_1_BASIC01")
msg("TABLE72_PEAPLE1_1_BASIC02")
msg("TABLE72_PEAPLE1_1_BASIC03")
msg("TABLE72_PEAPLE5_DLG1")
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
msg("ORCHARD_324_SQ_01_start")
msg("ORCHARD_324_SQ_01_prog_start")
msg("ORCHARD_324_SQ_01_succ")
msg("ORCHARD_324_SQ_02_start")
msg("ORCHARD_324_SQ_02_prog_start")
msg("ORCHARD_324_SQ_02_succ")
msg("ORCHARD_324_SQ_03_start")
msg("ORCHARD_324_SQ_03_prog_start")
msg("ORCHARD_324_SQ_03_succ")
msg("ORCHARD_324_SQ_02_add")
msg("ORCHARD_323_MQ_04_track_01")
msg("ORCHARD_324_SQ_02_AG")
msg("ORCHARD_324_SQ_03_AG")
msg("ORCHARD323_PRIEST_basic01")
msg("ORCHARD323_PRIEST_basic02")
msg("ORCHARD324_PRIEST_basic01")
msg("ORCHARD324_PRIEST_basic02")
msg("ORCHARD323_PRIEST_basic03")
end

----- npc_huevill_male_2 ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_FUZE -----
----- Dialog -----
addnpc(147408, "QUEST_LV_0300_20151022_000659", "f_orchard_32_3", -564, 1, 1116, 135, "npc_QUEST_LV_0300_20151022_000659")
function npc_QUEST_LV_0300_20151022_000659()
msg("ORCHARD_324_SQ_04_start")
msg("ORCHARD_324_SQ_04_prog_start")
msg("ORCHARD323_FUZE_basic01")
msg("ORCHARD323_FUZE_basic02")
msg("ORCHARD324_FUZE_basic01")
msg("ORCHARD324_FUZE_basic02")
end

----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "f_orchard_32_3", -357, 1, 716, 45, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_F_ORCHARD_32_3")
end

----- id_gate_npc ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(154046, "QUEST_20150918_002405", "f_orchard_32_3", -631, 1, 1114, 45, "npc_QUEST_20150918_002405")
function npc_QUEST_20150918_002405()
msg("INSTANCE_DUNGEON_REMAINS_05")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "f_orchard_32_3", 156, 1, 627, -90, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

----- npc_huevill_male_3 ----- 
----- npcselectdialog.ies | ClassName: ORCHARD323_RP_1_NPC -----
----- Dialog -----
----- QuestIDs: ORCHARD323_RP_1 -----
addnpc(147409, "QUEST_LV_0100_20160718_015129", "f_orchard_32_3", 569, -87, 240, 45, "npc_QUEST_LV_0100_20160718_015129")
function npc_QUEST_LV_0100_20160718_015129()
msg("ORCHARD323_RP_1_NPC_basic1")
msg("ORCHARD323_RP_1_1")
msg("ORCHARD323_RP_1_2")
msg("ORCHARD323_RP_1_3")
end

