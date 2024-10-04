Melia.Hook("RESTART_ON_MSG", function(original, result, frame, msg, argStr, argNum)

    if msg == "RESTART_HERE" then
		local btnRestart = GET_CHILD(frame, "restart6btn", "ui::CButton")

		-- Initialize the button with the text that will be used by the counter
		-- update method, so they're the same from the start. Set it on the
		-- button to process the text code and get the actual string, then
		-- modify the localized string.
		local text = "{@st66b}" .. ScpArgMsg("ReturnCity{SEC}", "SEC", 30) .. "{/}"
		btnRestart:SetText(text);

		text = btnRestart:GetText()
		text = M_TRIM_SECONDS(text)

		btnRestart:SetText(text)
	end

end)

Melia.Hook("COLONY_WAR_RESTART_UPDATE", function(original, result, frame)

	local btnRestart = GET_CHILD(frame, "restart6btn", "ui::CButton")
	
	local text = btnRestart:GetText()
	text = M_TRIM_SECONDS(text)

	btnRestart:SetText(text);

	return result
end)

function M_TRIM_SECONDS(text)
	local index = string.find(text, "%(")

	if index then
		text = string.sub(text, 1, index - 1)
		text = string.gsub(text, "%s+$", "") .. "{/}"
	end

	return text
end
