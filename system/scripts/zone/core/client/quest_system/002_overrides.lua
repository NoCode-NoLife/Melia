Melia.Override("QUEST_UPDATE_ALL", function(original, frame)
	-- do nothing
end)

Melia.Override("QUESTINFOSET_2_QUEST_ANGLE", function(original, frame, msg, argStr, argNum)
	-- Block the original function completely - it tries to hide/show the chase window
	-- during movement which causes flickering. We manage visibility ourselves.
	-- Do nothing here.
end)

Melia.Override("CHASEINFO_CLOSE_FRAME", function(original)
	-- Block the game from closing questinfoset_2 during dash/skills
	-- The original function closes chaseinfo, achieveinfoset, and questinfoset_2
	-- We manage questinfoset_2 visibility ourselves, so only close the others
	ui.CloseFrame("chaseinfo")
	ui.CloseFrame("achieveinfoset")
	-- Don't close questinfoset_2 - we manage it ourselves
end)

Melia.Override("QUEST_TAB_CHANGE", function(original, frame, argStr, argNum)
	local topFrame = frame:GetTopParentFrame();
	local questbox_tab = GET_CHILD_RECURSIVELY(topFrame, "questBox", "ui::CTabControl");
	local index = questbox_tab:GetSelectItemIndex();

	topFrame:SetUserValue("CurTabIndex", index);

	local levelOption = GET_QUEST_LEVEL_OPTION(index);
	if levelOption ~= nil then
		SET_QUEST_LEVEL_OPTION(levelOption);
	end
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
	UPDATE_QUEST_FILTER_ALLCHECK()
	SET_QUEST_MODE_OPTION(GET_QUEST_FILTER_OPTION_LIST())

	M_QUESTS_UPDATE_LIST()
end)
