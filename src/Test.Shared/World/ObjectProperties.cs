using System;
using System.Text;
using Melia.Shared.Tos.Const;
using Melia.Shared.Network2;
using Melia.Shared.World.ObjectProperties;
using Xunit;

namespace Test.Shared.World
{
	public class ObjectPropertiesTest
	{
		[Fact]
		public void TypeException()
		{
			var properties = new Properties();
			Assert.DoesNotThrow(() => properties.Set(PropertyId.Skill.Level, 2));
			Assert.DoesNotThrow(() => properties.Set(PropertyId.Skill.SplAngle, 300));
			Assert.DoesNotThrow(() => properties.Set(PropertyId.PC.JobName, "Char1_1"));
			Assert.Throws<ArgumentException>(() => properties.Set(PropertyId.Skill.Level, "2"));
			Assert.Throws<ArgumentException>(() => properties.Set(PropertyId.Skill.SplAngle, "300"));
			Assert.Throws<ArgumentException>(() => properties.Set(PropertyId.PC.JobName, 1));
		}

		[Fact]
		public void GetAll()
		{
			var properties = new Properties();
			properties.Set(PropertyId.Skill.Level, 2);
			properties.Set(PropertyId.Skill.SplAngle, 300);
			properties.Set(PropertyId.PC.JobName, "Char1_1");

			var all = properties.GetAll();
			Assert.Equal(3, all.Length);
			Assert.Equal(PropertyType.Float, all[0].Type);
			Assert.Equal(PropertyType.Float, all[1].Type);
			Assert.Equal(PropertyType.String, all[2].Type);
		}

		[Fact]
		public void GetAll2()
		{
			var properties = new Properties();
			properties.Set(PropertyId.Skill.Level, 2);
			properties.Set(PropertyId.Skill.SplAngle, 300);
			properties.Set(PropertyId.PC.JobName, "Char1_1");

			var all = properties.GetAll(PropertyId.Skill.Level, PropertyId.PC.JobName);
			Assert.Equal(2, all.Length);
			Assert.Equal(PropertyType.Float, all[0].Type);
			Assert.Equal(PropertyType.String, all[1].Type);
		}

		[Fact]
		public void Remove()
		{
			var properties = new Properties();
			properties.Set(PropertyId.Skill.Level, 2);
			properties.Set(PropertyId.Skill.SplAngle, 300);
			properties.Set(PropertyId.PC.JobName, "Char1_1");

			var all = properties.GetAll();
			Assert.Equal(3, all.Length);
			Assert.Equal(PropertyType.Float, all[0].Type);
			Assert.Equal(PropertyType.Float, all[1].Type);
			Assert.Equal(PropertyType.String, all[2].Type);

			properties.Remove(PropertyId.Skill.SplAngle);

			all = properties.GetAll();
			Assert.Equal(2, all.Length);
			Assert.Equal(PropertyType.Float, all[0].Type);
			Assert.Equal(PropertyType.String, all[1].Type);
		}

		[Fact]
		public void GetOne()
		{
			var properties = new Properties();
			properties.Set(PropertyId.Skill.SplAngle, 300);
			properties.Set(PropertyId.PC.JobName, "Char1_1");

			Assert.Equal(null, properties.Get(PropertyId.Skill.Level));
			Assert.Equal(300, (properties.Get(PropertyId.Skill.SplAngle) as FloatProperty).Value);
			Assert.Equal("Char1_1", (properties.Get(PropertyId.PC.JobName) as StringProperty).Value);
		}

		[Fact]
		public void Packet()
		{
			var properties = new Properties();
			properties.Set(PropertyId.Skill.Level, 2);
			properties.Set(PropertyId.Skill.SplAngle, 300);
			properties.Set(PropertyId.PC.JobName, "Char1_1");

			var allProperties = properties.GetAll();

			// Write to packet
			var packet = new Packet(Op.BC_MESSAGE);
			packet.PutShort((short)properties.Size);
			foreach (var property in allProperties)
			{
				packet.PutInt(property.Id);
				switch (property)
				{
					case FloatProperty floatProperty:
						packet.PutFloat(floatProperty.Value);
						break;

					case StringProperty stringProperty:
						packet.PutLpString(stringProperty.Value);
						break;
				}
			}

			// Convert packet to buffer and read it back
			var buffer = new byte[22 + packet.Length];
			packet.Build(ref buffer, 22);

			var propertiesSize = sizeof(int) * 2 + sizeof(float) * 2 + (sizeof(int) + sizeof(short) + Encoding.UTF8.GetByteCount("Char1_1") + sizeof(byte));

			packet = new Packet(buffer);
			Assert.Equal(propertiesSize, packet.GetShort());
			Assert.Equal(PropertyId.Skill.Level, packet.GetInt());
			Assert.Equal(2, packet.GetFloat());
			Assert.Equal(PropertyId.Skill.SplAngle, packet.GetInt());
			Assert.Equal(300, packet.GetFloat());
			Assert.Equal(PropertyId.PC.JobName, packet.GetInt());
			Assert.Equal("Char1_1", packet.GetLpString());
		}

		[Fact]
		public void RefFunc()
		{
			var properties = new Properties();
			properties.Add(new FloatProperty(1, 123));
			properties.Add(new RefFloatProperty(2, () => 345));
			properties.Add(new RefFloatProperty(3, RefFuncTest));

			Assert.Equal(123, (properties.Get(1) as FloatProperty).Value);
			Assert.Equal(345, (properties.Get(2) as FloatProperty).Value);
			Assert.Equal(901, (properties.Get(3) as FloatProperty).Value);

			Assert.Equal(678, new RefFloatProperty(3, () => 678).Value);
			Assert.Equal(901, new RefFloatProperty(3, RefFuncTest).Value);
		}

		private static float RefFuncTest()
		{
			return 901;
		}
	}
}
