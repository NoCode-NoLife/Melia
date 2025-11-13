if not M_ORIGINAL_ON_OPEN_DLG_COMPANIONSHOP then
	M_ORIGINAL_ON_OPEN_DLG_COMPANIONSHOP = ON_OPEN_DLG_COMPANIONSHOP
end

function ON_OPEN_DLG_COMPANIONSHOP(frame, msg, shopGroup)
	M_ORIGINAL_ON_OPEN_DLG_COMPANIONSHOP(frame, msg, shopGroup)
	frame:SetUserValue('COMPANION_SHOP_PAGE', 1)

	local tabCtrl = GET_CHILD_RECURSIVELY(frame, 'companionTab')
	if tabCtrl then tabCtrl:ShowWindow(0) end

	local foodBox = GET_CHILD_RECURSIVELY(frame, 'foodBox')
	if foodBox then foodBox:ShowWindow(0) end

	local adoptBox = GET_CHILD_RECURSIVELY(frame, 'adoptBox')
	if adoptBox then adoptBox:ShowWindow(1) end

	-- Create pagination UI elements
	M_CREATE_COMPANION_PAGINATION_UI(frame)
	M_CREATE_COMPANION_PAGINATION_UI_PART2(frame)
	M_CREATE_COMPANION_PAGINATION_UI_PART3(frame)

	-- Refresh the display now that pagination UI exists
	if M_COMPANION_SHOP and #M_COMPANION_SHOP > 0 then
		UPDATE_COMPANION_SELL_LIST(frame)
	end
end
