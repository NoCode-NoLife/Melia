Melia.Hook("UPDATE_MINIMAP", function(original, result, frame)
	local icons = Melia.World.Icons.GetAll()
	if not icons then
		return result
	end
	
	local mapName = session.GetMapName()
	local mapProp = geMapTable.GetMapProp(mapName)
	local lstNpcs = frame:GetChild("npclist")

	for i, icon in ipairs(icons) do
		if string.lower(icon.Map) == string.lower(mapName) then
			local ctrlName = "_M_MINIMAP_ICON_" .. i
			M_CREATE_MAP_ICON(lstNpcs, ctrlName, icon, mapProp, minimapw, minimaph, 0, 0)
		end
	end

	return result
end)

Melia.Hook("MAKE_MAP_NPC_ICONS", function(original, result, frame, mapName, mapWidth, mapHeight, offsetX, offsetY)
	local icons = Melia.World.Icons.GetAll()
	if not icons then
		return result
	end
	
	local mapProp = geMapTable.GetMapProp(mapName);

	for i, icon in ipairs(icons) do
		if string.lower(icon.Map) == string.lower(mapName) then
			local ctrlName = "_M_MAP_ICON_" .. i
			M_CREATE_MAP_ICON(frame, ctrlName, icon, mapProp, mapWidth, mapHeight, offsetX, offsetY)
		end
	end

	return result
end)
