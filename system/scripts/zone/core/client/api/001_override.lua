Melia = {}

Melia.Backup = function(original)
	return Melia.BackupIn(_G, original)
end

Melia.BackupIn = function(parent, original)
	local backupName = "MeliaBackup__" .. original;
	local backup = parent[backupName]
	
	if not backup then
		backup = parent[original]
		parent[backupName] = backup
	end
	
	return backup
end

Melia.Override = function (original, override)
	return Melia.OverrideIn(_G, original, override)
end


Melia.OverrideIn = function (parent, original, override)
	local backup = Melia.BackupIn(parent, original)
	
	parent[original] = function(...)
		return override(backup, ...)
	end
	
	return backup
end

MELIA_HOOKS = {}

Melia.Hook = function(originalName, hook)
	local listName = "_G_." .. originalName

	local list = MELIA_HOOKS[listName]
	local listExisted = list ~= nil

	if list == nil then
		list = {}
		MELIA_HOOKS[listName] = list
	end

	table.insert(list, hook)

	if not listExisted then
		Melia.Override(originalName, function(original, ...)
			local list = MELIA_HOOKS[listName]
		
			local result = original(...)
		
			if list then
				for _, hook in pairs(list) do
					result = hook(original, result, ...)
				end
			end

			return result
		end)
	end
end
