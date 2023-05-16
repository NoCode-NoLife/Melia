using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Util;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	public class PropertyData
	{
		public string Namespace { get; set; }
		public string Name { get; set; }
		public int Id { get; set; }
	}

	/// <summary>
	/// Property, aka "ClassKey", database, a list of named properties,
	/// each with a unique id to identify them by.
	/// </summary>
	public class PropertiesDb : DatabaseJsonIndexed<string, PropertyData>
	{
		private readonly Dictionary<string, Dictionary<string, int>> _idLookUp = new Dictionary<string, Dictionary<string, int>>();
		private readonly Dictionary<string, Dictionary<int, string>> _nameLookUp = new Dictionary<string, Dictionary<int, string>>();

		/// <summary>
		/// Returns the id of the given property in the given namespace.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="propertyName"></param>
		/// <returns></returns>
		/// <exception cref="KeyNotFoundException"></exception>
		public int GetId(string namespaceName, string propertyName)
		{
			if (!_idLookUp.TryGetValue(namespaceName, out var ns))
				throw new KeyNotFoundException($"Namespace '{namespaceName}' not found.");

			if (!ns.TryGetValue(propertyName, out var propertyId))
				throw new KeyNotFoundException($"Property '{propertyName}' not found in namespace '{namespaceName}'.");

			return propertyId;
		}

		/// <summary>
		/// Returns the name of the given property in the given namespace.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		/// <exception cref="KeyNotFoundException"></exception>
		public string GetName(string namespaceName, int id)
		{
			if (!_nameLookUp.TryGetValue(namespaceName, out var ns))
				throw new KeyNotFoundException($"Namespace '{namespaceName}' not found.");

			if (!ns.TryGetValue(id, out var propertyName))
				throw new KeyNotFoundException($"Property with id '{id}' not found in namespace '{namespaceName}'.");

			return propertyName;
		}

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
				propertyEntry.AssertNotMissing("name", "id");

				var data = new PropertyData();
				data.Namespace = namespaceName;
				data.Name = propertyEntry.ReadString("name");
				data.Id = propertyEntry.ReadInt("id");

				var fullName = data.Namespace + "." + data.Name;

				if (!_idLookUp.ContainsKey(namespaceName))
					_idLookUp.Add(namespaceName, new Dictionary<string, int>());

				if (!_nameLookUp.ContainsKey(namespaceName))
					_nameLookUp.Add(namespaceName, new Dictionary<int, string>());

				_idLookUp[namespaceName][data.Name] = data.Id;
				_nameLookUp[namespaceName][data.Id] = data.Name;

				this.AddOrReplace(fullName, data);
			}

		}
	}
}
