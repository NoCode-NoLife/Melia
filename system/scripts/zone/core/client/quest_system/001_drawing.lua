function M_QUESTS_DRAW_LIST(frame, quests)
	local x = 10
	local y = 0
	
	frame:DeleteAllControl()

	for i = 1, #quests do
		local quest = quests[i]
		y = y + M_QUESTS_DRAW_QUEST(frame, quest, i, x, y)
	end

	frame:Invalidate()
end

function M_QUESTS_DRAW_QUEST(frame, quest, i, x, y)
	local questCtrl = frame:CreateOrGetControlSet("quest_list_oneline", "QuestItemTest" .. i, 10, y)
	AUTO_CAST(questCtrl)
	
	if i % 2 == 0 then
		questCtrl:SetSkinName("chat_window_2")
	end

	M_QUESTS_SET_NAME(questCtrl, quest)
	M_QUESTS_SET_ICON(questCtrl, quest)
	M_QUESTS_SET_BUTTONS(questCtrl, quest)
	M_QUESTS_SET_CHASE(questCtrl, quest)

	questCtrl:SetEventScript(ui.LBUTTONDOWN, "M_QUESTS_CLICK_INFO")
	questCtrl:SetEventScriptArgString(ui.LBUTTONDOWN, quest.ObjectId)

	return questCtrl:GetHeight()
end
