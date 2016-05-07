// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Runtime.InteropServices;

namespace MeluaLib
{
	// Basic Lua API
	public static partial class Melua
	{
		public const int LUA_MULTRET = -1;
		public const int LUA_REGISTRYINDEX = -10000;
		public const int LUA_ENVIRONINDEX = -10001;
		public const int LUA_GLOBALSINDEX = -10002;

		public const int LUA_YIELD = 1;

		public const int LUA_TNONE = -1;
		public const int LUA_TNIL = 0;
		public const int LUA_TBOOLEAN = 1;
		public const int LUA_TLIGHTUSERDATA = 2;
		public const int LUA_TNUMBER = 3;
		public const int LUA_TSTRING = 4;
		public const int LUA_TTABLE = 5;
		public const int LUA_TFUNCTION = 6;
		public const int LUA_TUSERDATA = 7;
		public const int LUA_TTHREAD = 8;

		public const int LUA_HOOKCALL = 0;
		public const int LUA_HOOKRET = 1;
		public const int LUA_HOOKLINE = 2;
		public const int LUA_HOOKCOUNT = 3;
		public const int LUA_HOOKTAILRET = 4;

		public const int LUA_MASKCALL = (1 << LUA_HOOKCALL);
		public const int LUA_MASKRET = (1 << LUA_HOOKRET);
		public const int LUA_MASKLINE = (1 << LUA_HOOKLINE);
		public const int LUA_MASKCOUNT = (1 << LUA_HOOKCOUNT);

		// LUA_API void lua_call (lua_State *L, int nargs, int nresults)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_call(IntPtr L, int nargs, int nresults);

		// static int lua_pcall(lua_State*L,int nargs,int nresults,int errfunc)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_pcall(IntPtr L, int nargs, int nresults, int errfunc);

		// static void lua_pushcclosure(lua_State*L,lua_CFunction fn,int n)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_pushcclosure(IntPtr L, LuaNativeFunction fn, int n);

		// static void lua_setfield(lua_State*L,int idx,const char*k);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_setfield(IntPtr L, int idx, [MarshalAs(UnmanagedType.LPStr)] string k);

		// static void lua_getfield(lua_State*L,int idx,const char*k)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_getfield(IntPtr L, int idx, [MarshalAs(UnmanagedType.LPStr)] string k);

		// static const char*lua_tolstring(lua_State*L,int idx,size_t*len)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr lua_tolstring(IntPtr L, int idx, IntPtr len);

		// int lua_toboolean (lua_State *L, int index);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern bool lua_toboolean(IntPtr L, int index);

		// lua_Integer lua_tointeger (lua_State *L, int index);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_tointeger(IntPtr L, int index);

		// lua_Number lua_tonumber (lua_State *L, int index);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern double lua_tonumber(IntPtr L, int index);

		// static void lua_settop(lua_State*L,int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_settop(IntPtr L, int idx);

		// LUA_API lua_State *lua_newthread (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr lua_newthread(IntPtr L);

		// static void lua_pushstring(lua_State*L,const char*s)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_pushstring(IntPtr L, [MarshalAs(UnmanagedType.LPStr)] string s);

		// static void lua_pushinteger(lua_State*L,lua_Integer n)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_pushinteger(IntPtr L, int n);

		// static void lua_pushnumber(lua_State*L,lua_Number n)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_pushnumber(IntPtr L, double n);

		// void lua_pushnil (lua_State *L);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_pushnil(IntPtr L);

		// LUA_API void lua_pushboolean (lua_State *L, int b)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_pushboolean(IntPtr L, bool b);

		// static void lua_settable(lua_State*L,int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_settable(IntPtr L, int idx);

		// static int lua_type(lua_State*L,int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_type(IntPtr L, int idx);

		// static int lua_gettop(lua_State*L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_gettop(IntPtr L);

		// LUA_API int  (lua_yield) (lua_State *L, int nresults);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_yield(IntPtr L, int nresults);

		// LUA_API int  (lua_resume) (lua_State *L, int narg);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_resume(IntPtr L, int narg);

		// LUA_API int  (lua_status) (lua_State *L);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_status(IntPtr L);

		// LUA_API void lua_pushvalue (lua_State *L, int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_pushvalue(IntPtr L, int idx);

		// LUA_API void lua_insert (lua_State *L, int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_insert(IntPtr L, int idx);

		// LUA_API void lua_createtable (lua_State *L, int narray, int nrec)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_createtable(IntPtr L, int narray, int nrec);

		// int lua_error (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_error(IntPtr L);

		// LUALIB_API int luaopen_base (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaopen_base(IntPtr L);

		// LUALIB_API int luaopen_package (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaopen_package(IntPtr L);

		// LUALIB_API int luaopen_table (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaopen_table(IntPtr L);

		// LUALIB_API int luaopen_io (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaopen_io(IntPtr L);

		// LUALIB_API int luaopen_os (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaopen_os(IntPtr L);

		// LUALIB_API int luaopen_string (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaopen_string(IntPtr L);

		// LUALIB_API int luaopen_math (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaopen_math(IntPtr L);

		// LUALIB_API int luaopen_debug (lua_State *L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaopen_debug(IntPtr L);

		// LUA_API int lua_sethook (lua_State *L, lua_Hook func, int mask, int count)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_sethook(IntPtr L, lua_Hook func, int mask, int count);

