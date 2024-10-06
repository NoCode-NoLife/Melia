Melia.World = {}
Melia.World.Icons = {}
Melia.World.Icons.List = {}

Melia.World.Icons.Load = function(icons)
	Melia.World.Icons.Clear();

	for i = 1, #icons do
		Melia.World.Icons.Add(icons[i])
	end
end

Melia.World.Icons.Add = function(icon)
	table.insert(Melia.World.Icons.List, icon)
end

Melia.World.Icons.GetAll = function()
	return Melia.World.Icons.List
end

Melia.World.Icons.Clear = function()
	Melia.World.Icons.List = {}
end
