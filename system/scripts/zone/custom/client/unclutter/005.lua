Melia.Override("TARGETBUFF_ON_MSG", function(original, frame, msg, argStr, argNum)
	original(frame, msg, argStr, argNum)

	-- After the original did its thing, we toggle the button off if the target
	-- doesn't actually have buffs.
	if msg == "TARGET_SET" then
		local handle = session.GetTargetHandle()
		local buffCount = info.GetBuffCount(handle)
		
		if buffCount ~= nil and buffCount == 0 then
			TARGETBUFF_VISIBLE(frame, 0)
		end
	end
end)
