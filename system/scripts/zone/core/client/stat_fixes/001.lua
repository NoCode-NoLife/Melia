-- Used to modify the healing property for display only. Notidea what
-- this is about, but the values and previews not matching up bothers me,
-- so we'll force the actual value.
Melia.Override("GET_SHOW_HEAL_PWR", function (original, self, actualValue)
	return actualValue
end)
