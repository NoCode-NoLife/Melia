using Melia.Shared.Network;

namespace Melia.Social.Network
{
	public static partial class Send
	{
		/// <summary>
		/// Informs client about successful login.
		/// </summary>
		/// <param name="conn"></param>
		public static void SC_LOGIN_OK(ISocialConnection conn)
		{
			var packet = new Packet(Op.SC_LOGIN_OK);

			conn.Send(packet);
		}
	}
}
