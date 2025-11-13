function UPDATE_COMPANION_SELL_LIST(frame)
	if M_COMPANION_SHOP and #M_COMPANION_SHOP > 0 then
		local topBox = GET_CHILD_RECURSIVELY(frame, 'adoptTopBox')
		topBox:RemoveAllChild()

		local currentPage = tonumber(frame:GetUserValue('COMPANION_SHOP_PAGE')) or 1
		local itemsPerPage = M_COMPANION_SHOP_ITEMS_PER_PAGE
		local totalItems = #M_COMPANION_SHOP
		local totalPages = math.ceil(totalItems / itemsPerPage)

		local startIdx = (currentPage - 1) * itemsPerPage + 1
		local endIdx = math.min(startIdx + itemsPerPage - 1, totalItems)

		local displayIdx = 1
		for i = startIdx, endIdx do
			local comp = M_COMPANION_SHOP[i]
			local cls = GetClass('Companion', comp.className)
			if cls then
				local ctrlSet = topBox:CreateControlSet("companionshop_ctrl", "CTRLSET_" .. displayIdx, ui.CENTER_HORZ, ui.TOP, 0, 0, 0, 0)
				ctrlSet:SetUserValue("CLSNAME", cls.ClassName)
				ctrlSet:SetUserValue('SELL_PRICE', comp.price)
				ctrlSet:GetChild("price"):SetTextByKey("txt", GET_MONEY_IMG(20) .. " " .. GetCommaedText(comp.price))

				local name = ctrlSet:GetChild("name")
				local monCls = GetClass("Monster", cls.ClassName)
				if monCls then
					name:SetTextByKey("txt", monCls.Name)
					name:SetTextByKey("JobID", cls.JobID)
					CreateIcon(GET_CHILD(ctrlSet, "slot", "ui::CSlot")):SetImage(monCls.Icon)
				end
				ctrlSet:SetEventScript(ui.LBUTTONUP, "COMPANIONSHOP_SELECT_COMPANION")
				displayIdx = displayIdx + 1
			end
		end
		GBOX_AUTO_ALIGN(topBox, 20, 0, 10, true, false)

		local pageText = GET_CHILD_RECURSIVELY(frame, 'adopt_pagetxt')
		if pageText then
			pageText:SetText('{@st41b}' .. currentPage .. ' / ' .. totalPages .. '{/}')
		end

		frame:SetUserValue('COMPANION_SHOP_TOTAL_PAGES', totalPages)
		M_UPDATE_COMPANION_PAGE_BUTTONS(frame)
	else
		M_ORIGINAL_UPDATE_COMPANION_SELL_LIST(frame)
	end
end
