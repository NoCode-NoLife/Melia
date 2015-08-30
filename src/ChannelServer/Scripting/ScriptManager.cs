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
				Log.Error("Failed to load '{0}'.\n{1}", filePath, Melua.lua_tostring(GL, -1));
		}

		//-----------------------------------------------------------------//
		// SCRIPT FUNCTIONS												   //
		//-----------------------------------------------------------------//

		private int debug(IntPtr L)
		{
			var msg = Melua.luaL_checkstring(L, 1);
			Melua.lua_pop(L, 1);
			Log.Debug(msg);

			return 0;
		}

		private int addnpc(IntPtr L)
		{
			var argc = Melua.lua_gettop(L);
			if (argc < 7)
			{
				Log.Error("addnpc: Too few arguments, expected 7, got {0}.", argc);
				return 0;
			}

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
	}
}
