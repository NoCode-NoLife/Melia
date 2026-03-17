Melia.Hook("CHANGEJOB_OPEN", function(original, result, frame)
	local class_select = GET_CHILD_RECURSIVELY(frame, "resetInfoBox")
	class_select:ShowWindow(0)
	
	local class_select_multiple = GET_CHILD_RECURSIVELY(frame, "use_free_txt")
	class_select_multiple:ShowWindow(0)

	return result
end)
