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
}
