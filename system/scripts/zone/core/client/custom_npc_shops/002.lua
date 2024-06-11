-- Reroute the request for the shop item list of the current shop, so we
-- can return our custom shop list instead.
Melia.OverrideIn(session, "GetShopItemList", function(original)

	local shopName = session.GetCurrentShopName()
	if shopName ~= M_CUSTOM_SHOP_NAME then
		return original()
	end
	
	return M_CUSTOM_SHOP

end)

-- Function executed from the server to load a new shop.
function M_SET_CUSTOM_SHOP(items)
	
	local customShop = M_CUSTOM_SHOP
	customShop:Clear()
	
	for i = 1, #items do
		local itemData = items[i]
		local item = ShopItem_New(itemData[1], itemData[2], itemData[3], itemData[4])
		
		customShop:AddItem(item)
	end
	
	M_CUSTOM_SHOP = customShop
	
end
