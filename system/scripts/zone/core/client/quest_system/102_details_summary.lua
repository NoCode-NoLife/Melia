function M_QUESTS_DETAILS_SET_TITLE(frame, quest)
	local title = GET_CHILD_RECURSIVELY(frame, "title")
	local level = GET_CHILD_RECURSIVELY(frame, "level")

	title:SetTextByKey("text", quest.Name)
	level:SetTextByKey("text", ScpArgMsg("Level{Level}", "Level", quest.Level))
end

function M_QUESTS_DETAILS_ADD_SUMMARY(frame, x, y, quest)
	local height = 0
	local offsetX = 10

	local description = quest.Description and quest.Description or "No description given."
	
	local contentTitle = frame:CreateOrGetControl("richtext", "QuestSummary", x, y + height, frame:GetWidth() - x - SCROLL_WIDTH, 10)
	contentTitle:EnableHitTest(0)
	contentTitle:SetTextFixWidth(1)
	contentTitle:SetText("{img quest_detail_pic2 24 24}{@st41b}Description{/}")
   
	height = height + contentTitle:GetHeight() + 10

	local content = frame:CreateOrGetControl("richtext", "QuestSummaryDesc", x + offsetX, y + height, frame:GetWidth() - x - SCROLL_WIDTH, 10)
	content:EnableHitTest(0)
	content:SetTextFixWidth(1)
	content:SetText("{@st68}" .. description .. "{/}")
   
	height = height + content:GetHeight()

	return height
end
