using System;

namespace Melia.Shared.ObjectProperties
{
	/// <summary>
	/// A float-type property.
	/// </summary>
	public class FloatProperty : Properties.FloatVariable, IProperty
	{
		/// <summary>
		/// Creates new property.
		/// </summary>
		/// <param name="ident"></param>
		/// <param name="value"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		public FloatProperty(string ident, float value = 0, float min = float.MinValue, float max = float.MaxValue)
			: base(ident, value, min, max)
		{
		}
	}

	/// <summary>
	/// A float-type property that is calculated as needed.
	/// </summary>
	/// <remarks>
	/// The difference between CFloatProperty and RFloatProperty is that
	/// CFloatProperty will raise the ValueChanged event whenever it gets
	/// recalculated and the value changes. Since RFloatProperty just
	/// returns a referenced value, it can't keep track of changes.
	/// Additionally it saves computing power to not calculate the value
	/// every single time it's requested. Though this behavior might yet
	/// change if the need arises.
	/// </remarks>
	public class CFloatProperty : FloatProperty, IUnsettableProperty, IProperty
	{
		private readonly Func<float> _getter;
		private float _value;

		/// <summary>
		/// Returns the calculated value of the property.
		/// </summary>
		public override float Value
		{
			get => _value;
			set => throw new InvalidOperationException($"Calculated property '{this.Ident}' in '{this.GetType().Name}' cannot be set.");
		}

		/// <summary>
		/// Creates new property.
		/// </summary>
		/// <param name="ident"></param>
		/// <param name="getter"></param>
		public CFloatProperty(string ident, Func<float> getter) : base(ident, 0)
		{
			_getter = getter;
		}

		/// <summary>
		/// Triggers recalculation of this property's value.
		/// </summary>
		/// <param name="ident"></param>
		public void OnDependencyValueChange(string ident)
			=> this.Recalculate();

		/// <summary>
		/// Triggers recalculation of this property's value and returns
		/// its new value.
		/// </summary>
		/// <returns></returns>
		public float Recalculate()
		{
			var valueBefore = _value;
			_value = _getter();

			if (_value != valueBefore)
				this.OnValueChanged();

			return _value;
		}
	}

	/// <summary>
	/// A float-type property that returns a referenced value.
	/// </summary>
	public class RFloatProperty : FloatProperty, IUnsettableProperty, IProperty
	{
		private readonly Func<float> _getter;

		/// <summary>
		/// Returns the calculated value of the property.
		/// </summary>
		public override float Value
		{
			get => _getter();
			set => throw new InvalidOperationException($"Referenced property '{this.Ident}' in '{this.GetType().Name}' cannot be set.");
		}

		/// <summary>
		/// Creates new property.
		/// </summary>
		/// <param name="ident"></param>
		/// <param name="getter"></param>
		public RFloatProperty(string ident, Func<float> getter) : base(ident, 0)
		{
			_getter = getter;
		}
	}
}
