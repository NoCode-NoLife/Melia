local sysmenuFrame = ui.GetFrame("sysmenu")
local partyappsFrame = ui.GetFrame("partyapps")

local skilltreenoticeGb = GET_CHILD_RECURSIVELY(sysmenuFrame, "skilltreenotice", "ui::CGroupBox")
local friendnoticeGb = GET_CHILD_RECURSIVELY(sysmenuFrame, "friendnotice", "ui::CGroupBox")
local statusnoticeGb = GET_CHILD_RECURSIVELY(sysmenuFrame, "statusnotice", "ui::CGroupBox")
local journalnoticeGb = GET_CHILD_RECURSIVELY(sysmenuFrame, "journalnotice", "ui::CGroupBox")

Melia.Ui.SysMenu.HideNoticeTexts = function()
	skilltreenoticeGb:SetMargin(0, 0, -9999, 0)
	friendnoticeGb:SetMargin(0, 0, -9999, 0)
	statusnoticeGb:SetMargin(0, 0, -9999, 0)
	journalnoticeGb:SetMargin(0, 0, -9999, 0)
	partyappsFrame:SetMargin(0, 0, -9999, 0)
end

Melia.Ui.SysMenu.CreateButton = function(index, name, icon, tooltip, onClick)
	local marginRight = index * 38

	local newBtn = sysmenuFrame:CreateControl("button", name, 0, 0, 38, 44)
	AUTO_CAST(newBtn)
	newBtn:SetMargin(0, 0, marginRight, 10)
	newBtn:SetGravity(ui.RIGHT, ui.BOTTOM)
	newBtn:SetImage(icon)
	newBtn:SetTextTooltip("{@st59}" .. tooltip .. "{/}");

	if onClick then
		newBtn:SetEventScript(ui.LBUTTONUP, onClick, true)
	end

	if icon == "sysmenu_skill" then
		skilltreenoticeGb:SetMargin(0, 0, marginRight - 8, 40)
		skilltreenoticeGb:MakeTopBetweenChild()
	elseif icon == "sysmenu_friend" then
		friendnoticeGb:SetMargin(0, 0, marginRight - 8, 40)
		friendnoticeGb:MakeTopBetweenChild()
	elseif icon == "sysmenu_my" then
		statusnoticeGb:SetMargin(0, 0, marginRight, 40)
		statusnoticeGb:MakeTopBetweenChild()
	elseif icon == "sysmenu_qu" then
		journalnoticeGb:SetMargin(0, 0, marginRight - 8, 40)
		journalnoticeGb:MakeTopBetweenChild()
	elseif icon == "sysmenu_party" then
		partyappsFrame:SetMargin(0, 0, marginRight - 3, 55)
	end
end
