local sysmenuFrame = ui.GetFrame("sysmenu")

Melia.Ui.SysMenu.AddButton = function(name, icon, tooltip, onClick)
	local btnCount = #Melia.Ui.SysMenu.Buttons
	local pos = btnCount + 1
	
	local btnInfo = { ["name"] = name, ["icon"] = icon, ["tooltip"] = tooltip, ["onClick"] = onClick }
	table.insert(Melia.Ui.SysMenu.Buttons, pos, btnInfo)

	Melia.Ui.SysMenu.Refresh()
end

Melia.Ui.SysMenu.InsertButton = function(pos, name, icon, tooltip, onClick)
	local btnCount = #Melia.Ui.SysMenu.Buttons
	pos = math.max(1, math.min(btnCount + 1, pos))
	
	local btnInfo = { ["name"] = name, ["icon"] = icon, ["tooltip"] = tooltip, ["onClick"] = onClick }
	table.insert(Melia.Ui.SysMenu.Buttons, pos, btnInfo)

	Melia.Ui.SysMenu.Refresh()
end

Melia.Ui.SysMenu.RemoveButton = function(name)
	local buttons = Melia.Ui.SysMenu.Buttons

	for	i = 1, #buttons do
		local btnInfo = buttons[i]
		if btnInfo.name == name then
			table.remove(buttons, i)
			break
		end
	end

	Melia.Ui.SysMenu.Refresh()
end
