----- [Item Merchant]{nl} Mirina ----- 
----- npcselectdialog.ies | ClassName: EMILIA -----
----- Dialog -----
----- QuestIDs: JOB_SAPPER2_2 | JOB_DIEVDIRBYS3_1 | JOB_DIEVDIRBYS3_2 | JOB_DIEVDIRBYS3_3 | EAST_PREPARE_1 | EAST_PREPARE -----
addnpc(20115, "ETC_20150717_013603", "c_Klaipe", 510.7029, -1.292879, -349.3194, 45, "npc_itemmerchantmirina")
function npc_itemmerchantmirina()
--msg("KLAPEDA_Emilia_basic22")
--msg("Emilia_Select_2")
--msg("Emilia_Select_3")
msg("Emilia_Select_1")
openshop("Klapeda_Misc")
end

----- [Equipment Merchant]{nl} Dunkel ----- 
----- npcselectdialog.ies | ClassName: AKALABETH -----
----- Dialog -----
----- QuestIDs: JOB_SAPPER2_2 -----
addnpc(20111, "ETC_20150317_009196", "c_Klaipe", 394, -1, -475, 45, "npc_equipmentmerchantdunkel")
function npc_equipmentmerchantdunkel()
--msg("Akalabeth_Select_1")
--msg("KLAPEDA_Akalabeth_basic28")
--msg("Akalabeth_Select_2")
--msg("Akalabeth_Select_3")
local selection,i = nselect("KLAPEDA_Akalabeth_basic28", "weapon:@dicID_^*$ETC_20150317_004443$*^", "armor:@dicID_^*$ETC_20150317_004444$*^", "!@#$Auto_JongLyo#@!")

	if selection == "weapon" then
		openshop("Klapeda_Weapon")
	elseif selection == "armor" then
		openshop("Klapeda_Armor")
	end
end

----- [Accessory Merchant]{nl}Ronesa ----- 
----- npcselectdialog.ies | ClassName: ALFONSO -----
----- Enter | Dialog -----
----- QuestIDs: EAST_PREPARE_1 -----
addnpc(20104, "ETC_20150317_009197", "c_Klaipe", 268.7077, -1.343773, -610.9401, 45, "npc_accessorymerchantronesa")
function npc_accessorymerchantronesa()
--msg("Alfonso_Select_1")
--msg("Alfonso_Select_2")
--msg("Alfonso_Select_3")
msg("Alfonso_Select_1")
openshop("Klapeda_Accessory")
end

----- [Templar Master]{nl}Knight Commander Uska ----- 
----- npcselectdialog.ies | ClassName: KLAPEDA_USKA -----
----- Dialog -----
----- QuestIDs: KLAPEDA_GO_TO_EAST | CMINE6_TO_KATYN7_2 | JOB_PELTASTA2_2 | EAST_PREPARE | CMINE6_TO_KATYN7_3 | JOB_HIGHLANDER4_2 | JOB_HIGHLANDER4_3 | JOB_HIGHLANDER4_4 | JOB_TEMPLAR_7_1 | KATYN_14_HQ_01 | PARTY_Q_040 | PARTY_Q_042 | TABLELAND_70_SQ10 -----
addnpc(20113, "ETC_20151224_019888", "c_Klaipe", -467.28, 148.67, 114.01, 45, "ETC_20151224_019888_Call")
function ETC_20151224_019888_Call()
msg("ACT_KNIGHT_basic1")
msg("ACT_KNIGHT_basic2")
msg("ACT_KNIGHT_basic3")
end

----- [Cleric Master]{nl} Rozalija ----- 
----- npcselectdialog.ies | ClassName: MASTER_CLERIC -----
----- Dialog -----
----- QuestIDs: JOB_CLERIC1 | TUTO_CLERIC_TECH | JOB_SAPPER2_3 | JOB_CLERIC2_1 | JOB_CLERIC2_2 | JOB_CLERIC3_1 | JOB_KRIVI4_3 | JOB_DIEVDIRBYS4_1 | JOB_DIEVDIRBYS4_2 | JOB_CLERIC4_1 | JOB_CLERIC4_3 | JOB_CLERIC5_1 | KATYN_13_2_HQ_04 | PILGRIM51_SQ_5 | PILGRIM51_SQ_5_0 | FLASH_58_SQ_030 -----
addnpc(20112, "ETC_20150317_009207", "c_Klaipe", -400.58, 148.78, 207.72, -43.99, "ETC_20150317_009207_Call")
function ETC_20150317_009207_Call()
msg("MASTER_CLERIC_basic03")
msg("MASTER_CLERIC_basic01")
msg("MASTER_CLERIC_basic02")
msg("MASTER_CLERIC_basic04")
end

