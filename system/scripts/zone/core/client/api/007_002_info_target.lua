local function getStat()
	return info.GetStat(session.GetTargetHandle())
end

local function getTargetInfo()
	return info.GetTargetInfo(session.GetTargetHandle())
end

local function getStatNum(name)
	local stat = getStat()
	return stat and stat[name] or 0
end

local function getInfoNum(name)
	local info = getTargetInfo()
	return info and info[name] or 0
end

Melia.Info.Target = {
	GetHandle = function() return session.GetTargetHandle() end,

	GetName = function() return info.GetName(handle) end,
	GetTeamName = function() return info.GetFamilyName(handle) end,
	GetLevel = function() return info.GetLevel(handle) end,
	GetJob = function() return info.GetJob(handle) end,
	GetGender = function() return info.GetGender(handle) end,
	GetDistance = function() return getInfoNum('distance') end,

	GetHp = function() return getStatNum("HP") end,
	GetHpMax = function() return getStatNum("maxHP") end,
	GetSp = function() return getStatNum("SP") end,
	GetSpMax = function() return getStatNum("maxSP") end,
	GetStamina = function() return getStatNum("Stamina") end,
	GetStaminaMax = function() return getStatNum("MaxStamina") end,
}
