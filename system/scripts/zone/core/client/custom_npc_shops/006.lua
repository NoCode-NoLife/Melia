-- Create pagination UI elements for companion shop if they don't exist
function M_CREATE_COMPANION_PAGINATION_UI(frame)
	local adoptBox = GET_CHILD_RECURSIVELY(frame, 'adoptBox')
	if not adoptBox then return end

	-- Check if pagination elements already exist
	if GET_CHILD_RECURSIVELY(frame, 'adopt_pagetxt') then return end

	-- Create page start button
	local pageStart = adoptBox:CreateControl('button', 'adopt_pagestart', 0, 0, 60, 40)
	pageStart = tolua.cast(pageStart, 'ui::CButton')
	pageStart:SetGravity(ui.CENTER_HORZ, ui.BOTTOM)
	pageStart:SetMargin(-135, 0, 0, 285)
	pageStart:SetText('{img white_left_arrow 16 16}{img white_left_arrow 16 16}')
	pageStart:SetClickSound('button_click_close')
	pageStart:SetOverSound('button_cursor_over_2')
	pageStart:SetSkinName('test_normal_button')
	pageStart:SetTextAlign('center', 'center')
	pageStart:SetEventScript(ui.LBUTTONUP, 'COMPANIONSHOP_ADOPT_PAGE_LEFT')
	pageStart:SetEventScriptArgNumber(ui.LBUTTONUP, 1)

	-- Create page left button
	local pageLeft = adoptBox:CreateControl('button', 'adopt_pageleft', 0, 0, 60, 40)
	pageLeft = tolua.cast(pageLeft, 'ui::CButton')
	pageLeft:SetGravity(ui.CENTER_HORZ, ui.BOTTOM)
	pageLeft:SetMargin(-70, 0, 0, 285)
	pageLeft:SetText('{img white_left_arrow 16 16}')
	pageLeft:SetClickSound('button_click_close')
	pageLeft:SetOverSound('button_cursor_over_2')
	pageLeft:SetSkinName('test_normal_button')
	pageLeft:SetTextAlign('center', 'center')
	pageLeft:SetEventScript(ui.LBUTTONUP, 'COMPANIONSHOP_ADOPT_PAGE_LEFT')
	pageLeft:SetEventScriptArgNumber(ui.LBUTTONUP, 0)
end
