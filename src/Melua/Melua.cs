// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MeluaLib
{
	public static partial class Melua
	{
		private const string Lib = "lua51";

		private static Dictionary<IntPtr, List<LuaNativeFunction>> _functions = new Dictionary<IntPtr, List<LuaNativeFunction>>();

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int LuaNativeFunction(IntPtr L);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int LuaNativeNFunction(IntPtr L, int index);

		// typedef void (*lua_Hook) (lua_State *L, lua_Debug *ar);
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void lua_Hook(IntPtr L, IntPtr ar);

		/// <summary>
		/// Creates and saves reference to function, so it's not garbage
		/// collected.
		/// </summary>
		/// <param name="function"></param>
		public static LuaNativeFunction CreateFunctionReference(IntPtr L, LuaNativeFunction function)
		{
			List<LuaNativeFunction> list;
			if (!_functions.TryGetValue(L, out list) || list == null)
				list = _functions[L] = new List<LuaNativeFunction>();

			var func = new LuaNativeFunction(function);
			list.Add(func);

			return func;
		}

		/// <summary>
		/// Calls the specified standard library open functions.
		/// </summary>
		/// <param name="L"></param>
		/// <param name="libsToLoad"></param>
		public static void melua_openlib(IntPtr L, params LuaLib[] libsToLoad)
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
					case LuaLib.BaseSafe:
						name = "";
						func = meluaopen_basesafe;
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

				GC.KeepAlive(func);
			}
		}

		/// <summary>
		/// Calls all standard lib open functions.
		/// </summary>
		/// <param name="L"></param>
		public static void melua_openlibs(IntPtr L)
		{
			melua_openlib(L, LuaLib.Base, LuaLib.Package, LuaLib.Table, LuaLib.IO, LuaLib.OS, LuaLib.String, LuaLib.Math, LuaLib.Debug);
		}

		/// <summary>
		/// C# version of luaL_error.
		/// </summary>
		/// <remarks>
		/// Original: LUALIB_API int luaL_error (lua_State *L, const char *fmt, ...)
		/// </remarks>
		/// <param name="L"></param>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public static int melua_error(IntPtr L, string format, params object[] args)
		{
			luaL_where(L, 1);
			lua_pushstring(L, string.Format(format, args));
			lua_concat(L, 2);
			return lua_error(L);
		}

		/// <summary>
		/// Adds a safe subset of functions from the base library
		/// to the state.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		internal static int meluaopen_basesafe(IntPtr L)
		{
			auxopen(L, "ipairs", CreateFunctionReference(L, Melua.luaB_ipairs), CreateFunctionReference(L, Melua.ipairsaux));
			auxopen(L, "pairs", CreateFunctionReference(L, Melua.luaB_pairs), CreateFunctionReference(L, Melua.luaB_next));
			lua_register(L, "pcall", CreateFunctionReference(L, Melua.luaB_pcall));
			lua_register(L, "print", CreateFunctionReference(L, Melua.luaB_print));
			lua_register(L, "tonumber", CreateFunctionReference(L, Melua.luaB_tonumber));
			lua_register(L, "tostring", CreateFunctionReference(L, Melua.luaB_tostring));
			lua_register(L, "type", CreateFunctionReference(L, Melua.luaB_type));
			lua_register(L, "unpack", CreateFunctionReference(L, Melua.luaB_unpack));
			lua_register(L, "xpcall", CreateFunctionReference(L, Melua.luaB_xpcall));

			return 0;
		}
	}

	public enum LuaLib
	{
		Base,
		BaseSafe,
		Package,
		Table,
		IO,
		OS,
		String,
		Math,
		Debug,
	}
}
