using System;
using System.Globalization;

namespace Melia.Shared.World.ObjectProperties
{
	/// <summary>
	/// An object property of type float.
	/// </summary>
	public class FloatProperty : IProperty
	{
		private float _value;

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
		public FloatProperty(int propertyId, float value)
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
}
