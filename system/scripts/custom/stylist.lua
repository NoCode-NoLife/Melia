----- Melia Script ----------------------------------------------------------
-- Stylist
----- Description -----------------------------------------------------------
-- Allows changing the player's hair style.
----- Notes -----------------------------------------------------------------
-- There are no separate style and color settings, every hair style exists
-- X times, with different colors. Unfortunately there is no strict X styles
-- Y colors convention, some styles have 1 color, some 4, some 5, and
-- the number of available styles differs between genders as well. Splitting
-- into style and color would be bothersome and could break any time.
-----------------------------------------------------------------------------

addnpc(57223, "Stylist", "c_Klaipe", -66, 79, -547, 135, "npc_stylist")

function npc_stylist()
	local pc = getpc()
	local min = 1
	local max = pc.gender == GENDER_MALE and 420 or 454
	local style = pc.hair

	local function loopstyle()
		if style > max then
			style = min
		elseif style < min then
			style = max
		end
	end

	local function setstyle(val)
		style = val
		loopstyle()
	end

	local function modstyle(mod)
		style = style + mod
		loopstyle()
	end

	local function getoptions(direction)
		local options = {}

		for i=1,2 do
			if direction == i then
				table.insert(options, "n:Next")
			else
				table.insert(options, "p:Prev")
			end
		end
		
		table.insert(options, "j:Jump")
		table.insert(options, "I like it")

		return options
	end

	local selection = nselect("What can I do for you today?", "hair:Change Hair", "end:Nothing")
	if selection == "end" then
		msg("Please come back any time.")
		return
	end

	msg("Good decision, one should treat himself once in a while.")

	local direction = 1
	while true do
		local options = getoptions(direction)

		changehair(style)
		selection = nselect("This is style " .. style .. ", what do you think?", options)

		if selection == "n" then
			modstyle(1)
			direction = 1
		elseif selection == "p" then
			modstyle(-1)
			direction = 2
		elseif selection == "j" then
			setstyle(numinput("Which style would you like to see?", min, max))
		else
			msg("Yes, this style does suit you well. Please come back any time.")
			return
		end
	end
end