----- Klaipeda Resident ----- 
----- npcselectdialog.ies | ClassName: ACT_VILLAGERS -----
----- Dialog -----
addnpc(20158, "QUEST_LV_0100_20150317_000413", "c_Klaipe", -9, 156, 131, -23.96, "QUEST_LV_0100_20150317_000413_Call")
function QUEST_LV_0100_20150317_000413_Call()
msg("KLAPEDA_Villagers_basic11")
msg("KLAPEDA_Villagers_basic12")
msg("KLAPEDA_Villagers_basic13")
msg("KLAPEDA_Villagers_basic14")
msg("KLAPEDA_Villagers_basic15")
msg("KLAPEDA_Villagers_basic16")
msg("KLAPEDA_Villagers_basic17")
msg("KLAPEDA_Villagers_basic18")
msg("KLAPEDA_Villagers_basic19")
msg("KLAPEDA_Villagers_basic20")
msg("KLAPEDA_Villagers_basic21")
msg("KLAPEDA_Villagers_basic22")
end

----- Mother of a Soldier ----- 
----- npcselectdialog.ies | ClassName: ACT_SMOM -----
----- Dialog -----
addnpc(20114, "QUEST_LV_0100_20150317_000423", "c_Klaipe", -60, 148, 42, 36.57, "QUEST_LV_0100_20150317_000423_Call")
function QUEST_LV_0100_20150317_000423_Call()
msg("KLAPEDA_Smom_basic1")
msg("KLAPEDA_Smom_basic2")
msg("KLAPEDA_Smom_basic3")
msg("KLAPEDA_Smom_basic4")
msg("KLAPEDA_Smom_basic5")
msg("KLAPEDA_Smom_basic6")
msg("KLAPEDA_Smom_basic7")
end

----- [Priest Master]{nl} Boruble ----- 
----- npcselectdialog.ies | ClassName: MASTER_PRIEST -----
----- Dialog -----
----- QuestIDs: JOB_PRIEST1 | JOB_PRIEST2_1 | JOB_CLERIC2_1 | JOB_PRIEST3_1 | JOB_KRIVI4_1 | JOB_PRIEST4_1 | JOB_DIEVDIRBYS4_3 | JOB_DIEVDIRBYS4_4 | JOB_KRIVI4_2 | JOB_PRIEST5_1 | PILGRIM51_SQ_2_1 | PILGRIM51_SQ_2_2 | ABBEY_35_4_SQ_5 -----
addnpc(57229, "ETC_20150317_009208", "c_Klaipe", -196.47, 148.83, 350.73, -45, "ETC_20150317_009208_Call")
function ETC_20150317_009208_Call()
msg("MASTER_PRIEST_basic2")
msg("MASTER_PRIEST_basic1")
msg("MASTER_PRIEST_basic3")
msg("MASTER_PRIEST_basic4")
end

----- Bulletin Board ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40090, "QUEST_20150317_000081", "c_Klaipe", -80, 148, 387, -15, "QUEST_20150317_000081_Call")
function QUEST_20150317_000081_Call()
msg("KLAPEDA_SIGN9")
end

----- [Blacksmith]{nl} Zaras ----- 
----- npcselectdialog.ies | ClassName: BLACKSMITH -----
----- Enter | Dialog -----
----- QuestIDs: ROKAS29_VACYS8 | ROKAS29_VACYS7 | REMAINS37_2_SQ_031 | REMAINS37_2_SQ_032 -----
addnpc(20105, "ETC_20150317_009199", "c_Klaipe", 600, -1, -83, 45, "ETC_20150317_009199_Call")
function ETC_20150317_009199_Call()
msg("TUTO_REPAIR_NPC")
msg("KLAPEDA_Smith_basic1")
msg("KLAPEDA_Smith_basic2")
msg("KLAPEDA_Smith_basic3")
end

