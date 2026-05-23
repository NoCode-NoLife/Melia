function M_QUESTS_DETAILS_ADD_OBJECTIVES(frame, x, y, quest)
	local height = 0
	local offsetX = 10
	local checkSize = 10
	local checkSpacing = 5
	local width = frame:GetWidth() - x - SCROLL_WIDTH

	local lblTitle = frame:CreateOrGetControl("richtext", "QuestObjectives", x, y + height, width, 10)
	lblTitle:EnableHitTest(0)
	lblTitle:SetTextFixWidth(1)
	lblTitle:SetText("{img quest_detail_pic3 24 24}{@st41b}Objectives{/}")

	height = height + lblTitle:GetHeight() + 10

	if quest.Objectives == nil or #quest.Objectives == 0 then
		local lblNone = frame:CreateOrGetControl("richtext", "QuestObjectivesNone", x + offsetX, y + height, width, 10)
		lblNone:EnableHitTest(0)
		lblNone:SetTextFixWidth(1)
		lblNone:SetText("{@st68}None{/}")

		height = height + lblNone:GetHeight() + 10
	else
		for i = 1, #quest.Objectives do
			local objective = quest.Objectives[i]

			local chkComplete = frame:CreateOrGetControl("checkbox", "QuestObjectiveCheck" .. tostring(i), x + offsetX, y + height, checkSize, checkSize)
			AUTO_CAST(chkComplete)
			chkComplete:EnableHitTest(0)

			if objective.Done then
				chkComplete:ToggleCheck()
			end

			local lblDesc = frame:CreateOrGetControl("richtext", "QuestObjectiveDesc" .. tostring(i), x + offsetX + chkComplete:GetWidth() + checkSpacing, y + height + 3, width, 10)
			lblDesc:SetTextFixWidth(1)
			if not objective.Unlocked then
				lblDesc:SetText(string.format("{@st68}?{/}"))
				lblDesc:SetTextTooltip("{@st59}Continue the quest to reveal this objective.{/}")
			else
				local t=objective.Text
                if objective.TargetCount>1 then t=t.." ("..objective.Count.."/"..objective.TargetCount..")" end
                if objective.Monsters and #objective.Monsters>0 then t=t.."{nl}• "..table.concat(objective.Monsters,"{nl}• ") end
                lblDesc:SetText(string.format("{@st68}%s{/}",t))
            end

			height = height + lblDesc:GetHeight() + 10
		end
	end

	return height
end
