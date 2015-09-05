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
		public IntPtr NL { get; private set; }
		public Monster CurrentNpc { get; set; }

		public ScriptState(ChannelConnection conn, IntPtr NL)
		{
			this.Connection = conn;
			this.NL = NL;
		}
	}
}
