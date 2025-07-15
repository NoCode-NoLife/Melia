local function RemoveObsoleteUiElements()
	local questFrame = ui.GetFrame("quest")
	questFrame:GetChild("bg"):GetChild("tipMessage"):SetVisible(false)

	local tabCtrl = GET_CHILD_RECURSIVELY(questFrame, "questBox", "ui::CTabControl")
	if tabCtrl:GetItemCount() > 1 then
		tabCtrl:DeleteTab(3) -- Res Sacrae w/e
		tabCtrl:DeleteTab(2) -- Complete
		tabCtrl:DeleteTab(0) -- Episodes
	end
	tabCtrl:SelectTab(0) -- Quest List

	local statusFilterGroup = GET_CHILD_RECURSIVELY(questFrame, "checkbox_Gbox", "ui::CGroupBox")
	local progressGroup = GET_CHILD_RECURSIVELY(questFrame, "gb_progressQuest", "ui::CGroupBox")
	local searchGroup = GET_CHILD_RECURSIVELY(questFrame, "gb_searchGbox", "ui::CGroupBox")
	local bodyGroup = GET_CHILD_RECURSIVELY(questFrame, "gb_body", "ui::CGroupBox")
	local levelFilter1 = GET_CHILD_RECURSIVELY(questFrame, "progressLeveLFilterOpt_1", "ui::CRadioButton")
	local levelFilter2 = GET_CHILD_RECURSIVELY(questFrame, "progressLeveLFilterOpt_2", "ui::CRadioButton")
	
	local top = tabCtrl:GetY() + 4
	local bodyMargin = bodyGroup:GetMargin()

	progressGroup:SetMargin(0, top, 0, 0)
	searchGroup:SetMargin(0, 0, 0, 0)
	bodyGroup:SetMargin(bodyMargin.left, searchGroup:GetY() + searchGroup:GetHeight(), bodyMargin.right, bodyMargin.bottom)
	bodyGroup:Resize(bodyGroup:GetOriginalWidth(), bodyGroup:GetOriginalHeight() + tabCtrl:GetHeight() + statusFilterGroup:GetHeight())
	
	statusFilterGroup:SetVisible(false)
	levelFilter1:SetVisible(false)
	levelFilter2:SetVisible(false)
	tabCtrl:SetVisible(false)
end

RemoveObsoleteUiElements()
