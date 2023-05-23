using System.Collections;
using System.Collections.Generic;

namespace Melia.Shared.World.ObjectProperties
{
	/// <summary>
	/// A list of properties from a given namespace.
	/// </summary>
	public class PropertyList : IEnumerable<IProperty>
	{
		private readonly List<IProperty> _properties = new List<IProperty>();

		/// <summary>
		/// Returns the namespace of the properties in this list.
		/// </summary>
		public string Namespace { get; }

		/// <summary>
		/// Returns the number of properties in this list.
		/// </summary>
		public int Count { get { lock (_properties) return _properties.Count; } }

		/// <summary>
		/// Creates a new list.
		/// </summary>
		/// <param name="namespaceName"></param>
		public PropertyList(string namespaceName)
		{
			this.Namespace = namespaceName;
		}

		/// <summary>
		/// Adds the property to the list.
		/// </summary>
		/// <param name="property"></param>
		public void Add(IProperty property)
		{
			lock (_properties)
				_properties.Add(property);
		}

		/// <summary>
		/// Adds the range of properties to the list.
		/// </summary>
		/// <param name="properties"></param>
		public void AddRange(IEnumerable<IProperty> properties)
		{
			lock (_properties)
				_properties.AddRange(properties);
		}

		/// <summary>
		/// Returns an enumerator for the properties in this list.
		/// </summary>
		/// <returns></returns>
		public IEnumerator<IProperty> GetEnumerator()
			=> _properties.GetEnumerator();

		/// <summary>
		/// Returns an enumerator for the properties in this list.
		/// </summary>
		/// <returns></returns>
		IEnumerator IEnumerable.GetEnumerator()
			=> this.GetEnumerator();
	}
}
