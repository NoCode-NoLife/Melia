function M_QUESTS_SET_CHASE(questCtrl, quest)
	local chkChase = GET_CHILD(questCtrl, "chase", "ui::CCheckBox")
	
	if not Melia.Conf.GetBool("display_quest_objectives") then
		chkChase:ShowWindow(0)
		return
	end

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
	local hasTrackedQuests = Melia.Quests.CountTracked() > 0

	if hasTrackedQuests then
		M_CHASE_REDRAW(frmQuestInfo)
		frmQuestInfo:ShowWindow(1)
	else
		frmQuestInfo:ShowWindow(0)
	end
end
