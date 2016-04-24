----- Melia Script ----------------------------------------------------------
-- Dialog
----- Description -----------------------------------------------------------
-- Collection of commonly used dialog functions.
-----------------------------------------------------------------------------

--- Extension of select that supports named indices.
-- The options can be prefixed with a string, separated with a colon,
-- which become the first return value, the second being the actual index
-- selected. If an option doesn't have a name, it defaults to __unnamedX.
-- @tparam  string  msg  The message to display.
-- @tparam  string  ...  The selectable options.
-- @treturn string  The name of the selected index.
-- @treturn int     The selected index.
-- @usage local n,i = nselect("How are you?", "g:Good", "foo:Bad", "Cancel")
function nselect(msg, ...)
	local args = {...}
	local keys = {}
	local vals = {}
	local n = 1

	-- Get keys and values
	for i=1,#args do
		local arg = args[i]
		local index = string.find(arg, ':')
		local key, val

		if index == nil then
			-- Fallback to "__unnamedX" if no colon was found
			key = "__unnamed" .. n
			val = arg
			n = n + 1
		else
			-- Get sub strings if there was a colon
			key = string.sub(arg, 1, index - 1)
			val = string.sub(arg, index + 1)
		end

		-- Save key and val for later
		table.insert(keys, key)
		table.insert(vals, val)
	end

	-- Get result from select
	local selectedindex = select(msg, unpack(vals))
	local optionname = keys[selectedindex]
	
	return optionname, selectedindex
end
