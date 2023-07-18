local sysmenuFrame = ui.GetFrame("sysmenu")

Melia.Ui.SysMenu.Clear = function()
	sysmenuFrame:RemoveChildByType("button")
	
	Melia.Ui.SysMenu.Buttons = {}
	Melia.Ui.SysMenu.HideNoticeTexts()

	Melia.Ui.SysMenu.Refresh()
end

Melia.Ui.SysMenu.Refresh = function()
	if Melia.Ui.SysMenu.RefreshSuspended == true then
		return
	end

	sysmenuFrame:RemoveChildByType("button")
	Melia.Ui.SysMenu.HideNoticeTexts()

	for i = 1, #Melia.Ui.SysMenu.Buttons do
		local btnInfo = Melia.Ui.SysMenu.Buttons[i]
		local index = i - 1

		Melia.Ui.SysMenu.CreateButton(index, btnInfo.name, btnInfo.icon, btnInfo.tooltip, btnInfo.onClick)
	end
end

Melia.Ui.SysMenu.SuspendRefresh = function()
	Melia.Ui.SysMenu.RefreshSuspended = true
end

Melia.Ui.SysMenu.ResumeRefresh = function()
	Melia.Ui.SysMenu.RefreshSuspended = false
	Melia.Ui.SysMenu.Refresh()
end
