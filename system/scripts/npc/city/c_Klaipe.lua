--- [Item Merchant] Mirina --- 
--- npcselectdialog.ies | ClassName: EMILIA ---
--- QuestIDs: JOB_SAPPER2_2 | JOB_DIEVDIRBYS3_1 | JOB_DIEVDIRBYS3_2 | JOB_DIEVDIRBYS3_3 | EAST_PREPARE_1 | EAST_PREPARE ---
addnpc(20115, "ETC_20150717_013603", "c_Klaipe", 511, -1, -349, 45, "npc_itemmerchantmirina")
function npc_itemmerchantmirina()
	msg("Emilia_Select_1")
	openshop("Klapeda_Misc")
end

--- [Equipment Merchant] Dunkel --- 
--- npcselectdialog.ies | ClassName: AKALABETH ---
--- QuestIDs: JOB_SAPPER2_2 ---
addnpc(20111, "ETC_20150317_009196", "c_Klaipe", 394, -1, -475, 45, "npc_equipmentmerchantdunkel")
function npc_equipmentmerchantdunkel()
	local selection,i = nselect("KLAPEDA_Akalabeth_basic28", "weapon:@dicID_^*$ETC_20150317_004443$*^", "armor:@dicID_^*$ETC_20150317_004444$*^", "!@#$Auto_JongLyo#@!")

	if selection == "weapon" then
		openshop("Klapeda_Weapon")
	elseif selection == "armor" then
		openshop("Klapeda_Armor")
	end
end

--- [Accessory Merchant]Ronesa --- 
--- npcselectdialog.ies | ClassName: ALFONSO ---
--- QuestIDs: EAST_PREPARE_1 ---
addnpc(20104, "ETC_20150317_009197", "c_Klaipe", 269, -1, -611, 45, "npc_accessorymerchantronesa")
function npc_accessorymerchantronesa()
	msg("Alfonso_Select_1")
	openshop("Klapeda_Accessory")
end

--- Indifferent Widow --- 
--- npcselectdialog.ies | ClassName: TUTO_GIRL ---
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

--- [Templar Master]Knight Commander Uska --- 
--- npcselectdialog.ies | ClassName: KLAPEDA_USKA ---
--- QuestIDs: KLAPEDA_GO_TO_EAST | CMINE6_TO_KATYN7_2 | JOB_PELTASTA2_2 | EAST_PREPARE | CMINE6_TO_KATYN7_3 | JOB_HIGHLANDER4_2 | JOB_HIGHLANDER4_3 | JOB_HIGHLANDER4_4 | JOB_TEMPLAR_7_1 | JOB_TEMPLAR_8_1 | KATYN_14_HQ_01 | PARTY_Q_040 | PARTY_Q_042 | TABLELAND_70_SQ10 | WHITETREES56_1_SQ10 ---
addnpc(20113, "ETC_20151224_019888", "c_Klaipe", -474, 149, 82, 360, "npc_dummy")

--- [Cleric Master] Rozalija --- 
--- npcselectdialog.ies | ClassName: MASTER_CLERIC ---
--- QuestIDs: JOB_CLERIC1 | TUTO_CLERIC_TECH | JOB_SAPPER2_3 | JOB_CLERIC2_1 | JOB_CLERIC2_2 | JOB_CLERIC3_1 | JOB_KRIVI4_3 | JOB_DIEVDIRBYS4_1 | JOB_DIEVDIRBYS4_2 | JOB_CLERIC4_1 | JOB_CLERIC4_3 | JOB_CLERIC5_1 | KATYN_13_2_HQ_04 | PILGRIM51_SQ_5 | PILGRIM51_SQ_5_0 | FLASH_58_SQ_030 ---
addnpc(20112, "ETC_20150317_009207", "c_Klaipe", -409, 149, 174, 360, "npc_dummy")

--- Klaipeda Resident --- 
--- npcselectdialog.ies | ClassName: ACT_VILLAGERS ---
addnpc(20158, "QUEST_LV_0100_20150317_000413", "c_Klaipe", -9, 156, 131, -23.96, "npc_dummy")

--- Mother of a Soldier --- 
--- npcselectdialog.ies | ClassName: ACT_SMOM ---
addnpc(20114, "QUEST_LV_0100_20150317_000423", "c_Klaipe", -60, 148, 42, 36.57, "npc_dummy")

