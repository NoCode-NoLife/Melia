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

	public static class BCNormalMsg
	{
		/// <summary>
		/// Indicates to the client that a barrack purchase succeeded.
		/// </summary>
		public static readonly string THEMA_BUY_SUCCESS = "THEMA_BUY_SUCCESS";
	}
}
