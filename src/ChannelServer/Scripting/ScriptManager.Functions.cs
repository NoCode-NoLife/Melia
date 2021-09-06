﻿using System;
using System.Collections.Generic;
using Melia.Channel.Network;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;
using static MeluaLib.Melua;
using MySql.Data.MySqlClient;

namespace Melia.Channel.Scripting
{
	public partial class ScriptManager
	{
#pragma warning disable IDE0009 // No "this" necessary

		/// <summary>
		/// Registers functions that can be used by scripts.
		/// </summary>
		private void RegisterFunctions()
		{
			// Setup
			Register(addnpc);
			Register(addwarp);
			Register(addspawn);

			// General
			Register(var);
			Register(logdebug);
			Register(sqlquery);
			Register(sqlescape);
			Register(addonmsg);
			Register(servermsg);

			// Dialog
			Register(msg);
			Register(select);
			Register(close);
			Register(input);
			Register(numinput);
			Register(openshop);

			// Information
			Register(getpc);
			Register(getnpc);
			Register(gettime);

			// Jobs
			Register(isjob);
			Register(isjobclass);
			Register(addjob);
			Register(removejob);

			// Inventory
			Register(hasitem);
			Register(countitem);
			Register(additem);
			Register(removeitem);

			// Action
			Register(warp);
			Register(resetstats);
			Register(changehair);
			Register(spawn);
			Register(levelup);
		}

#pragma warning restore IDE0009 // No "this" necessary

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
			var msg = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			Log.Debug(msg);

			return 0;
		}

		/// <summary>
		/// Adds NPC to world.
		/// </summary>
		/// <remarks>
		/// The parameter `dialogFunctionName` can be the name of a Lua
		/// function name, the name of a client-side dialog, or a
		/// localization key. A client-side dialog controls the NPC name
		/// and appearance, while a localization key will simply send the
		/// key in one message. A Lua function allows for completely
		/// custom dialog.
		/// 
		/// The parameter `direction` is an angle, with 0 being down/south.
		/// Example:
		/// - 0   South
		/// - 90  Right
		/// - -90 Left
		/// 
		/// Parameters:
		/// - int monsterId
		/// - string name / dictId
		/// - string mapName
		/// - number x
		/// - number y
		/// - number z
		/// - int direction
		/// - string|function dialogFunction
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int addnpc(IntPtr L)
		{
			var monsterId = luaL_checkinteger(L, 1);
			var name = luaL_checkstring(L, 2);
			var mapName = luaL_checkstring(L, 3);
			var x = (float)luaL_checknumber(L, 4);
			var y = (float)luaL_checknumber(L, 5);
			var z = (float)luaL_checknumber(L, 6);
			var direction = luaL_checkinteger(L, 7);

			// If the last argument is a function, the dialog function
			// for the NPC was passed to addnpc directly. In  that case,
			// we're going to create a global field with a new name and
			// assign the function to it, so we can then later call it
			// by that name.
			string dialog;
			if (lua_isfunction(L, 8))
			{
				dialog = this.GenerateDialogFunctionName();
				lua_setglobal(L, dialog);
			}
			else
			{
				dialog = luaL_checkstring(L, 8);
			}

			lua_settop(L, 0);

			var map = ChannelServer.Instance.World.GetMap(mapName);
			if (map == null)
				return melua_error(L, "Map '{0}' not found.", mapName);

			// Wrap name in localization code if applicable
			if (this.IsLocalizationKey(name))
				name = this.WrapLocalizationKey(name);

			var monster = new Monster(monsterId, NpcType.NPC);
			monster.Name = name;
			monster.DialogName = dialog;
			monster.Position = new Position(x, y, z);
			monster.Direction = new Direction(direction);

			map.AddMonster(monster);

			return 0;
		}

