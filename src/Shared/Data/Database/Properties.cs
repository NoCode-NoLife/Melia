using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	public class PropertyData
	{
		public string Namespace { get; set; }
		public string Name { get; set; }
		public PropertyType Type { get; set; }
		public int Id { get; set; }
	}

	public enum PropertyType
	{
		Number,
		String,
		Calculated,
	}

	/// <summary>
	/// Property, aka "ClassKey", database, a list of named properties,
	/// each with a unique id to identify them by.
	/// </summary>
	public class PropertiesDb : DatabaseJsonIndexed<string, PropertyData>
	{
		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("namespace", "properties");

			var namespaceName = entry.ReadString("namespace");

			foreach (var propertyEntry in entry.ReadArray<JObject>("properties"))
			{
				propertyEntry.AssertNotMissing("namespace", "name", "type", "id");

				var data = new PropertyData();
				data.Namespace = namespaceName;
				data.Name = propertyEntry.ReadString("name");
				data.Type = propertyEntry.ReadEnum<PropertyType>("type");
				data.Id = propertyEntry.ReadInt("id");

				var fullName = data.Namespace + "." + data.Name;

				this.AddOrReplace(fullName, data);
			}
		}
	}
}
