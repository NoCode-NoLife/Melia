using System;
using System.Collections.Generic;
using Melia.Shared.Tos.Properties;
using Yggdrasil.Variables;

namespace Melia.Shared.ObjectProperties
{
	/// <summary>
	/// A collection of properties.
	/// </summary>
	public class Properties : VariableContainer<string>
	{
		private readonly Dictionary<string, List<string>> _maxProperties = new Dictionary<string, List<string>>();
		private readonly bool _checkNamespaceValidity;

		/// <summary>
		/// Returns the namespace of the properties in this collection.
		/// </summary>
		public string Namespace { get; }

		/// <summary>
		/// Creates new property collection with the given namespace.
		/// </summary>
		/// <param name="namespaceName">Namespace of the collection, controlling which properties can be added to it.</param>
		public Properties(string namespaceName)
			: this(namespaceName, true)
		{
		}

		/// <summary>
		/// Creates new property collection with the given namespace.
		/// </summary>
		/// <param name="namespaceName">Namespace of the collection, controlling which properties can be added to it.</param>
		/// <param name="checkNamespaceValidity">If true, only properties that are part of the namespace can be added to this collection.</param>
		public Properties(string namespaceName, bool checkNamespaceValidity)
		{
			this.Namespace = namespaceName;
			_checkNamespaceValidity = checkNamespaceValidity;
		}

		/// <summary>
		/// Creates the given property and adds it to this collection.
		/// </summary>
		/// <typeparam name="TVariable"></typeparam>
		/// <param name="variable"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public override TVariable Create<TVariable>(TVariable variable)
		{
			if (!(variable is IProperty))
				throw new ArgumentException($"The given variable '{variable.Ident}' is not a property.");

			if (_checkNamespaceValidity)
			{
				if (!PropertyTable.Exists(this.Namespace, variable.Ident))
					throw new ArgumentException($"The property '{variable.Ident}' doesn't exist in the namespace '{this.Namespace}'.");
			}

			return base.Create(variable);
		}

		/// <summary>
		/// Returns a list of all properties.
		/// </summary>
		/// <returns></returns>
		public new PropertyList GetAll()
		{
			// We're returning a specialized list from the multi-getters
			// because we need the namespace as well on the other side
			// to be able to get the ids from the property table before
			// sending anything to the client.

			var propertyList = new PropertyList(this.Namespace);

			lock (_syncLock)
			{
				foreach (var variable in _vars.Values)
				{
					if (variable is IProperty property)
						propertyList.Add(property);
				}
			}

			return propertyList;
		}

		/// <summary>
		/// Returns a list of properties with the given names.
		/// </summary>
		/// <param name="propertyNames"></param>
		/// <returns></returns>
		public PropertyList GetSelect(params string[] propertyNames)
		{
			if (propertyNames == null || propertyNames.Length == 0)
				return this.GetAll();

			var propertyList = new PropertyList(this.Namespace);

			foreach (var propertyName in propertyNames)
			{
				if (!this.TryGet<IProperty>(propertyName, out var property))
					continue;

				propertyList.Add(property);
			}

			return propertyList;
		}

		/// <summary>
		/// Copies the values from the given properties into this collection.
		/// </summary>
		/// <param name="otherProperties"></param>
		public void CopyFrom(Properties otherProperties)
		{
			foreach (var otherProperty in otherProperties.GetAll())
			{
				// Calculated and referenced properties are set up when
				// an object is created and can't be copied. And even if
				// could replicate them, it wouldn't be safe because they
				// might reference data of another object.
				if (otherProperty is CFloatProperty || otherProperty is RFloatProperty)
					continue;

				if (otherProperty is FloatProperty floatProperty)
				{
					if (!this.TryGet<FloatProperty>(otherProperty.Ident, out var thisProperty))
						thisProperty = this.Create(new FloatProperty(otherProperty.Ident));

					thisProperty.MaxValue = floatProperty.MaxValue;
					thisProperty.MinValue = floatProperty.MinValue;
					thisProperty.Value = floatProperty.Value;
				}
				else if (otherProperty is StringProperty stringProperty)
				{
					if (!this.TryGet<StringProperty>(otherProperty.Ident, out var thisProperty))
						thisProperty = this.Create(new StringProperty(otherProperty.Ident));

					thisProperty.Value = stringProperty.Value;
				}
				else
				{
					throw new TypeMismatchException($"Type '{otherProperty.GetType().Name}' of property '{otherProperty.Ident}' is not supported.");
				}
			}
		}

