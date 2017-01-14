function crystals_maker_onstart() 

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

function crystals_maker_onentitydeleted(dummy)

	local maker = getmaker();
	if (maker == null) then
		return
	end
	
	available_spawns = {};
	avail_count = 0;
	
	for i=1, maker.spawns_count do
		local spawn = getmakerspawn((i-1));
		if (spawn ~= nil) then
			if (spawn.count < spawn.total) then
				if (maker.max_entities >= (maker.entities_count + 1)) then
					avail_count = avail_count + 1;
					spawn.idx = i;
					available_spawns[avail_count] = spawn;			
				end
			end
			
		end
	end

	if (avail_count > 0) then
		local spawn_to_use = math.random(1, avail_count);
		maker.entities_count = makerincreasetotal(available_spawns[spawn_to_use], 1)
		spawn2(available_spawns[spawn_to_use].idx, 1, available_spawns[spawn_to_use].respawn_time, available_spawns[spawn_to_use].random_respawn_time);
	end
	
end

function crystals_maker_onend()
	local maker = getmaker();
	if (maker == null) then
		return
	end
	
	for i=1, maker.spawns_count do
		disablespawn(i-1);
	end
end