		/// <summary>
		/// Adds monster spawner to a map.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string  monsterClassName
		/// - number  amount
		/// - number  respawnDelayMs
		/// - string  mapClassName
		/// - table   area
		/// {
		///     x  X-coordinate of the spawn area's center
		///     y  Y-coordinate of the spawn area's center
		///     z  Z-coordinate of the spawn area's center
		///     width  Width of the spawn area
		///     height  Height of the spawn area
		/// }
		/// 
		/// Example:
		/// -- Spawns 5 Kepas on the starter map, in a 100x100 area around
		/// -- [-605/260/-1155]. Respawns dead Kepas after 5000 milliseconds.
		/// addspawn("Onion", 5, 5000, "f_siauliai_west", { x = -605, y = 260, z = -1155, width = 100, height = 100 })
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int addspawn(IntPtr L)
		{
			var monsterClassName = luaL_checkstring(L, 1);
			var amount = luaL_checkinteger(L, 2);
			var respawnDelayMs = luaL_checkinteger(L, 3);
			var mapClassName = luaL_checkstring(L, 4);

			luaL_checktype(L, 5, LUA_TTABLE);

			lua_getfield(L, 5, "x");
			var x = (float)luaL_checknumber(L, -1);

			lua_getfield(L, 5, "y");
			var y = (float)luaL_checknumber(L, -1);

			lua_getfield(L, 5, "z");
			var z = (float)luaL_checknumber(L, -1);

			lua_getfield(L, 5, "width");
			var width = (float)luaL_checknumber(L, -1);

			lua_getfield(L, 5, "height");
			var height = (float)luaL_checknumber(L, -1);

			lua_settop(L, 0);

			if (!ChannelServer.Instance.Data.MonsterDb.TryFind(a => a.ClassName == monsterClassName, out _))
				return melua_error(L, "addspawn: Monster '{0}'  not found.", monsterClassName);

			if (!ChannelServer.Instance.World.TryGetMap(mapClassName, out var map))
				return melua_error(L, "addspawn: Map '{0}' for '{1}' spawn not found.", mapClassName, monsterClassName);

			var area = new Position[]
			{
				new Position(x - width / 2, y, z - height / 2),
				new Position(x + width / 2, y, z - height / 2),
				new Position(x + width / 2, y, z + height / 2),
				new Position(x - width / 2, y, z + height / 2),
			};

			var spawner = new MonsterSpawner(monsterClassName, amount, TimeSpan.FromMilliseconds(respawnDelayMs), mapClassName, area);
			map.AddSpawner(spawner);

			return 0;
		}

		/// <summary>
		/// Adds warp to world.
		/// </summary>
		/// <remarks>
		/// The parameter `direction` is an angle, with 0 being down/south.
		/// Example:
		/// - 0   South
		/// - 90  Right
		/// - -90 Left
		/// 
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
			var warpName = luaL_checkstring(L, 1);
			var direction = luaL_checknumber(L, 2);
			var fromMapName = luaL_checkstring(L, 3);
			var fromX = (float)luaL_checknumber(L, 4);
			var fromY = (float)luaL_checknumber(L, 5);
			var fromZ = (float)luaL_checknumber(L, 6);
			var toMapName = luaL_checkstring(L, 7);
			var toX = (float)luaL_checknumber(L, 8);
			var toY = (float)luaL_checknumber(L, 9);
			var toZ = (float)luaL_checknumber(L, 10);

			lua_settop(L, 0);

			// Check "from" map data
			var fromMapData = ChannelServer.Instance.Data.MapDb.Find(fromMapName);
			if (fromMapData == null)
				return melua_error(L, "Map '{0}' not found in data.", fromMapName);

			// Check map in world
			var map = ChannelServer.Instance.World.GetMap(fromMapData.Id);
			if (map == null)
				return melua_error(L, "Map '{0}' not found in world.", fromMapName);

			// Check "to" map data
			var toMapData = ChannelServer.Instance.Data.MapDb.Find(toMapName);
			if (toMapData == null)
				return melua_error(L, "Map '{0}' not found in data.", toMapName);

			// It would be pointless to check the "to map in world" here,
			// since the target map could easily be on an entirely different
			// server. *This* channel may not have that map.

			// Get name, preferably a localization key
			var name = toMapName;
			if (toMapData.LocalKey != "?")
				name = this.WrapLocalizationKey(toMapData.LocalKey);

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
		/// If message is a localization key (e.g. "ETC_20150317_000015"),
		/// the string is wrapped in a dict code, so the client looks it up
		/// in its dictionary.
		/// 
		/// Parameters:
		/// - string message
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int msg(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);

			var msg = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			this.HandleCustomCode(conn, ref msg);
			this.AttachNpcName(conn, ref msg);

			Send.ZC_DIALOG_OK(conn, msg);

