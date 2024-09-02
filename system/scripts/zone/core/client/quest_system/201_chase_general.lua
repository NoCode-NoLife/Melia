function M_QUESTS_SET_CHASE(questCtrl, quest)
	local chkChase = GET_CHILD(questCtrl, "chase", "ui::CCheckBox")

	if quest.Tracked then
		chkChase:ToggleCheck()
	end

	chkChase:SetEventScript(ui.LBUTTONDOWN, "M_CHASE_UPDATE")
	chkChase:SetEventScriptArgString(ui.LBUTTONDOWN, quest.ObjectId)
end

function M_CHASE_UPDATE(frame, ctrl, argStr, argNum, notUpdateRightUI)
	local questObjectId = argStr
	local quest = Melia.Quests.Get(questObjectId)

	tolua.cast(ctrl, "ui::CCheckBox")
	if ctrl:IsChecked() == 1 then
		quest.Tracked = true
	else
		quest.Tracked = false
	end

	Melia.Quests.RequestTrack(questObjectId, quest.Tracked)

	M_CHASE_UPDATE_VISIBILITY()
end

function M_CHASE_UPDATE_VISIBILITY()
	local frmQuestInfo = ui.GetFrame("questinfoset_2")

	if Melia.Quests.CountTracked() > 0 then
		frmQuestInfo:ShowWindow(1)
		--CHASEINFO_SHOW_QUEST_TOGGLE(1)
		
		M_CHASE_REDRAW(frmQuestInfo)
	else
		frmQuestInfo:ShowWindow(0)
		--CHASEINFO_SHOW_QUEST_TOGGLE(0)
	end
end
