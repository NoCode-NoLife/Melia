Melia.Override("VIEW_BOOKITEM_PAGE", function(original, frame, page)

	if string.find(g_bookClassName, "CUSTOM:") ~= 1 then
		return original(frame, page)
	end

	local textElLeft = GET_CHILD(frame, "text_left", "ui::CFlowText")
	local textElRight = GET_CHILD(frame, "text_right", "ui::CFlowText")
	local nextPageBtn = GET_CHILD(frame, "nextBtn", "ui::CButton");
	local prevPageBtn = GET_CHILD(frame, "prevBtn", "ui::CButton");

	textElLeft:SetText(" ")
	textElLeft:ClearText()
	textElRight:SetText(" ")
	textElRight:ClearText()
	
	local bookText = g_bookClassName:sub(8)
	local leftPage = ""
	local rightPage = ""
	
	local pages = Melia.Util.Split(bookText, "{np}")

	if page > #pages then
		page = #pages
	end

	leftPage = pages[page]

	if page + 1 <= #pages then
		rightPage = pages[page + 1]
	end

	leftPage = string.gsub(leftPage, "\r\n", "{nl}")
	rightPage = string.gsub(rightPage, "\r\n", "{nl}")
	
	textElLeft:SetText(leftPage);
    textElLeft:SetFontName("bookfont");
	textElLeft:SetFlowSpeed(200);
	
	textElRight:SetText(rightPage);
    textElRight:SetFontName("bookfont");
	textElRight:SetFlowSpeed(200);

	if page > 1 then
		prevPageBtn:ShowWindow(1);
	else
		prevPageBtn:ShowWindow(0);
	end

	if page < #pages then
		nextPageBtn:ShowWindow(1);
	else
		nextPageBtn:ShowWindow(0);
	end

end)
