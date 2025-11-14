local questFrame = ui.GetFrame("quest")

local function RemoveObsoleteUiElements()
	questFrame:GetChild("bg"):GetChild("tipMessage"):SetVisible(false)

	local questBox = GET_CHILD_RECURSIVELY(questFrame, "questBox", "ui::CTabControl")
	if questBox:GetItemCount() > 1 then
		questBox:DeleteTab(3) -- Res Sacrae w/e
		questBox:DeleteTab(2) -- Complete
		questBox:DeleteTab(0) -- Episodes
	end
	questBox:SelectTab(0) -- Quest List
end

function M_QUESTS_UPDATE_LIST()
	local gb_progressQuest = GET_CHILD_RECURSIVELY(questFrame, "gb_progressQuestItem", "ui::CGroupBox")
	local quests = Melia.Quests.GetAll()

	M_QUESTS_DRAW_LIST(gb_progressQuest, quests)
	M_CHASE_UPDATE_VISIBILITY()
end

RemoveObsoleteUiElements()
M_QUESTS_UPDATE_LIST()
