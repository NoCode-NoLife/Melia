Melia.Hook("WORLDMAP2_MAINMAP_DRAW_CITY", function(original, result, frame, mapData)

	local episode = mapData.ClassName
	
	local setEpisode = GET_CHILD_RECURSIVELY(frame, episode)
	if setEpisode == nil then
		return result
	end
	
	-- Replace episode text with "Area" for city areas
    local btnEpisode = AUTO_CAST(setEpisode:GetChild("city_episode_text"))
    btnEpisode:SetText("{@st100white_16}Area")

	return result

end)

Melia.Override("WORLDMAP2_SUBMAP_EFFECT_ON_ZONE_CHECK", function(original, frame)
	-- Don't add glowing green circle around maps
end)
