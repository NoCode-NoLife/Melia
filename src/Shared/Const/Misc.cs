// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Const
{
	public enum TeamNameChangeResult : int
	{
		TeamNameAlreadyExist = -1,
		Okay = 0,
		TeamChangeFailed = 1,
	}

	public static class HelpTopics
	{
		// TODO: Find which database declares the list of default help topics and use it instead of this list.

		/// <summary>
		/// The initial list of help topics available to a player.
		/// These are the class names found in the HelpDb.
		/// </summary>
		public static string[] Default = new string[]
		{
			"TUTO_MOVE_KB",
			"TUTO_MOVE_JUMP",
			"TUTO_ATTACK_KB",
			"TUTO_MAP",
			"TUTO_INVEN",
			"TUTO_QUEST",
			"TUTO_ACHIEVEMENT",
			"TUTO_C_MONSTER",
			"TUTO_PARTY",
			"TUTO_PVP",
			"TUTO_TELEPORT",
			"TUTO_CARDBATTLE",
			"TUTO_BARRACK",
			"TUTO_CAPTURE",
			"TUTO_PC_TRADE",
			"TUTO_GUILD",
			"TUTO_GUILD_AGIT",
			"TUTO_GUILD_EVENT",
			"TUTO_GROWING_NORMAL",
			"TUTO_GROWING_SPECIAL",
			"TUTO_CLASS",
			"TUTO_POINT_SHOP",
			"TUTO_ESCAPE_ORB",
			"TUTO_STREET_STALL",
			"TUTO_OBLATION",
			"TUTO_CHATTING_COMMAND",
			"TUTO_FIELD_BOSS",
			"TUTO_GUILD_WAR",
			"TUTO_GUILD_BATTLE",
		};
	}
}
