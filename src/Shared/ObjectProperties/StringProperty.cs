using System;

namespace Melia.Shared.ObjectProperties
{
	/// <summary>
	/// A string-type property.
	/// </summary>
	public class StringProperty : Properties.StringVariable, IProperty
	{
		/// <summary>
		/// Creates new property.
		/// </summary>
		/// <param name="ident"></param>
		/// <param name="value"></param>
		public StringProperty(string ident, string value = null)
			: base(ident, value)
		{
		}
	}

	/// <summary>
	/// A string-type property that returns a referenced value.
	/// </summary>
	public class RStringProperty : StringProperty, IUnsettableProperty, IProperty
	{
		private readonly Func<string> _getter;

		/// <summary>
		/// Returns the calculated value of the property.
		/// </summary>
		public override string Value
		{
			get => _getter();
			set => throw new InvalidOperationException($"Referenced property '{this.Ident}' in '{this.GetType().Name}' cannot be set.");
		}

		/// <summary>
		/// Creates new property.
		/// </summary>
		/// <param name="ident"></param>
		/// <param name="getter"></param>
		public RStringProperty(string ident, Func<string> getter) : base(ident, null)
		{
			_getter = getter;
		}
	}
}
