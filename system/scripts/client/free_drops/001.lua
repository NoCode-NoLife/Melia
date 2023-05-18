if not GetClassByType_Original then
	GetClassByType_Original = GetClassByType
end

-- Mark all items as destroyable.
function GetClassByType(idSpace, classId)
	local result = GetClassByType_Original(idSpace, classId)
	
	if result ~= nil and idSpace == "Item" then
		result.Destroyable = "YES"
	end
	
	return result
end

-- Always return true, so the server can decide what's destroyable.
function geItemTable.IsDestroyable(itemClassId)
	return true
end

if not INVENTORY_DELETE_Original then
	INVENTORY_DELETE_Original = INVENTORY_DELETE
end

-- This function is called when the player wants to drop an item, and the
-- mouse will be at the position where they dragged the item, so it will
-- reflect the position the player wants to drop the item "at". We don't
-- have world positions, but we can use this to determine the direction
-- to drop items in.
function INVENTORY_DELETE(itemIESID, itemType)
	ui.Chat(string.format("/updatemouse %f %f %f %f", mouse.GetX(), mouse.GetY(), option.GetClientWidth(), option.GetClientHeight()))
	
	INVENTORY_DELETE_Original(itemIESID, itemType)
end
