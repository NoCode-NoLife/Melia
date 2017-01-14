function default_maker_onstart() 

	local maker = getmaker();
	if (maker == null) then
		return
	end
	
	if (maker.on_start_spawn == 0) then
		return;
	end
	
	for i=1, maker.spawns_count do
		local spawn = getmakerspawn((i-1));
		if (spawn ~= nil) then
			if (maker.max_entities >= (maker.entities_count + spawn.total)) then
				maker.entities_count = makerincreasetotal(spawn, spawn.total)
				spawn2(i, spawn.total, 0, 0);
				
			end
		end
	end
end

function default_maker_onentitydeleted(spawn)

	local maker = getmaker();
	if (maker == null) then
		return
	end
	
	if (spawn ~= nil) then
		if (spawn.respawn_time > 0) then
			if (maker.max_entities >= (maker.entities_count + 1)) then	
				maker.entities_count = makerincreasetotal(spawn, 1)	
				spawn2(spawn.idx, 1, spawn.respawn_time, spawn.random_respawn_time);
			end
		end
	end
end