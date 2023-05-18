if not geShopTable_GetByClassID_Original then
	geShopTable_GetByClassID_Original = geShopTable.GetByClassID
end

-- Used to get the shop item's class id from the shop table. For our
-- custom shop, we reroute the request and get the class id from our
-- own list instead.
function geShopTable.GetByClassID(classID)

	local shopName = session.GetCurrentShopName()
	if shopName ~= M_CUSTOM_SHOP_NAME then
		return geShopTable_GetByClassID_Original(classID)
	end
	
	local shopItemList = session.GetShopItemList()
	return shopItemList:GetByClassID(classID)
	
end
