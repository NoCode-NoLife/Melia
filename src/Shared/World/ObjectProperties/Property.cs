// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
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
		public PropertyType Type { get { return PropertyType.Float; } }

		/// <summary>
		/// Returns byte size of float.
		/// </summary>
		public int Size { get { return sizeof(int) + sizeof(float); } }

		/// <summary>
		/// Gets or sets this property's value.
		/// </summary>
		public float Value { get; set; }

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
		public PropertyType Type { get { return PropertyType.String; } }

		/// <summary>
		/// Returns byte size of the string, plus 2 bytes for length and 1
		/// byte for the null terminator.
		/// </summary>
		public int Size { get { return sizeof(int) + sizeof(short) + Encoding.UTF8.GetByteCount(this.Value) + sizeof(byte); } }

		/// <summary>
		/// Gets or sets this property's value.
		/// </summary>
		public string Value { get; set; }

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
	}

	public enum PropertyType
	{
		Float,
		String,
	}
}
