
local history = {}
local historyIndex = 0

local chatFrame = ui.GetFrame('chat')
local chatEditCtrl = GET_CHILD(chatFrame, "mainchat", "ui::CEditControl");
chatEditCtrl:SetEventScript(ui.ENTERKEY, "M_CHAT_ENTERKEY");

local chatTimer = chatFrame:CreateControl("timer", "ChatTimer", 0, 0, 1, 1)
AUTO_CAST(chatTimer)
chatTimer:SetUpdateScript("M_CHAT_ON_TIMER");
chatTimer:Start(0.01);

function M_CHAT_ON_TIMER(frame)
	if keyboard.IsKeyDown("UP") == 1 then
		M_CHAT_HISTORY_CYCLE(-1)
	elseif keyboard.IsKeyDown("DOWN") == 1 then
		M_CHAT_HISTORY_CYCLE(1)
	end
end

function M_CHAT_HISTORY_CYCLE(modifier)
	if #history	== 0 then
		return
	end

	historyIndex = historyIndex + modifier
	if historyIndex < 0 then
		historyIndex = #history
	elseif historyIndex > #history then
		historyIndex = 0
	end
	
	if historyIndex == 0 then
		chatEditCtrl:SetText("")
	else
		chatEditCtrl:SetText(history[historyIndex])
	end
end

function M_CHAT_ENTERKEY(frame, control, argStr, argNum)
	local text = control:GetText()
	local isWhitespace = text:match("^%s*$") ~= nil

	if isWhitespace then
		return
	end

	for i = 1, #history do
		if history[i] == text then
			table.remove(history, i)
			break
		end
	end

	table.insert(history, text)
	historyIndex = 0
end
