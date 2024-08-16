using System;
using System.Collections.Generic;
using Melia.Shared.Data.Database;

namespace Melia.Shared.Game.Properties
{
	/// <summary>
	/// A table of all properties in the game and the namespaces they
	/// belong to.
	/// </summary>
	public static class PropertyTable
	{
		private static readonly Dictionary<string, Dictionary<string, int>> NsNames = new Dictionary<string, Dictionary<string, int>>();
		private static readonly Dictionary<string, Dictionary<int, string>> NsIds = new Dictionary<string, Dictionary<int, string>>();

		private static bool Loaded;

		/// <summary>
		/// Loads properties from the given database.
		/// </summary>
		/// <param name="db"></param>
		public static void Load(PropertiesDb db)
		{
			Loaded = true;

			NsNames.Clear();
			NsIds.Clear();

			foreach (var entry in db.Entries.Values)
			{
				if (!NsNames.TryGetValue(entry.Namespace, out var nsNames))
					NsNames[entry.Namespace] = nsNames = new Dictionary<string, int>();

				if (!NsIds.TryGetValue(entry.Namespace, out var nsIds))
					NsIds[entry.Namespace] = nsIds = new Dictionary<int, string>();

				nsNames.Add(entry.Name, entry.Id);

				// Use index since ids can appear multiple times, though
				// the names just have a different capitilization.
				nsIds[entry.Id] = entry.Name;
			}
		}

		/// <summary>
		/// Returns true if the property exists in the given namespace.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="propertyName"></param>
		/// <returns></returns>
		public static bool Exists(string namespaceName, string propertyName)
		{
			if (!Loaded)
				throw new InvalidOperationException("Properties not loaded.");

			if (!NsNames.TryGetValue(namespaceName, out var ns))
				return false;

			return ns.ContainsKey(propertyName);
		}
		/// <summary>
		/// Returns the id of the given property in the given namespace.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="propertyName"></param>
		/// <returns></returns>
		/// <exception cref="KeyNotFoundException"></exception>
		public static int GetId(string namespaceName, string propertyName)
		{
			if (!NsNames.TryGetValue(namespaceName, out var ns))
				throw new KeyNotFoundException($"Namespace '{namespaceName}' not found.");

			if (!ns.TryGetValue(propertyName, out var propertyId))
				throw new KeyNotFoundException($"Property '{propertyName}' not found in namespace '{namespaceName}'.");

			return propertyId;
		}

		/// <summary>
		/// Returns the name of the given property in the given namespace.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="propertyId"></param>
		/// <returns></returns>
		/// <exception cref="KeyNotFoundException"></exception>
		public static string GetName(string namespaceName, int propertyId)
		{
			if (!NsIds.TryGetValue(namespaceName, out var ns))
				throw new KeyNotFoundException($"Namespace '{namespaceName}' not found.");

			if (!ns.TryGetValue(propertyId, out var propertyName))
				throw new KeyNotFoundException($"Property with id '{propertyId}' not found in namespace '{namespaceName}'.");

			return propertyName;
		}

		/// <summary>
		/// Returns the property name for the given id via out. Returns
		/// false if the property wasn't found.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="propertyId"></param>
		/// <param name="propertyName"></param>
		/// <returns></returns>
		public static bool TryGetName(string namespaceName, int propertyId, out string propertyName)
		{
			propertyName = null;

			if (!NsIds.TryGetValue(namespaceName, out var ns))
				return false;

			return ns.TryGetValue(propertyId, out propertyName);
		}
	}
}
