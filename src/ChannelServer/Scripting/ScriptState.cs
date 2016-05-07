// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Channel.World;
using System;

namespace Melia.Channel.Scripting
{

	public class ScriptState
	{
		public ChannelConnection Connection { get; private set; }
		public LuaThread LuaThread { get; set; }
		public Monster CurrentNpc { get; set; }

		/// <summary>
		/// Name of the shop currently open, null if there is no shop.
		/// </summary>
		public string CurrentShop { get; set; }

		public ScriptState(ChannelConnection conn)
		{
			this.Connection = conn;
		}

		public void Reset()
		{
			ChannelServer.Instance.ScriptManager.RemoveThread(this.LuaThread);

			this.CurrentShop = null;
			this.CurrentNpc = null;
			this.LuaThread = null;
		}
	}
}
