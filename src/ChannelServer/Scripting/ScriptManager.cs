// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using Melia.Channel.Network;
using Melia.Shared.Util;
using MeluaLib;

namespace Melia.Channel.Scripting
{
	public partial class ScriptManager
	{
		private const string SystemRoot = "system/scripts/";
		private const string UserRoot = "user/scripts/";
		private const string List = SystemRoot + "scripts.txt";

		private const string NpcNameSeperator = "*@*";
		private const string NpcDialogTextSeperator = "\\";

		private const string GlobalVariableOwner = "global";
		private const int VariableSaveInterval = 5 * 60 * 1000; // 5 min

		private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1);
		private static readonly Regex VarNameCheck = new Regex(@"^[a-z][a-z0-9_]*$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

		private IntPtr _gL;
		private readonly object _glSyncLock = new object();

		private readonly Dictionary<IntPtr, ScriptState> _states = new Dictionary<IntPtr, ScriptState>();

		private Timer _globalVarSaver;
		private DateTime _lastVarChange;

		private int _anonymousDialogCount;

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
		public Variables Variables { get; protected set; } = new Variables();

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
			_gL = Melua.luaL_newstate();

			Melua.melua_openlib(_gL, new[]
			{
				new Melua.LuaLib("", Melua.meluaopen_basesafe),
				new Melua.LuaLib("table", Melua.luaopen_table),
				new Melua.LuaLib("string", Melua.luaopen_string),
				new Melua.LuaLib("math", Melua.luaopen_math),
			});

			Melua.lua_atpanic(_gL, Melua.CreateFunctionReference(_gL, this.OnPanic));

			this.RegisterFunctions();
		}

