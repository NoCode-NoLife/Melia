Melia.DoString = function(code)
	local chunk, err = load(code)
	if chunk then
		chunk(func)
		return true
	else
		Melia.Log.Error('Execution failed. Error: ' .. err)
		return false
	end
end
