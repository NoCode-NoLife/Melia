-- Hook GetClassByType to mark all items as destroyable.
Melia.Hook("GetClassByType", function(original, result, idSpace, classId)

	if result ~= nil and idSpace == "Item" then
		result.Destroyable = "YES"
	end
	
	return result

end)

-- Replace IsDestroyable to always return, so the server can decide what's
-- destroyable and what's not.
function geItemTable.IsDestroyable(itemClassId)
	return true
end

-- Override inventory deletion function, which is called when a player
-- tries to destroy an item from their inventory. At that time, their
-- cursor will be at the position where they dragged the item, so it will
-- reflect the position the player wants to drop the item "at". We don't
-- have world positions, but we can use this to determine the direction
-- to drop items in.
Melia.Override("INVENTORY_DELETE", function(original, itemIESID, itemType)

	ui.Chat(string.format("/updatemouse %f %f %f %f", mouse.GetX(), mouse.GetY(), option.GetClientWidth(), option.GetClientHeight()))
	original(itemIESID, itemType)

end)
