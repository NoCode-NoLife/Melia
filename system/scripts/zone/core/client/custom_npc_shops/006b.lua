-- Create pagination UI elements for companion shop (continued)
function M_CREATE_COMPANION_PAGINATION_UI_PART2(frame)
	local adoptBox = GET_CHILD_RECURSIVELY(frame, 'adoptBox')
	if not adoptBox then return end

	-- Create page right button
	local pageRight = adoptBox:CreateControl('button', 'adopt_pageright', 0, 0, 60, 40)
	pageRight = tolua.cast(pageRight, 'ui::CButton')
	pageRight:SetGravity(ui.CENTER_HORZ, ui.BOTTOM)
	pageRight:SetMargin(70, 0, 0, 285)
	pageRight:SetText('{img white_right_arrow 16 16}')
	pageRight:SetClickSound('button_click_close')
	pageRight:SetOverSound('button_cursor_over_2')
	pageRight:SetSkinName('test_normal_button')
	pageRight:SetTextAlign('center', 'center')
	pageRight:SetEventScript(ui.LBUTTONUP, 'COMPANIONSHOP_ADOPT_PAGE_RIGHT')
	pageRight:SetEventScriptArgNumber(ui.LBUTTONUP, 0)

	-- Create page end button
	local pageEnd = adoptBox:CreateControl('button', 'adopt_pageend', 0, 0, 60, 40)
	pageEnd = tolua.cast(pageEnd, 'ui::CButton')
	pageEnd:SetGravity(ui.CENTER_HORZ, ui.BOTTOM)
	pageEnd:SetMargin(135, 0, 0, 285)
	pageEnd:SetText('{img white_right_arrow 16 16}{img white_right_arrow 16 16}')
	pageEnd:SetClickSound('button_click_close')
	pageEnd:SetOverSound('button_cursor_over_2')
	pageEnd:SetSkinName('test_normal_button')
	pageEnd:SetTextAlign('center', 'center')
	pageEnd:SetEventScript(ui.LBUTTONUP, 'COMPANIONSHOP_ADOPT_PAGE_RIGHT')
	pageEnd:SetEventScriptArgNumber(ui.LBUTTONUP, 1)
end