			return lua_yield(L, 0);
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
			var argc = lua_gettop(L);
			if (argc == 0)
			{
				Log.Warning("select: No arguments.");
				lua_pushinteger(L, 0);
				return 1;
			}

			var conn = this.GetConnectionFromState(L);

			// Get arguments, first argument is the message, everything afterwards
			// is one option to select from.
			var args = new string[argc];
			for (var i = 1; i <= argc; ++i)
			{
				var arg = luaL_checkstring(L, i);
				this.HandleCustomCode(conn, ref arg);
				args[i - 1] = arg;
			}

			if (argc > 12)
				Log.Warning("ScriptManager.select: {0} options given, but the client only displays 11.", argc - 1);

			lua_settop(L, 0);

			this.AttachNpcName(conn, ref args[0]);

			Send.ZC_DIALOG_SELECT(conn, args);

			return lua_yield(L, 1);
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
			var argc = lua_gettop(L);
			if (argc == 0)
			{
				Log.Warning("input: No arguments.");
				lua_pushstring(L, "");
				return 1;
			}

			var conn = this.GetConnectionFromState(L);

			// Get message
			var msg = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			this.HandleCustomCode(conn, ref msg);
			this.AttachNpcName(conn, ref msg);

			Send.ZC_DIALOG_STRINGINPUT(conn, msg);

			return lua_yield(L, 1);
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
			var argc = lua_gettop(L);
			if (argc == 0)
			{
				Log.Warning("numinput: No arguments.");
				lua_pushinteger(L, 0);
				return 1;
			}

			var conn = this.GetConnectionFromState(L);

			int min = 0, max = 255;

			// Get arguments
			var msg = luaL_checkstring(L, 1);
			if (argc >= 3)
			{
				min = luaL_checkinteger(L, 2);
				max = luaL_checkinteger(L, 3);
			}

			lua_settop(L, 0);

			this.HandleCustomCode(conn, ref msg);
			this.AttachNpcName(conn, ref msg);

			Send.ZC_DIALOG_NUMBERRANGE(conn, msg, min, max);

