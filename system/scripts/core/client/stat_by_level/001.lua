-- Usage of StatByLevel is commented in the official scripts, since it's
-- not being used anymore. This override simply adds that property on top
-- of the result of the official function again.
Melia.Override("GET_STAT_POINT", function(original, pc)

	local result = original(pc)

	local byLevel = TryGetProp(pc, "StatByLevel")
	if byLevel ~= nil then
		result = result + byLevel
	end
	
	return math.floor(result);

end)
