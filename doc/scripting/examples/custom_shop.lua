-- Example of a custom shop.
addnpc(20104, "Custom Shop", "c_Klaipe", 276, -1, -936, 45, function()

	msg("Welcome.")
	
	-- Use openshop like normal, but pass a table with items to it.
	-- The server will then create a custom shop and you'll be able
	-- to buy the items like normal.
	openshop({
		{ id = 640011, amount = 3, price = 2 },
		{ id = 640012, amount = 1, price = 1 },
		{ id = 101126, amount = 1, price = 300 },
		{ id = 104112, amount = 1, price = 10000 },
	})
	
end)
