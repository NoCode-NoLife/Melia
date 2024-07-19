local sysmenuFrame = ui.GetFrame("sysmenu")

Melia.Ui.RestMenu.Buttons = {}

Melia.Ui.RestMenu.Clear = function()
	Melia.Ui.RestMenu.Buttons = {}
end

Melia.Ui.RestMenu.AddButton = function(cls)
	table.insert(Melia.Ui.RestMenu.Buttons, cls)
end

Melia.Ui.RestMenu.RemoveButton = function(name)
	for i, cls in ipairs(Melia.Ui.RestMenu.Buttons) do
		if cls.Script == name then
			table.remove(Melia.Ui.RestMenu.Buttons, i)
			return
		end
	end
end

local list, count = GetClassList("restquickslotinfo")
for i = 0, count - 1 do
	local cls = GetClassByIndexFromList(list, i)
	if cls ~= nil and (cls.VisibleScript == "None" or _G[cls.VisibleScript]() == 1) then
		-- icon_rest_fire -> RestFire
		--local name = cls.Icon:gsub("^icon_", ""):gsub("^(%a)", string.upper):gsub("_([%w])", string.upper):gsub("_", "")

		Melia.Ui.RestMenu.AddButton(cls)
	end
end

Melia.Override("ON_RESTQUICKSLOT_OPEN", function(original, frame, msg, argStr, argNum)
	for i, cls in ipairs(Melia.Ui.RestMenu.Buttons) do
		local slot = GET_CHILD(frame, "slot"..i, "ui::CSlot")
		if slot ~= nil then
			slot:ReleaseBlink()
			slot:ClearIcon()
			SET_REST_QUICK_SLOT(slot, cls)
		end
	end

	frame:ShowWindow(1);

	if IsJoyStickMode() == 0 then
		local quickFrame = ui.GetFrame("quickslotnexpbar")
		quickFrame:ShowWindow(0);
	elseif IsJoyStickMode(pc) == 1 then
		local joystickQuickFrame = ui.GetFrame("joystickquickslot")
		joystickQuickFrame:ShowWindow(0);
	end

	OPEN_REST_QUICKSLOT(frame);
end)
