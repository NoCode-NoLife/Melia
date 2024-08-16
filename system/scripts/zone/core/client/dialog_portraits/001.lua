-- Replaces function to add support for setting a title after a dialog
-- target was set. In the official function, a dialog element's caption
-- takes precedence over a custom title.
Melia.Override("DIALOG_TEXTVIEW", function(original, frame, msg, argStr)
	
	local text
	local title = "Unknown"
	local voice = "None"
	
	g_lastClassName = argStr
	
	-- If the message is a dialog element, use its data.
	local dialogText = GetClass('DialogText', argStr)
	if dialogText then
	
		text = dialogText.Text
		title = dialogText.Caption
		voice = dialogText.VoiceName
	
	-- If the message is not simply a dialog element, parse it.
	else
		
		-- A backwards slash is the delimiter between a dialog class name,
		-- to get the title and voice from, and the rest of the message.
		local index = string.find(argStr, "\\")
		if index ~= nil then
			local className = string.sub(argStr, 1, index - 1)
			dialogText = GetClass('DialogText', className)
			
			if dialogText then
				title = dialogText.Caption
				voice = dialogText.VoiceName
			end
			
			argStr = string.sub(argStr, index + 1)
		end

		-- The string "*@*" is the delimiter between a custom title for the
		-- dialog frame and the text. If the delimiter doesn't exist, the
		-- rest of the message simply becomes the text, otherwise, the
		-- string is split at the delimiter.
		index = string.find(argStr, "*@*");
		if index ~= nil then
			title = string.sub(argStr, 1, index - 1)
			text = string.sub(argStr, index + 3)

			dialogText = GetClass('DialogText', title)
			if dialogText then
				title = dialogText.Caption
			end
		else
			text = argStr
		end
		
	end
	
	DIALOG_SHOW_DIALOG_TEXT(frame, text, title, voice);
	
end)
