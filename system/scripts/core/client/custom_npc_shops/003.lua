-- Used to get the shop item's class id from the shop table. For our
-- custom shop, we reroute the request and get the class id from our
-- own list instead.
Melia.OverrideIn(geShopTable, "GetByClassID", function(original, classID)

	local shopName = session.GetCurrentShopName()
	if shopName ~= M_CUSTOM_SHOP_NAME then
		return original(classID)
	end
	
	local shopItemList = session.GetShopItemList()
	return shopItemList:GetByClassID(classID)
	
end)
