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

Melia.Util.Split = function(str, sep)
	if sep == '' then return {str} end
  
	local res, from = {}, 1

	repeat
		local pos = str:find(sep, from)
		res[#res + 1] = str:sub(from, pos and pos - 1)
		from = pos and pos + #sep
	until not from

	return res
end
