using System;
using System.Globalization;
using System.Text;

namespace Melia.Shared.World.ObjectProperties
{
	public interface IProperty
	{
		/// <summary>
		/// Returns the property's id.
		/// </summary>
		int Id { get; }

		/// <summary>
		/// Returns the property's size it bytes, as it would take
		/// up in a packet, incl. the id.
		/// </summary>
		int Size { get; }

		/// <summary>
		/// Returns the property's type.
		/// </summary>
		PropertyType Type { get; }

		/// <summary>
		/// Returns a string representation of the property's value.
		/// </summary>
		/// <returns></returns>
		string GetString();
	}

	/// <summary>
	/// An object property of type float.
	/// </summary>
	public class FloatProperty : IProperty
	{
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
		public virtual float Value { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public FloatProperty(int propertyId, float value)
		{
			this.Id = propertyId;
			this.Value = value;
		}

		/// <summary>
		/// Returns the property's value as a string.
		/// </summary>
		/// <returns></returns>
		public string GetString()
		{
			return this.Value.ToString("g", CultureInfo.InvariantCulture);
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

	/// <summary>
	/// An object property of type string.
	/// </summary>
	public class StringProperty : IProperty
	{
		/// <summary>
		/// Returns this property's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// Returns the property's type.
		/// </summary>
		public PropertyType Type => PropertyType.String;

		/// <summary>
		/// Returns byte size of the string, plus 2 bytes for length and 1
		/// byte for the null terminator.
		/// </summary>
		public int Size => sizeof(int) + sizeof(short) + Encoding.UTF8.GetByteCount(this.Value) + sizeof(byte);

		/// <summary>
		/// Gets or sets this property's value.
		/// </summary>
		public virtual string Value { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public StringProperty(int propertyId, string value)
		{
			this.Id = propertyId;
			this.Value = value ?? throw new ArgumentNullException(nameof(value));
		}

		/// <summary>
		/// Returns the property's value.
		/// </summary>
		/// <returns></returns>
		public string GetString()
			=> this.Value;
	}

	/// <summary>
	/// An object property of type float, that takes its value from
	/// a function, with no way of setting it.
	/// </summary>
	public class RefStringProperty : StringProperty
	{
		private readonly Func<string> _func;

		/// <summary>
		/// Returns this property's value, setting it doesn't do anything.
		/// </summary>
		public override string Value { get => _func(); set { } }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="func">Function that returns the value.</param>
		public RefStringProperty(int propertyId, Func<string> func) : base(propertyId, func())
		{
			_func = func;
		}
	}

	public enum PropertyType
	{
		Float,
		String,
	}
}
