Melia.Info = {}

local handle = session.GetMyHandle()

local function getStat()
	return info.GetStat(handle)
end

Melia.Info.Character = {
	GetHandle = function() return handle end,

	GetName = function() return info.GetName(handle) end,
	GetTeamName = function() return info.GetFamilyName(handle) end,
	GetLevel = function() return info.GetLevel(handle) end,
	GetJob = function() return info.GetJob(handle) end,
	GetGender = function() return info.GetGender(handle) end,
	GetExp = function() return session.GetEXP() end,
	GetMaxExp = function() return session.GetMaxEXP() end,
	GetMapName = function() return session.GetMapName() end,

	GetHp = function() return getStat().HP end,
	GetHpMax = function() return getStat().maxHP end,
	GetSp = function() return getStat().SP end,
	GetSpMax = function() return getStat().maxSP end,
	GetStamina = function() return getStat().Stamina end,
	GetStaminaMax = function() return getStat().MaxStamina end,
	GetMoney = function() return GET_TOTAL_MONEY_STR() end,
}
