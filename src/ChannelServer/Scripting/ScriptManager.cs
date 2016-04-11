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
using System.Threading;

namespace Melia.Channel.Scripting
{
	public class ScriptManager
	{
		private const string SystemRoot = "system/scripts/";
		private const string UserRoot = "user/scripts/";
		private const string List = SystemRoot + "scripts.txt";

		private const string NpcNameSeperator = "*@*";

		private const string GlobalVariableOwner = "global";
		private const int VariableSaveInterval = 5 * 60 * 1000; // 5 min

		private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1);

		private IntPtr GL;
		private List<Melua.LuaNativeFunction> _functions;
		private Dictionary<IntPtr, ScriptState> _states;

		private Timer _globalVarSaver;
		private DateTime _lastVarChange;

		/// <summary>
		/// Amount of scripts currently loaded.
		/// </summary>
		public int LoadedCount { get; protected set; }

		/// <summary>
		/// Amount of all scripts in script list.
		/// </summary>
		public int TotalCount { get; protected set; }

		/// <summary>
		/// Global scripting variables.
		/// </summary>
		public Variables Variables { get; protected set; }

		/// <summary>
		/// Creates new script manager.
		/// </summary>
		public ScriptManager()
		{
			_functions = new List<Melua.LuaNativeFunction>();
			_states = new Dictionary<IntPtr, ScriptState>();

			this.Variables = new Variables();
		}

		/// <summary>
		/// Initializes scripting environment.
		/// </summary>
		public void Initialize()
		{
			this.InitializeVariables();
			this.InitializeLua();
		}

		/// <summary>
		/// Initializes global Lua state.
		/// </summary>
		private void InitializeLua()
		{
			GL = Melua.luaL_newstate();
			Melua.melua_openlib(GL, LuaLib.Table, LuaLib.String, LuaLib.Math);

			var func = new Melua.LuaNativeFunction(OnPanic);
			_functions.Add(func);
			Melua.lua_atpanic(GL, func);

			// Functions
			// --------------------------------------------------------------
			// Output
			Register(print);
			Register(logdebug);

			// Setup
			Register(addnpc);
			Register(addwarp);

			// Dialog
			Register(msg);
			Register(select);
			Register(close);
			Register(input);
			Register(numinput);

			// Information
			Register(getpc);
			Register(getnpc);
			Register(gettime);

			// Inventory
			Register(hasitem);
			Register(countitem);

			// Action
			Register(warp);
			Register(resetstats);
			Register(changehair);
			Register(spawn);
		}

		/// <summary>
		/// Initializes global variable manager.
		/// </summary>
		private void InitializeVariables()
		{
			// TODO: Replace timer with time event.
			ChannelServer.Instance.Database.LoadVars(GlobalVariableOwner, this.Variables.Perm);
			_globalVarSaver = new Timer(SaveGlobalVars, null, VariableSaveInterval, VariableSaveInterval);
			_lastVarChange = DateTime.Now;
		}

