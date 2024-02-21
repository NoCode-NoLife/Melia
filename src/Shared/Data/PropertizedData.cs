using System;
using System.Reflection;
using Melia.Shared.ObjectProperties;

namespace Melia.Shared.Data
{
	/// <summary>
	/// Base class for data entries that adds support for property creation
	/// based on the data and its attributes.
	/// </summary>
	public abstract class PropertizedData
	{
		/// <summary>
		/// Returns the data entries properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("", false);

		/// <summary>
		/// Initializes properties.
		/// </summary>
		public PropertizedData()
		{
			this.LoadProperties();
		}

		/// <summary>
		/// Creates reference properties for all data fields that have
		/// a PropertyAttribute.
		/// </summary>
		private void LoadProperties()
		{
			var props = this.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
			foreach (var prop in props)
			{
				var attr = prop.GetCustomAttribute<PropertyAttribute>();
				if (attr == null)
					continue;

				if (prop.PropertyType == typeof(float))
				{
					var propertyName = attr.PropertyName;
					var property = new RFloatProperty(propertyName, () => (float)prop.GetValue(this));

					this.Properties.Create(property);
				}
				else if (prop.PropertyType == typeof(string))
				{
					var propertyName = attr.PropertyName;
					var property = new RStringProperty(propertyName, () => (string)prop.GetValue(this));

					this.Properties.Create(property);
				}
			}
		}
	}

	/// <summary>
	/// Marks a data field as a game property with a name.
	/// </summary>
	public class PropertyAttribute : Attribute
	{
		/// <summary>
		/// Returns the name of the property the field represents.
		/// </summary>
		public string PropertyName { get; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="propertyName"></param>
		public PropertyAttribute(string propertyName)
		{
			this.PropertyName = propertyName;
		}
	}
}