--- [Priest Master] Boruble --- 
--- npcselectdialog.ies | ClassName: MASTER_PRIEST ---
--- QuestIDs: JOB_PRIEST1 | JOB_PRIEST2_1 | JOB_CLERIC2_1 | JOB_PRIEST3_1 | JOB_KRIVI4_1 | JOB_PRIEST4_1 | JOB_DIEVDIRBYS4_3 | JOB_DIEVDIRBYS4_4 | JOB_KRIVI4_2 | JOB_PRIEST5_1 | PILGRIM51_SQ_2_1 | PILGRIM51_SQ_2_2 | ABBEY_35_4_SQ_5 | CATACOMB_25_4_SQ_90 | THORN22_HQ1 ---
addnpc(57229, "ETC_20150317_009208", "c_Klaipe", -196, 149, 351, -45, "npc_dummy")

--- Bulletin Board --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40090, "QUEST_20150317_000081", "c_Klaipe", -80, 148, 387, -15, "npc_dummy")

--- [Blacksmith] Zaras --- 
--- npcselectdialog.ies | ClassName: BLACKSMITH ---
--- QuestIDs: ROKAS29_VACYS8 | ROKAS29_VACYS7 | REMAINS37_2_SQ_031 | REMAINS37_2_SQ_032 ---
addnpc(20105, "ETC_20150317_009199", "c_Klaipe", 600, -1, -83, 45, "npc_dummy")

--- [Krivis Master] Herkus --- 
--- npcselectdialog.ies | ClassName: MASTER_KRIWI ---
--- QuestIDs: JOB_KRIWI1 | JOB_KRIWI1_1 | JOB_KRIVI2_1 | JOB_CLERIC2_1 | JOB_KRIVI3_1 | JOB_KRIVI4_1 | JOB_KRIVI4_3 | JOB_BOCOR4_1 | JOB_BOCOR4_2 | JOB_BOCOR4_3 | JOB_BOCOR4_4 | JOB_DIEVDIRBYS4_2 | JOB_DIEVDIRBYS4_3 | JOB_KRIVI5_1 ---
addnpc(57228, "ETC_20150317_009209", "c_Klaipe", -1108, 240, 512, 360, "npc_dummy")

--- Refugee --- 
--- npcselectdialog.ies | ClassName: KLAPEDA_NPC_14 ---
addnpc(20139, "QUEST_LV_0100_20150317_001418", "c_Klaipe", -60, 79, -446, -33.69, "npc_dummy")

--- [Market Manager] Logi --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(20169, "ETC_20150317_009211", "c_Klaipe", 278, 79, 137, 45, "npc_dummy")

--- [Peltasta Master]Maria Leed --- 
--- npcselectdialog.ies | ClassName: MASTER_PELTASTA ---
--- QuestIDs: JOB_PELTASTA1 | JOB_HIGHLANDER2_1 | JOB_PELTASTA2_1 | JOB_PELTASTA3_1 | JOB_HIGHLANDER4_1 | JOB_HIGHLANDER4_2 | JOB_PELTASTA4_1 | JOB_PELTASTA4_4 | JOB_PELTASTA5_1 | JOB_PELTASTA2_2 ---
addnpc(20028, "ETC_20150317_009200", "c_Klaipe", -225, 97, -385, -55, "npc_dummy")

--- [Cryomancer Master] Aleister Crowley --- 
--- npcselectdialog.ies | ClassName: MASTER_ICEMAGE ---
--- QuestIDs: JOB_ICEMAGE1 | JOB_CRYOMANCER2_1 | JOB_CRYOMANCER2_2 | JOB_CRYOMANCER3_1 | JOB_CRYOMANCER4_1 | JOB_CRYOMANCER5_1 | SIAULIAI_50_1_SQ_090 | PARTY_Q_070 ---
addnpc(20137, "ETC_20151224_019889", "c_Klaipe", -205, 79, -515, 51.17, "npc_dummy")

--- [Quarrel Shooter Master]Ream Toiler --- 
--- npcselectdialog.ies | ClassName: MASTER_QU ---
--- QuestIDs: JOB_QUARRELSHOOTER1 | JOB_HUNTER2_2 | JOB_QUARREL2_1 | JOB_QUARREL2_2 | JOB_QUARREL2_3 | JOB_QUARREL2_4 | JOB_ARCHER2_3 | JOB_RANGER2_3 | JOB_QUARREL3_1 | JOB_QUARREL3_2 | JOB_QUARREL4_1 | JOB_QUARREL5_1 ---
addnpc(147445, "ETC_20150317_009202", "c_Klaipe", -236, 241, 867, 270, "npc_dummy")