----- [Krivis Master]{nl} Herkus ----- 
----- npcselectdialog.ies | ClassName: MASTER_KRIWI -----
----- Dialog -----
----- QuestIDs: JOB_KRIWI1 | JOB_KRIWI1_1 | JOB_KRIVI2_1 | JOB_CLERIC2_1 | JOB_KRIVI3_1 | JOB_KRIVI4_1 | JOB_KRIVI4_3 | JOB_BOCOR4_1 | JOB_BOCOR4_2 | JOB_BOCOR4_3 | JOB_BOCOR4_4 | JOB_DIEVDIRBYS4_2 | JOB_DIEVDIRBYS4_3 | JOB_KRIVI5_1 -----
addnpc(57228, "ETC_20150317_009209", "c_Klaipe", -775.11, 240.39, 525.74, -45, "ETC_20150317_009209_Call")
function ETC_20150317_009209_Call()
msg("MASTER_KRIWI_basic2")
msg("MASTER_KRIWI_basic1")
msg("MASTER_KRIWI_basic3")
end

----- Indifferent Widow ----- 
----- npcselectdialog.ies | ClassName: TUTO_GIRL -----
----- Dialog -----
addnpc(20114, "QUEST_20150317_000083", "c_Klaipe", -409, -1, -647, -47.29, "npc_indifferentwidow")
function npc_indifferentwidow()
	if select("TUTO_GIRL_basic_02", "!@#$TUTO_GIRL_select01#@!", "!@#$Auto_JongLyo#@!") ~= 1 then
		return
	end
	if select("TUTO_GIRL_basic_03", "!@#$TUTO_GIRL_select02#@!", "!@#$Auto_JongLyo#@!") ~= 1 then
		return
	end
	if select("TUTO_GIRL_basic_04", "!@#$TUTO_GIRL_select03#@!", "!@#$Auto_JongLyo#@!") ~= 1 then
		return
	end

	msg("TUTO_GIRL_basic_05")
end

----- Refugee ----- 
----- npcselectdialog.ies | ClassName: KLAPEDA_NPC_14 -----
----- Dialog -----
addnpc(20139, "QUEST_LV_0100_20150317_001418", "c_Klaipe", -60, 79, -446, -33.69, "QUEST_LV_0100_20150317_001418_Call")
function QUEST_LV_0100_20150317_001418_Call()
msg("KLAPEDA_NPC_14_basic01")
msg("KLAPEDA_NPC_14_basic02")
msg("KLAPEDA_NPC_14_basic03")
end

----- [Market Manager]{nl} Logi ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Enter | Dialog -----
addnpc(20169, "ETC_20150317_009211", "c_Klaipe", 278, 79, 137, 45, "ETC_20150317_009211_Call")
function ETC_20150317_009211_Call()
msg("TUTO_MARKET_NPC")
msg("KLAPEDA_MARKET_SEL")
end

----- [Peltasta Master]{nl} Maria Leed ----- 
----- npcselectdialog.ies | ClassName: MASTER_PELTASTA -----
----- Dialog -----
----- QuestIDs: JOB_PELTASTA1 | JOB_HIGHLANDER2_1 | JOB_PELTASTA2_1 | JOB_PELTASTA3_1 | JOB_HIGHLANDER4_1 | JOB_HIGHLANDER4_2 | JOB_PELTASTA4_1 | JOB_PELTASTA4_4 | JOB_PELTASTA5_1 | JOB_PELTASTA2_2 -----
addnpc(20028, "ETC_20150317_009200", "c_Klaipe", -225, 97, -385, -55, "ETC_20150317_009200_Call")
function ETC_20150317_009200_Call()
msg("MASTER_PELTASTA_basic1")
msg("MASTER_PELTASTA_basic2")
msg("MASTER_PELTASTA_basic3")
msg("MASTER_PELTASTA_basic4")
end

----- [Cryomancer Master]{nl}Aleister Crowley ----- 
----- npcselectdialog.ies | ClassName: MASTER_ICEMAGE -----
----- Dialog -----
----- QuestIDs: JOB_ICEMAGE1 | JOB_CRYOMANCER2_1 | JOB_CRYOMANCER2_2 | JOB_CRYOMANCER3_1 | JOB_CRYOMANCER4_1 | JOB_CRYOMANCER5_1 | SIAULIAI_50_1_SQ_090 | PARTY_Q_070 -----
addnpc(20137, "ETC_20151224_019889", "c_Klaipe", -205, 79, -515, 51.17, "ETC_20151224_019889_Call")
function ETC_20151224_019889_Call()
msg("MASTER_ICEMAGE_basic1")
msg("MASTER_ICEMAGE_basic2")
msg("MASTER_ICEMAGE_basic3")
end

