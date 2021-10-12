namespace Melia.Channel.Network
{
	/// <summary>
	/// Represents Key-Value string parameters used by some packets.
	/// </summary>
	public class MsgParameter
	{
		/// <summary>
		/// Returns the parameter's key.
		/// </summary>
		public string Key { get; }

		/// <summary>
		/// Returns the parameter's value.
		/// </summary>
		public string Value { get; }

		/// <summary>
		/// Creates new parameter.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public MsgParameter(string key, string value)
		{
			this.Key = key;
			this.Value = value;
		}
	}
}
