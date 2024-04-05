Melia.Override("QUEST_UPDATE_ALL", function(original, frame)
	-- do nothing
end)

Melia.Override("QUEST_FILTER_UPDATE", function(original, frame, control, argStr, argNum)
	-- TODO: Filter

	AUTO_CAST(control)

	if control:GetName() == "mode_all_check" then
		local isChecked = control:IsChecked();

		local list = { "mode_main_check", "mode_sub_check", "mode_repeat_check", "mode_party_check", "mode_keyitem_check", "mode_chase_check" }
		for i = 1, #list do
			local checkbox = GET_CHILD(frame, list[i], "ui::CCheckBox");
			if checkbox ~= nil then
				checkbox:SetCheck(isChecked);
			end
		end
	end
end)
