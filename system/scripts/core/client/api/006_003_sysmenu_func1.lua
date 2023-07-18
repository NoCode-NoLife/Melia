local sysmenuFrame = ui.GetFrame("sysmenu")

Melia.Ui.SysMenu.Clear = function()
	sysmenuFrame:RemoveChildByType("button")
	Melia.Ui.SysMenu.HideNoticeTexts()
	Melia.Ui.SysMenu.Buttons = {}
end

Melia.Ui.SysMenu.Refresh = function()
	sysmenuFrame:RemoveChildByType("button")
	Melia.Ui.SysMenu.HideNoticeTexts()

	for i = 1, #Melia.Ui.SysMenu.Buttons do
		local btnInfo = Melia.Ui.SysMenu.Buttons[i]
		local index = i - 1

		Melia.Ui.SysMenu.CreateButton(index, btnInfo.name, btnInfo.icon, btnInfo.tooltip, btnInfo.onClick)
	end
end
