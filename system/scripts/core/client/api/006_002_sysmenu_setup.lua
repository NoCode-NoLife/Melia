local sysmenuFrame = ui.GetFrame("sysmenu")

local skilltreenoticeGb = GET_CHILD_RECURSIVELY(sysmenuFrame, "skilltreenotice", "ui::CGroupBox")
local friendnoticeGb = GET_CHILD_RECURSIVELY(sysmenuFrame, "friendnotice", "ui::CGroupBox")
local statusnoticeGb = GET_CHILD_RECURSIVELY(sysmenuFrame, "statusnotice", "ui::CGroupBox")
local journalnoticeGb = GET_CHILD_RECURSIVELY(sysmenuFrame, "journalnotice", "ui::CGroupBox")

function M_SYSMENU_BTN_DEFAULT()
	ui.MsgBox("Button clicked!")
end

if not Melia.Ui.SysMenu.ButtonTemplate then
	local otherBtn = sysmenuFrame:GetChild("system")
	
	local buttonTpl = sysmenuFrame:CreateControl("button", "ButtonTemplate", 0, 0, 38, 44)
	buttonTpl:CloneFrom(otherBtn)
	AUTO_CAST(buttonTpl)
	
	buttonTpl:SetMargin(0, 0, 0, 0)
	buttonTpl:SetTextTooltip("{@st59}Button tooltip");
	buttonTpl:SetEventScript(ui.LBUTTONUP, "M_SYSMENU_BTN_DEFAULT()");
	
	Melia.Ui.SysMenu.ButtonTemplate = buttonTpl

	sysmenuFrame:RemoveChild("ButtonTemplate")
end
