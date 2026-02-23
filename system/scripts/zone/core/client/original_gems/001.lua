Melia.Override("DRAW_GEM_COMMON_TOOLTIP", function(original, tooltipframe, invitem, mainframename)

	local result = original(tooltipframe, invitem, mainframename)
	
	local gemItem = M_GET_GEM_OVERRIDE_ITEM(invitem.ClassID)
	if gemItem ~= nil then
		local gBox = GET_CHILD(tooltipframe, mainframename, "ui::CGroupBox")
		local cset = GET_CHILD(gBox, "gem_common_cset")
		local nameChild = GET_CHILD(cset, "name", "ui::CRichText");

		local itemPicture = GET_CHILD(cset, "itempic", "ui::CPicture")
		if itemPicture:IsVisible() == 1 then
			itemPicture:SetImage(gemItem.Image)
		end
		
		nameChild:SetText(dic.getTranslatedStr(gemItem.Name))
	end
	
	return result

end)

Melia.Override("GET_ITEM_ICON_IMAGE", function(original, itemCls, gender)

	local result = original(itemCls, gender)
	
	local gemItem = M_GET_GEM_OVERRIDE_ITEM(itemCls.ClassID)
	if gemItem ~= nil then
		result = gemItem.Image
	end

	return result

end)

Melia.Override("INV_ICON_SETINFO", function(original, frame, slot, invItem, customFunc, scriptArg, count)

	local result = original(itemCls, gender)
	
	local gemItem = M_GET_GEM_OVERRIDE_ITEM(itemCls.ClassID)
	if gemItem ~= nil then
		result = gemItem.Image
	end

	return result

end)

function M_GET_GEM_OVERRIDE_ITEM(classId)
	return M_GEM_OVERRIDE_ITEMS[classId]
end

M_GEM_OVERRIDE_ITEMS = {
	--[643580] = { Name: "@dicID_^*$ETC_20151102_016685$*^", Image: "gem_mon_onion" }
}
