using System;

namespace Melia.Channel.Scripting
{
	/// <summary>
	/// References a Lua thread.
	/// </summary>
	public class LuaThread
	{
		/// <summary>
		/// Pointer to the Lua state.
		/// </summary>
		public IntPtr L { get; private set; }

		/// <summary>
		/// The index of the thread on the global stack.
		/// </summary>
		public int StackIndex { get; set; }

		/// <summary>
		/// Creates new thread reference.
		/// </summary>
		/// <param name="luaState"></param>
		/// <param name="stackIndex"></param>
		public LuaThread(IntPtr luaState, int stackIndex)
		{
			this.L = luaState;
			this.StackIndex = stackIndex;
		}
	}
}
