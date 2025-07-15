function M_QUESTS_UPDATE_LIST()
	local questFrame = ui.GetFrame("quest")
	local gb_progressQuest = GET_CHILD_RECURSIVELY(questFrame, "gb_progressQuestItem", "ui::CGroupBox")
	local quests = Melia.Quests.GetAll()

	M_QUESTS_DRAW_LIST(gb_progressQuest, quests)
	M_CHASE_UPDATE_VISIBILITY()
end

M_QUESTS_UPDATE_LIST()
