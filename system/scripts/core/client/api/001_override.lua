Melia = {}

Melia.Backup = function(original)
	return Melia.BackupIn(_G, original)
end

Melia.BackupIn = function(parent, original)
	local backupName = "MeliaBackup__" .. original;
	local backup = parent["MeliaBackup__" .. original]
	
	if not backup then
		backup = parent[original]
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