		/// <summary>
		/// Called if Lua panics.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		private int OnPanic(IntPtr L)
		{
			var error = string.Format("unprotected error in call to Lua API ({0})", Melua.lua_tostring(L, -1));

			// Throwing an exception to get out of here, which should stop
			// Lua from exiting the host process, causes a stack overflow
			// for some reason.
			//throw new Exception("Lua panic: " + error);

			Log.Error("Lua panic: " + error);
			return 0;
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
			// We could use Lua's require system to load everything,
			// but relative paths don't work with that. Additionally,
			// we'd have to clear the require cache on reload,
			// so it actually loads files again. The way it is,
			// we don't have yet another include mechanism, we have control
			// over the amount of loaded files, we don't need calls to
			// require, and we have relative paths.

			this.LoadedCount = 0;
			this.TotalCount = 0;

			Log.Info("Loading scripts...");

			using (var fr = new FileReader(List))
			{
				foreach (var line in fr)
				{
					var dir = Path.GetDirectoryName(line.File);
					var filePath = Path.Combine(dir, line.Value);

					if (this.LoadFile(filePath))
						this.LoadedCount++;

					this.TotalCount++;
				}
			}

			Log.Info("  done loading {0} scripts (of {1}).", this.LoadedCount, this.TotalCount);
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
		/// <returns></returns>
		private bool LoadFile(string filePath)
		{
			if (!File.Exists(filePath))
			{
				Log.Error("ScriptManager.LoadFile: File '{0}' not found.", filePath);
				return false;
			}

			// Load file
			var result = Melua.luaL_loadfile(GL, filePath);
			if (result != 0)
			{
				Log.Error("ScriptManager.LoadFile: Failed to compile '{0}' (Error code: {1}).\n{2}", filePath, result, Melua.lua_tostring(GL, -1));
				return false;
			}

			// Execute it
			if (Melua.lua_pcall(GL, 0, 0, 0) != 0)
			{
				Log.Error("ScriptManager.LoadFile: Failed to load '{0}'.\n{1}", filePath, Melua.lua_tostring(GL, -1));
				return false;
			}

			return true;
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
		/// Removes script state from the manager.
		/// </summary>
		/// <param name="state"></param>
		/// <returns></returns>
		public void RemoveScriptState(ScriptState state)
		{
			if (state == null)
				return;

			lock (_states)
				_states.Remove(state.NL);

			// Apparently there is no lua_closethread()?
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
			{
				Log.Error("ScriptManager.Call: Error while executing '{0}' for {1}.\n{2}", functionName, conn.Account.Name, Melua.lua_tostring(NL, -1));
				result = 0; // Set to 0 to close dialog on error
			}

			// Close dialog if end of function was reached
			if (result == 0)
			{
				Send.ZC_DIALOG_CLOSE(conn);
				conn.ScriptState.CurrentNpc = null;
			}
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
				// a selection handler, which's windows don't disappear when
				// sending the next message. So let's close it before
				// continuing.
				Send.ZC_DIALOG_CLOSE(conn);
			}

			var result = Melua.lua_resume(NL, argc);

			// Log error if result is not success or yield
			if (result != 0 && result != Melua.LUA_YIELD)
			{
				Log.Error("ScriptManager.Call: Error while resuming script for {0}.\n{1}", conn.Account.Name, Melua.lua_tostring(NL, -1));
				result = 0; // Set to 0 to close dialog on error
			}

			// Close dialog if end of function was reached
			if (result == 0)
			{
				// Only close from here if the end was reached after an
				// argument-less resume, since close is already called
				// from the argument handling to get rid of the selection
				// dialog.
				if (argc == 0)
					Send.ZC_DIALOG_CLOSE(conn);
				conn.ScriptState.CurrentNpc = null;
			}
		}

		/// <summary>
		/// Returns connection associated with state.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		private ChannelConnection GetConnectionFromState(IntPtr L)
		{
			ScriptState state;
			lock (_states)
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

		/// <summary>
		/// Prepends NPC name code to msg if no name is set for the msg.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="msg"></param>
		private void AttachNpcName(ChannelConnection conn, ref string msg)
		{
			// Prepend NPC name
			if (!msg.Contains(NpcNameSeperator) && conn.ScriptState.CurrentNpc != null)
				msg = conn.ScriptState.CurrentNpc.Name + NpcNameSeperator + msg;
		}

		/// <summary>
		/// Saves global variables to database.
		/// </summary>
		/// <param name="state"></param>
		private void SaveGlobalVars(object state)
		{
			if (this.Variables.Perm.LastChange <= _lastVarChange)
				return;

			_lastVarChange = this.Variables.Perm.LastChange;

			try
			{
				ChannelServer.Instance.Database.SaveVariables(GlobalVariableOwner, this.Variables.Perm);
				Log.Info("Saved global script variables.");
			}
			catch (Exception ex)
			{
				Log.Exception(ex, "Failed to save global script variables.");
			}
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
		/// - string name / Localkey
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
			var monsterId = Melua.luaL_checkinteger(L, 1);
			var name = Melua.luaL_checkstring(L, 2);
			var mapName = Melua.luaL_checkstring(L, 3);
			var x = (float)Melua.luaL_checknumber(L, 4);
			var y = (float)Melua.luaL_checknumber(L, 5);
			var z = (float)Melua.luaL_checknumber(L, 6);
			var direction = Melua.luaL_checkinteger(L, 7);
			var dialog = Melua.luaL_checkstring(L, 8);

			Melua.lua_pop(L, 8);

			var map = ChannelServer.Instance.World.GetMap(mapName);
			if (map == null)
				return Melua.melua_error(L, "Map '{0}' not found.", mapName);

			// Wrap name in localization code if applicable
			if (name.StartsWith("ETC_") || name.StartsWith("QUEST_"))
				name = "@dicID_^*$" + name + "$*^";

			var monster = new Monster(monsterId, NpcType.NPC);
			monster.Name = name;
			monster.DialogName = dialog;
			monster.Position = new Position(x, y, z);
			monster.Direction = new Direction(direction);

			map.AddMonster(monster);

			return 0;
		}

		/// <summary>
		/// Adds warp to world.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string warpName
		/// - number direction
		/// - string fromMapName
		/// - number fromX
		/// - number fromY
		/// - number fromZ
		/// - string toMapName
		/// - number toX
		/// - number toY
		/// - number toZ
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int addwarp(IntPtr L)
		{
			var warpName = Melua.luaL_checkstring(L, 1);
			var direction = Melua.luaL_checknumber(L, 2);
			var fromMapName = Melua.luaL_checkstring(L, 3);
			var fromX = (float)Melua.luaL_checknumber(L, 4);
			var fromY = (float)Melua.luaL_checknumber(L, 5);
			var fromZ = (float)Melua.luaL_checknumber(L, 6);
			var toMapName = Melua.luaL_checkstring(L, 7);
			var toX = (float)Melua.luaL_checknumber(L, 8);
			var toY = (float)Melua.luaL_checknumber(L, 9);
			var toZ = (float)Melua.luaL_checknumber(L, 10);

			Melua.lua_pop(L, 10);

			// Check "from" map data
			var fromMapData = ChannelServer.Instance.Data.MapDb.Find(fromMapName);
			if (fromMapData == null)
				return Melua.melua_error(L, "Map '{0}' not found in data.", fromMapName);

			// Check map in world
			var map = ChannelServer.Instance.World.GetMap(fromMapData.Id);
			if (map == null)
				return Melua.melua_error(L, "Map '{0}' not found in world.", fromMapName);

			// Check "to" map data
			var toMapData = ChannelServer.Instance.Data.MapDb.Find(toMapName);
			if (toMapData == null)
				return Melua.melua_error(L, "Map '{0}' not found in data.", toMapName);

			// It would be pointless to check the "to map in world" here,
			// since the target map could easily be on an entirely different
			// server. *This* channel may not have that map.

			// Get name, preferably a localization key
			var name = toMapName;
			if (toMapData.LocalKey != "?")
				name = "@dicID_^*$" + toMapData.LocalKey + "$*^";

			// Create a warping monster...
			var monster = new Monster(40001, NpcType.NPC);
			monster.Name = name;
			monster.WarpName = warpName;
			monster.Position = new Position(fromX, fromY, fromZ);
			monster.Direction = new Direction(direction);
			monster.WarpLocation = new Location(toMapData.Id, toX, toY, toZ);

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
			var conn = this.GetConnectionFromState(L);

			var msg = Melua.luaL_checkstring(L, 1);
			Melua.lua_pop(L, 1);

			this.AttachNpcName(conn, ref msg);
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
		/// - string options...
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

			this.AttachNpcName(conn, ref args[0]);

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

			this.AttachNpcName(conn, ref msg);
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
		/// - int min (optional, defaults to 0)
		/// - int max (optional, defaults to 255)
		/// 
		/// Result:
		/// The number put in by the user.
		/// Returns 0 on error.
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

			int min = 0, max = 255;

			// Get arguments
			var msg = Melua.luaL_checkstring(L, 1);
			if (argc >= 3)
			{
				min = Melua.luaL_checkinteger(L, 2);
				max = Melua.luaL_checkinteger(L, 3);
			}

			Melua.lua_pop(L, argc);

			this.AttachNpcName(conn, ref msg);
			this.HandleCustomCode(conn, ref msg);

			Send.ZC_DIALOG_NUMBERRANGE(conn, msg, min, max);

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

		/// <summary>
		/// Returns a table with information about the player.
		/// </summary>
		/// <remarks>
		/// Result:
		/// {
		///		string  name,     -- Character's name
		///		string  teamName, -- Character's team name
		///		integer gender,   -- Character's gender
		///		integer level,    -- Character's level
		///		integer hp,       -- Character's HP
		///		integer maxHp,    -- Character's max HP
		///		integer sp,       -- Character's SP
		///		integer maxSp,    -- Character's max SP
		///		integer stamina,  -- Character's stamina
		///		integer hair,     -- Character's hair
		/// }
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int getpc(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			Melua.lua_newtable(L);

			Melua.lua_pushstring(L, "name");
			Melua.lua_pushstring(L, character.Name);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "teamName");
			Melua.lua_pushstring(L, character.TeamName);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "gender");
			Melua.lua_pushinteger(L, (int)character.Gender);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "level");
			Melua.lua_pushinteger(L, character.Level);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "hp");
			Melua.lua_pushinteger(L, character.Hp);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "maxHp");
			Melua.lua_pushinteger(L, character.MaxHp);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "sp");
			Melua.lua_pushinteger(L, character.Sp);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "maxSp");
			Melua.lua_pushinteger(L, character.MaxSp);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "stamina");
			Melua.lua_pushinteger(L, character.Stamina);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "hair");
			Melua.lua_pushinteger(L, character.Hair);
			Melua.lua_settable(L, -3);

			return 1;
		}

		/// <summary>
		/// Returns a table with information about the NPC.
		/// </summary>
		/// <remarks>
		/// Result:
		/// {
		///		string name,        -- NPCs name
		///		string dialogName,  -- Name of NPCs main dialog function
		/// }
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int getnpc(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.ScriptState.CurrentNpc;

			Melua.lua_newtable(L);

			Melua.lua_pushstring(L, "name");
			Melua.lua_pushstring(L, character.Name);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "dialogName");
			Melua.lua_pushstring(L, character.DialogName);
			Melua.lua_settable(L, -3);

			return 1;
		}

		/// <summary>
		/// Returns table, containing information about the current date/time.
		/// </summary>
		/// <remarks>
		/// Result:
		/// {
		///		integer year,     -- Current year
		///		integer month,    -- Current month
		///		integer day,      -- Current day
		///		integer weekday,  -- Day of the week (0-6), starting on Sunday
		///		integer yearday,  -- Day of the current year
		///		integer hour,     -- Current hours (0-23)
		///		integer min,      -- Current minutes (0-59)
		///		integer sec,      -- Current seconds (0-59)
		///		integer msec,     -- Current milliseconds (0-999)
		///		boolean isdst,    -- Is Daylight Saving Time?
		///		integer unixts,   -- Unix timestamp
		/// }
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int gettime(IntPtr L)
		{
			var now = DateTime.Now;

			// TODO: Could a general table generation like this be cached?

			Melua.lua_newtable(L);

			Melua.lua_pushstring(L, "year");
			Melua.lua_pushinteger(L, now.Year);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "month");
			Melua.lua_pushinteger(L, now.Month);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "day");
			Melua.lua_pushinteger(L, now.Day);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "weekday");
			Melua.lua_pushinteger(L, (int)now.DayOfWeek);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "yearday");
			Melua.lua_pushinteger(L, now.DayOfYear);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "hour");
			Melua.lua_pushinteger(L, now.Hour);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "min");
			Melua.lua_pushinteger(L, now.Minute);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "sec");
			Melua.lua_pushinteger(L, now.Second);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "msec");
			Melua.lua_pushinteger(L, now.Millisecond);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "isdst");
			Melua.lua_pushboolean(L, now.IsDaylightSavingTime());
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "unixts");
			Melua.lua_pushinteger(L, (int)(now.ToUniversalTime().Subtract(UnixEpoch)).TotalSeconds);
			Melua.lua_settable(L, -3);

			return 1;
		}

		/// <summary>
		/// Warps player to given location.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string mapName
		/// - number x
		/// - number y
		/// - number z
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int warp(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);

			var mapName = Melua.luaL_checkstring(L, 1);
			var x = (float)Melua.luaL_checknumber(L, 2);
			var y = (float)Melua.luaL_checknumber(L, 3);
			var z = (float)Melua.luaL_checknumber(L, 4);

			Melua.lua_pop(L, 4);

			try
			{
				conn.SelectedCharacter.Warp(mapName, x, y, z);
			}
			catch (ArgumentException ex)
			{
				Melua.lua_pushstring(L, ex.Message);
				Melua.lua_error(L);
			}

			return 0;
		}

		/// <summary>
		/// Resets the player's stat points
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		private int resetstats(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			character.StatByLevel += character.Str - 1;
			character.StatByLevel += character.Con - 1;
			character.StatByLevel += character.Int - 1;
			character.StatByLevel += character.Spr - 1;
			character.StatByLevel += character.Dex - 1;
			character.UsedStat = 0;

			character.Str = 1;
			character.Con = 1;
			character.Int = 1;
			character.Spr = 1;
			character.Dex = 1;

			Send.ZC_OBJECT_PROPERTY(character,
				ObjectProperty.PC.STR, ObjectProperty.PC.CON, ObjectProperty.PC.INT, ObjectProperty.PC.MNA, ObjectProperty.PC.DEX,
				ObjectProperty.PC.StatByLevel, ObjectProperty.PC.StatByBonus, ObjectProperty.PC.UsedStat
			);

			return 0;
		}

		/// <summary>
		/// Changes the player's hairstyle.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int hairId
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int changehair(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			var hairId = Melua.luaL_checkinteger(L, 1);

			Melua.lua_pop(L, 1);

			character.Hair = (byte)hairId;
			Send.ZC_UPDATED_PCAPPEARANCE(character);

			return 0;
		}

		/// <summary>
		/// Spawns monster.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int    monsterId
		/// - string mapName
		/// - float  x
		/// - float  y
		/// - float  z
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int spawn(IntPtr L)
		{
			var monsterId = Melua.luaL_checkinteger(L, 1);
			var mapName = Melua.luaL_checkstring(L, 2);
			var x = (float)Melua.luaL_checknumber(L, 3);
			var y = (float)Melua.luaL_checknumber(L, 4);
			var z = (float)Melua.luaL_checknumber(L, 5);

			Melua.lua_pop(L, 5);

			var map = ChannelServer.Instance.World.GetMap(mapName);
			if (map == null)
				return Melua.melua_error(L, "Map '{0}' not found.", mapName);

			var monster = new Monster(monsterId, NpcType.Monster);
			monster.Position = new Position(x, y, z);

			map.AddMonster(monster);

			return 0;
		}

		/// <summary>
		/// Returns true if character has items with the given id.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int itemId
		/// 
		/// Result:
		/// - bool hasItem?
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int hasitem(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			var itemId = Melua.luaL_checkinteger(L, 1);
			Melua.lua_pop(L, 1);

			var result = character.Inventory.HasItem(itemId);
			Melua.lua_pushboolean(L, result);

			return 1;
		}

		/// <summary>
		/// Returns amount of items with the given id in character's inventory.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int itemId
		/// 
		/// Result:
		/// - int amount
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int countitem(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			var itemId = Melua.luaL_checkinteger(L, 1);
			Melua.lua_pop(L, 1);

			var result = character.Inventory.CountItem(itemId);
			Melua.lua_pushinteger(L, result);

			return 1;
		}
	}
}
