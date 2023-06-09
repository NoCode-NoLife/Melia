Melia.Comm = {}

local cache = {}

Melia.Comm.BeginRecv = function(key)
	cache[key] = {}
end

Melia.Comm.Recv = function(key, data)
	local cache = cache[key]
	
	if cache then
		if type(data) ~= "table" then
			data = {data}
		end

		for	_, v in ipairs(data) do
			table.insert(cache, v)
		end
		Melia.Log.Info(cache)
	end
end

Melia.Comm.EndRecv = function(key, callback)
	local cache = cache[key]
	
	if cache then
		callback(cache)
		cache[key] = nil
	end
end
