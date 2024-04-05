-- Replaces dialog portrait display function to add support for directly
-- referencing images from the basic skin set, instead of relying on
-- the dialog data.
Melia.Override("DIALOGILLUST_TEXTVIEW", function(original, frame, msg, argStr, argNum)

	local index = string.find(argStr, "\\")
	if index == nil then
		return original(frame, msg, argStr, argNum)
	end

	local clsName = string.sub(argStr, 1, index - 1)
	local imgName = clsName

	-- Use the dialog text element's image if the element exists.
	-- Otherwise, set the image directly.
	local dialogText = GetClass('DialogText', clsName)
	if dialogText ~= nil then
		imgName = dialogText.ImgName
	end

    local frame = ui.GetFrame('dialogillust')
	local img = frame:GetChild('dialogimage')
	AUTO_CAST(img)

	img:SetImage(imgName)
	frame:ShowWindow(1)

end)
