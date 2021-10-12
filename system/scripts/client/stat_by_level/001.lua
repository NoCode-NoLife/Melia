if not GET_STAT_POINT_Original then
	GET_STAT_POINT_Original = GET_STAT_POINT
end

-- Usage of StatByLevel is commented in the official scripts, since it's
-- not being used anymore. This override simply adds that property on top
-- of the result of the official function again.
function GET_STAT_POINT(pc)
	local result = GET_STAT_POINT_Original(pc)

	local byLevel = TryGetProp(pc, "StatByLevel")
	if byLevel ~= nil then
		result = result + byLevel
	end
    
    return math.floor(result);
end