			return lua_yield(L, 1);
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
		///     string  name,         -- Character's name
		///     string  teamname,     -- Character's team name
		///     integer gender,       -- Character's gender
		///     integer level,        -- Character's level
		///     integer classlevel,   -- Character's class level
		///     integer hp,           -- Character's HP
		///     integer maxhp,        -- Character's max HP
		///     integer sp,           -- Character's SP
		///     integer maxsp,        -- Character's max SP
		///     integer stamina,      -- Character's stamina
		///     integer maxstamina,   -- Character's max stamina
		///     integer hair,         -- Character's hair
		///     integer job,          -- Character's current main job
		///     integer jobclass,     -- Character's job's class (Swordsman, Archer, etc.)
		///     integer rank,         -- Character's current job rank
		///     table jobs
		///     {
		///         integer jobId:
		///         {
		///             integer circle;       -- Job's circle
		///             integer skillpoints;  -- Skill points
		///         }
		///     }
		///     table account
		///     {
		///         string  name,     -- Account's name
		///         integer auth,     -- Account's authority level
		///     }
		/// }
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int getpc(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			// Character data
			// --------------------------------------------------------------
			lua_newtable(L);

			lua_pushstring(L, "name");
			lua_pushstring(L, character.Name);
			lua_settable(L, -3);

			lua_pushstring(L, "teamname");
			lua_pushstring(L, character.TeamName);
			lua_settable(L, -3);

			lua_pushstring(L, "gender");
			lua_pushinteger(L, (int)character.Gender);
			lua_settable(L, -3);

			lua_pushstring(L, "level");
			lua_pushinteger(L, character.Level);
			lua_settable(L, -3);

			lua_pushstring(L, "classlevel");
			lua_pushinteger(L, character.ClassLevel);
			lua_settable(L, -3);

			lua_pushstring(L, "hp");
			lua_pushinteger(L, character.Hp);
			lua_settable(L, -3);

			lua_pushstring(L, "maxhp");
			lua_pushinteger(L, character.MaxHp);
			lua_settable(L, -3);

			lua_pushstring(L, "sp");
			lua_pushinteger(L, character.Sp);
			lua_settable(L, -3);

			lua_pushstring(L, "maxsp");
			lua_pushinteger(L, character.MaxSp);
			lua_settable(L, -3);

			lua_pushstring(L, "stamina");
			lua_pushinteger(L, character.Stamina);
			lua_settable(L, -3);

			lua_pushstring(L, "maxstamina");
			lua_pushinteger(L, character.MaxStamina);
			lua_settable(L, -3);

			lua_pushstring(L, "hair");
			lua_pushinteger(L, character.Hair);
			lua_settable(L, -3);

			lua_pushstring(L, "job");
			lua_pushinteger(L, (int)character.JobId);
			lua_settable(L, -3);

			lua_pushstring(L, "jobclass");
			lua_pushinteger(L, (int)character.JobClass);
			lua_settable(L, -3);

			lua_pushstring(L, "rank");
			lua_pushinteger(L, (int)character.Jobs.GetCurrentRank());
			lua_settable(L, -3);

			lua_pushstring(L, "jobs");
			lua_newtable(L);
			foreach (var job in character.Jobs.GetList())
			{
				lua_pushinteger(L, (int)job.Id);
				lua_newtable(L);
				{
					lua_pushstring(L, "circle");
					lua_pushinteger(L, (int)job.Circle);
					lua_settable(L, -3);

					lua_pushstring(L, "skillpoints");
					lua_pushinteger(L, job.SkillPoints);
					lua_settable(L, -3);
				}
				lua_settable(L, -3);
			}
			lua_settable(L, -3);

			// Account data
			// --------------------------------------------------------------
			lua_newtable(L);

			lua_pushstring(L, "name");
			lua_pushstring(L, conn.Account.Name);
			lua_settable(L, -3);

			lua_pushstring(L, "auth");
			lua_pushinteger(L, conn.Account.Authority);
			lua_settable(L, -3);

			// Put account table into character table
			lua_pushstring(L, "account");
			lua_insert(L, -2);
			lua_settable(L, -3);

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

			lua_newtable(L);

			lua_pushstring(L, "name");
			lua_pushstring(L, character.Name);
			lua_settable(L, -3);

			lua_pushstring(L, "dialogName");
			lua_pushstring(L, character.DialogName);
			lua_settable(L, -3);

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

			lua_newtable(L);

			lua_pushstring(L, "year");
			lua_pushinteger(L, now.Year);
			lua_settable(L, -3);

			lua_pushstring(L, "month");
			lua_pushinteger(L, now.Month);
			lua_settable(L, -3);

			lua_pushstring(L, "day");
			lua_pushinteger(L, now.Day);
			lua_settable(L, -3);

			lua_pushstring(L, "weekday");
			lua_pushinteger(L, (int)now.DayOfWeek);
			lua_settable(L, -3);

			lua_pushstring(L, "yearday");
			lua_pushinteger(L, now.DayOfYear);
			lua_settable(L, -3);

			lua_pushstring(L, "hour");
			lua_pushinteger(L, now.Hour);
			lua_settable(L, -3);

			lua_pushstring(L, "min");
			lua_pushinteger(L, now.Minute);
			lua_settable(L, -3);

			lua_pushstring(L, "sec");
			lua_pushinteger(L, now.Second);
			lua_settable(L, -3);

			lua_pushstring(L, "msec");
			lua_pushinteger(L, now.Millisecond);
			lua_settable(L, -3);

			lua_pushstring(L, "isdst");
			lua_pushboolean(L, now.IsDaylightSavingTime());
			lua_settable(L, -3);

			lua_pushstring(L, "unixts");
			lua_pushinteger(L, (int)(now.ToUniversalTime().Subtract(UnixEpoch)).TotalSeconds);
			lua_settable(L, -3);

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

			var mapName = luaL_checkstring(L, 1);
			var x = (float)luaL_checknumber(L, 2);
			var y = (float)luaL_checknumber(L, 3);
			var z = (float)luaL_checknumber(L, 4);

			lua_settop(L, 0);

			try
			{
				conn.SelectedCharacter.Warp(mapName, x, y, z);
			}
			catch (ArgumentException ex)
			{
				lua_pushstring(L, ex.Message);
				lua_error(L);
			}

			return 0;
		}

		/// <summary>
		/// Resets the player's stat points.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		private int resetstats(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			character.StatByLevel += character.StrByJob - 1;
			character.StatByLevel += character.ConByJob - 1;
			character.StatByLevel += character.IntByJob - 1;
			character.StatByLevel += character.SprByJob - 1;
			character.StatByLevel += character.DexByJob - 1;
			character.UsedStat = 0;