--- [Ranger Master] Nemoken --- 
--- npcselectdialog.ies | ClassName: MASTER_RANGER ---
--- QuestIDs: JOB_HUNTER1 | JOB_HUNTER2_4 | JOB_QUARREL2_4 | JOB_ARCHER2_4 | JOB_RANGER2_1 | JOB_RANGER2_2 | JOB_RANGER2_3 | JOB_RANGER2_4 | JOB_RANGER2_5 | JOB_RANGER3_1 | JOB_RANGER3_2 | JOB_RANGER4_1 | JOB_RANGER5_1 | SIAULIAI_50_1_SQ_050 | SIAULIAI_50_1_SQ_060 | KATYN_45_3_SQ_15 ---
addnpc(147343, "ETC_20150317_009203", "c_Klaipe", -489, 149, 27, 51.17, "npc_dummy")

--- [Swordsman Master]Rashua --- 
--- npcselectdialog.ies | ClassName: MASTER_SWORDMAN ---
--- QuestIDs: TUTO_SWORDMAN_TECH | JOB_SWORDMAN1 | JOB_WARRIOR2_1 | JOB_WARRIOR3_1 | JOB_SWORDMAN4_1 | JOB_SWORDMAN5_1 | KATYN_13_2_HQ_01 ---
addnpc(20023, "ETC_20150317_009204", "c_Klaipe", -92, 241, 784, 270, "npc_dummy")

--- [Wizard Master]Lucia --- 
--- npcselectdialog.ies | ClassName: MASTER_WIZARD ---
--- QuestIDs: TUTO_WIZARD_TECH | JOB_WIZARD1 | JOB_WIZARD2_1 | JOB_WIZARD2_2 | JOB_WIZARD3_1 | JOB_WIZARD3_2 | JOB_WIZARD4_1 | JOB_WIZARD5_1 | KATYN_13_2_HQ_02 ---
addnpc(20021, "ETC_20150317_009205", "c_Klaipe", -100, 96, -275, -45, "npc_dummy")

--- [Archer Master] Edmundas Tiller --- 
--- npcselectdialog.ies | ClassName: MASTER_ARCHER ---
--- QuestIDs: TUTO_ARCHER_TECH | JOB_ARCHER1 | JOB_HUNTER2_3 | JOB_QUARREL2_3 | JOB_ARCHER2_1 | JOB_ARCHER2_2 | JOB_ARCHER2_3 | JOB_ARCHER2_4 | JOB_RANGER2_4 | JOB_ARCHER3_1 | JOB_ARCHER3_3 | JOB_ARCHER4_1 | JOB_ARCHER4_3 | JOB_ARCHER5_1 | KATYN_13_2_HQ_03 ---
addnpc(147447, "ETC_20150317_009206", "c_Klaipe", -949, 241, 308, 360, "npc_dummy")

--- Bulletin Board --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -66, -1, -752, -47.99, "npc_dummy")

--- Bulletin Board --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", 195, -1, -641, -33.69, "npc_dummy")

--- Bulletin Board --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", 58, 79, -359, -11.66, "npc_dummy")

--- Bulletin Board --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -63, 148, -108, 37.87, "npc_dummy")

--- Bulletin Board --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -165, -1, -958, 18.43, "npc_dummy")

--- Signboard --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40070, "QUEST_20150317_000821", "c_Klaipe", 744, -1, 192, -81.23, "npc_dummy")

--- About the Goddess Statue --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40070, "QUEST_20150729_002302", "c_Klaipe", -125, 148, -11, -3.009998, "npc_dummy")

--- Holiday Notice --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40070, "QUEST_20150317_000830", "c_Klaipe", 617, -1, 61, 45, "npc_dummy")

--- Lyliana --- 
--- npcselectdialog.ies | ClassName: HUEVILLAGE_58_3_KLAIPEDA_NPC ---
--- QuestIDs: HUEVILLAGE_58_3_HQ_01 ---
addnpc(147473, "QUEST_LV_0100_20150317_002150", "c_Klaipe", 615, -1, 132, 45, "npc_dummy")

--- [Companion Trader]Christina --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(153005, "ETC_20150317_009212", "c_Klaipe", 6, -1, -760, 315, "npc_dummy")

--- Velheider --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(47521, "ETC_20150317_007299", "c_Klaipe", -22, -1, -757, 315, "npc_dummy")

