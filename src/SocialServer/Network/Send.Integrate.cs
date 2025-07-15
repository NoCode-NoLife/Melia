using Melia.Shared.Network;
using Melia.Social.World;

namespace Melia.Social.Network
{
	public static partial class Send
	{
		public static class SC_FROM_INTEGRATE
		{
			/// <summary>
			/// Purpose currently unknown.
			/// </summary>
			/// <param name="user"></param>
			public static void Unknown_01(SocialUser user)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Integrate.Unknown_01);

				packet.PutLong(user.Id);
				packet.PutInt(0);

				user.Connection?.Send(packet);
			}

			/// <summary>
			/// Purpose currently unknown.
			/// </summary>
			/// <param name="user"></param>
			public static void Unknown_14(SocialUser user)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Integrate.Unknown_14);

				packet.PutLong(user.Id);
				packet.PutInt(0); // 728

				user.Connection?.Send(packet);
			}

			/// <summary>
			/// Purpose currently unknown.
			/// </summary>
			/// <param name="user"></param>
			public static void Unknown_19(SocialUser user)
			{
				var packet = new Packet(Op.SC_NORMAL);
				packet.PutInt(NormalOp.Integrate.Unknown_19);

				packet.PutLong(user.Id);
				packet.PutLong(user.Id);
				packet.PutEmptyBin(16);
				packet.PutLpString("WEEK");
				packet.PutLong(1);

				user.Connection?.Send(packet);
			}
		}
	}
}