----- [Quarrel Shooter Master]{nl}Ream Toiler ----- 
----- npcselectdialog.ies | ClassName: MASTER_QU -----
----- Dialog -----
----- QuestIDs: JOB_QUARRELSHOOTER1 | JOB_HUNTER2_2 | JOB_QUARREL2_1 | JOB_QUARREL2_2 | JOB_QUARREL2_3 | JOB_QUARREL2_4 | JOB_ARCHER2_3 | JOB_RANGER2_3 | JOB_QUARREL3_1 | JOB_QUARREL3_2 | JOB_QUARREL4_1 | JOB_QUARREL5_1 -----
addnpc(147445, "ETC_20150317_009202", "c_Klaipe", -461, 240, 743, -48.73, "ETC_20150317_009202_Call")
function ETC_20150317_009202_Call()
msg("MASTER_QU_basic2")
msg("MASTER_QU_basic1")
msg("MASTER_QU_basic3")
msg("MASTER_QU_basic4")
end

----- [Ranger Master]{nl} Nemoken ----- 
----- npcselectdialog.ies | ClassName: MASTER_RANGER -----
----- Dialog -----
----- QuestIDs: JOB_HUNTER1 | JOB_HUNTER2_4 | JOB_QUARREL2_4 | JOB_ARCHER2_4 | JOB_RANGER2_1 | JOB_RANGER2_2 | JOB_RANGER2_3 | JOB_RANGER2_4 | JOB_RANGER2_5 | JOB_RANGER3_1 | JOB_RANGER3_2 | JOB_RANGER4_1 | JOB_RANGER5_1 | SIAULIAI_50_1_SQ_050 | SIAULIAI_50_1_SQ_060 | KATYN_45_3_SQ_15 -----
addnpc(147343, "ETC_20150317_009203", "c_Klaipe", -488.78, 148.61, 27, 51.17, "ETC_20150317_009203_Call")
function ETC_20150317_009203_Call()
msg("MASTER_RANGER_basic2")
msg("MASTER_RANGER_basic1")
msg("MASTER_RANGER_basic3")
msg("MASTER_RANGER_basic4")
end

----- [Swordsman Master]{nl}Rashua ----- 
----- npcselectdialog.ies | ClassName: MASTER_SWORDMAN -----
----- Dialog -----
----- QuestIDs: TUTO_SWORDMAN_TECH | JOB_SWORDMAN1 | JOB_WARRIOR2_1 | JOB_WARRIOR3_1 | JOB_SWORDMAN4_1 | JOB_SWORDMAN5_1 | KATYN_13_2_HQ_01 -----
addnpc(20023, "ETC_20150317_009204", "c_Klaipe", -295, 240, 790, 45, "ETC_20150317_009204_Call")
function ETC_20150317_009204_Call()
msg("MASTER_SWORDMAN_basic2")
msg("MASTER_SWORDMAN_basic1")
msg("MASTER_SWORDMAN_basic3")
msg("MASTER_SWORDMAN_basic4")
end

----- [Wizard Master]{nl}Lucia ----- 
----- npcselectdialog.ies | ClassName: MASTER_WIZARD -----
----- Dialog -----
----- QuestIDs: TUTO_WIZARD_TECH | JOB_WIZARD1 | JOB_WIZARD2_1 | JOB_WIZARD2_2 | JOB_WIZARD3_1 | JOB_WIZARD3_2 | JOB_WIZARD4_1 | JOB_WIZARD5_1 | KATYN_13_2_HQ_02 -----
addnpc(20021, "ETC_20150317_009205", "c_Klaipe", -100, 96, -275, -45, "ETC_20150317_009205_Call")
function ETC_20150317_009205_Call()
msg("MASTER_WIZARD_basic2")
msg("MASTER_WIZARD_basic1")
msg("MASTER_WIZARD_basic3")
msg("MASTER_WIZARD_basic4")
end

