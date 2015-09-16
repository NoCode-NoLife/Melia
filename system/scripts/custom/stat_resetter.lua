----- Melia Script ----------------------------------------------------------
-- Stat Resetter
----- Description -----------------------------------------------------------
-- Resets player's stat points.
-----------------------------------------------------------------------------

addnpc(57223, "Stat Resetter", "c_Klaipe", 40, 79, -367, -45, "stat_resetter")

function stat_resetter()
	local name = "Stat Resetter*@*"

	if select(name .. "Oh my, your stats are a mess... If you want to fix that, I can reset them for you.", "Yes, please.", "No, thanks.") == 1 then
		msg(name .. "That was the right decision.")
		resetstats()
	else
		msg(name .. "Suit yourself... come back if you change your mind.")
	end
end
