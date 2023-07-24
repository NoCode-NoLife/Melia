using Melia.Shared.Scripting;
using Xunit;

namespace Melia.Test.Shared.Scripting
{
	public class LuaTableTests
	{
		[Fact]
		public void Insert()
		{
			var table = new LuaTable();
			Assert.Equal("{}", table.Serialize());

			table.Insert(1);
			Assert.Equal("{ [1] = 1 }", table.Serialize());

			table.Insert(2);
			Assert.Equal("{ [1] = 1, [2] = 2 }", table.Serialize());

			table.Insert(3);
			Assert.Equal("{ [1] = 1, [2] = 2, [3] = 3 }", table.Serialize());

			table.Insert("foobar");
			Assert.Equal("{ [1] = 1, [2] = 2, [3] = 3, [4] = \"foobar\" }", table.Serialize());

			table.Clear();
			Assert.Equal("{}", table.Serialize());

			table.Insert(1);
			Assert.Equal("{ [1] = 1 }", table.Serialize());

			table.Insert(1, "test");
			Assert.Equal("{ [1] = 1, [2] = \"test\" }", table.Serialize());

			table.Insert("foo", "bar");
			Assert.Equal("{ [1] = 1, [2] = \"test\", [\"foo\"] = \"bar\" }", table.Serialize());

			table.Clear();
			Assert.Equal("{}", table.Serialize());
		}

		[Fact]
		public void Size()
		{
			var table = new LuaTable();
			Assert.Equal(2, table.SerializedSize);

			table.Insert(1);
			Assert.Equal(11, table.SerializedSize);

			table.Insert(2);
			Assert.Equal(20, table.SerializedSize);

			table.Insert(3);
			Assert.Equal(29, table.SerializedSize);

			table.Insert("foobar");
			Assert.Equal(45, table.SerializedSize);

			table.Clear();
			Assert.Equal(2, table.SerializedSize);

			table.Insert(1);
			Assert.Equal(11, table.SerializedSize);

			table.Insert(1, "test");
			Assert.Equal(25, table.SerializedSize);

			table.Insert("foo", "bar");
			Assert.Equal(42, table.SerializedSize);

			table.Clear();
			Assert.Equal(2, table.SerializedSize);
		}
	}
}
