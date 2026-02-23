Melia.Override("INVENTORY_OPEN", function(original, frame)
	original(frame)
	
	local function disable(frame, name)
		local ctrl = GET_CHILD_RECURSIVELY(frame, name, "ui::CControl")
		if ctrl ~= nil then
			ctrl:ShowWindow(0)
		end
	end
	
	local function resize(frame, name, x, y, w, h)
		local ctrl = GET_CHILD_RECURSIVELY(frame, name, "ui::CControl")
		if ctrl ~= nil then
			ctrl:Resize(x, y, w, h)
		end
	end

	-- Disable undesired controls after original call
	disable(frame, "helper_btn")
	disable(frame, "cabinet_btn")
	disable(frame, "goddess_mgr_btn")
	disable(frame, "core_manager")
	disable(frame, "relic_manager")
	disable(frame, "trustPointGbox")
	
	-- Move/Resize controls to fill space
	resize(frame, "weightGbox", 40, 0, 96, 33 * 2 + 1)
	resize(frame, "inventory_weight_name_bg", 0, 0, 96, 33 * 2 + 1)
end)
