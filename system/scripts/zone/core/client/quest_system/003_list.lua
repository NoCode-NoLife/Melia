function M_QUESTS_SET_NAME(questCtrl, quest)
	local txtName = GET_CHILD(questCtrl, "name", "ui::CRichText")
	local lvlText = GET_CHILD(questCtrl, "level", "ui::CRichText")
	
	txtName:SetText("{@s16}{#ffffff}" .. quest.Name)	
	lvlText:SetText("{#ffffff}" .. "Lv " .. quest.Level)
end

function M_QUESTS_SET_ICON(questCtrl, quest)
	local iconName = "minimap_clear"
	local questmark = GET_CHILD(questCtrl, "questmark", "ui::CPicture")

	if not quest.Done then
		questmark:EnableHitTest(1)
		questmark:SetTextTooltip("{@st59}The quest is in progress.{/}")
	else
		questmark:EnableHitTest(1)
		questmark:SetTextTooltip("{@st59}The quest's objectives have been cleared.{/}")
		iconName = "minimap_1_MAIN"
	end

	questmark:SetImage(iconName)
	questmark:ShowWindow(1)
end

function M_QUESTS_SET_BUTTONS(questCtrl, quest)
	local shareParty = GET_CHILD_RECURSIVELY(questCtrl, "shareParty")
	local questPositionCheck = GET_CHILD_RECURSIVELY(questCtrl, "questPositionCheck")
	local abandonquest_try = GET_CHILD_RECURSIVELY(questCtrl, "abandonquest_try")
	local dialogReplay = GET_CHILD_RECURSIVELY(questCtrl, "dialogReplay")
	local abandon = GET_CHILD_RECURSIVELY(questCtrl, "abandon")

	shareParty:ShowWindow(0)
	questPositionCheck:ShowWindow(0)
	abandonquest_try:ShowWindow(0)
	dialogReplay:ShowWindow(0)
	abandon:ShowWindow(0)
end
