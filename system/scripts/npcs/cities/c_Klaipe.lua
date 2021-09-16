--- [Item Merchant] Mirina
addnpc(20115, "[Item Merchant] Mirina", "c_Klaipe", 511, -1, -349, 45, function()

	msg("May I help you?{nl}Fortunately, we have some potions left in stock.")
	openshop("Klapeda_Misc")
	
end)

--- [Equipment Merchant] Dunkel
addnpc(20111, "[Equipment Merchant] Dunkel", "c_Klaipe", 394, -1, -475, 45, function()
	
	local selection = nselect("A lot of people seem to be coming thanks to Sir Uska's recruitment notice.{nl}Take a look around at your own pace without feeling anxious.",
		"weapon:Weapons",
		"armor:Armor",
		"Cancel"
	)

	if selection == "weapon" then
		openshop("Klapeda_Weapon")
	elseif selection == "armor" then
		openshop("Klapeda_Armor")
	end
	
end)

--- [Accessory Merchant] Ronesa
addnpc(20104, "[Accessory Merchant] Ronesa", "c_Klaipe", 269, -1, -611, 45, function()

	msg("Welcome.{nl}Only hard-to-find stuff here.")
	openshop("Klapeda_Accessory")
	
end)

--- Klaipeda Girl
--- Uses one of two random dialogues.
addnpc(20164, "Klaipeda Girl", "c_Klaipe", -225.8313, -1.3338, -848.0712, 45, function()

	if math.random(2) == 1 then
		msg("I heard the town men can't make their way back because of the monsters.{nl}We have food but it will run out soon...")
	else
		msg("My father told me Klaipeda is also becoming a difficult place to live.{np}There are many people who want to buy things but it's not easy to get what they want.{nl}We have enough food supplies for now but it won't last long.")
	end
	
end)

--- Worried Wife
--- Tells stories about the various goddesses.
addnpc(20147, "Worried Wife", "c_Klaipe", -107.036, -1.3438, -749.1073, 135, function()

	local selection = nselect("As you may already know, our kingdom has five major goddesses and other goddesses who{nl}assist them. But nobody knows where all of them are now.",
		"Regarding the five goddesses",
		"leave:Leave"
	)
	
	while selection ~= "leave" do
		-- Select goddess
		selection = nselect("As you may know, the five goddesses are Laima, Zemyna, Vakarine, Gabija and Ausrine.",
			"ausrine:About Goddess Ausrine",
			"laima:About Goddess Laima",
			"gabija:About Goddess Gabija",
			"zemyna:About Goddess Zemyna",
			"vakarine:About Goddess Vakarine",
			"leave:Leave "
		)

		-- Info about selected goddess
		if selection == "ausrine" then
			msg("Morning dawns after night, does it not? Goddess Ausrine is the one who brings us morning. {nl}Not only that, when we die, we go to her as well.")
		elseif selection == "laima" then
			msg("Goddess Laima... Actually, I don't know her that well. No one does, except for her priests. {nl}I heard she's the goddess of fate and foresight, but she has not once appeared before us.")
		elseif selection == "gabija" then
			msg("I pray to Goddess Gabija everyday. It keeps the house warm.{nl}As you may already know, Goddess Gabija controls fire and since I'm a housewife,{nl}I am close to fire as well.")
		elseif selection == "zemyna" then
			msg("My husband always prays to Goddess Zemyna.{nl}We can't afford getting on Her wrong side if we want our potatoes to grow.{nl}Zemyna is the goddess of the earth. She looks after the crops.{np}Speaking of which.{nl}About the plants overgrowing ever since Medzio Diena four years ago...{np}I wonder what Goddess Zemyna will think of it.{nl}Everything will be revealed when the goddess returns but...{nl}Oh, what blasphemous words I speak.")
		elseif selection == "vakarine" then
			msg("Have you ever seen the stars glittering red in the night sky?{nl}That's the very symbol of Goddess Vakarine.{nl}She leads the evening star and wakes Goddess Ausrine the following day.{np}She also oversees energy and rest, so she is the guardian of travelers like you.{nl}Shout Goddess Vakarine's name three times when your legs hurt and you'll feel much better.")
		end
	end
	
end)

--- [Swordsman Master] Rashua
--- Swordsman ability trainer
addnpc(20023, "[Swordsman Master] Rashua", "c_Klaipe", -92, 241, 784, 270, function()

	msg("The capital may already be in ruins, but I will protect Klaipeda.")
	
	-- Ability shops aren't a thing anymore.
	-- close()
	-- addonmsg("ABILSHOP_OPEN", "Ability_Warrior")
	
end)
