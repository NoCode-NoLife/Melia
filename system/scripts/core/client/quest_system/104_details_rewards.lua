function M_QUESTS_DETAILS_ADD_REWARDS(frame, x, y, quest)
	local height = 0
	local offsetX = 10
	local iconSize = 22
	local width = frame:GetWidth() - x - SCROLL_WIDTH

	local lblTitle = frame:CreateOrGetControl("richtext", "QuestRewards", x, y + height, width, 10)
	lblTitle:EnableHitTest(0)
	lblTitle:SetTextFixWidth(1)
	lblTitle:SetText("{img quest_detail_pic4 24 24}{@st41b}Rewards{/}")

	height = height + lblTitle:GetHeight() + 10
	
	if quest.Rewards == nil or #quest.Rewards == 0 then
		local lblNone = frame:CreateOrGetControl("richtext", "QuestRewardsNone", x + offsetX, y + height, width, 10)
		lblNone:EnableHitTest(0)
		lblNone:SetTextFixWidth(1)
		lblNone:SetText("{@st68}None{/}")

		height = height + lblNone:GetHeight() + 10
	else
		for i = 1, #quest.Rewards do
			local reward = quest.Rewards[i]
		
			local icon = reward.Icon
			local iconWidth = 0
			local iconSpacing = 5

			if icon ~= nil then
				local itemClassId = tonumber(string.match(icon, "Item:(%d+)"))
				if itemClassId ~= nil then
					local itemCls = GetClassByType("Item", itemClassId);
					icon = GET_ITEM_ICON_IMAGE(itemCls)
				end

				local imgIcon = frame:CreateOrGetControl("picture", "QuestRewardIcon" .. tostring(i), x + offsetX, y + height, iconSize, iconSize);
				AUTO_CAST(imgIcon)

				imgIcon:SetImage(icon)
				imgIcon:SetEnableStretch(1)
				iconWidth = imgIcon:GetWidth() + iconSpacing
			end

			local lblDesc = frame:CreateOrGetControl("richtext", "QuestRewardDesc" .. tostring(i), x + offsetX + iconWidth, y + height, width, 10)
			lblDesc:EnableHitTest(0)
			lblDesc:SetTextFixWidth(1)
			lblDesc:SetText("{@st68}" .. reward.Text .. "{/}")

			height = height + lblDesc:GetHeight() + 10
		end
	end

	return height
end
