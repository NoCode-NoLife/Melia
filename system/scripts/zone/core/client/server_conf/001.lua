Melia.Conf = {}
Melia.Conf.Options = {}

Melia.Conf.Init = function(optionTable)
	for k, v in pairs(optionTable) do
		Melia.Conf.Options[k] = v
	end
end

Melia.Conf.Get = function(optionName)
	return Melia.Conf.Options[optionName]
end

Melia.Conf.GetInt = function(optionName)
	return tonumber(Melia.Conf.Options[optionName])
end

Melia.Conf.GetBool = function(optionName)
	local val = Melia.Conf.Options[optionName]
	return val == "true" or val == "1" or val == "yes"
end
