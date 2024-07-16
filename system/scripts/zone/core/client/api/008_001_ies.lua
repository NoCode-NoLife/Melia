Melia.Ies = {}

MELIA_IES_DB = {}

Melia.Ies.AddClass = function(idSpace, cls)
	local list = MELIA_IES_DB[idSpace]

	if not list then
		list = {}
		list["Entries"] = {}
		list["ById"] = {}
		list["ByName"] = {}

		MELIA_IES_DB[idSpace] = list
	end

	table.insert(list["Entries"], cls)
	list["ById"][cls.ClassID] = cls
	list["ByName"][cls.ClassName] = cls
end

Melia.Ies.GetClassById = function(idSpace, clsId)
	local list = MELIA_IES_DB[idSpace]

	if list then
		local cls = list["ById"][clsId]
		if cls then
			return cls
		end
	end

	return nil
end

Melia.Ies.GetClassByName = function(idSpace, clsName)
	local list = MELIA_IES_DB[idSpace]

	if list then
		local cls = list["ByName"][clsName]
		if cls then
			return cls
		end
	end

	return nil
end

Melia.Ies.GetIdSpace = function(clsList)
	local first = GetClassByIndexFromList(clsList, 0)
	return GetIDSpace(first)
end
