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
