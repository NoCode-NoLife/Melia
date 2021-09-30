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

				if (value < this.MinValue)
					_value = this.MinValue;
				else if (value > this.MaxValue)
					_value = this.MaxValue;
				else
					_value = value;

				if (_value != valueBefore)
					this.ValueChanged?.Invoke(this);
			}
		}

		/// <summary>
		/// Gets or sets the minimum value this property can have.
		/// </summary>
		public float MinValue { get; set; }

		/// <summary>
		/// Gets or sets the maximum value this property can have.
		/// </summary>
		public float MaxValue { get; set; }

		/// <summary>
		/// Raised when the property's value changed.
		/// </summary>
		/// <remarks>
		/// The event is only raised if the value actually changed, not if
		/// the value is set, but it ends up being the same as before.
		/// </remarks>
		public event Action<IProperty> ValueChanged;

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		public FloatProperty(int propertyId, float value = 0, float min = float.MinValue, float max = float.MaxValue)
		{
			this.Id = propertyId;
			this.MinValue = min;
			this.MaxValue = max;
			this.Value = value;
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
		/// Creates a new property. The getter is used to set the initial
		/// value.
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
