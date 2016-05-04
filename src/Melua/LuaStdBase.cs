// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;

namespace MeluaLib
{
	// Partial Lua Standard Base library, used for safe subset.
	public static partial class Melua
	{
		// static void auxopen (lua_State *L, const char *name, lua_CFunction f, lua_CFunction u)
		internal static void auxopen(IntPtr L, string name, LuaNativeFunction f, LuaNativeFunction u)
		{
			lua_pushcfunction(L, u);
			lua_pushcclosure(L, f, 1);
			lua_setglobal(L, name);
		}

		// static int ipairsaux(lua_State* L)
		internal static int ipairsaux(IntPtr L)
		{
			luaL_checktype(L, 1, LUA_TTABLE);

			var i = luaL_checkinteger(L, 2);
			i++;

			lua_pushinteger(L, i);
			lua_rawgeti(L, 1, i);

			return (lua_isnil(L, -1) ? 0 : 2);
		}

		// static int luaB_next(lua_State* L)
		internal static int luaB_next(IntPtr L)
		{
			luaL_checktype(L, 1, LUA_TTABLE);
			lua_settop(L, 2);

			if (lua_next(L, 1) != 0)
				return 2;

			lua_pushnil(L);
			return 1;
		}

		// static int luaB_tostring (lua_State *L)
		internal static int luaB_tostring(IntPtr L)
		{
			luaL_checkany(L, 1);
			if (luaL_callmeta(L, 1, "__tostring"))
				return 1;

			switch (lua_type(L, 1))
			{
				case LUA_TNUMBER:
					lua_pushstring(L, lua_tostring(L, 1));
					break;

				case LUA_TSTRING:
					lua_pushvalue(L, 1);
					break;

				case LUA_TBOOLEAN:
					lua_pushstring(L, (lua_toboolean(L, 1) ? "true" : "false"));
					break;

				case LUA_TNIL:
					lua_pushliteral(L, "nil");
					break;

				default:
					lua_pushstring(L, string.Format("{0}: 0x{1:x}", luaL_typename(L, 1), lua_topointer(L, 1)));
					break;
			}

			return 1;
		}

		// static int luaB_print (lua_State *L)
		internal static int luaB_print(IntPtr L)
		{
			var n = lua_gettop(L);

			lua_getglobal(L, "tostring");
			for (int i = 1; i <= n; i++)
			{
				lua_pushvalue(L, -1);
				lua_pushvalue(L, i);
				lua_call(L, 1, 1);

				var s = lua_tostring(L, -1);
				if (s == null)
					return melua_error(L, "tostring must return a string to print");

				if (i > 1)
					Console.Write("\t");

				Console.Write(s);
				lua_pop(L, 1);
			}
			Console.Write("\n");
			return 0;
		}

		// static int luaB_tonumber (lua_State *L)
		internal static int luaB_tonumber(IntPtr L)
		{
			var nBase = luaL_optinteger(L, 2, 10);
			if (nBase != 2 && nBase != 8 && nBase != 10 && nBase != 16)
				melua_error(L, "base out of range");

			if (nBase == 10)
			{
				luaL_checkany(L, 1);
				if (lua_isnumber(L, 1))
				{
					lua_pushnumber(L, lua_tonumber(L, 1));
					return 1;
				}
			}
			else
			{
				var s1 = luaL_checkstring(L, 1).Trim();

				try
				{
					lua_pushnumber(L, Convert.ToInt32(s1, nBase));
					return 1;
				}
				catch
				{
				}
			}

			lua_pushnil(L);

			return 1;
		}

		// static int luaB_type (lua_State *L) {
		internal static int luaB_type(IntPtr L)
		{
			luaL_checkany(L, 1);
			lua_pushstring(L, luaL_typename(L, 1));
			return 1;
		}

		// static int luaB_unpack(lua_State* L)
		internal static int luaB_unpack(IntPtr L)
		{
			luaL_checktype(L, 1, LUA_TTABLE);

			var i = luaL_optinteger(L, 2, 1);
			var e = luaL_opt(L, luaL_checkinteger, 3, luaL_getn(L, 1));

			if (i > e)
				return 0;

			var n = e - i + 1;
			if (n <= 0 || !lua_checkstack(L, n))
				return melua_error(L, "too many results to unpack");

			lua_rawgeti(L, 1, i);
			while (i++ < e)
				lua_rawgeti(L, 1, i);

			return n;
		}

		// static int luaB_pairs(lua_State* L)
		internal static int luaB_pairs(IntPtr L)
		{
			luaL_checktype(L, 1, LUA_TTABLE);
			lua_pushvalue(L, lua_upvalueindex(1));
			lua_pushvalue(L, 1);
			lua_pushnil(L);

			return 3;
		}

		// static int luaB_ipairs(lua_State* L)
		internal static int luaB_ipairs(IntPtr L)
		{
			luaL_checktype(L, 1, LUA_TTABLE);
			lua_pushvalue(L, lua_upvalueindex(1));
			lua_pushvalue(L, 1);
			lua_pushinteger(L, 0);

			return 3;
		}

		// static int luaB_pcall(lua_State* L)
		internal static int luaB_pcall(IntPtr L)
		{
			luaL_checkany(L, 1);

			var status = lua_pcall(L, lua_gettop(L) - 1, LUA_MULTRET, 0);
			lua_pushboolean(L, (status == 0));
			lua_insert(L, 1);

			return lua_gettop(L);
		}

		// static int luaB_xpcall(lua_State* L)
		internal static int luaB_xpcall(IntPtr L)
		{
			luaL_checkany(L, 2);

			lua_settop(L, 2);
			lua_insert(L, 1);

			var status = lua_pcall(L, 0, LUA_MULTRET, 1);
			lua_pushboolean(L, (status == 0));
			lua_replace(L, 1);

			return lua_gettop(L);
		}
	}
}
