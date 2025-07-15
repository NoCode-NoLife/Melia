Melia.Override("STATUS_HIDDEN_JOB_UNLOCK_VIEW", function(original, pc, opc, frame, gboxctrl, y)
	-- Don't show list of unlocked jobs
	return y
end)

Melia.Override("STATUS_ITEM_GEAR_SCORE", function(original, pc, opc, frame, gboxctrl, y)
	-- Don't show "Gear Score"
	return y
end)

Melia.Override("STATUS_ABILITY_POINT_SCORE", function(original, pc, opc, frame, gboxctrl, y)
	-- Don't show Attribute Achievement Rate
	return y
end)
