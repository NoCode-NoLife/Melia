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
	local max = pc.gender == GENDER_MALE and 71 or 82
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

	local selection = nselect("What can I do for you today?", "hair:Change Hair", "end:Nothing")
	if selection == "end" then
		msg("Please come back any time.")
		return
	end

	msg("Good decision, one should treat himself once in a while.")

	while true do
		changehair(style)
		selection = nselect("This is style " .. style .. ", what do you think?", "n:Next", "p:Prev", "j:Jump", "I like it")

		if selection == "n" then
			modstyle(1)
		elseif selection == "p" then
			modstyle(-1)
		elseif selection == "j" then
			setstyle(numinput("Which style would you like to see?", min, max))
		else
			msg("Yes, this style does suit you well. Please come back any time.")
			return
		end
	end
end
