using System;
using System.Collections.Generic;
using System.Linq;

namespace Melia.Shared.IES
{
	/// <summary>
	/// List of IES class property modifications.
	/// </summary>
	public class IesModList
	{
		/// <summary>
		/// Returns a list of all mods.
		/// </summary>
		public Dictionary<string, IesModGroup> Mods { get; } = new();

		/// <summary>
		/// Adds a property mod.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="classId"></param>
		/// <param name="propertyName"></param>
		/// <param name="newValue"></param>
		public void Add(string namespaceName, int classId, string propertyName, int newValue)
			=> this.Add(namespaceName, classId, propertyName, "", newValue.ToString());

		/// <summary>
		/// Adds a property mod.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="classId"></param>
		/// <param name="propertyName"></param>
		/// <param name="newValue"></param>
		public void Add(string namespaceName, int classId, string propertyName, string newValue)
			=> this.Add(namespaceName, classId, propertyName, "", newValue);

		/// <summary>
		/// Adds a property mod.
		/// </summary>
		/// <param name="namespaceName"></param>
		/// <param name="classId"></param>
		/// <param name="propertyName"></param>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		private void Add(string namespaceName, int classId, string propertyName, string oldValue, string newValue)
		{
			if (!this.Mods.TryGetValue(namespaceName, out var group))
				this.Mods[namespaceName] = group = new IesModGroup(namespaceName);

			if (!group.Classes.TryGetValue(classId, out var cls))
				group.Classes[classId] = cls = new IesModClass(classId);

			if (!cls.Properties.TryGetValue(propertyName, out var prop))
				cls.Properties[propertyName] = prop = new IesModProperty(propertyName);

			var revision = 1_000_000;

			var latestChange = prop.Changes.OrderByDescending(x => x.Revision).FirstOrDefault();
			if (latestChange != null)
			{
				revision = latestChange.Revision + 1;
				oldValue = latestChange.NewValue;
			}

			var change = new IesModPropertyChange(revision, oldValue, newValue, "Melia", DateTime.Now, "Change by server");
			prop.Changes.Add(change);
		}
	}
}
