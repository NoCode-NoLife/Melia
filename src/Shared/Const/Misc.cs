// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

namespace Melia.Shared.Const
{
	public enum TeamNameChangeResult : int
	{
		TeamNameAlreadyExist = -1,
		Okay = 0,
		TeamChangeFailed = 1,
	}

	public enum PostBoxMessageState : byte
	{
		None = 0,
		Read = 1,
		Store = 2,
		Delete = 3,
		RequestLoad = 4,
		Count = 5,
	}
}