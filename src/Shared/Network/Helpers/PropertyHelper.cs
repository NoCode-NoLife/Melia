using System.Collections.Generic;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Shared.Network.Helpers
{
	public static class PropertyHelper
	{
		/// <summary>
		/// Adds properties to packet, with key and value. Does not write
		/// the property's size!
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="properties"></param>
		public static void AddProperties(this Packet packet, IEnumerable<IProperty> properties)
		{
			foreach (var property in properties)
			{
				packet.PutInt(property.Id);

				if (property is FloatProperty floatProperty)
					packet.PutFloat(floatProperty.Value);
				else if (property is StringProperty stringProperty)
					packet.PutLpString(stringProperty.Value);
			}
		}
	}
}
