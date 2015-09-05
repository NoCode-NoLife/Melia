// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeluaLib
{
	public static class Melua
	{
		private const string Lib = "lua51";

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

		[UnmanagedFunctionPointer(CallingConvention.Cdecl‌)]
		public delegate int LuaNativeFunction(IntPtr L);

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

		// LUA_API void lua_pushboolean (lua_State *L, int b)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_pushboolean(IntPtr L, bool b);

		// static void lua_settable(lua_State*L,int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void lua_settable(IntPtr L, int idx);

		// static lua_Number luaL_checknumber(lua_State*L,int narg)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern double luaL_checknumber(IntPtr L, int narg);

		// static int lua_type(lua_State*L,int idx)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_type(IntPtr L, int idx);

		// static const char* luaL_checklstring(lua_State*L,int numArg,size_t*l)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr luaL_checklstring(IntPtr L, int numArg, IntPtr l);

		// static int lua_gettop(lua_State*L)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int lua_gettop(IntPtr L);

		// static lua_Integer luaL_checkinteger(lua_State*L,int numArg)
		[DllImport(Lib, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int luaL_checkinteger(IntPtr L, int numArg);

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




		// #define luaL_dostring(L, s) (luaL_loadstring(L, s) || lua_pcall(L, 0, LUA_MULTRET, 0))
		public static int luaL_dostring(IntPtr L, string s)
		{
			return (luaL_loadstring(L, s) != 0 || lua_pcall(L, 0, LUA_MULTRET, 0) != 0) ? 1 : 0;
		}

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

		// #define luaL_checkstring(L,n)(luaL_checklstring(L,(n),NULL))
		public static string luaL_checkstring(IntPtr L, int n)
		{
			var ptr = luaL_checklstring(L, n, IntPtr.Zero);

			// Output 200 bytes of memory, briefly used to debug a problem where
			// Lua apparently wrote other information into the string's memory...
			// bug went away after getting rid of LUAI_EXTRASPACE.
			//unsafe
			//{
			//	var p = (byte*)ptr.ToPointer();
			//	var buf = new byte[200];
			//	for (int i = 0; i < buf.Length; ++i)
			//	{
			//		buf[i] = *(p + i);
			//	}
			//	Console.WriteLine(BitConverter.ToString(buf));
			//}

			var val = Marshal.PtrToStringAnsi(ptr);
			return val;
		}

		// #define lua_newtable(L)		lua_createtable(L, 0, 0)
		public static void lua_newtable(IntPtr L)
		{
			lua_createtable(L, 0, 0);
		}




		// LUALIB_API int (luaL_loadstring) (lua_State *L, const char *s)
		public static int luaL_loadstring(IntPtr L, string s)
		{
			return luaL_loadbuffer(L, s, s.Length, s);
		}



		/// <summary>
		/// Custom function, calls the specified standard lib open functions.
		/// </summary>
		/// <param name="L"></param>
		/// <param name="libsToLoad"></param>
		public static void openlib(IntPtr L, params LuaLib[] libsToLoad)
		{
			foreach (var lib in libsToLoad)
			{
				string name;
				LuaNativeFunction func;

				switch (lib)
				{
					case LuaLib.Base:
						name = "";
						func = luaopen_base;
						break;
					case LuaLib.Package:
						name = "package";
						func = luaopen_package;
						break;
					case LuaLib.Table:
						name = "table";
						func = luaopen_table;
						break;
					case LuaLib.IO:
						name = "io";
						func = luaopen_io;
						break;
					case LuaLib.OS:
						name = "os";
						func = luaopen_os;
						break;
					case LuaLib.String:
						name = "string";
						func = luaopen_string;
						break;
					case LuaLib.Math:
						name = "math";
						func = luaopen_math;
						break;
					case LuaLib.Debug:
						name = "debug";
						func = luaopen_debug;
						break;

					default:
						throw new Exception("Unknown lua lib '" + lib + "'.");
				}

				lua_pushcfunction(L, func);
				lua_pushstring(L, name);
				lua_call(L, 1, 0);
			}
		}

		/// <summary>
		/// Custom function, calls all standard lib open functions.
		/// </summary>
		/// <param name="L"></param>
		public static void openlibs(IntPtr L)
		{
			openlib(L, LuaLib.Base, LuaLib.Package, LuaLib.Table, LuaLib.IO, LuaLib.OS, LuaLib.String, LuaLib.Math, LuaLib.Debug);
		}
	}
}
