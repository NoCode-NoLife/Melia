function M_CREATE_MAP_ICON(parent, ctrlName, icon, mapProp, mapWidth, mapHeight, offsetX, offsetY)
	mapWidth = mapWidth or m_mapWidth
	mapHeight = mapHeight or m_mapHeight
	offsetX = offsetX or m_offsetX
	offsetY = offsetY or m_offsetY

	local mapPos = mapProp:WorldPosToMinimapPos(icon.WorldPos.X, icon.WorldPos.Z, mapWidth, mapHeight)
	local iconWidth = icon.Width or iconW
	local iconHeight = icon.Height or iconH
	local drawX = offsetX + mapPos.x - iconWidth / 2
	local drawY = offsetY + mapPos.y - iconHeight / 2
	local imageName = icon.Image or "minimap_0"

	local imgIcon = parent:CreateOrGetControl("picture", ctrlName, drawX, drawY, iconWidth, iconHeight)
	tolua.cast(imgIcon, "ui::CPicture")

	imgIcon:SetImage(imageName)
	imgIcon:SetEnableStretch(1)
	imgIcon:SetEnable(1)
	imgIcon:EnableChangeMouseCursor(1)
	
	if icon.Tooltip then
		imgIcon:SetTextTooltip("{@st59}" .. icon.Tooltip .. "{/}");
	end
	
	return imgIcon
end