		// LUA_API void lua_concat (lua_State *L, int n)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_concat(IntPtr L, int n);

		// lua_CFunction lua_atpanic (lua_State *L, lua_CFunction panicf);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_atpanic(IntPtr L, LuaNativeFunction panicf);

		// void lua_remove (lua_State *L, int index);
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_remove(IntPtr L, int index);

		// LUA_API void lua_pushlstring (lua_State *L, const char *s, size_t len)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_pushlstring(IntPtr L, [MarshalAs(UnmanagedType.LPStr)] string s, int len);

		// LUA_API const char *lua_typename (lua_State *L, int t)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr lua_typename(IntPtr L, int t);

		// LUA_API int lua_checkstack (lua_State *L, int size)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern bool lua_checkstack(IntPtr L, int size);

		// LUA_API void lua_rawget (lua_State *L, int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_rawget(IntPtr L, int idx);

		// LUA_API void lua_rawgeti (lua_State *L, int idx, int n)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_rawgeti(IntPtr L, int idx, int n);

		// LUA_API size_t lua_objlen (lua_State *L, int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_objlen(IntPtr L, int idx);

		// LUA_API int lua_setmetatable (lua_State *L, int objindex)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_setmetatable(IntPtr L, int objindex);

		// LUA_API int lua_next (lua_State *L, int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_next(IntPtr L, int idx);

		// LUA_API void lua_replace (lua_State *L, int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_replace(IntPtr L, int idx);

		// LUA_API const void *lua_topointer (lua_State *L, int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr lua_topointer(IntPtr L, int idx);

		// #define lua_register(L,n,f) (lua_pushcfunction(L, (f)), lua_setglobal(L, (n)))
		public static void lua_register(IntPtr L, string n, LuaNativeFunction f)
		{
			lua_pushcfunction(L, f);
			lua_setglobal(L, n);
		}

		// #define lua_pushcfunction(L,f)	lua_pushcclosure(L, (f), 0)
		public static void lua_pushcfunction(IntPtr L, LuaNativeFunction f)
		{
			lua_pushcclosure(L, f, 0);
		}

		// #define lua_getglobal(L,s)	lua_getfield(L, LUA_GLOBALSINDEX, (s))
		public static void lua_getglobal(IntPtr L, string s)
		{
			lua_getfield(L, LUA_GLOBALSINDEX, s);
		}

		// #define lua_setglobal(L,s)lua_setfield(L,(-10002),(s))
		public static void lua_setglobal(IntPtr L, string s)
		{
			lua_setfield(L, -10002, s);
		}

		// #define lua_tostring(L,i)lua_tolstring(L,(i),NULL)
		public static string lua_tostring(IntPtr L, int i)
		{
			var ptr = lua_tolstring(L, i, IntPtr.Zero);
			var val = Marshal.PtrToStringAnsi(ptr);
			return val;
		}

		// #define lua_pop(L,n)lua_settop(L,-(n)-1)
		public static void lua_pop(IntPtr L, int n)
		{
			lua_settop(L, -n - 1);
		}

		// #define lua_isnil(L,n)(lua_type(L,(n))==0)
		public static bool lua_isnil(IntPtr L, int n)
		{
			return (lua_type(L, n) == LUA_TNIL);
		}

		// int lua_isstring (lua_State *L, int index);
		public static bool lua_isstring(IntPtr L, int index)
		{
			var type = lua_type(L, index);
			return (type == LUA_TSTRING || type == LUA_TNUMBER);
		}

		// int lua_isnumber (lua_State *L, int index);
		public static bool lua_isnumber(IntPtr L, int index)
		{
			var type = lua_type(L, index);

			switch (type)
			{
				default: return false;
				case LUA_TNUMBER: return true;
				case LUA_TSTRING:
					var s = lua_tostring(L, index);
					double d;
					return double.TryParse(s, out d);
			}
		}

		// #define lua_isboolean(L,n)	(lua_type(L, (n)) == LUA_TBOOLEAN)
		public static bool lua_isboolean(IntPtr L, int n)
		{
			return (lua_type(L, n) == LUA_TBOOLEAN);
		}

		// #define lua_istable(L,n)	(lua_type(L, (n)) == LUA_TTABLE)
		public static bool lua_istable(IntPtr L, int n)
		{
			return (lua_type(L, n) == LUA_TTABLE);
		}

		// #define lua_isfunction(L,n)	(lua_type(L, (n)) == LUA_TFUNCTION)
		public static bool lua_isfunction(IntPtr L, int n)
		{
			return (lua_type(L, n) == LUA_TFUNCTION);
		}

		// #define lua_newtable(L)		lua_createtable(L, 0, 0)
		public static void lua_newtable(IntPtr L)
		{
			lua_createtable(L, 0, 0);
		}

		// #define lua_isnoneornil(L, n)	(lua_type(L, (n)) <= 0)
		public static bool lua_isnoneornil(IntPtr L, int n)
		{
			return (lua_type(L, n) <= 0);
		}

		// #define lua_pushliteral(L, s)  lua_pushlstring(L, "" s, (sizeof(s)/sizeof(char))-1)
		public static void lua_pushliteral(IntPtr L, string s)
		{
			lua_pushlstring(L, s, s.Length);
		}

		// #define lua_upvalueindex(i)	(LUA_GLOBALSINDEX-(i))
		public static int lua_upvalueindex(int i)
		{
			return (LUA_GLOBALSINDEX - i);
		}
	}
}
