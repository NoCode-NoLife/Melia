// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Runtime.InteropServices;

namespace MeluaLib
{
	// Auxiliary Lua API
	public static partial class Melua
	{
		// LUALIB_API lua_State *luaL_newstate(void)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr luaL_newstate();

		// static void luaL_openlibs(lua_State*L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void luaL_openlibs(IntPtr L);

		// static int luaL_loadbuffer(lua_State*L,const char*buff,size_t size,const char*name)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaL_loadbuffer(IntPtr L, [MarshalAs(UnmanagedType.LPStr)] string buff, int size, [MarshalAs(UnmanagedType.LPStr)] string name);

		// static int luaL_loadfile(lua_State*L,const char*filename)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaL_loadfile(IntPtr L, [MarshalAs(UnmanagedType.LPStr)] string filename);

		// static lua_Number luaL_checknumber(lua_State*L,int narg)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern double luaL_checknumber(IntPtr L, int narg);

		// static const char* luaL_checklstring(lua_State*L,int numArg,size_t*l)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr luaL_checklstring(IntPtr L, int numArg, IntPtr l);

		// static lua_Integer luaL_checkinteger(lua_State*L,int numArg)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaL_checkinteger(IntPtr L, int numArg);

		// LUALIB_API void luaL_where (lua_State *L, int level)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void luaL_where(IntPtr L, int level);

		// LUALIB_API void luaL_checkany (lua_State *L, int narg)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void luaL_checkany(IntPtr L, int narg);

		// LUALIB_API int luaL_callmeta (lua_State *L, int obj, const char *event)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern bool luaL_callmeta(IntPtr L, int obj, [MarshalAs(UnmanagedType.LPStr)] string ev);

		// void luaL_argcheck (lua_State *L, int cond, int narg, const char *extramsg);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void luaL_argcheck(IntPtr L, bool cond, int narg, [MarshalAs(UnmanagedType.LPStr)] string extramsg);

		// #define luaL_dostring(L, s) (luaL_loadstring(L, s) || lua_pcall(L, 0, LUA_MULTRET, 0))
		public static int luaL_dostring(IntPtr L, string s)
		{
			return (luaL_loadstring(L, s) != 0 || lua_pcall(L, 0, LUA_MULTRET, 0) != 0) ? 1 : 0;
		}

		// #define luaL_dofile(L, fn) (luaL_loadfile(L, fn) || lua_pcall(L, 0, LUA_MULTRET, 0))
		public static int luaL_dofile(IntPtr L, string fn)
		{
			return (luaL_loadfile(L, fn) != 0 || lua_pcall(L, 0, LUA_MULTRET, 0) != 0) ? 1 : 0;
		}

		// #define luaL_checkstring(L,n)(luaL_checklstring(L,(n),NULL))
		public static string luaL_checkstring(IntPtr L, int n)
		{
			var ptr = luaL_checklstring(L, n, IntPtr.Zero);
			var val = Marshal.PtrToStringAnsi(ptr);
			return val;
		}

		// #define luaL_opt(L,f,n,d)	(lua_isnoneornil(L,(n)) ? (d) : f(L,(n)))
		public static int luaL_opt(IntPtr L, LuaNativeNFunction f, int n, int d)
		{
			return (lua_isnoneornil(L, n) ? d : f(L, n));
		}

		// #define luaL_typename(L,i)	lua_typename(L, lua_type(L,(i)))
		public static string luaL_typename(IntPtr L, int i)
		{
			var ptr = lua_typename(L, lua_type(L, i));
			var val = Marshal.PtrToStringAnsi(ptr);
			return val;
		}

		// LUALIB_API lua_Integer (luaL_optinteger) (lua_State *L, int nArg, lua_Integer def);
		public static int luaL_optinteger(IntPtr L, int narg, int def)
		{
			return luaL_opt(L, luaL_checkinteger, narg, def);
		}

		// LUALIB_API int (luaL_loadstring) (lua_State *L, const char *s)
		public static int luaL_loadstring(IntPtr L, string s)
		{
			return luaL_loadbuffer(L, s, s.Length, s);
		}

		// LUALIB_API void luaL_checktype (lua_State *L, int narg, int t)
		public static void luaL_checktype(IntPtr L, int narg, int t)
		{
			if (lua_type(L, narg) != t)
				melua_error(L, string.Format("{0} expected, got {1}"), lua_typename(L, t), luaL_typename(L, narg));
		}

		// LUALIB_API int luaL_getn (lua_State *L, int t) 
		public static int luaL_getn(IntPtr L, int t)
		{
			int n;
			t = abs_index(L, t);
			lua_pushliteral(L, "n");
			lua_rawget(L, t);

			if ((n = checkint(L, 1)) >= 0)
				return n;

			getsizes(L);
			lua_pushvalue(L, t);
			lua_rawget(L, -2);

			if ((n = checkint(L, 2)) >= 0)
				return n;

			return lua_objlen(L, t);
		}

		// #define abs_index(L, i)		((i) > 0 || (i) <= LUA_REGISTRYINDEX ? (i) : lua_gettop(L) + (i) + 1)
		internal static int abs_index(IntPtr L, int i)
		{
			return (i > 0 || i <= LUA_REGISTRYINDEX ? i : lua_gettop(L) + i + 1);
		}

		//static int checkint(lua_State* L, int topop)
		internal static int checkint(IntPtr L, int topop)
		{
			int n = (lua_type(L, -1) == LUA_TNUMBER) ? lua_tointeger(L, -1) : -1;
			lua_pop(L, topop);
			return n;
		}

		// static void getsizes(lua_State* L)
		internal static void getsizes(IntPtr L)
		{
			lua_getfield(L, LUA_REGISTRYINDEX, "LUA_SIZES");
			if (lua_isnil(L, -1))
			{
				lua_pop(L, 1);
				lua_newtable(L);
				lua_pushvalue(L, -1);
				lua_setmetatable(L, -2);
				lua_pushliteral(L, "kv");
				lua_setfield(L, -2, "__mode");
				lua_pushvalue(L, -1);
				lua_setfield(L, LUA_REGISTRYINDEX, "LUA_SIZES");
			}
		}
	}
}
