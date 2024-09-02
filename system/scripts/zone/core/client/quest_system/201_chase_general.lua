function M_QUESTS_SET_CHASE(questCtrl, quest)
	local chkChase = GET_CHILD(questCtrl, "chase", "ui::CCheckBox")

	chkChase:SetEventScript(ui.LBUTTONDOWN, "M_ADD_QUEST_INFOSET_CTRL")
	chkChase:SetEventScriptArgString(ui.LBUTTONDOWN, quest.ObjectId)
end

local selectedQuests = 0

function M_ADD_QUEST_INFOSET_CTRL(frame, ctrl, argStr, argNum, notUpdateRightUI)
	local questObjectId = argStr
	local quest = Melia.Quests.Get(questObjectId)

	local frmQuestInfo = ui.GetFrame("questinfoset_2");
	local grpMember = GET_CHILD(frmQuestInfo, "member", "ui::CGroupBox");
	
	tolua.cast(ctrl, "ui::CCheckBox"); 
	if ctrl:IsChecked() == 1 then
		selectedQuests = selectedQuests + 1
	else
		selectedQuests = math.max(0, selectedQuests - 1)
	end

	if selectedQuests > 0 then
		frmQuestInfo:ShowWindow(1)
		--CHASEINFO_SHOW_QUEST_TOGGLE(1)

		M_CHASE_REDRAW(frmQuestInfo, grpMember)
	else
		frmQuestInfo:ShowWindow(0)
		--CHASEINFO_SHOW_QUEST_TOGGLE(0)
	end
end