		/// <summary>
		/// Returns the property with the given identifier. If the
		/// property doesn't exist yet, it will be created.
		/// </summary>
		/// <param name="ident"></param>
		/// <returns></returns>
		public FloatProperty Float(string ident)
		{
			if (!this.TryGet<FloatProperty>(ident, out var property))
				property = this.Create(new FloatProperty(ident));

			return property;
		}

		/// <summary>
		/// Returns the calculated property with the given identifier.
		/// </summary>
		/// <param name="ident"></param>
		/// <returns></returns>
		public CFloatProperty CFloat(string ident)
		{
			if (!this.TryGet<CFloatProperty>(ident, out var property))
				throw new ArgumentException($"No calculated property '{ident}' found in '{this.GetType().Name}'.");

			return property;
		}

		/// <summary>
		/// Returns the property with the given identifier. If the
		/// property doesn't exist yet, it will be created.
		/// </summary>
		/// <param name="ident"></param>
		/// <returns></returns>
		public StringProperty String(string ident)
		{
			if (!this.TryGet<StringProperty>(ident, out var property))
				property = this.Create(new StringProperty(ident));

			return property;
		}

		/// <summary>
		/// Returns the value of the given property, or the default value
		/// if the property wasn't defined.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		public float GetFloat(string propertyName, float defaultValue = 0)
		{
			if (!this.TryGet<FloatProperty>(propertyName, out var property))
				return defaultValue;

			return property.Value;
		}

		/// <summary>
		/// Returns the value of the given property via out. Returns false
		/// if the property wasn't set yet.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public bool TryGetFloat(string propertyName, out float value)
		{
			if (!this.TryGet<FloatProperty>(propertyName, out var property))
			{
				value = 0;
				return false;
			}

			value = property.Value;
			return true;
		}

		/// <summary>
		/// Returns the value of the given property, or the default value
		/// if the property wasn't defined.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
		public string GetString(string propertyName, string defaultValue = null)
		{
			if (!this.TryGet<StringProperty>(propertyName, out var property))
				return defaultValue;

			return property.Value;
		}

		/// <summary>
		/// Sets the value of the given property. If the property doesn't
		/// exist yet it will be created.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FloatProperty SetFloat(string propertyName, float value)
		{
			if (!this.TryGet<FloatProperty>(propertyName, out var property))
				return this.Create(new FloatProperty(propertyName, value));

			property.Value = value;
			return property;
		}

		/// <summary>
		/// Sets the value of the given property. If the property doesn't
		/// exist yet it will be created.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public StringProperty SetString(string propertyName, string value)
		{
			if (!this.TryGet<StringProperty>(propertyName, out var property))
				return this.Create(new StringProperty(propertyName, value));

			property.Value = value;
			return property;
		}

		/// <summary>
		/// Modifies the value of the property by the given modifier.
		/// If the property doesn't exist yet it will be created.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="modifier"></param>
		/// <returns></returns>
		public float Modify(string propertyName, float modifier)
		{
			if (!this.TryGet<FloatProperty>(propertyName, out var property))
				return this.Create(new FloatProperty(propertyName, modifier));

			property.Value += modifier;
			return property;
		}

		/// <summary>
		/// Returns the sum of all given properties.
		/// </summary>
		/// <param name="propertyNames"></param>
		/// <returns></returns>
		public float Sum(params string[] propertyNames)
		{
			var result = 0f;

			foreach (var propertyName in propertyNames)
			{
				if (!this.TryGet<FloatProperty>(propertyName, out var property))
					continue;

				result += property.Value;
			}

			return result;
		}

