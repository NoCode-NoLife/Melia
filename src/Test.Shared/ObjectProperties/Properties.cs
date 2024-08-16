using Melia.Shared.ObjectProperties;
using Xunit;

namespace Melia.Test.Shared.ObjectProperties
{
	public class PropertiesTests
	{
		[Fact]
		public void CopyFrom()
		{
			// Simple copy

			var properties1 = new Properties("Test", false);
			properties1.SetFloat("Foo", 843);
			properties1.SetString("Bar", "Foo");

			Assert.Equal(2, properties1.GetAll().Count);
			Assert.Equal(843, properties1.GetFloat("Foo"));
			Assert.Equal("Foo", properties1.GetString("Bar"));

			var properties2 = new Properties("Test", false);
			properties2.CopyFrom(properties1);

			Assert.Equal(2, properties2.GetAll().Count);
			Assert.Equal(843, properties2.GetFloat("Foo"));
			Assert.Equal("Foo", properties2.GetString("Bar"));

			// Changes don't happen in the copy

			properties1.SetFloat("Foo", 123);
			properties1.SetFloat("Foo2", 234);
			properties1.SetString("Bar", "Bar");

			Assert.Equal(3, properties1.GetAll().Count);
			Assert.Equal(123, properties1.GetFloat("Foo"));
			Assert.Equal(234, properties1.GetFloat("Foo2"));
			Assert.Equal("Bar", properties1.GetString("Bar"));

			Assert.Equal(2, properties2.GetAll().Count);
			Assert.Equal(843, properties2.GetFloat("Foo"));
			Assert.Equal("Foo", properties2.GetString("Bar"));

			// Reference properties aren't copied

			properties1.Create(new RFloatProperty("Foo3", () => 345));
			properties1.Create(new CFloatProperty("Foo4", () => properties1.GetFloat("Foo2") + properties1.GetFloat("Foo3")));

			Assert.Equal(5, properties1.GetAll().Count);
			Assert.Equal(123, properties1.GetFloat("Foo"));
			Assert.Equal(234, properties1.GetFloat("Foo2"));
			Assert.Equal(345, properties1.GetFloat("Foo3"));
			Assert.Equal(579, properties1.GetFloat("Foo4"));
			Assert.Equal("Bar", properties1.GetString("Bar"));

			properties2.CopyFrom(properties1);

			Assert.Equal(3, properties2.GetAll().Count);
			Assert.Equal(123, properties2.GetFloat("Foo"));
			Assert.Equal(234, properties2.GetFloat("Foo2"));
			Assert.Equal("Bar", properties2.GetString("Bar"));
		}
	}
}