----- [Archer Master]{nl} Edmundas Tiller ----- 
----- npcselectdialog.ies | ClassName: MASTER_ARCHER -----
----- Dialog -----
----- QuestIDs: TUTO_ARCHER_TECH | JOB_ARCHER1 | JOB_HUNTER2_3 | JOB_QUARREL2_3 | JOB_ARCHER2_1 | JOB_ARCHER2_2 | JOB_ARCHER2_3 | JOB_ARCHER2_4 | JOB_RANGER2_4 | JOB_ARCHER3_1 | JOB_ARCHER3_3 | JOB_ARCHER4_1 | JOB_ARCHER4_3 | JOB_ARCHER5_1 | KATYN_13_2_HQ_03 -----
addnpc(147447, "ETC_20150317_009206", "c_Klaipe", -835, 240, 245, -45, "ETC_20150317_009206_Call")
function ETC_20150317_009206_Call()
msg("MASTER_ARCHER_basic2")
msg("MASTER_ARCHER_basic1")
msg("MASTER_ARCHER_basic3")
msg("MASTER_ARCHER_basic4")
end

----- Bulletin Board ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -66, -1, -752, -47.99, "QUEST_20150317_000081_Call")
function QUEST_20150317_000081_Call()
msg("KLAPEDA_SIGN30")
end

----- Bulletin Board ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", 195, -1, -641, -33.69, "QUEST_20150317_000081_Call")
function QUEST_20150317_000081_Call()
msg("KLAPEDA_SIGN31")
end

----- Bulletin Board ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", 58, 79, -359, -11.66, "QUEST_20150317_000081_Call")
function QUEST_20150317_000081_Call()
msg("KLAPEDA_SIGN32")
end

----- Bulletin Board ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -63, 148, -108, 37.87, "QUEST_20150317_000081_Call")
function QUEST_20150317_000081_Call()
msg("KLAPEDA_SIGN33")
end

----- Bulletin Board ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -165, -1, -958, 18.43, "QUEST_20150317_000081_Call")
function QUEST_20150317_000081_Call()
msg("KLAPEDA_SIGN_WELCOME")
end

----- Signboard ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000821", "c_Klaipe", 744, -1, 192, -81.23, "QUEST_20150317_000821_Call")
function QUEST_20150317_000821_Call()
msg("KLAPEDA_SIGN35")
end

----- About the Goddess Statue ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150729_002302", "c_Klaipe", -125, 148, -11, -3.009998, "QUEST_20150729_002302_Call")
function QUEST_20150729_002302_Call()
msg("KLAPEDA_SIGN36")
end

----- Holiday Notice ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000830", "c_Klaipe", 617, -1, 61, 45, "QUEST_20150317_000830_Call")
function QUEST_20150317_000830_Call()
msg("KLAPEDA_BOARD_01")
end

----- Lyliana ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_3_KLAIPEDA_NPC -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_3_HQ_01 -----
addnpc(147473, "QUEST_LV_0100_20150317_002150", "c_Klaipe", 615.23, -1.35, 132.44, 45, "QUEST_LV_0100_20150317_002150_Call")
function QUEST_LV_0100_20150317_002150_Call()
msg("HUEVILLAGE_58_3_KLAIPEDA_NPC_basic01")
msg("HUEVILLAGE_58_3_KLAIPEDA_NPC_basic02")
msg("HUEVILLAGE_58_3_KLAIPEDA_NPC_basic03")
msg("HUEVILLAGE_58_3_KLAIPEDA_NPC_basic04")
end

----- [Companion Trader]{nl}Christina ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(153005, "ETC_20150317_009212", "c_Klaipe", 6, -1, -760, 315, "ETC_20150317_009212_Call")
function ETC_20150317_009212_Call()
msg("PETSHOP_KLAIPE_basic1")
end

----- Velheider ----- 
addnpc(47521, "ETC_20150317_007299", "c_Klaipe", -22, -1, -757, 315, "npc_dummy")

----- [Wings of Vaivora]{nl}Lena ----- 
----- npcselectdialog.ies | ClassName: JOURNEY_SHOP -----
----- Enter | Dialog -----
----- QuestIDs: REMAINS37_2_SQ_070 -----
addnpc(152005, "ETC_20150317_009214", "c_Klaipe", 68.44363, 148.8388, 485.8954, -59, "ETC_20150317_009214_Call")
function ETC_20150317_009214_Call()
msg("TUTO_JOURNAL_NPC")
msg("RENA_BASIC01")
end

