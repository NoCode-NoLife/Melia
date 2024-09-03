local _questList = {}

Melia.Quests = {}

Melia.Quests.Add = function(quest)
	Melia.Quests.Restore(quest)
	ui.SysMsg("New Quest: " .. quest.Name)
end

Melia.Quests.Restore = function(quest)
	table.insert(_questList, quest)
	M_QUESTS_UPDATE_LIST()
end

Melia.Quests.Update = function(quest)
	local existingQuest = Melia.Quests.Get(quest.ObjectId)
	if existingQuest ~= nil then
		existingQuest.Status = quest.Status
		existingQuest.Done = quest.Done
		existingQuest.Objectives = quest.Objectives
		
		M_QUESTS_UPDATE_LIST()
		M_QUESTS_DETAILS_UPDATE(existingQuest)
	end
end

Melia.Quests.Get = function(questObjectId)
	for i = 1, #_questList do
		local quest = _questList[i]
		if quest.ObjectId == questObjectId then
			return quest
		end
	end

	return nil
end

Melia.Quests.GetAll = function()
	return _questList
end

Melia.Quests.Remove = function(questObjectId)
	for i = 1, #_questList do
		local quest = _questList[i]
		if quest.ObjectId == questObjectId then
			table.remove(_questList, i)

			M_QUESTS_UPDATE_LIST()
			M_QUESTS_DETAILS_CLOSE()
			return
		end
	end
end

Melia.Quests.CountTracked = function()
	local result = 0
	
	for i = 1, #_questList do
		local quest = _questList[i]
		if quest.Tracked then
			result = result + 1
		end
	end

	return result
end

Melia.Quests.RequestComplete = function(questObjectId)
	ui.Chat("/quest complete " .. questObjectId)
end

Melia.Quests.RequestCancel = function(questObjectId)
	ui.Chat("/quest cancel " .. questObjectId)
end

Melia.Quests.RequestTrack = function(questObjectId, enabled)
	ui.Chat("/quest track " .. questObjectId .. " " .. tostring(enabled))
end
