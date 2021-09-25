-- Writes string to client's stdout.
function M_DEBUG(str)
	if not str then
		str = ""
	end

	-- print behaves weirdly, let's use IMC_LOG instead.
	IMC_LOG("INFO_NORMAL", str)
end
