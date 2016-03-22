----- Melia Script ----------------------------------------------------------
-- Stylist
----- Description -----------------------------------------------------------
-- Allows changing the player's hair style.
----- Notes -----------------------------------------------------------------
-- There are no separate style and color settings, every hair style exists
-- X times, with different colors. While the NPC could split them, it would
-- only work while the client sticks to a strict "X styles Y colors" system.
-----------------------------------------------------------------------------

addnpc(57223, "Stylist", "c_Klaipe", -66, 79, -547, 135, "stylist")

function stylist()
	local pc = getpc()
	local min, max = 1, 82
	local style = pc.hair

	function setStyle(val)
		style = val
		loopStyle()
	end

	function modStyle(mod)
		style = style + mod
		loopStyle()
	end

	function loopStyle()
		if style > max then
			style = min
		elseif style < min then
			style = max
		end
	end

	local selection = select("What can I do for you today?", "Change Hair", "Nothing")
	if selection == 2 then
		msg("Please come back any time.")
		return
	end

	msg("Good decision, one should treat himself once in a while.")

	while true do
		changehair(style)
		selection = select("This is style " .. style .. ", what do you think?", "Next", "Prev", "Jump", "I like it")

		if selection == 1 then
			modStyle(1)
		elseif selection == 2 then
			modStyle(-1)
		elseif selection == 3 then
			setStyle(numinput("Which style would you like to see?", min, max))
		elseif selection == 4 then
			msg("Yes, this style does suit you well. Please come back any time.")
			return
		end
	end
end
