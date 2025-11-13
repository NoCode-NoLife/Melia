function M_TRY_COMPANION_HIRE_PART2(frm, clsName, byShop)
	local cls = GetClass("Companion", clsName)
	if not cls then
		return
	end

	local price
	if M_COMPANION_SHOP and #M_COMPANION_SHOP > 0 then
		for i = 1, #M_COMPANION_SHOP do
			if M_COMPANION_SHOP[i].className == clsName then
				price = M_COMPANION_SHOP[i].price
				break
			end
		end
		if not price then
			return
		end
	else
		if cls.SellPrice == "None" then
			return
		end
		price = _G[cls.SellPrice](cls, GetMyPCObject())
	end

	local name = byShop and GET_CHILD_RECURSIVELY(frm, 'compaNameEdit') or frm:GetChild("input")
	if not name then
		return
	end
	local txt = name:GetText()

	if not txt then return end
	if string.find(txt, ' ') then
		ui.SysMsg(ClMsg("NameCannotIncludeSpace"))
		return
	end
	if not ui.IsValidCharacterName(txt) then
		ui.SysMsg(ScpArgMsg('CompanionNameIsInvalid'))
		return
	end

	if IsGreaterThanForBigNumber(price, GET_TOTAL_MONEY_STR()) == 1 then
		ui.SysMsg(ClMsg('NotEnoughMoney'))
	else
		local scp = string.format("EXEC_BUY_COMPANION(\"%s\", \"%s\")", clsName, txt)
		local msg = ScpArgMsg("PossibleChangeName_2{Name}", "Name", txt)
		ui.MsgBox(msg.." {nl}"..ScpArgMsg("ReallyBuyCompanion?"), scp, "None")
	end
end
