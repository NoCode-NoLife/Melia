Melia.Override("UI_LIB_TAB_ADD_TAB_LIST", function(original, parent, tab, addTabInfoList, width, height, uiHorizontal, uiVertical, x, y, groupBoxKey, groupBoxValue, tabWidth, tabItemKeyName)
	-- Set tab width to nil to enable auto width if there's more than 2 tabs
	if groupBoxKey == "job_tab_box" and tabItemKeyName == "JobClsName" and tab:GetItemCount() > 4 then
		tabWidth = nil
	end

	return original(parent, tab, addTabInfoList, width, height, uiHorizontal, uiVertical, x, y, groupBoxKey, groupBoxValue, tabWidth, tabItemKeyName)
end)
