using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Network;
using Melia.Social.Database;

namespace Melia.Social.Network
{
	public static partial class Send
	{
		/// <summary>
		/// Login succeeded
		/// </summary>
		/// <param name="conn"></param>
		public static void SC_LOGIN_OK(ISocialConnection conn)
		{
			var packet = new Packet(Op.SC_LOGIN_OK);

			conn.Send(packet);
		}

		/// <summary>
		/// Unknown Purpose
		/// </summary>
		public static void SC_FROM_INTEGRATE(ISocialConnection conn, int type)
		{
			var packet = new Packet(Op.SC_FROM_INTEGRATE);

			switch (type)
			{
				case 0x01:
					packet.PutLong(conn.Account.Id);
					packet.PutInt(0);
					break;
				case 0x14:
					packet.PutLong(conn.Account.Id);
					packet.PutInt(0); // 728
					break;
				case 0x19:
					packet.PutLong(conn.Account.Id);
					packet.PutLong(conn.Account.Id);
					packet.PutEmptyBin(16);
					packet.PutLpString("WEEK");
					packet.PutLong(1);
					break;
			}
			conn.Send(packet);
		}
	}
}
