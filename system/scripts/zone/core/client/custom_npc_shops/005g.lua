function TRY_COMPANION_HIRE(byShop)
	local acc = session.barrack.GetMyAccount()
	local bCls = GetClass("BarrackMap", acc:GetThemaName())
	if acc:GetPCCount() >= bCls.MaxCashPC + bCls.BaseSlot then
		ui.SysMsg(ClMsg('CanCreateCharCuzMaxSlot'))
		return
	end
	if session.pet.GetPetTotalCount() >= GET_MY_AVAILABLE_CHARACTER_SLOT() then
		EXEC_BUY_CHARACTER_SLOT()
		return
	end

	local frm = byShop and ui.GetFrame('companionshop') or ui.GetFrame("companionhire")
	local eggGuid = frm:GetUserValue("EGG_GUID")
	if "None" ~= eggGuid then
		local nfrm = ui.GetFrame("inputstring")
		nfrm:SetUserValue("InputType", "PetName")
		nfrm:SetUserValue("ItemIES", eggGuid)
		nfrm:SetUserValue("ItemType", "Companionhire")
		INPUT_STRING_BOX(ClMsg("InputCompanionName"), "EXEC_CHANGE_NAME_BY_ITEM", "", 0, 16)
		frm:SetUserValue("EGG_GUID", 'None')
		return
	end

	local clsName = frm:GetUserValue("CLSNAME")
	local exchange = frm:GetUserIValue("EXCHANGE_TIKET")
	if 0 < exchange then
		frm:SetUserValue("EXCHANGE_TIKET", 0)
		TRY_CECK_BARRACK_SLOT_BY_COMPANION_EXCHANGE(exchange)
		return
	end

	M_TRY_COMPANION_HIRE_PART2(frm, clsName, byShop)
end
