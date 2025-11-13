-- Create pagination UI elements for companion shop (page text)
function M_CREATE_COMPANION_PAGINATION_UI_PART3(frame)
	local adoptBox = GET_CHILD_RECURSIVELY(frame, 'adoptBox')
	if not adoptBox then return end

	-- Create page text
	local pageText = adoptBox:CreateControl('richtext', 'adopt_pagetxt', 0, 0, 35, 20)
	pageText = tolua.cast(pageText, 'ui::CRichText')
	pageText:SetGravity(ui.CENTER_HORZ, ui.BOTTOM)
	pageText:SetMargin(0, 0, 0, 293)
	pageText:SetText('{@st41b}1 / 1{/}')
	pageText:SetTextAlign('center', 'center')
end

-- Update button enable/disable states based on current page
function M_UPDATE_COMPANION_PAGE_BUTTONS(frame)
	local currentPage = tonumber(frame:GetUserValue('COMPANION_SHOP_PAGE')) or 1
	local totalPages = tonumber(frame:GetUserValue('COMPANION_SHOP_TOTAL_PAGES')) or 1

	local pageLeft = GET_CHILD_RECURSIVELY(frame, 'adopt_pageleft')
	local pageStart = GET_CHILD_RECURSIVELY(frame, 'adopt_pagestart')
	local pageRight = GET_CHILD_RECURSIVELY(frame, 'adopt_pageright')
	local pageEnd = GET_CHILD_RECURSIVELY(frame, 'adopt_pageend')

	if pageLeft and pageStart then
		local enableLeft = currentPage > 1 and 1 or 0
		pageLeft:SetEnable(enableLeft)
		pageStart:SetEnable(enableLeft)
	end

	if pageRight and pageEnd then
		local enableRight = currentPage < totalPages and 1 or 0
		pageRight:SetEnable(enableRight)
		pageEnd:SetEnable(enableRight)
	end
end
