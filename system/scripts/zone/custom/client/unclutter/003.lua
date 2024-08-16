Melia.Override("SKL_KEY_PRESS", function(original, result, actor, obj, dik, startDelay, pressSpd, duration, hitCancel)
	-- Stop here for Stabbing, since the key presses don't do anything for it.
	if obj ~= nil and obj.type == 10301 then
		return 0, 0;
	end

	return original(actor, obj, dik, startDelay, pressSpd, duration, hitCancel)
end)
