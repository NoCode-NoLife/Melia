function M_CHASE_CREATE_OBJECTIVES(parent, quest, x, y)
	if quest.Objectives == nil or #quest.Objectives == 0 then
		return 0
	end

	local height = 0
	local offsetX = 10
	local checkSize = 10
	local checkSpacing = 5
	local width = parent:GetWidth() - x - SCROLL_WIDTH
	local textWidth = width - offsetX - checkSize - checkSpacing
	local textStyle = "{@s16}{#ffffff}";

	for i = 1, #quest.Objectives do
		local objective = quest.Objectives[i]

		local chkComplete = parent:CreateOrGetControl("checkbox", "QuestObjectiveCheck" .. tostring(i), x + offsetX, y + height, checkSize, checkSize)
		AUTO_CAST(chkComplete)
		chkComplete:EnableHitTest(0)

		if objective.Done then
			chkComplete:ToggleCheck()
		end

		local lblDesc = parent:CreateOrGetControl("richtext", "QuestObjectiveDesc" .. tostring(i), x + offsetX + chkComplete:GetWidth() + checkSpacing, y + height + 3, textWidth, 10)
		--lblDesc:EnableHitTest(0)
		lblDesc:SetTextFixWidth(1)

		if not objective.Unlocked then
			lblDesc:SetText(string.format(textStyle .. "?{/}"))
			lblDesc:SetTextTooltip("{@st59}Continue the quest to reveal this objective.{/}")
		elseif objective.TargetCount <= 1 then
			lblDesc:SetText(string.format(textStyle .. "%s{/}", objective.Text))
		else
			lblDesc:SetText(string.format(textStyle .. "%s (%d/%d){/}", objective.Text, objective.Count, objective.TargetCount))
		end

		height = height + lblDesc:GetHeight() + 10
	end

	return height
end
