function COMPANIONSHOP_ADOPT_PAGE_LEFT(frame, ctrl, argstr, argnum)
	local topFrame = frame:GetTopParentFrame()
	local currentPage = tonumber(topFrame:GetUserValue('COMPANION_SHOP_PAGE')) or 1
	if argnum == 1 then
		topFrame:SetUserValue('COMPANION_SHOP_PAGE', 1)
	elseif currentPage > 1 then
		topFrame:SetUserValue('COMPANION_SHOP_PAGE', currentPage - 1)
	end
	UPDATE_COMPANION_SELL_LIST(topFrame)
end
