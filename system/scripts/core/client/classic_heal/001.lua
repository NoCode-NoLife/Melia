
Melia.Override("SKL_PARTY_TARGET_BY_KEY", function(original, actor, obj, dik, showHPGauge)

	local skl = GetClassByType('Skill', obj.type)
	local skill_name = TryGetProp(skl, 'ClassName', 'None')	

	if skill_name == 'Cleric_Heal' then
		-- Returning "0, 1" makes it cast the skill instantly
		return 0, 1
	end
	
	return original(actor, obj, dik, showHPGauge)

end)