			character.StrInvested = 0;
			character.ConInvested = 0;
			character.IntInvested = 0;
			character.SprInvested = 0;
			character.DexInvested = 0;

			character.StrByJob = 1;
			character.ConByJob = 1;
			character.IntByJob = 1;
			character.SprByJob = 1;
			character.DexByJob = 1;

			Send.ZC_OBJECT_PROPERTY(character,
					PropertyId.PC.STR, PropertyId.PC.STR_STAT, PropertyId.PC.STR_JOB, PropertyId.PC.CON, PropertyId.PC.CON_STAT, PropertyId.PC.CON_JOB,
					PropertyId.PC.INT, PropertyId.PC.INT_STAT, PropertyId.PC.INT_JOB, PropertyId.PC.MNA, PropertyId.PC.MNA_STAT, PropertyId.PC.MNA_JOB,
					PropertyId.PC.DEX, PropertyId.PC.DEX_STAT, PropertyId.PC.DEX_JOB, PropertyId.PC.UsedStat, PropertyId.PC.MINPATK,
					PropertyId.PC.MAXPATK, PropertyId.PC.MINMATK, PropertyId.PC.MAXMATK, PropertyId.PC.MINPATK_SUB, PropertyId.PC.MAXPATK_SUB,
					PropertyId.PC.CRTATK, PropertyId.PC.HR, PropertyId.PC.DR, PropertyId.PC.BLK_BREAK, PropertyId.PC.BLK, PropertyId.PC.RHP,
					PropertyId.PC.RSP, PropertyId.PC.MHP, PropertyId.PC.MSP
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

			var hairId = luaL_checkinteger(L, 1);

			lua_settop(L, 0);

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
			var monsterId = luaL_checkinteger(L, 1);
			var mapName = luaL_checkstring(L, 2);
			var x = (float)luaL_checknumber(L, 3);
			var y = (float)luaL_checknumber(L, 4);
			var z = (float)luaL_checknumber(L, 5);

			lua_settop(L, 0);

			var map = ChannelServer.Instance.World.GetMap(mapName);
			if (map == null)
				return melua_error(L, "Map '{0}' not found.", mapName);

			var monster = new Monster(monsterId, NpcType.Monster);
			monster.Position = new Position(x, y, z);

			map.AddMonster(monster);

			return 0;
		}

		/// <summary>
		/// Instructs client to open the shop with the given name
		/// and stops script until shop is closed.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string shopName
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int openshop(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);

			var shopName = luaL_checkstring(L, 1);
			if (shopName.Length > 32)
				shopName = shopName.Substring(0, 32);

			lua_settop(L, 0);

			if (!ChannelServer.Instance.Data.ShopDb.Exists(shopName))
				return melua_error(L, "Shop '{0}' not found.", shopName);

			conn.ScriptState.CurrentShop = shopName;
			Send.ZC_DIALOG_TRADE(conn, shopName);

