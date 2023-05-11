using Melia.Channel.Network;
using Melia.Channel.World.Entities;
using Melia.Shared.Data.Database;

namespace Melia.Channel.Scripting
{
	/// <summary>
	/// State information for a script session.
	/// </summary>
	public class ScriptState
	{
		/// <summary>
		/// Returns the connection associated with this state.
		/// </summary>
		public ChannelConnection Connection { get; private set; }

		/// <summary>
		/// Gets or sets pointer to the state's Lua thread.
		/// </summary>
		//public LuaThread LuaThread { get; set; }

		/// <summary>
		/// Gets or sets the NPC associated with this state.
		/// </summary>
		public Monster CurrentNpc { get; set; }

		/// <summary>
		/// Gets or sets the current dialog title.
		/// </summary>
		public string DialogTitle { get; set; }

		/// <summary>
		/// Get sor sets the current dialog class name.
		/// </summary>
		public string DialogClassName { get; set; }

		/// <summary>
		/// Gets or sets the reference to the currently open shop's
		/// data. Null if no shop is open.
		/// </summary>
		public ShopData CurrentShop { get; set; }

		/// <summary>
		/// Creates script state for connection.
		/// </summary>
		/// <param name="conn"></param>
		public ScriptState(ChannelConnection conn)
		{
			this.Connection = conn;
		}

		/// <summary>
		/// Resets script state, closing the thread and resetting all
		/// state information.
		/// </summary>
		public void Reset()
		{
			//ChannelServer.Instance.ScriptManager.RemoveThread(this.LuaThread);

			this.CurrentShop = null;
			this.CurrentNpc = null;
			this.DialogTitle = null;
			this.DialogClassName = null;
			//this.LuaThread = null;
		}
	}
}
