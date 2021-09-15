--- [Item Merchant] Mirina
addnpc(20115, "[Item Merchant] Mirina", "c_Klaipe", 511, -1, -349, 45, function()

	msg("May I help you?{nl}Fortunately, we have some potions left in stock.")
	openshop("Klapeda_Misc")
	
end)
 
--- [Equipment Merchant] Dunkel
addnpc(20111, "[Equipment Merchant] Dunkel", "c_Klaipe", 394, -1, -475, 45, function()
	
	local selection,i = nselect("KLAPEDA_Akalabeth_basic28", "weapon:ETC_20150317_004443", "armor:ETC_20150317_004444", "!@#$Auto_JongLyo#@!")

	if selection == "weapon" then
		openshop("Klapeda_Weapon")
	elseif selection == "armor" then
		openshop("Klapeda_Armor")
	end
	
end)
 
--- [Accessory Merchant] Ronesa
addnpc(20104, "[Accessory Merchant] Ronesa", "c_Klaipe", 269, -1, -611, 45, function()

	msg("Alfonso_Select_1")
	openshop("Klapeda_Accessory")
	
end)

--- Klaipeda Girl
--- Uses one of two random dialogues.
addnpc(20164, "Klaipeda Girl", "c_Klaipe", -225.8313, -1.3338, -848.0712, 45, function()

	if math.random(2) == 1 then
		msg("KLAFEDA_NPC_05_basic01")
	else
		msg("KLAFEDA_NPC_05_basic02")
	end
	
end)

--- Worried Wife
--- Tells stories about the various goddesses.
addnpc(20147, "Worried Wife", "c_Klaipe", -107.036, -1.3438, -749.1073, 135, function()

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
	
end)

--- [Swordsman Master] Rashua
--- Swordsman ability trainer
addnpc(20023, "[Swordsman Master] Rashua", "c_Klaipe", -92, 241, 784, 270, function()

	msg("MASTER_SWORDMAN_basic2")
	close()
	addonmsg("ABILSHOP_OPEN", "Ability_Warrior")
	
end)
