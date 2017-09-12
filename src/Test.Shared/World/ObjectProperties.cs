// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Text;
using Melia.Shared.Const;
using Melia.Shared.Network;
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
			Assert.DoesNotThrow(() => properties.Set(ObjectProperty.Skill.Level, 2));
			Assert.DoesNotThrow(() => properties.Set(ObjectProperty.Skill.SplAngle, 300));
			Assert.DoesNotThrow(() => properties.Set(ObjectProperty.PC.JobName, "Char1_1"));
			Assert.Throws<ArgumentException>(() => properties.Set(ObjectProperty.Skill.Level, "2"));
			Assert.Throws<ArgumentException>(() => properties.Set(ObjectProperty.Skill.SplAngle, "300"));
			Assert.Throws<ArgumentException>(() => properties.Set(ObjectProperty.PC.JobName, 1));
		}

		[Fact]
		public void GetAll()
		{
			var properties = new Properties();
			properties.Set(ObjectProperty.Skill.Level, 2);
			properties.Set(ObjectProperty.Skill.SplAngle, 300);
			properties.Set(ObjectProperty.PC.JobName, "Char1_1");

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
			properties.Set(ObjectProperty.Skill.Level, 2);
			properties.Set(ObjectProperty.Skill.SplAngle, 300);
			properties.Set(ObjectProperty.PC.JobName, "Char1_1");

			var all = properties.GetAll(ObjectProperty.Skill.Level, ObjectProperty.PC.JobName);
			Assert.Equal(2, all.Length);
			Assert.Equal(PropertyType.Float, all[0].Type);
			Assert.Equal(PropertyType.String, all[1].Type);
		}

		[Fact]
		public void GetOne()
		{
			var properties = new Properties();
			properties.Set(ObjectProperty.Skill.SplAngle, 300);
			properties.Set(ObjectProperty.PC.JobName, "Char1_1");

			Assert.Equal(null, properties.Get(ObjectProperty.Skill.Level));
			Assert.Equal(300, (properties.Get(ObjectProperty.Skill.SplAngle) as FloatProperty).Value);
			Assert.Equal("Char1_1", (properties.Get(ObjectProperty.PC.JobName) as StringProperty).Value);
		}

		[Fact]
		public void Packet()
		{
			var properties = new Properties();
			properties.Set(ObjectProperty.Skill.Level, 2);
			properties.Set(ObjectProperty.Skill.SplAngle, 300);
			properties.Set(ObjectProperty.PC.JobName, "Char1_1");

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
			var buffer = new byte[10 + packet.Length];
			packet.Build(ref buffer, 10);

			var propertiesSize = sizeof(int) * 2 + sizeof(float) * 2 + (sizeof(int) + sizeof(short) + Encoding.UTF8.GetByteCount("Char1_1") + sizeof(byte));

			packet = new Packet(buffer);
			Assert.Equal(propertiesSize, packet.GetShort());
			Assert.Equal(ObjectProperty.Skill.Level, packet.GetInt());
			Assert.Equal(2, packet.GetFloat());
			Assert.Equal(ObjectProperty.Skill.SplAngle, packet.GetInt());
			Assert.Equal(300, packet.GetFloat());
			Assert.Equal(ObjectProperty.PC.JobName, packet.GetInt());
			Assert.Equal("Char1_1", packet.GetLpString());
		}
	}
}