		/// <summary>
		/// Initializes global variable manager.
		/// </summary>
		private void InitializeVariables()
		{
			// TODO: Replace timer with time event.
			ChannelServer.Instance.Database.LoadVars(GlobalVariableOwner, this.Variables.Perm);
			_globalVarSaver = new Timer(this.SaveGlobalVars, null, VariableSaveInterval, VariableSaveInterval);
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
		/// <param name="function"></param>
		private void Register(Melua.LuaNativeFunction function)
		{
			var func = Melua.CreateFunctionReference(_gL, function);
			Melua.lua_register(_gL, function.Method.Name, func);
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

			var toLoad = this.ReadScriptList(List);
			this.TotalCount = toLoad.Count;

			foreach (var filePath in toLoad)
			{
				if (this.LoadFile(filePath))
					this.LoadedCount++;
			}

			Log.Info("  done loading {0} scripts (of {1}).", this.LoadedCount, this.TotalCount);
		}

		/// <summary>
		/// Reads given list file and returns list of all script files that
		/// are to be loaded.
		/// </summary>
		/// <param name="listFilePath"></param>
		private List<string> ReadScriptList(string listFilePath)
		{
			var result = new List<string>();

			using (var fr = new FileReader(listFilePath))
			{
				foreach (var line in fr)
				{
					var path = line.Value.Replace("\\", "/");
					var cwd = Directory.GetCurrentDirectory().Replace("\\", "/");

					string dir;
					if (path.StartsWith("/")) // Relative to root
						dir = cwd;
					else // Relative to list location
						dir = Path.GetDirectoryName(line.File).Replace("\\", "/");

					path = Path.Combine(dir, path).Replace("\\", "/");

					var user = Path.GetFullPath(UserRoot).Replace("\\", "/");
					var system = Path.GetFullPath(SystemRoot).Replace("\\", "/");

					var relativePath = path.Replace(user, "").Replace(system, "");
					var userPath = Path.Combine(user, relativePath).Replace("\\", "/");
					var systemPath = Path.Combine(system, relativePath).Replace("\\", "/");

					// Prioritize user folder
					if (File.Exists(userPath))
						relativePath = userPath;
					else
						relativePath = systemPath;

					relativePath = relativePath.Replace(cwd + '/', "");

					result.Add(relativePath);
				}
			}

			return result;
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
			var result = Melua.luaL_loadfile(_gL, filePath);
			if (result != 0)
			{
				Log.Error("ScriptManager.LoadFile: Failed to compile '{0}' (Error code: {1}).\n{2}", filePath, result, Melua.lua_tostring(_gL, -1));
				return false;
			}

			// Execute it
			if (Melua.lua_pcall(_gL, 0, 0, 0) != 0)
			{
				Log.Error("ScriptManager.LoadFile: Failed to load '{0}'.\n{1}", filePath, Melua.lua_tostring(_gL, -1));
				return false;
			}

			return true;
		}

		/// <summary>
		/// Creates new Lua thread for the state to use and saves
		/// a reference to the connection's script state.
		/// </summary>
		/// <param name="conn"></param>
		/// <returns></returns>
		public LuaThread GetNewThread(ScriptState state)
		{
			if (state.LuaThread != null)
				this.RemoveThread(state.LuaThread);

			IntPtr NL;
			int index;
			lock (_glSyncLock)
			{
				// Create new thread and save index, so it can be removed later.
				NL = Melua.lua_newthread(_gL);
				index = Melua.lua_gettop(_gL);
			}

			lock (_states)
				_states.Add(NL, state);

			return new LuaThread(NL, index);
		}

		/// <summary>
		/// Removes thread and the associated state from the manager.
		/// </summary>
		/// <param name="state"></param>
		/// <returns></returns>
		public void RemoveThread(LuaThread thread)
		{
			if (thread == null || thread.L == IntPtr.Zero)
				return;

			lock (_glSyncLock)
			{
				// Remove thread from stack and update all stack indexes,
				// as the removal will shift all following elements.
				Melua.lua_remove(_gL, thread.StackIndex);

				lock (_states)
				{
					foreach (var state in _states.Values)
					{
						if (state.LuaThread.StackIndex > thread.StackIndex)
							state.LuaThread.StackIndex--;
					}
				}
			}

			lock (_states)
				_states.Remove(thread.L);

			// Apparently there is no lua_closethread()?
		}

		/// <summary>
		/// Returns true if value looks like a localization key.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private bool IsLocalizationKey(string value)
		{
			return (value.StartsWith("ETC_") || value.StartsWith("QUEST_"));
		}

		/// <summary>
		/// Returns true if value is a known client-side dialog name.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private bool IsClientDialog(string value)
		{
			return ChannelServer.Instance.Data.DialogDb.Exists(value);
		}

		/// <summary>
		/// Returns true if functionName looks like a localization key or a
		/// known client-side dialog name.
		/// </summary>
		/// <param name="functionName"></param>
		/// <returns></returns>
		private bool IsOneLiner(string functionName)
		{
			return (this.IsLocalizationKey(functionName) || this.IsClientDialog(functionName));
		}

		/// <summary>
		/// Wraps key with dictonary code.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		private string WrapLocalizationKey(string key)
		{
			return ("@dicID_^*$" + key + "$*^");
		}

		/// <summary>
		/// Calls dialog function with connection's script state.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="functionName"></param>
		public void CallDialog(ChannelConnection conn, string functionName)
		{
			if (conn.ScriptState.LuaThread != null)
				Log.Warning("ScriptManager.CallDialog: A previous thread wasn't closed for user '{0}'.", conn.Account.Name);

			// Get function name, use oneliner for localized, single-line
			// dialogues.
			if (this.IsOneLiner(functionName))
				functionName = "npc_oneliner";

			// Prepare thread
			conn.ScriptState.LuaThread = this.GetNewThread(conn.ScriptState);
			var NL = conn.ScriptState.LuaThread.L;
			var top = Melua.lua_gettop(_gL);

			// Get function
			Melua.lua_getglobal(NL, functionName);
			if (Melua.lua_isnil(NL, -1))
			{
				Log.Error("ScriptManager.CallDialog: Function '{0}' not found.", functionName);
				return;
			}

			// Run
			var result = Melua.lua_resume(NL, 0);

			// Log error if result is not success or yield
			if (result != 0 && result != Melua.LUA_YIELD)
			{
				Log.Error("ScriptManager.CallDialog: Error while executing '{0}' for user '{1}'.\n{2}", functionName, conn.Account.Name, Melua.lua_tostring(NL, -1));
				result = 0; // Set to 0 to close dialog on error
			}

			// Close dialog if end of function was reached
			if (result == 0)
			{
				Send.ZC_DIALOG_CLOSE(conn);

				conn.ScriptState.Reset();
			}
		}

		/// <summary>
		/// Resumes dialog script after yielding.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="argument"></param>
		public void ResumeDialog(ChannelConnection conn, params object[] arguments)
		{
			if (conn.ScriptState.LuaThread == null)
			{
				Send.ZC_DIALOG_CLOSE(conn);
				Log.Warning("ScriptManager: Resume on empty ScriptState from user '{0}'.", conn.Account.Name);
				return;
			}

			var NL = conn.ScriptState.LuaThread.L;
			var argc = arguments?.Length ?? 0;

			// Reset current shop in case we came from one.
			conn.ScriptState.CurrentShop = null;

			if (argc != 0)
			{
				PushArguments(NL, arguments);

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

				conn.ScriptState.Reset();
			}
		}

		/// <summary>
		/// Calls function with connection's script state.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="functionName"></param>
		/// <param name="arguments"></param>
		public ScriptCallResult Call(ChannelConnection conn, string functionName, params object[] arguments)
		{
			if (conn.ScriptState.LuaThread != null)
				Log.Warning("ScriptManager.Call: A previous thread wasn't closed for user '{0}'.", conn.Account.Name);

			// Prepare thread
			conn.ScriptState.LuaThread = this.GetNewThread(conn.ScriptState);

			var NL = conn.ScriptState.LuaThread.L;
			var top = Melua.lua_gettop(_gL);

			// Get function
			Melua.lua_getglobal(NL, functionName);
			if (Melua.lua_isnil(NL, -1))
			{
				conn.ScriptState.Reset();
				return new ScriptCallResult(ScriptCallResultType.NotFound);
			}

			// Push all arguments
			var argc = arguments?.Length ?? 0;
			if (argc != 0)
				PushArguments(NL, arguments);

			// Execute the function with the arguments
			var funcResult = Melua.lua_resume(NL, argc);

			// If result is not a success or yield, an error occurred.
			if (funcResult != 0 && funcResult != Melua.LUA_YIELD)
			{
				conn.ScriptState.Reset();

				var errorMessage = string.Format("Error while executing '{0}' for user '{1}': {2}", functionName, conn.Account.Name, Melua.lua_tostring(NL, -1));
				return new ScriptCallResult(ScriptCallResultType.Error, errorMessage);
			}

			// We currently don't expect functions called this way to yield
			if (funcResult == Melua.LUA_YIELD)
				Log.Warning("ScriptManager.Call: Script function '{0}' yielded for user '{1}', a behavior that's currently not handled.", functionName, conn.Account.Name);

			conn.ScriptState.Reset();
			return new ScriptCallResult(ScriptCallResultType.Success);
		}

		/// <summary>
		/// Pushes the arguments onto the Lua stack.
		/// </summary>
		/// <param name="NL"></param>
		/// <param name="args"></param>
		private static void PushArguments(IntPtr NL, params object[] args)
		{
			foreach (var arg in args)
			{
				switch (arg)
				{
					case byte v: Melua.lua_pushinteger(NL, v); break;
					case bool v: Melua.lua_pushboolean(NL, v); break;
					case short v: Melua.lua_pushinteger(NL, v); break;
					case int v: Melua.lua_pushinteger(NL, v); break;
					case float v: Melua.lua_pushnumber(NL, v); break;
					case double v: Melua.lua_pushnumber(NL, v); break;
					case string v: Melua.lua_pushstring(NL, v); break;

					default:
					{
						Log.Warning("ScriptManager.PushArguments: Invalid argument type '{0}', pushing 'int 0' instead.", arg.GetType().Name);
						Melua.lua_pushinteger(NL, 0);
						break;
					}
				}
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
			// Wrap localization key
			if (this.IsLocalizationKey(msg))
			{
				msg = this.WrapLocalizationKey(msg);

				// Return, as there won't be any custom code.
				return;
			}

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
			// Don't attach NPC name to client dialogues, those are handled
			// by the client.
			if (this.IsClientDialog(msg))
				return;

			// Prepend NPC name if no seperator is present, otherwise no name
			// will be displayed.
			if (!msg.Contains(NpcNameSeperator) && !msg.Contains(NpcDialogTextSeperator) && conn.ScriptState.CurrentNpc != null)
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

		/// <summary>
		/// Returns a name for an anonymous dialog function. Every name is
		/// given out only once.
		/// </summary>
		/// <returns></returns>
		private string GenerateDialogFunctionName()
		{
			var count = Interlocked.Increment(ref _anonymousDialogCount);
			return "_anonymousDialogFunction" + count;
		}
	}
}