			return lua_yield(L, 0);
		}

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

			var itemId = luaL_checkinteger(L, 1);
			lua_settop(L, 0);

			var result = character.Inventory.HasItem(itemId);
			lua_pushboolean(L, result);

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

			var itemId = luaL_checkinteger(L, 1);
			lua_settop(L, 0);

			var result = character.Inventory.CountItem(itemId);
			lua_pushinteger(L, result);

			return 1;
		}

		/// <summary>
		/// Adds the specified amount of items to the character's inventory.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int itemId
		/// - int amount
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int additem(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			var itemId = luaL_checkinteger(L, 1);
			var amount = luaL_checkinteger(L, 2);
			lua_settop(L, 0);

			var itemData = ChannelServer.Instance.Data.ItemDb.Find(itemId);
			if (itemData == null)
				return melua_error(L, "Unknown item id.");

			try
			{
				character.Inventory.Add(itemId, amount, InventoryAddType.PickUp);
			}
			catch (Exception ex)
			{
				Log.Exception(ex);
				return melua_error(L, "Failed to add item to inventory.");
			}

			return 0;
		}

		/// <summary>
		/// Removes the specified amount of items with the given id from
		/// character's inventory.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int itemId
		/// - int amount
		/// 
		/// Result:
		/// - int removedCount
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int removeitem(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			var itemId = luaL_checkinteger(L, 1);
			var amount = luaL_checkinteger(L, 2);
			lua_settop(L, 0);

			var itemData = ChannelServer.Instance.Data.ItemDb.Find(itemId);
			if (itemData == null)
				return melua_error(L, "Unknown item id.");

			amount = Math.Max(0, amount);

			var removed = character.Inventory.Remove(itemId, amount, InventoryItemRemoveMsg.Given);
			lua_pushinteger(L, removed);

			return 1;
		}

		/// <summary>
		/// Increases character Level by the given amount
		/// </summary>		
		/// <remarks>
		/// Parameters:
		/// - int amount
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int levelup(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			var amount = luaL_checkinteger(L, 1);

			if (amount < 0)
				return melua_error(L, "Amount must be greater than 0.");

			character.LevelUp(amount);

			return 0;
		}

		/// <summary>
		/// Gets or sets a scripting variable.
		/// </summary>
		/// <remarks>
		/// Scripting variables are separate from Lua variables and exist
		/// across script and playing sessions. How the variable is saved
		/// depends on the used prefix.
		/// 
		/// Variable names may contain the following characters, apart from
		/// the prefixes, and must start with a character:
		/// abcdefghijklmnopqrstuvwxyz0123456789_
		/// 
		/// Prefixes:
		/// ""   - Permanent variable attached to the character.
		/// "@"  - Temporary variable attached to the character.
		/// "#"  - Permanent variable attached to the account.
		/// "$"  - Permanent global variable.
		/// "$@" - Temporary global variable.
		/// 
		/// Parameters:
		/// - string variableName
		/// - (optional) T value
		/// 
		/// Result:
		/// - T value
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int var(IntPtr L)
		{
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			// Get parameters
			var argc = lua_gettop(L);
			var name = luaL_checkstring(L, 1).Trim();

			object value = null;
			if (argc == 2)
			{
				if (lua_isnumber(L, 2))
					value = lua_tonumber(L, 2);
				else if (lua_isstring(L, 2))
					value = lua_tostring(L, 2);
				else if (lua_isboolean(L, 2))
					value = lua_toboolean(L, 2);
				else
					return melua_error(L, "Unsupported variable type.");
			}

			lua_settop(L, 0);

			// Get variable manager and trim name
			VariableManager vars;

			if (name.StartsWith("$@"))
			{
				vars = this.Variables.Temp;
				name = name.Substring(2);
			}
			else if (name.StartsWith("$"))
			{
				vars = this.Variables.Perm;
				name = name.Substring(1);
			}
			else if (name.StartsWith("#"))
			{
				vars = conn.Account.Variables.Perm;
				name = name.Substring(1);
			}
			else if (name.StartsWith("@"))
			{
				vars = character.Variables.Temp;
				name = name.Substring(1);
			}
			else
			{
				vars = character.Variables.Perm;
			}

			// Check name syntax, if we want to add more prefixes later on,
			// we can't have special characters in names.
			if (!VarNameCheck.IsMatch(name))
				return melua_error(L, "Invalid variable name.");

			// Update or get value
			if (value == null)
				value = vars[name];
			else
				vars[name] = value;

			// Push return value
			switch (value)
			{
				case null: lua_pushnil(L); break;
				case string v: lua_pushstring(L, v); ; break;
				case double v: lua_pushnumber(L, v); ; break;
				case float v: lua_pushnumber(L, v); ; break;
				case int v: lua_pushinteger(L, v); ; break;
				case bool v: lua_pushboolean(L, v); ; break;

				default:
					return melua_error(L, "Unsupported variable type '{0}'.", value.GetType().Name);
			}

			return 1;
		}

		/// <summary>
		/// Returns whether the character has a given job and circle.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int jobId
		/// - (optional) int circle
		/// 
		/// Result:
		/// - bool
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int isjob(IntPtr L)
		{
			// Get parameters
			var argc = lua_gettop(L);

			var jobId = (JobId)luaL_checkint(L, 1);
			var circle = Circle.First;

			if (argc > 1)
				circle = (Circle)luaL_checkint(L, 2);

			lua_settop(L, 0);

			// Return
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			lua_pushboolean(L, character.Jobs.Has(jobId, circle));

			return 1;
		}

		/// <summary>
		/// Returns whether the character has the given job class.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int jobClass
		/// 
		/// Result:
		/// - bool
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int isjobclass(IntPtr L)
		{
			var jobClass = (JobClass)luaL_checkint(L, 1);

			lua_settop(L, 0);

			// Return
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			lua_pushboolean(L, character.JobClass == jobClass);

			return 1;
		}

		/// <summary>
		/// Adds job to character or changes its circle.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int jobId
		/// - (optional) int circle
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int addjob(IntPtr L)
		{
			// Get parameters
			var argc = lua_gettop(L);

			var jobId = (JobId)luaL_checkint(L, 1);
			var circle = Circle.First;

			if (argc > 1)
				circle = (Circle)luaL_checkint(L, 2);

			lua_settop(L, 0);

			// Add job
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			var job = new Job(character, jobId, circle);
			character.Jobs.Add(job);

			return 0;
		}

		/// <summary>
		/// Removes job from character.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - int jobId
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int removejob(IntPtr L)
		{
			var jobId = (JobId)luaL_checkint(L, 1);

			lua_settop(L, 0);

			// Remove job
			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			character.Jobs.Remove(jobId);

			return 0;
		}

		/// <summary>
		/// Executes SQL query on server's database.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string SQL query
		/// 
		/// Result:
		/// - table Results
		/// - int Number of affected rows
		/// - string Last inserted id
		/// 
		/// Example:
		/// local results, affected, lastid = sqlquery("SELECT * FROM `updates`")
		/// print("affected: " .. tostring(affected))
		/// print("lastid: " .. tostring(lastid))
		/// print("results: ")
		/// for i,v in ipairs(results) do
		/// 	print("  " .. v["path"])
		/// end
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int sqlquery(IntPtr L)
		{
			var sqlQuery = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			List<Dictionary<string, object>> result;
			int affectedRows;
			long lastInsertId;

			try
			{
				result = ChannelServer.Instance.Database.GetQueryResult(sqlQuery, out affectedRows, out lastInsertId);
			}
			catch (Exception ex)
			{
				return melua_error(L, "Failed to execute SQL query: {0}", ex.Message);
			}

			lua_newtable(L);

			var key = 1;
			foreach (var row in result)
			{
				// Prepare table for new row's values
				lua_pushinteger(L, key++);
				lua_newtable(L);

				foreach (var field in row)
				{
					// Push key and value to row's table
					lua_pushstring(L, field.Key);
					switch (field.Value)
					{
						case sbyte value: lua_pushinteger(L, value); break;
						case byte value: lua_pushinteger(L, value); break;
						case short value: lua_pushinteger(L, value); break;
						case ushort value: lua_pushinteger(L, value); break;
						case int value: lua_pushinteger(L, value); break;
						case uint value: lua_pushinteger(L, (int)value); break;
						case float value: lua_pushnumber(L, value); break;
						case double value: lua_pushnumber(L, value); break;
						default: lua_pushstring(L, field.Value.ToString()); break;
					}
					lua_settable(L, -3);
				}

				// Push row table to result table
				lua_settable(L, -3);
			}

			lua_pushinteger(L, affectedRows);
			lua_pushstring(L, lastInsertId.ToString());

			return 3;
		}

		/// <summary>
		/// Escapes string for safe use in an SQL query.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string String to escape
		/// 
		/// Result:
		/// - string Escaped string
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int sqlescape(IntPtr L)
		{
			var str = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			var result = MySqlHelper.EscapeString(str);
			melua_pushstring(L, result);

			return 1;
		}

		/// <summary>
		/// Sends an addon message to player's client.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string Message to send to client
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int addonmsg(IntPtr L)
		{
			var msg = luaL_checkstring(L, 1);
			var param = luaL_checkstring(L, 2);
			lua_settop(L, 0);

			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			Send.ZC_ADDON_MSG(character, msg, param);

			return 0;
		}

		/// <summary>
		/// Sends a server message to the client, displayed in the chat log.
		/// </summary>
		/// <remarks>
		/// Parameters:
		/// - string Message to send to client
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		private int servermsg(IntPtr L)
		{
			var msg = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			var conn = this.GetConnectionFromState(L);
			var character = conn.SelectedCharacter;

			character.ServerMessage(msg);

			return 0;
		}
	}
}
