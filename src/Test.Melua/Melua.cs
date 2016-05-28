// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Xunit;

namespace MeluaLib.Test
{
	// A few tests for potential issues that came up in the past.
	public class MeuaTests
	{
		[Fact]
		public void tostring()
		{
			var L = Melua.luaL_newstate();

			Melua.lua_pushinteger(L, 123);
			var str = Melua.lua_tostring(L, -1);
			Assert.Equal("123", str);

			Melua.lua_newtable(L);
			Assert.Equal(null, Melua.lua_tostring(L, -1));

			Melua.lua_pushstring(L, "foobar");
			Assert.Equal("foobar", Melua.lua_tostring(L, -1));
		}

		[Fact]
		public void type()
		{
			var L = Melua.luaL_newstate();

			Melua.lua_pushinteger(L, 123);
			Assert.Equal(Melua.LUA_TNUMBER, Melua.lua_type(L, -1));

			Melua.lua_pushstring(L, "123");
			Assert.Equal(Melua.LUA_TSTRING, Melua.lua_type(L, -1));

			Melua.lua_newtable(L);
			Assert.Equal(Melua.LUA_TTABLE, Melua.lua_type(L, -1));
		}

		[Fact]
		public void typename()
		{
			var L = Melua.luaL_newstate();

			Melua.lua_pushinteger(L, 123);
			Assert.Equal("number", Melua.luaL_typename(L, -1));

			Melua.lua_pushstring(L, "123");
			Assert.Equal("string", Melua.luaL_typename(L, -1));

			Melua.lua_newtable(L);
			Assert.Equal("table", Melua.luaL_typename(L, -1));
		}

		[Fact]
		public void tonumber()
		{
			var L = Melua.luaL_newstate();

			Melua.lua_pushstring(L, "123");
			Assert.Equal(123, Melua.lua_tonumber(L, -1));

			Melua.lua_pushstring(L, "0x123");
			Assert.Equal(0x123, Melua.lua_tonumber(L, -1));

			Melua.lua_pushstring(L, "0x12AB34");
			Assert.Equal(0x12AB34, Melua.lua_tonumber(L, -1));
		}
	}
}
