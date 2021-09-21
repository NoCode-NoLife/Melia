using Melia.Channel.Network;
using Melia.Channel.World.Entities;
using Melia.Shared.Data.Database;

namespace Melia.Channel.Scripting
{
	public class ScriptState
	{
		public ChannelConnection Connection { get; private set; }
		public LuaThread LuaThread { get; set; }
		public Monster CurrentNpc { get; set; }
		public string DialogTitle { get; set; }
		public string DialogClassName { get; set; }

		/// <summary>
		/// Gets or sets the reference to the currently open shop's
		/// data. Null if no shop is open.
		/// </summary>
		public ShopData CurrentShop { get; set; }

		public ScriptState(ChannelConnection conn)
		{
			this.Connection = conn;
		}

		public void Reset()
		{
			ChannelServer.Instance.ScriptManager.RemoveThread(this.LuaThread);

			this.CurrentShop = null;
			this.CurrentNpc = null;
			this.DialogTitle = null;
			this.DialogClassName = null;
			this.LuaThread = null;
		}
	}
}
