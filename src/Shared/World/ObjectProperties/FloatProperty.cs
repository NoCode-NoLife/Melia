using System;
using System.Globalization;

namespace Melia.Shared.World.ObjectProperties
{
	/// <summary>
	/// An object property of type float.
	/// </summary>
	public class FloatProperty : IProperty
	{
		protected float _value;

		/// <summary>
		/// Returns this property's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the property's type.
		/// </summary>
		public PropertyType Type => PropertyType.Float;

		/// <summary>
		/// Returns byte size of float.
		/// </summary>
		public int Size => sizeof(int) + sizeof(float);

		/// <summary>
		/// Gets or sets this property's value.
		/// </summary>
		public virtual float Value
		{
			get => _value;
			set
			{
				var valueBefore = _value;
				_value = value;

				if (_value != valueBefore)
					this.ValueChanged?.Invoke(this);
			}
		}

		/// <summary>
		/// Raised when the property's value changed.
		/// </summary>
		public event Action<IProperty> ValueChanged;

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public FloatProperty(int propertyId, float value = 0)
		{
			this.Id = propertyId;
			_value = value;
		}

		/// <summary>
		/// Returns the property's value as a string.
		/// </summary>
		/// <returns></returns>
		public string GetString()
		{
			return _value.ToString("g", CultureInfo.InvariantCulture);
		}

		/// <summary>
		/// Raises the ValueChanged event.
		/// </summary>
		protected void OnValueChanged()
			=> this.ValueChanged?.Invoke(this);
	}

	/// <summary>
	/// An object property of type float, that takes its value from
	/// a function, with no way of setting it.
	/// </summary>
	public class RefFloatProperty : FloatProperty
	{
		private readonly Func<float> _func;

		/// <summary>
		/// Returns this property's value, setting it doesn't do anything.
		/// </summary>
		public override float Value { get => _func(); set { } }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="func">Function that returns the value.</param>
		public RefFloatProperty(int propertyId, Func<float> func) : base(propertyId, func())
		{
			_func = func;
		}
	}

	/// <summary>
	/// A property that gets its value from a getter function and is able
	/// to be updated automatically when other properties change.
	/// </summary>
	public class CalculatedFloatProperty : FloatProperty
	{
		private readonly Func<float> _getter;

		/// <summary>
		/// Returns the property's last calculated value. Setting does
		/// nothing.
		/// </summary>
		public override float Value
		{
			get => _value;
			set { }
		}

		/// <summary>
		/// Creates a new property.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="getter"></param>
		public CalculatedFloatProperty(int propertyId, Func<float> getter) : base(propertyId, getter())
		{
			_getter = getter;
		}

		/// <summary>
		/// Triggers a recalculation of the property's value and updates
		/// it. ValueChanged will be raised if the value did change.
		/// </summary>
		/// <param name="property"></param>
		public void TriggerCalculation(IProperty property)
		{
			var valueBefore = _value;
			_value = _getter();

			if (_value != valueBefore)
				this.OnValueChanged();
		}
	}
}
