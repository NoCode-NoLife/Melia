--- [Item Merchant] Mirina ---
addnpc(20115, "[Item Merchant]{nl}    Mirina", "c_Klaipe", 511, -1, -349, 45, function()
	msg("May I help you?{nl}Fortunately, we have some potions left in stock.")
	openshop("Klapeda_Misc")
end)
 
--- [Equipment Merchant] Dunkel ---
addnpc(20111, "ETC_20150317_009196", "c_Klaipe", 394, -1, -475, 45, "npc_equipmentmerchantdunkel")
function npc_equipmentmerchantdunkel()
	local selection,i = nselect("KLAPEDA_Akalabeth_basic28", "weapon:ETC_20150317_004443", "armor:ETC_20150317_004444", "!@#$Auto_JongLyo#@!")

	if selection == "weapon" then
		openshop("Klapeda_Weapon")
	elseif selection == "armor" then
		openshop("Klapeda_Armor")
	end
end
 
--- [Accessory Merchant]Ronesa ---
addnpc(20104, "ETC_20150317_009197", "c_Klaipe", 269, -1, -611, 45, "npc_accessorymerchantronesa")
function npc_accessorymerchantronesa()
	msg("Alfonso_Select_1")
	openshop("Klapeda_Accessory")
end

--- Indifferent Widow ---
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
addnpc(20113, "ETC_20151224_019888", "c_Klaipe", -474, 149, 82, 360, "npc_dummy")
 
--- [Cleric Master] Rozalija ---
addnpc(20112, "ETC_20150317_009207", "c_Klaipe", -409, 149, 174, 360, "npc_dummy")
 
--- Klaipeda Resident ---
addnpc(20158, "QUEST_LV_0100_20150317_000413", "c_Klaipe", -9, 156, 131, -23.96, "npc_dummy")
 
--- Mother of a Soldier ---
addnpc(20114, "QUEST_LV_0100_20150317_000423", "c_Klaipe", -60, 148, 42, 36.57, "npc_dummy")
 
--- [Priest Master] Boruble ---
addnpc(57229, "ETC_20150317_009208", "c_Klaipe", -196, 149, 351, -45, "npc_dummy")
 
--- Bulletin Board ---
addnpc(40090, "QUEST_20150317_000081", "c_Klaipe", -80, 148, 387, -15, "npc_dummy")
 
--- [Blacksmith] Zaras ---
addnpc(20105, "ETC_20150317_009199", "c_Klaipe", 600, -1, -83, 45, "npc_dummy")
 
--- [Krivis Master] Herkus ---
addnpc(57228, "ETC_20150317_009209", "c_Klaipe", -1108, 240, 512, 360, "npc_dummy")
 
--- Refugee ---
addnpc(20139, "QUEST_LV_0100_20150317_001418", "c_Klaipe", -60, 79, -446, -33.69, "npc_dummy")
 
--- [Market Manager] Logi ---
addnpc(20169, "ETC_20150317_009211", "c_Klaipe", 278, 79, 137, 45, "npc_dummy")
 
--- [Peltasta Master]Maria Leed ---
addnpc(20028, "ETC_20150317_009200", "c_Klaipe", -225, 97, -385, -55, "npc_dummy")
 
--- [Cryomancer Master] Aleister Crowley ---
addnpc(20137, "ETC_20151224_019889", "c_Klaipe", -205, 79, -515, 51.17, "npc_dummy")
 
--- [Quarrel Shooter Master]Ream Toiler ---
addnpc(147445, "ETC_20150317_009202", "c_Klaipe", -236, 241, 867, 270, "npc_dummy")
 
--- [Ranger Master] Nemoken ---
addnpc(147343, "ETC_20150317_009203", "c_Klaipe", -489, 149, 27, 51.17, "npc_dummy")
 
--- [Wizard Master]Lucia ---
addnpc(20021, "ETC_20150317_009205", "c_Klaipe", -100, 96, -275, -45, "npc_dummy")
 
--- [Archer Master] Edmundas Tiller ---
addnpc(147447, "ETC_20150317_009206", "c_Klaipe", -949, 241, 308, 360, "npc_dummy")
 
--- Bulletin Board ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -66, -1, -752, -47.99, "npc_dummy")
 
