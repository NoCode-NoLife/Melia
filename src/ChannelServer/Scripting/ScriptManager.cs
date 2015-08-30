// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeluaLib;
using Melia.Shared.Util;
using System.IO;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.World;
using Melia.Channel.Network;
using System.Runtime.CompilerServices;
using Melia.Shared.Network;

namespace Melia.Channel.Scripting
{
	public class ScriptManager
	{
		private IntPtr GL;

		private List<Melua.LuaNativeFunction> _functions;

		/// <summary>
		/// Creates new script manager.
		/// </summary>
		public ScriptManager()
		{
			_functions = new List<Melua.LuaNativeFunction>();

			GL = Melua.luaL_newstate();
			Melua.luaL_openlibs(GL);

			Register(debug);
			Register(addnpc);
			Register(msg);
		}

		/// <summary>
		/// Registers function on global Lua state.
		/// </summary>
		/// <param name="functionName"></param>
		private void Register(Melua.LuaNativeFunction function)
		{
			// Keep a reference, so it's not garbage collected...?
			var func = new Melua.LuaNativeFunction(function);
			_functions.Add(func);
			Melua.lua_register(GL, function.Method.Name, func);
		}

		/// <summary>
		/// Loads all scripts.
		/// </summary>
		public void Initialize()
		{
			this.LoadFile("system/scripts/test.lua");
		}

		/// <summary>
		/// Loads file from given path.
		/// </summary>
		/// <param name="filePath"></param>
		private void LoadFile(string filePath)
		{
			if (!File.Exists(filePath))
			{
				Log.Error("ScriptManager.LoadFile: File '{0}' not found.", filePath);
				return;
			}

			Melua.luaL_loadfile(GL, filePath);
			if (Melua.lua_pcall(GL, 0, 0, 0) != 0)
				Log.Error("ScriptManager.LoadFile: Failed to load '{0}'.\n{1}", filePath, Melua.lua_tostring(GL, -1));
		}

		/// <summary>
		/// Returns a script state for the connection.
		/// </summary>
		/// <param name="conn"></param>
		/// <returns></returns>
		public IntPtr GetState(ChannelConnection conn)
		{
			var NL = Melua.lua_newthread(GL);
			unsafe
			{
				var ptr = (int*)NL.ToPointer();
				ptr -= 8;
				*ptr = conn.Index;
			}
			return NL;
		}

		/// <summary>
		/// Calls function with connection's script state.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="functionName"></param>
		public void Call(ChannelConnection conn, string functionName)
		{
			var NL = conn.ScriptState;

			Melua.lua_getglobal(NL, functionName);
			if (Melua.lua_isnil(NL, -1))
			{
				Log.Error("ScriptManager.Call: Function '{0}' not found.", functionName);
				return;
			}

			if (Melua.lua_pcall(NL, 0, 0, 0) != 0)
				Log.Error("ScriptManager.Call: Error while executing '{0}' for {1}.\n{2}", functionName, conn.Account.Name, Melua.lua_tostring(GL, -1));
		}

		/// <summary>
		/// Returns true if enough arguments are on the stack,
		/// otherwise it logs an error an returns false.
		/// </summary>
		/// <param name="L"></param>
		/// <param name="expected"></param>
		/// <returns></returns>
		private bool CheckArgumentCount(IntPtr L, int expected, [CallerMemberName]string caller = "")
		{
			var argc = Melua.lua_gettop(L);
			if (argc < expected)
			{
				Log.Error("{0}: Too few arguments, expected {1}, got {2}.", caller, expected, argc);
				return false;
			}

			return true;
		}

		/// <summary>
		/// Returns connection associated with state.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		private ChannelConnection GetConnectionFromState(IntPtr L)
		{
			var index = 0;
			unsafe
			{
				var ptr = (int*)L.ToPointer();
				ptr -= 8;
				index = *ptr;
			}

			if (index == 0)
				throw new ArgumentException("No index found in state.");

			var conn = ChannelServer.Instance.ConnectionManager.Connections[index];
			if (conn == null)
				throw new Exception("No connection found for index.");

			return conn;
		}

		//-----------------------------------------------------------------//
		// SCRIPT FUNCTIONS												   //
		//-----------------------------------------------------------------//

		private int debug(IntPtr L)
		{
			if (!this.CheckArgumentCount(L, 1))
				return 0;

			var msg = Melua.luaL_checkstring(L, 1);
			Melua.lua_pop(L, 1);
			Log.Debug(msg);

			return 0;
		}

		private int addnpc(IntPtr L)
		{
			if (!this.CheckArgumentCount(L, 7))
				return 0;

			var monsterId = Melua.luaL_checkinteger(L, 1);
			var name = Melua.luaL_checkstring(L, 2);
			var mapName = Melua.luaL_checkstring(L, 3);
			var x = (float)Melua.luaL_checknumber(L, 4);
			var y = (float)Melua.luaL_checknumber(L, 5);
			var z = (float)Melua.luaL_checknumber(L, 6);
			var dialog = Melua.luaL_checkstring(L, 7);

			Melua.lua_pop(L, 6);

			var map = ChannelServer.Instance.World.GetMap(mapName);
			if (map == null)
			{
				Log.Error("addnpc: Map '{0}' not found.", mapName);
				return 0;
			}

			var monster = new Monster(monsterId, NpcType.NPC);
			monster.Name = name;
			monster.DialogName = dialog;
			monster.Position = new Position(x, y, z);

			map.AddMonster(monster);

			return 0;
		}

		private int msg(IntPtr L)
		{
			if (!this.CheckArgumentCount(L, 1))
				return 0;

			var msg = Melua.luaL_checkstring(L, 1);

			Melua.lua_pop(L, 1);

			var conn = this.GetConnectionFromState(L);
			Send.ZC_DIALOG_OK(conn, msg);

			return 0;
		}
	}
}
