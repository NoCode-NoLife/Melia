// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Scripting;
using System;
using Xunit;

namespace Melia.Test.Channel.Scripting
{
	public class VariablesTests
	{
		[Fact]
		public void Variables_SetAndGet()
		{
			var vars = new VariableManager();

			vars["test1"] = 1;
			vars["test1"] = "5";
			vars["test1"] = 6;
			Assert.Equal(6, vars["test1"]);

			vars["test1"] = "foobar";
			Assert.Equal("foobar", vars["test1"]);

			vars["test1"] = vars["test1"] + "_test";
			Assert.Equal("foobar_test", vars["test1"]);

			vars["test2"] = ((string)vars["test1"]).Substring(0, "foo".Length) + "bar";
			Assert.Equal("foobar", vars["test2"]);

			Assert.Equal(null, vars["test3"]);

			Assert.Throws(typeof(InvalidCastException), () => { var test2 = (int)vars["test2"]; });
			Assert.DoesNotThrow(() => { var test2 = (string)vars["test2"]; });

			Assert.Throws(typeof(InvalidCastException), () => { var test1 = vars.Get<int>("test1", 0); });
			Assert.DoesNotThrow(() => { var test1 = vars.Get<string>("test1", null); });
		}
	}
}
