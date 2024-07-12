Melia.Hook("GetClassByNameFromList", function(original, result, clsList, name)

	local idSpace = Melia.Ies.GetIdSpace(clsList)
	if idSpace then
		local dbCls = Melia.Ies.GetClassByName(idSpace, name)
		if dbCls ~= nil then
			return dbCls
		end
	end

	return result

end)

Melia.Hook("GetClass", function(original, result, clsListName, clsName)

	local dbCls = Melia.Ies.GetClassByName(clsListName, clsName)
	if dbCls ~= nil then
		return dbCls
	end

	return result

end)

Melia.Hook("GetClassByType", function(original, result, clsListName, clsId)

	local dbCls = Melia.Ies.GetClassById(clsListName, clsId)
	if dbCls ~= nil then
		return dbCls
	end

	return result

end)
