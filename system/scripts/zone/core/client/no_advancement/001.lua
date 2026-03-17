Melia.Override("ON_CHANGE_JOB_BUTTON", function(original, frame, msg, name, range)
	frame:ShowWindow(0)
end)

Melia.Override("CHANGEJOB_OPEN", function(original, frame)
	original(frame)

	local class_select = GET_CHILD_RECURSIVELY(frame, "class_select")
	class_select:ShowWindow(0)
end)
