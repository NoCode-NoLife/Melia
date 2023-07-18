Melia.Serialize = function(obj)
	if obj == nil then
		return "nil"
	end

	if type(obj) ~= "table" then
		return tostring(obj)
	end

	local s = "{ "

	for k, v in pairs(obj) do
		if type(k) ~= "number" then k = '"' .. k .. '"' end
		s = s .. "["..k.."] = " .. Melia.Serialize(v) .. ", "
	end

	return s .. "}"
end

Melia.DicID = function(str)
	return "@dicID_^*$"..str.."$*^"
end

function DicID(str)
	return Melia.DicID(str)
end
