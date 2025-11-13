if not M_ORIGINAL_COMPANIONSHOP_SELECT_COMPANION then
	M_ORIGINAL_COMPANIONSHOP_SELECT_COMPANION = COMPANIONSHOP_SELECT_COMPANION
end

function COMPANIONSHOP_SELECT_COMPANION(frame, ctrl)
	local selectedCompa = ctrl:GetUserValue('CLSNAME')

	if M_COMPANION_SHOP and #M_COMPANION_SHOP > 0 then
		local topFrame = frame:GetTopParentFrame()
		local slot = GET_CHILD_RECURSIVELY(topFrame, 'compaSelectSlot')
		local name = GET_CHILD_RECURSIVELY(topFrame, 'compaSelectText')
		local buyMoneyText = GET_CHILD_RECURSIVELY(topFrame, 'buyMoneyText')

		local compaCls = GetClass('Companion', selectedCompa)
		local monCls = GetClass('Monster', selectedCompa)

		if compaCls == nil or monCls == nil then
			return
		end

		local icon = CreateIcon(slot)
		icon:SetImage(monCls.Icon)
		name:SetTextByKey('name', monCls.Name)
		buyMoneyText:SetTextByKey('money', ctrl:GetUserValue('SELL_PRICE'))
		topFrame:SetUserValue('CLSNAME', selectedCompa)

		COMPANIONSHOP_UPDATE_REMAINMONEY(topFrame)
	else
		M_ORIGINAL_COMPANIONSHOP_SELECT_COMPANION(frame, ctrl)
	end
end