--- Bulletin Board ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", 195, -1, -641, -33.69, "npc_dummy")
 
--- Bulletin Board ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", 58, 79, -359, -11.66, "npc_dummy")
 
--- Bulletin Board ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -63, 148, -108, 37.87, "npc_dummy")
 
--- Bulletin Board ---
addnpc(40070, "QUEST_20150317_000081", "c_Klaipe", -165, -1, -958, 18.43, "npc_dummy")
 
--- Signboard ---
addnpc(40070, "QUEST_20150317_000821", "c_Klaipe", 744, -1, 192, -81.23, "npc_dummy")
 
--- About the Goddess Statue ---
addnpc(40070, "QUEST_20150729_002302", "c_Klaipe", -125, 148, -11, -3.009998, "npc_dummy")
 
--- Holiday Notice ---
addnpc(40070, "QUEST_20150317_000830", "c_Klaipe", 617, -1, 61, 45, "npc_dummy")
 
--- Lyliana ---
addnpc(147473, "QUEST_LV_0100_20150317_002150", "c_Klaipe", 615, -1, 132, 45, "npc_dummy")
 
--- [Companion Trader]Christina ---
addnpc(153005, "ETC_20150317_009212", "c_Klaipe", 6, -1, -760, 315, "npc_dummy")
 
--- Velheider ---
addnpc(47521, "ETC_20150317_007299", "c_Klaipe", -22, -1, -757, 315, "npc_dummy")
 
--- [Wings of Vaivora]Lena ---
addnpc(152005, "ETC_20150317_009214", "c_Klaipe", 68, 149, 486, -59, "npc_dummy")
 
--- [Klaipeda's Magic Association] Henrika ---
addnpc(152004, "ETC_20150317_009215", "c_Klaipe", -292, 149, 291, 360, "npc_dummy")
 
--- [Storage Keeper] Rita ---
addnpc(154018, "ETC_20150414_011199", "c_Klaipe", 262, 79, 233, 45, "npc_dummy")
 
--- [Oracle Master]Apolonjia Barbora ---
addnpc(57224, "ETC_20150414_011198", "c_Klaipe", -1118, 240, 283, 45, "npc_dummy")
 
--- Statue of Goddess Ausrine ---
addnpc(154039, "ETC_20150317_007031", "c_Klaipe", -207, 149, 99, 0, "npc_dummy")
 
--- [TP Trader] Leticia ---
addnpc(20068, "ETC_20151224_019887", "c_Klaipe", 285, 79, 78, 45, "npc_dummy")
 
--- Mercenary Post Manager Rota ---
addnpc(151037, "ETC_20150317_009064", "c_Klaipe", -638, 240, 1017, 360, "npc_dummy")
 
--- Receptionist Ramda ---
addnpc(147484, "QUEST_20150414_001802", "c_Klaipe", -609, 241, 867, 360, "npc_dummy")
 
--- Receptionist Liam ---
addnpc(154054, "QUEST_20151001_002454", "c_Klaipe", -457, 241, 895, 315, "npc_dummy")
 
--- Receptionist Donnes ---
addnpc(151039, "QUEST_LV_0100_20151224_011238", "c_Klaipe", -537, 241, 882, 360, "npc_dummy")
 
--- Selphie ---
addnpc(147473, "QUEST_LV_0300_20161214_007808", "c_Klaipe", -605, -1, -479, -48, "npc_dummy")
 
--- Baron Munchausen ---
addnpc(155017, "QUEST_UNUSED_20161214_003244", "c_Klaipe", -949, 241, 365, 360, "npc_dummy")
 
--- Team Battle League Valis ---
addnpc(158000, "ETC_20160224_020711", "c_Klaipe", -390, 241, 605, 45, "npc_dummy")
 
--- Event Notice Board ---
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

--- [Swordsman Master]Rashua ---
-- Swordsman ability trainer
addnpc(20023, "ETC_20150317_009204", "c_Klaipe", -92, 241, 784, 270, "npc_swordsmanmasterrashua")
function npc_swordsmanmasterrashua()
	msg("MASTER_SWORDMAN_basic2")
	close()
	addonmsg("ABILSHOP_OPEN", "Ability_Warrior")
end
