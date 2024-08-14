-- The original function fails to find the slot control because it"s
-- searching in the wrong place. We have to make sure it finds it,
-- for the clicked items to be moved to slot and be added to the list.
Melia.Override("PS_SET_ITEM_TO_SLOT", function(original, parent, ctrl)

	local slot = ctrl:GetTopParentFrame():GetChild("gbox"):GetChild("selllist"):GetChild("CTRLSET_NEW"):GetChild("slot")
	local classId = ctrl:GetUserIValue("ITEM_CLSID")
	local cls = GetClassByType("Item", classId)
	
	SET_SLOT_ITEM_CLS(slot, cls)
	slot:SetUserValue("ITEM_CLSID", classId)
	
end)

-- The original function makes assumptions about the things in the shop
-- and doesn't work with normal items anymore. We'll catch PersonalShop
-- requests and handle them ourselves, while calling the original function
-- for all other requests.
Melia.Override("BUFFSELLER_REG_EXEC", function(original, frame)

	frame = frame:GetTopParentFrame();
	
	local groupName = frame:GetUserValue("GroupName");
	local serverGroupName = frame:GetUserValue("ServerGroupName");
	
	if groupName ~= "PersonalShop" then
		original(frame);
	end

	local title = frame:GetChild("gbox"):GetChild("inputname"):GetText()
	
	if string.len(title) == 0 then
		ui.MsgBox(ClMsg("InputTitlePlease"));
		return;
	end

	--session.autoSeller.RequestRegister(groupName, serverGroupName, title, nil);

	-- Execute a command instead of the register request that wouldn't get
	-- us anywhere, because the client doesn't handle PersonalShop anymore.
	-- The server will then set up the shop.
	local msg = '/buyshop "'..title..'"'

	local groupCount = session.autoSeller.GetCount(groupName)
	for i = 0, groupCount - 1 do
		local info = session.autoSeller.GetByIndex(groupName, i)
		msg = msg .. " " .. info.classID..","..info.remainCount..","..info.price
	end

	ui.Chat(msg)
	
	frame:ShowWindow(0);

end)
