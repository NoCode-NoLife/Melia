Melia.Log = {}

Melia.Log.Info = function(format, ...)
	Melia.Log.Write("INFO_NORMAL", format, ...)
end

Melia.Log.Error = function(format, ...)
	Melia.Log.Write("ERROR_LOGIC", format, ...)
end

Melia.Log.Warning = function(format, ...)
	Melia.Log.Write("WARNING_DEBUG", format, ...)
end

Melia.Log.Write = function(errorCode, format, ...)
	local argCount = select("#", ...)
	
	if argCount == 0 then
		IMC_LOG(errorCode, Melia.Util.Serialize(format))
		return
	end

	local text = format;

	for i = 1, argCount do
		local indexStr = "{" .. (i - 1) .. "}"
		local replacement = Melia.Util.Serialize(select(i, ...))

		text = string.gsub(text, indexStr, replacement)
	end

	IMC_LOG(errorCode, text)
end
