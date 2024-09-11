Melia.Hook("WORLDMAP2_SUBMAP_DRAW_ZONE", function(original, result, frame, cls)

	local mapName = cls.MapName

	local setMap = GET_CHILD_RECURSIVELY(frame, mapName)
	if setMap == nil then
		return result
	end

	-- Hide level range text
    local lblBottom = AUTO_CAST(setMap:GetChild("zone_text_bottom"))
	lblBottom:SetText("")

	-- Center map name
	local lblTop = AUTO_CAST(setMap:GetChild("zone_text_top"))
	local margin = lblTop:GetMargin()
	lblTop:SetMargin(margin.left, 0, margin.right, 0)

	return result

end)

Melia.Hook("WORLDMAP2_MINIMAP_INFO_SETTING", function(original, result, frame)

	local hideChildren = {
		"minimap_level_text",
		"minimap_challenge_text",
		"minimap_star_rate",
		"minimap_info_tab",
		"minimap_quest_tab_text",
		"minimap_npc_tab_text",
		"minimap_monster_tab_text",
		"minimap_nothing_text",
		"minimap_info_bg_frame",
		"minimap_info_bg",
	}

	-- Hide level and other info elements that depend on client data
	for _, childName in ipairs(hideChildren) do
		local child = frame:GetChild(childName)
		if child ~= nil then
		child:ShowWindow(0)
		end
	end

	-- Center minimap
	local grpMinimap = frame:GetChild("minimap_pic_bg")
	local margin = grpMinimap:GetMargin()
	grpMinimap:SetMargin(0, margin.top, margin.right, margin.bottom)

	return result

end)

Melia.Hook("MAP_OPEN", function(original, result, frame)

    local imgMap = GET_CHILD_RECURSIVELY(frame, "map")
    imgMap:GetChild("mapRank"):ShowWindow(0)
    imgMap:GetChild("monlv"):ShowWindow(0)

	return result

end)