--- [Wings of Vaivora]Lena --- 
--- npcselectdialog.ies | ClassName: JOURNEY_SHOP ---
--- QuestIDs: REMAINS37_2_SQ_070 | BRACKEN42_1_SQ10 ---
addnpc(152005, "ETC_20150317_009214", "c_Klaipe", 68, 149, 486, -59, "npc_dummy")

--- [Klaipeda's Magic Association] Henrika --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(152004, "ETC_20150317_009215", "c_Klaipe", -292, 149, 291, 360, "npc_dummy")

--- [Storage Keeper] Rita --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(154018, "ETC_20150414_011199", "c_Klaipe", 262, 79, 233, 45, "npc_dummy")

--- [Oracle Master]Apolonjia Barbora --- 
--- npcselectdialog.ies | ClassName: MASTER_ORACLE ---
--- QuestIDs: JOB_ORACLE5_1 | JOB_ORACLE_6_1 | JOB_ORACLE_7_1 ---
addnpc(57224, "ETC_20150414_011198", "c_Klaipe", -1118, 240, 283, 45, "npc_dummy")

--- Statue of Goddess Ausrine --- 
--- npcselectdialog.ies | ClassName: WARP_C_KLAIPE ---
--- QuestIDs: JOB_KRIVI4_3 | EAST_PREPARE ---
addnpc(154039, "ETC_20150317_007031", "c_Klaipe", -207, 149, 99, 0, "npc_dummy")

--- [TP Trader] Leticia --- 
--- npcselectdialog.ies | ClassName: TP_NPC ---
--- QuestIDs: TUTO_TP_SHOP ---
addnpc(20068, "ETC_20151224_019887", "c_Klaipe", 285, 79, 78, 45, "npc_dummy")

--- Mercenary Post Manager Rota --- 
--- npcselectdialog.ies | ClassName: FEDIMIAN_ROTA_02 ---
--- QuestIDs: TUTO_REQUEST_MISSION ---
addnpc(151037, "ETC_20150317_009064", "c_Klaipe", -638, 240, 1017, 360, "npc_dummy")

--- Receptionist Ramda --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(147484, "QUEST_20150414_001802", "c_Klaipe", -609, 241, 867, 360, "npc_dummy")

--- Receptionist Liam --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(154054, "QUEST_20151001_002454", "c_Klaipe", -457, 241, 895, 315, "npc_dummy")

--- Receptionist Donnes --- 
--- npcselectdialog.ies | ClassName: DROPITEM_REQUEST1_NPC ---
--- QuestIDs: DROPITEM_REQUEST1 ---
addnpc(151039, "QUEST_LV_0100_20151224_011238", "c_Klaipe", -537, 241, 882, 360, "npc_dummy")

--- Selphie --- 
--- npcselectdialog.ies | ClassName: LOWLV_GREEN_SELPHUI ---
--- QuestIDs: LOWLV_GREEN_SQ_60 ---
addnpc(147473, "QUEST_LV_0300_20161214_007808", "c_Klaipe", -605, -1, -479, -48, "npc_dummy")

--- Baron Munchausen --- 
--- npcselectdialog.ies | ClassName: LOWLV_BOASTER_MUENCHHAUSEN ---
--- QuestIDs: LOWLV_BOASTER_SQ_10 | LOWLV_BOASTER_SQ_20 | LOWLV_BOASTER_SQ_50 | LOWLV_BOASTER_SQ_40 | LOWLV_BOASTER_SQ_30 ---
addnpc(155017, "QUEST_UNUSED_20161214_003244", "c_Klaipe", -949, 241, 365, 360, "npc_dummy")

--- Team Battle League Valis --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(158000, "ETC_20160224_020711", "c_Klaipe", -390, 241, 605, 45, "npc_dummy")

--- Event Notice Board --- 
--- npcselectdialog.ies | ClassName:  ---
addnpc(40090, "QUEST_20160723_004066", "c_Klaipe", 95, 149, 391, 225, "npc_dummy")

--- Klaipeda Girl
-- Uses one of two random dialogues.
addnpc(20164, "QUEST_20150317_000127", "c_Klaipe", -225.8313, -1.3338, -848.0712, 45, "npc_klaipedagirl")
function npc_klaipedagirl()
	if math.random(2) == 1 then
		msg("KLAFEDA_NPC_05_basic01")
	else
		msg("KLAFEDA_NPC_05_basic02")
	end
end

--- Worried Wife
-- Tells stories about the various goddesses.
addnpc(20147, "QUEST_20150317_000382", "c_Klaipe", -107.036, -1.3438, -749.1073, 135, "npc_worriedwife")
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
