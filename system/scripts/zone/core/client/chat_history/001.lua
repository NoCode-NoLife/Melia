if not M_CHAT_HISTORY_LIST then
	M_CHAT_HISTORY_LIST = {}
	M_CHAT_HISTORY_LIST_IDX = 0
end

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
	if #M_CHAT_HISTORY_LIST	== 0 then
		return
	end

	M_CHAT_HISTORY_LIST_IDX = M_CHAT_HISTORY_LIST_IDX + modifier
	if M_CHAT_HISTORY_LIST_IDX < 0 then
		M_CHAT_HISTORY_LIST_IDX = #M_CHAT_HISTORY_LIST
	elseif M_CHAT_HISTORY_LIST_IDX > #M_CHAT_HISTORY_LIST then
		M_CHAT_HISTORY_LIST_IDX = 0
	end
	
	if M_CHAT_HISTORY_LIST_IDX == 0 then
		chatEditCtrl:SetText("")
	else
		chatEditCtrl:SetText(M_CHAT_HISTORY_LIST[M_CHAT_HISTORY_LIST_IDX])
	end
end

function M_CHAT_ENTERKEY(frame, control, argStr, argNum)
	local text = control:GetText()
	local isWhitespace = text:match("^%s*$") ~= nil

	if isWhitespace then
		return
	end

	for i = 1, #M_CHAT_HISTORY_LIST do
		if M_CHAT_HISTORY_LIST[i] == text then
			table.remove(M_CHAT_HISTORY_LIST, i)
			break
		end
	end

	table.insert(M_CHAT_HISTORY_LIST, text)
	M_CHAT_HISTORY_LIST_IDX = 0
end
