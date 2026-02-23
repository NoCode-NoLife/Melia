Melia.Override("INVENTORY_ON_MSG", function(original, frame, msg, argStr, argNum)

	original(frame, msg, argStr, argNum)

	local accountObj = GetMyAccountObj()

	-- Make Premium TP tooltip easier to hit
	local medalGbox_2 = GET_CHILD_RECURSIVELY(frame, "medalGbox_2")
	local invenzenytext = GET_CHILD_RECURSIVELY(medalGbox_2, "invenzenytext")
	medalGbox_2:SetTextTooltip("")
	invenzenytext:SetTextTooltip("Premium TP: " .. tostring(accountObj.PremiumMedal) .. ", Event TP: " .. tostring(accountObj.GiftMedal))

	-- Add Free TP tooltip
	local medalGbox = GET_CHILD_RECURSIVELY(frame, "medalGbox")
	medalGbox:SetTextTooltip("Free TP")
	
	-- Add Silver tooltip
	local invenZeny = GET_CHILD_RECURSIVELY(frame, "invenZeny")
	invenZeny:SetTextTooltip("Silver")
	
	-- Add Season Coin tooltip
	local sesasonCoinText = GET_CHILD_RECURSIVELY(frame, "sesasonCoinText")
	sesasonCoinText:SetTextTooltip("Season Coins")
end)
