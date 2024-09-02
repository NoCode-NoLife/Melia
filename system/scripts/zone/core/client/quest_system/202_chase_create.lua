function M_CHASE_REDRAW(frame)
	local ctrl = GET_CHILD(frame, "member", "ui::CGroupBox")

	local txtCustomName = GET_CHILD(frame, "quest_custom_name")
	local chkCustomName = GET_CHILD(frame, "quest_custom")
	txtCustomName:ShowWindow(0)
	chkCustomName:ShowWindow(0)

	ctrl:DeleteAllControl();
	
	local quests = Melia.Quests.GetAll()
	local x = 0
	local y = 0

	for i = 1, #quests do
		local quest = quests[i]

		-- Only lists quests with non-nil lists of objectives
		if quest.Objectives ~= nil then
			local height = M_CHASE_CREATE_QUEST(frame, ctrl, quest, x, y)
			y = y + height
		end
	end

	frame:Invalidate()
end

function M_CHASE_CREATE_QUEST(frame, ctrl, quest, x, y)
	local width = frame:GetWidth() - x - SCROLL_WIDTH

	local ctrlQuest = ctrl:CreateOrGetControlSet("emptyset2", "_Q_" .. quest.ObjectId, x, y)
	tolua.cast(ctrlQuest, "ui::CControlSet")
	
	local skinName = frame:GetUserConfig("CTRLSETSKINNAME")
	ctrlQuest:SetSkinName(skinName)
	ctrlQuest:Resize(width, 30)
	
	local lblTitle = ctrlQuest:CreateOrGetControl("richtext", "title", 0, 0, ctrlQuest:GetWidth(), 30)
	lblTitle:SetText(QUEST_TITLE_FONT .. quest.Name)
	lblTitle:EnableHitTest(0)
	
	local titleHeight = lblTitle:GetHeight()

	local objectivesHeight = M_CHASE_CREATE_OBJECTIVES(ctrlQuest, quest, 0, titleHeight + 5)
	local height = titleHeight + objectivesHeight + 3
	
	ctrlQuest:Resize(ctrlQuest:GetWidth(), height)

	return height
end
