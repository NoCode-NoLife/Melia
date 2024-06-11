Melia.Comm = {}

local cache = {}

Melia.Comm.BeginRecv = function(key)
	cache[key] = { ['key'] = key, ['data'] = {} }
end

Melia.Comm.Recv = function(key, dataset)
	local obj = cache[key]
	
	if obj then
		if type(data) ~= "table" then
			data = {data}
		end

		for	_, v in ipairs(dataset) do
			table.insert(obj.data, v)
		end
	end
end

Melia.Comm.Exec = function(key, callback)
	local obj = cache[key]
	
	if obj then
		callback(obj)
	end
end

Melia.Comm.ExecData = function(key, callback)
	local obj = cache[key]
	
	if obj then
		callback(obj.data)
	end
end

Melia.Comm.EndRecv = function(key)
	cache[key] = nil
end
