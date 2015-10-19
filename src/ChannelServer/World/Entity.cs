// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

namespace Melia.Channel.World
{
	public interface IEntity
	{
		int Handle { get; }
		int Hp { get; }
		Map Map { get; }
	}
}