----- [Klaipeda's Magic Association]{nl}Henrika ----- 
addnpc(152004, "ETC_20150317_009215", "c_Klaipe", -345.0014, 148.8224, 283.8124, 0, "npc_dummy")

----- [Storage Keeper]{nl}Rita ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Enter | Dialog -----
addnpc(154018, "ETC_20150414_011199", "c_Klaipe", 262.0322, 79.47649, 233.2017, 45, "ETC_20150414_011199_Call")
function ETC_20150414_011199_Call()
msg("TUTO_STORAGE_NPC")
msg("WAREHOUSE_FEDIMIAN_DLG")
end

----- [Oracle Master]{nl}Apolonjia Barbora ----- 
----- npcselectdialog.ies | ClassName: MASTER_ORACLE -----
----- Dialog -----
----- QuestIDs: JOB_ORACLE5_1 | JOB_ORACLE_6_1 -----
addnpc(57224, "ETC_20150414_011198", "c_Klaipe", -893.4678, 240.3878, 74.93089, 45, "ETC_20150414_011198_Call")
function ETC_20150414_011198_Call()
msg("MASTER_ORACLE_NORMAL_2_SELECT")
msg("MASTER_ORACLE_basic01")
msg("MASTER_ORACLE_basic02")
msg("MASTER_ORACLE_basic03")
end

----- Statue of Goddess Ausrine ----- 
----- npcselectdialog.ies | ClassName: WARP_C_KLAIPE -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 | EAST_PREPARE -----
addnpc(154039, "ETC_20150317_007031", "c_Klaipe", -206.574, 148.8251, 98.63973, 0, "npc_dummy")

----- [TP Trader]{nl} Leticia ----- 
----- npcselectdialog.ies | ClassName: TP_NPC -----
----- Enter | Dialog -----
addnpc(20068, "ETC_20151224_019887", "c_Klaipe", 285, 79, 78, 45, "ETC_20151224_019887_Call")
function ETC_20151224_019887_Call()
msg("TUTO_TPSHOP_NPC")
msg("TP_NPC_basic01")
msg("TP_NPC_basic02")
end

addnpc(20164, "QUEST_20150317_000127", "c_Klaipe", -225.8313, -1.3338, -848.0712, 45, "npc_klaipedagirl")
--- Klaipeda Girl
-- Uses one of two random dialogues.
function npc_klaipedagirl()
	if math.random(2) == 1 then
		msg("KLAFEDA_NPC_05_basic01")
	else
		msg("KLAFEDA_NPC_05_basic02")
	end
end

addnpc(20147, "QUEST_20150317_000382", "c_Klaipe", -107.036, -1.3438, -749.1073, 135, "npc_worriedwife")
--- Worried Wife
-- Tells stories about the various goddesses.
function npc_worriedwife()
	if select("KLAPEDA_NPC_04_basic01", "!@#$Auto_KLAPEDA_NPC_04_S1#@!", "!@#$Auto_SinKyeongSseuJi_anNeunDa#@!") ~= 1 then
		return
	end

	local selection;
	while selection ~= "leave" do
		-- Select goddess
		selection = nselect("KLAPEDA_NPC_04_basic02",
			"ausrine:!@#$Auto_KLAPEDA_NPC_04_S2#@!",
			"laima:!@#$Auto_KLAPEDA_NPC_04_S3#@!",
			"gabija:!@#$Auto_KLAPEDA_NPC_04_S4#@!",
			"zemyna:!@#$Auto_KLAPEDA_NPC_04_S5#@!",
			"vakarine:!@#$Auto_KLAPEDA_NPC_04_S6#@!",
			"leave:!@#$Auto_TteoNanDa#@!"
		)

		-- Info about selected goddess
		if selection == "ausrine" then
			msg("KLAPEDA_NPC_04_basic03")
		elseif selection == "laima" then
			msg("KLAPEDA_NPC_04_basic04")
		elseif selection == "gabija" then
			msg("KLAPEDA_NPC_04_basic05")
		elseif selection == "zemyna" then
			msg("KLAPEDA_NPC_04_basic06")
		elseif selection == "vakarine" then
			msg("KLAPEDA_NPC_04_basic07")
		end
	end
end