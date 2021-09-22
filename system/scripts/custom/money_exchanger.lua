----- Melia Script ----------------------------------------------------------
-- Money Exchanger
----- Description -----------------------------------------------------------
-- Trades silver for paper currency items and vice versa.
-----------------------------------------------------------------------------

addnpc(57223, "[Money Exchanger] Max", "c_Klaipe", 312, -1, -830, -45, function()

	local selection = nselect("Hi, what can I do for you?",
		"Exchange Silver:silver",
		"Exchange Money:money",
		"Nothing:nothing"
	)
	
	if selection == "silver" then
	
		msg("Want some shiny paper money? That's the best decision you will ever make!")
		
		local currentSilver = countsilver()
		local amount = input("Looks like you have "..currentSilver.." silver, how much do you want to exchange?")
	
		local match = amount:match("^[0-9]+$")
		if match == nil then
			msg("What...? Sorry, I can't help you with that.")
			return
		end
		
		amount = tonumber(amount)
		if amount < 1000 then
			msg("That's all? Sorry, I have a 1000 silver minimum.")
			return
		end
		
		local ks = math.floor(amount / 1000)
		removesilver(ks * 1000)
		
		while ks > 0 do
			if ks > 500 then
				additem(900426, 1)
				ks = ks - 500
			elseif ks > 100 then
				additem(900269, 1)
				ks = ks - 100
			elseif ks > 50 then
				additem(900268, 1)
				ks = ks - 50
			elseif ks > 10 then
				additem(900267, 1)
				ks = ks - 10
			elseif ks > 5 then
				additem(900266, 1)
				ks = ks - 5
			else
				additem(900265, ks)
				ks = 0
			end
		end
	
		msg("Thanks for your business!")

	elseif selection == "money" then
	
		msg("Eh? You want silver? But paper is the future! No, really! Would I lie to you? ... Well, suit yourself.")
		
		local amount = input("How much silver do you want?")
	
		local match = amount:match("^[0-9]+$")
		if match == nil then
			msg("What...? Sorry, I can't help you with that.")
			return
		end
		
		amount = tonumber(amount)
		if amount < 1000 then
			msg("Sorry, I have a 1000 silver minimum.")
			return
		end
		
		local ks = math.floor(amount / 1000)
		local remove = {}
		
		local bills = { 900426, 900269, 900268, 900267, 900266, 900265 }
		local steps = { 500, 100, 50, 10, 5, 1 }
		
		local total = 0
		for i=1,#bills do
			total = total + countitem(bills[i]) * steps[i]
		end
		
		if total < ks then
			msg("You don't have enough money to cover that, do you? Better keep the paper.")
			return
		end
		
		local totalAdded = 0
		for i=1,#steps do
			local v = steps[i]
			
			if ks >= v then
				local remove = math.floor(ks / v)
				local add = remove * v * 1000
				
				removeitem(bills[i], remove)
				addsilver(add)
				
				totalAdded = totalAdded + add
				
				ks = ks - remove * v
			end
			
			if ks <= 0 then
				break
			end
		end
		
		msg("Okay, I can give you "..totalAdded..". Here you go.")
		
	else
	
		msg("Hm.")
		
	end

end)
