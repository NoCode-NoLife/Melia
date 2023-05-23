using System;
using System.Collections.Generic;
using System.Text;
using Melia.Shared.Tos.Properties;
using Melia.Shared.ObjectProperties;

namespace Melia.Shared.Network.Helpers
{
	public static class PropertyHelper
	{
		/// <summary>
		/// Adds properties to packet, with key and value. Does not write
		/// the collective size of the properties.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="properties"></param>
		public static void AddProperties(this Packet packet, PropertyList properties)
		{
			foreach (var property in properties)
			{
				var propertyId = PropertyTable.GetId(properties.Namespace, property.Ident);

				packet.PutInt(propertyId);

				switch (property)
				{
					case FloatProperty floatProperty:
						packet.PutFloat(floatProperty.Value);
						break;

					case StringProperty stringProperty:
						packet.PutLpString(stringProperty.Value);
						break;

					default:
						throw new ArgumentException($"Unknown property type: {property.GetType().Name}");
				}
			}
		}

		/// <summary>
		/// Returns the size in bytes the properties would take up in
		/// a packet.
		/// </summary>
		/// <param name="properties"></param>
		/// <returns></returns>
		public static int GetByteCount(this IEnumerable<IProperty> properties)
		{
			var result = 0;

			foreach (var property in properties)
			{
				result += sizeof(int); // Id

				switch (property)
				{
					case FloatProperty _:
						result += sizeof(float); // Value
						break;

					case StringProperty stringProperty:
						result += sizeof(short); // Length
						result += Encoding.UTF8.GetByteCount(stringProperty.Value); // Value
						result += sizeof(byte); // Null-terminator
						break;

					default:
						throw new ArgumentException($"Unknown property type: {property.GetType().Name}");
				}
			}

			return result;
		}
	}
}
