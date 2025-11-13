if not M_ORIGINAL_COMPANIONSHOP_ADOPT then
	M_ORIGINAL_COMPANIONSHOP_ADOPT = COMPANIONSHOP_ADOPT
end

function COMPANIONSHOP_ADOPT(frame, ctrl)
	local topFrame = frame:GetTopParentFrame()
	local selectedCompa = topFrame:GetUserValue('CLSNAME')

	if M_COMPANION_SHOP and #M_COMPANION_SHOP > 0 then
		local compaCls = GetClass('Companion', selectedCompa)
		if compaCls == nil then
			return
		end

		if compaCls.JobID == 0 or 0 ~= session.GetJobGradePC(compaCls.JobID) then
			TRY_CHECK_BARRACK_SLOT(frame, ctrl, true)
		else
			ui.MsgBox(ScpArgMsg("HaveNotJobForbyingCompaion"))
		end
	else
		M_ORIGINAL_COMPANIONSHOP_ADOPT(frame, ctrl)
	end
end
