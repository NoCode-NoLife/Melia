-- Hijack SHOW_BUFF_TEXT to display custom text
Melia.Override("SHOW_BUFF_TEXT", function(original, argNum, argStr)

	if argStr ~= nil and argStr:find("^CUSTOM:") then
		local text = argStr:sub(8)
		return text
	end

	return original(argNum, argStr)

end)
