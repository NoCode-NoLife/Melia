Melia.Util = {}

Melia.Util.Serialize = function(obj)
	if obj == nil then
		return "nil"
	end

	if type(obj) ~= "table" then
		return tostring(obj)
	end

	local s = "{ "

	for k, v in pairs(obj) do
		if type(k) ~= "number" then k = '"' .. k .. '"' end
		s = s .. "["..k.."] = " .. Melia.Util.Serialize(v) .. ", "
	end

	return s .. "}"
end

Melia.Util.DicID = function(str)
	return "@dicID_^*$"..str.."$*^"
end

function DicID(str)
	return Melia.Util.DicID(str)
end
