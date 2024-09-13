local lastQuestObjectId = -1

function M_QUESTS_CLICK_INFO(frame, control, argStr, argNum)
	local quest = Melia.Quests.Get(argStr)
	if quest == nil then
		return
	end

	M_QUESTS_DETAILS_OPEN(quest)
end

function M_QUESTS_DETAILS_OPEN(quest)
	local frame = ui.GetFrame("questdetail")
	local gbBody = frame:GetChild("gbBody")

	if frame:IsVisible() == 1 and quest.ObjectId == lastQuestObjectId then
		frame:ShowWindow(0)
		return
	end 
	
	M_QUESTS_DETAILS_INFO_REBUILD(quest)
	frame:ShowWindow(1)

	lastQuestObjectId = quest.ObjectId
end

function M_QUESTS_DETAILS_CLOSE()
	local frame = ui.GetFrame("questdetail")
	frame:ShowWindow(0)
end

function M_QUESTS_DETAILS_UPDATE(quest)
	local frame = ui.GetFrame("questdetail")
	local gbBody = frame:GetChild("gbBody")

	if frame:IsVisible() == 1 and quest.ObjectId == lastQuestObjectId then
		M_QUESTS_DETAILS_INFO_REBUILD(quest)
		frame:ShowWindow(1)
	end
end

function M_QUESTS_DETAILS_INFO_REBUILD(quest)
	local frame = ui.GetFrame("questdetail")

	local gbBody = frame:GetChild("gbBody")
	AUTO_CAST(gbBody)
	gbBody:DeleteAllControl()
	
	local xPos = frame:GetWidth() - 120
	local x = 10;
	local y = 20;
	local spaceY = 20

	M_QUESTS_DETAILS_SET_TITLE(frame, quest)
	y = y + M_QUESTS_DETAILS_ADD_SUMMARY(gbBody, x, y, quest) + spaceY

	if Melia.Conf.GetBool("display_quest_objectives") then
		y = y + M_QUESTS_DETAILS_ADD_OBJECTIVES(gbBody, x, y, quest) + spaceY
	end

	y = y + M_QUESTS_DETAILS_ADD_REWARDS(gbBody, x, y, quest) + spaceY
	y = y + M_QUESTS_DETAILS_ADD_BUTTONS(gbBody, x, y, quest) + spaceY
	
	gbBody:Resize(gbBody:GetWidth(), y)
	frame:Resize(xPos, frame:GetY(), frame:GetWidth(), y + 100)
	frame:Invalidate()

	return y
end
