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

	local function addSection(title, text)
		if text and text ~= "" then
			height = height + 15
			local t = frame:CreateOrGetControl("richtext", "Quest"..title, x, y + height, frame:GetWidth() - x - SCROLL_WIDTH, 10)
			t:EnableHitTest(0)
			t:SetTextFixWidth(1)
			t:SetText("{img quest_detail_pic2 24 24}{@st41b}"..title.."{/}")
			height = height + t:GetHeight() + 10
			local c = frame:CreateOrGetControl("richtext", "Quest"..title.."Desc", x + offsetX, y + height, frame:GetWidth() - x - SCROLL_WIDTH, 10)
			c:EnableHitTest(0)
			c:SetTextFixWidth(1)
			c:SetText("{@st68}"..text.."{/}")
			height = height + c:GetHeight()
		end
	end

	addSection("Location", quest.Location)
	local giverText = quest.QuestGiver
	if quest.QuestGiverLocation then
		giverText = (giverText or "") .. (giverText and " (" or "(") .. quest.QuestGiverLocation .. ")"
	end
	addSection("Quest Giver", giverText)

	return height
end