		/// <summary>
		/// Sets up automatic update for a property when any of its
		/// dependencies change.
		/// </summary>
		/// <remarks>
		/// Used for calculated properties, whichs' values depend on other
		/// properties. For example, STR should be calculated based on
		/// other properties and factors and should be updated automatically
		/// if any property it depends on changes, like STR_ADD.
		/// </remarks>
		/// <param name="parentPropertyName"></param>
		/// <param name="dependencyPropertyNames"></param>
		public void AutoUpdate(string parentPropertyName, string[] dependencyPropertyNames)
		{
			if (dependencyPropertyNames == null || dependencyPropertyNames.Length == 0)
				throw new ArgumentException($"No dependencies defined.");

			if (!this.TryGet<CFloatProperty>(parentPropertyName, out var parentProperty))
				throw new ArgumentException($"Property '{parentPropertyName}' not found.");

			foreach (var dependency in dependencyPropertyNames)
			{
				// Add sub-property if it doesn't exist yet? There are quite
				// a few buff and bonus properties, and this way we don't
				// need to explicitly define all of them.
				if (!this.TryGet(dependency, out var dependencyProperty))
					//throw new ArgumentException($"Sub-property '{subPropertyId}' not found.");
					this.Create(dependencyProperty = new FloatProperty(dependency));

				// Subscribe to sub-property's ValueChanged event, so we
				// automatically trigger a recalculation of the "parent"
				// property. For Example, STR might be updated automatically
				// when STR_Bonus changes.
				// Before subscribing, unsubscribe, just in case, so we
				// don't get duplicate subscriptions.
				dependencyProperty.ValueChanged -= parentProperty.OnDependencyValueChange;
				dependencyProperty.ValueChanged += parentProperty.OnDependencyValueChange;
			}
		}

		/// <summary>
		/// Sets up automatic updates of max values on float properties.
		/// </summary>
		/// <remarks>
		/// Used for properties like HP, which have max values corresponding
		/// with other properties, like MHP (Max HP). If the value of MHP
		/// changes, the max value of HP should be updated automatically.
		/// </remarks>
		/// <param name="propertyName"></param>
		/// <param name="maxPropertyName"></param>
		public void AutoUpdateMax(string propertyName, string maxPropertyName)
		{
			// Check if both properties exist and have the right type
			if (!this.TryGet<FloatProperty>(propertyName, out var property))
				throw new ArgumentException($"Property '{propertyName}' not found.");

			if (!this.TryGet<FloatProperty>(maxPropertyName, out var maxProperty))
				throw new ArgumentException($"Max property '{maxPropertyName}' not found.");

			// Update the list of properties to update when the max property
			// changes
			if (!_maxProperties.TryGetValue(maxPropertyName, out var propertyNames))
				_maxProperties[maxPropertyName] = propertyNames = new List<string>();

			// Stop if the property is already in the list
			if (propertyNames.Contains(propertyName))
				return;

			propertyNames.Add(propertyName);

			// Subscribe to the max changed event, which updates the
			// "child" properties
			maxProperty.ValueChanged -= this.OnMaxValueChanged;
			maxProperty.ValueChanged += this.OnMaxValueChanged;

			// Set the initial max value
			property.MaxValue = maxProperty.Value;
		}

		/// <summary>
		/// Called when a property's designated max property changed.
		/// </summary>
		/// <param name="maxPropertyName"></param>
		private void OnMaxValueChanged(string maxPropertyName)
		{
			if (!_maxProperties.TryGetValue(maxPropertyName, out var propertyNames))
				return;

			if (!this.TryGet<FloatProperty>(maxPropertyName, out var maxProperty))
				return;

			foreach (var propertyName in propertyNames)
			{
				if (!this.TryGet(propertyName, out var property) || !(property is FloatProperty floatProperty))
					continue;

				floatProperty.MaxValue = maxProperty.Value;

				if (floatProperty.Value > maxProperty.Value)
					floatProperty.Value = maxProperty.Value;
			}
		}

		/// <summary>
		/// Invalidates the given property.
		/// </summary>
		/// <param name="propertyName"></param>
		public void Invalidate(params string[] propertyNames)
		{
			foreach (var propertyName in propertyNames)
			{
				if (!this.TryGet<CFloatProperty>(propertyName, out var property))
					return;

				property.Invalidate();
			}
		}

		/// <summary>
		/// Invalidates all calculated properties, to update them when
		/// they're accessed next.
		/// </summary>
		public void InvalidateAll()
		{
			var properties = this.GetAll();

			foreach (var property in properties)
			{
				if (property is CFloatProperty calcProperty)
					calcProperty.Invalidate();
			}
		}
	}
}
