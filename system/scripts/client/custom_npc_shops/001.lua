M_CUSTOM_SHOP_NAME = "MeliaCustomShop"

-- Returns a new shop list that's modeled after the ones the client returns.
function ShopItemList_New(name)

	local result = {}
	
	result.name = name
	result.items = {}
	
	function result:PtrAt(idx)
		idx = idx + 1
		return self.items[idx]
	end
	
	function result:Count()
		return #self.items
	end
	
	function result:GetByClassID(classID)
		for k,v in ipairs(self.items) do
			if v.classID == classID then
				return v
			end
		end
		
		return nil
	end
	
	function result:AddItem(item)
		table.insert(self.items, item)
	end
	
	function result:Clear()
		self.items = {}
	end
	
	return result
	
end

-- Returns a new shop item that's modeled after the ones the client returns.
function ShopItem_New(classId, itemId, count, price)

	local result = {}
	
	result.classID = classId
	result.type = itemId
	result.count = count
	result.price = price
	result.ItemType = "Item"
	
	function result:GetIDSpace()
		return "Item"
	end
	
	function result:GetIcon()
		local cls = GetClassByType(self:GetIDSpace(), self.type)
		if not cls then
			return "None"
		end
		
		return TryGet_Str(cls, "Icon")
	end
	
	function result:GetPropName()
		return "None"
	end
	
	function result:GetBuyAccountPropName()
		return "None"
	end
	
	function result:GetAccountPropIcon()
		return "None"
	end
	
	return result
	
end

-- Create a custom shop that we can modify on demand.
M_CUSTOM_SHOP = ShopItemList_New(M_CUSTOM_SHOP_NAME)
