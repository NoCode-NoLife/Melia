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
		private const string List = "system/scripts/scripts.txt";

		private IntPtr GL;
		private List<Melua.LuaNativeFunction> _functions;
		private Dictionary<IntPtr, ScriptState> _states;

		/// <summary>
		/// Amount of scripts currently loaded.
		/// </summary>
		public int Count { get; protected set; }

		/// <summary>
		/// Creates new script manager.
		/// </summary>
		public ScriptManager()
		{
			_functions = new List<Melua.LuaNativeFunction>();
			_states = new Dictionary<IntPtr, ScriptState>();

			GL = Melua.luaL_newstate();

			Register(print);
			Register(logdebug);
			Register(addnpc);
			Register(msg);
			Register(select);
			Register(close);
			Register(input);
			Register(numinput);
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
		public void Load()
		{
			// TODO: Remove NPCs before reloading.
			this.Count = 0;

			using (var fr = new FileReader(List))
			{
				foreach (var line in fr)
				{
					var dir = Path.GetDirectoryName(line.File);
					var filePath = Path.Combine(dir, line.Value);

					this.LoadFile(filePath);
					this.Count++;
				}
			}
		}

		/// <summary>
		/// Removes all scripted entities and reloads all scripts.
		/// </summary>
		public void Reload()
		{
			ChannelServer.Instance.World.RemoveScriptedEntities();
			this.Load();
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
		public ScriptState CreateScriptState(ChannelConnection conn)
		{
			var NL = Melua.lua_newthread(GL);
			var state = new ScriptState(conn, NL);
			lock (_states)
				_states.Add(NL, state);
			return state;
		}

		/// <summary>
		/// Calls function with connection's script state.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="functionName"></param>
		public void Call(ChannelConnection conn, string functionName)
		{
			var NL = conn.ScriptState.NL;

			Melua.lua_getglobal(NL, functionName);
			if (Melua.lua_isnil(NL, -1))
			{
				Log.Error("ScriptManager.Call: Function '{0}' not found.", functionName);
				return;
			}

			var result = Melua.lua_resume(NL, 0);

			// Log error if result is not success or yield
			if (result != 0 && result != Melua.LUA_YIELD)
				Log.Error("ScriptManager.Call: Error while executing '{0}' for {1}.\n{2}", functionName, conn.Account.Name, Melua.lua_tostring(NL, -1));

			// Close dialog if end of function was reached
			if (result == 0)
				Send.ZC_DIALOG_CLOSE(conn);
		}

		/// <summary>
		/// Resumes script after yielding.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="argument"></param>
		public void Resume(ChannelConnection conn, params object[] arguments)
		{
			var NL = conn.ScriptState.NL;
			var argc = (arguments != null ? arguments.Length : 0);

			if (argc != 0)
			{
				foreach (var arg in arguments)
				{
					if (arg is byte) Melua.lua_pushinteger(NL, (byte)arg);
					else if (arg is short) Melua.lua_pushinteger(NL, (short)arg);
					else if (arg is int) Melua.lua_pushinteger(NL, (int)arg);
					else if (arg is string) Melua.lua_pushstring(NL, (string)arg);
					else
					{
						Log.Warning("ScriptManager.Resume: Invalid argument type '{0}'.", arg.GetType().Name);
						Melua.lua_pushinteger(NL, 0);
					}
				}

				// If arguments were passed, we can assume we're coming from
				// a selection handler, which's window don't disappear when
				// sending the next message. So let's close it before
				// continuing.
				Send.ZC_DIALOG_CLOSE(conn);
			}

			var result = Melua.lua_resume(NL, argc);

			// Log error if result is not success or yield
			if (result != 0 && result != Melua.LUA_YIELD)
				Log.Error("ScriptManager.Call: Error while resuming script for {0}.\n{1}", conn.Account.Name, Melua.lua_tostring(NL, -1));

			// Close dialog if end of function was reached
			if (result == 0)
				Send.ZC_DIALOG_CLOSE(conn);
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
			ScriptState state;
			if (!_states.TryGetValue(L, out state))
				throw new Exception("No matching connection found.");

			return state.Connection;
		}

		/// <summary>
		/// Replaces custom codes in msg.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		private void HandleCustomCode(ChannelConnection conn, ref string msg)
		{
			// {pcname} Character name
			if (msg.IndexOf("{pcname}") != -1)
				msg = msg.Replace("{pcname}", conn.SelectedCharacter.Name);

			// {teamname} Character team name
			if (msg.IndexOf("{teamname}") != -1)
				msg = msg.Replace("{teamname}", conn.SelectedCharacter.TeamName);

			// {fullname} Character name + team name
			if (msg.IndexOf("{fullname}") != -1)
				msg = msg.Replace("{fullname}", conn.SelectedCharacter.Name + " " + conn.SelectedCharacter.TeamName);
		}

		//-----------------------------------------------------------------//
		// SCRIPT FUNCTIONS												   //
		//-----------------------------------------------------------------//

		/// <summary>
		/// Prints message in console using Console.WriteLine.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string message
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int print(IntPtr L)
		{
			if (!this.CheckArgumentCount(L, 1))
				return 0;

			var msg = Melua.luaL_checkstring(L, 1);
			Melua.lua_pop(L, 1);

			Console.WriteLine(msg);

			return 0;
		}

		/// <summary>
		/// Prints and logs debug message.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string message
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int logdebug(IntPtr L)
		{
			if (!this.CheckArgumentCount(L, 1))
				return 0;

			var msg = Melua.luaL_checkstring(L, 1);
			Melua.lua_pop(L, 1);

			Log.Debug(msg);

			return 0;
		}

		/// <summary>
		/// Adds NPC to world.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int monsterId
		/// - string name
		/// - string mapName
		/// - number x
		/// - number y
		/// - number z
		/// - string dialogFunctionName
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
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

			Melua.lua_pop(L, 7);

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

		/// <summary>
		/// Sends dialog message to client.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string message
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int msg(IntPtr L)
		{
			if (!this.CheckArgumentCount(L, 1))
				return 0;

			var conn = this.GetConnectionFromState(L);

			var msg = Melua.luaL_checkstring(L, 1);
			Melua.lua_pop(L, 1);

			this.HandleCustomCode(conn, ref msg);

			Send.ZC_DIALOG_OK(conn, msg);

			return Melua.lua_yield(L, 0);
		}

		/// <summary>
		/// Sends dialog select message to client, showing a message and a
		/// list of options to select from.
		/// </summary>
		/// <remarks>
		/// Select can take an arbitrary amount of options.
		/// 
		/// Parameters:
		/// - string message
		/// - string option...
		/// 
		/// Result:
		/// The number of the selected option, starting from 1.
		/// Returns 0 on error.
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int select(IntPtr L)
		{
			// Check arguments and return 0 on error
			var argc = Melua.lua_gettop(L);
			if (argc == 0)
			{
				Log.Warning("select: No arguments.");
				Melua.lua_pushinteger(L, 0);
				return 1;
			}

			var conn = this.GetConnectionFromState(L);

			// Get arguments, first argument is the message, everything afterwards
			// is one option to select from.
			var args = new string[argc];
			for (int i = 1; i <= argc; ++i)
			{
				var arg = Melua.luaL_checkstring(L, i);
				this.HandleCustomCode(conn, ref arg);
				args[i - 1] = arg;
			}

			Melua.lua_pop(L, argc);

			Send.ZC_DIALOG_SELECT(conn, args);

			return Melua.lua_yield(L, 1);
		}

		/// <summary>
		/// Sends dialog input message, showing a message and a text field,
		/// for the user to put in a string.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string message
		/// 
		/// Result:
		/// The string put in by the user.
		/// Returns empty string on error.
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int input(IntPtr L)
		{
			// Check arguments and return empty string on error
			var argc = Melua.lua_gettop(L);
			if (argc == 0)
			{
				Log.Warning("input: No arguments.");
				Melua.lua_pushstring(L, "");
				return 1;
			}

			var conn = this.GetConnectionFromState(L);

			// Get message
			var msg = Melua.luaL_checkstring(L, 1);
			Melua.lua_pop(L, 1);

			this.HandleCustomCode(conn, ref msg);

			Send.ZC_DIALOG_STRINGINPUT(conn, msg);

			return Melua.lua_yield(L, 1);
		}

		/// <summary>
		/// Sends dialog numberrange message, showing a message and a small text field,
		/// for the user to put in a number.
		/// </summary>
		/// <remarks>
		/// NUMBERRANGE uses CZ_DIALOG_SELECT for its response,
		/// which means the number range is that of a byte, 0~255.
		/// 
		/// Parameters:
		/// - string message
		/// 
		/// Result:
		/// The number put in by the user.
		/// Returns empty string on error.
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int numinput(IntPtr L)
		{
			// Check arguments and return 0 on error
			var argc = Melua.lua_gettop(L);
			if (argc == 0)
			{
				Log.Warning("numinput: No arguments.");
				Melua.lua_pushinteger(L, 0);
				return 1;
			}

			var conn = this.GetConnectionFromState(L);

			// Get message
			var msg = Melua.luaL_checkstring(L, 1);
			Melua.lua_pop(L, 1);

			this.HandleCustomCode(conn, ref msg);

			Send.ZC_DIALOG_NUMBERRANGE(conn, msg);

			return Melua.lua_yield(L, 1);
		}

		/// <summary>
		/// Instructs client to close the dialog window.
		/// Does not stop the script's execution.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		private int close(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);

			Send.ZC_DIALOG_CLOSE(conn);

			return 0;
		}
	}

	public class ScriptState
	{
		public ChannelConnection Connection { get; private set; }
		public IntPtr NL { get; private set; }

		public ScriptState(ChannelConnection conn, IntPtr NL)
		{
			this.Connection = conn;
			this.NL = NL;
		}
	}
}
