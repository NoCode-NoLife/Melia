-- Custom companion shop with pagination (6 per page)
M_COMPANION_SHOP = {}
M_COMPANION_SHOP_ITEMS_PER_PAGE = 6

function M_SET_CUSTOM_COMPANION_SHOP(companions)
	M_COMPANION_SHOP = {}
	for i = 1, #companions do
		M_COMPANION_SHOP[i] = {
			className = companions[i][1],
			price = companions[i][2]
		}
	end
end

if not M_ORIGINAL_UPDATE_COMPANION_SELL_LIST then
	M_ORIGINAL_UPDATE_COMPANION_SELL_LIST = UPDATE_COMPANION_SELL_LIST
end
