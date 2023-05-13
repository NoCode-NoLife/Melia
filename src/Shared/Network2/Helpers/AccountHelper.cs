using Melia.Shared.Tos.Const;

namespace Melia.Shared.Network2.Helpers
{
	public static class AccountHelper
	{
		/// <summary>
		/// Writes account's properties to packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="account"></param>
		public static void AddAccountProperties(this Packet packet, IAccount account)
		{
			packet.PutShort(77); // Account properties size
			packet.PutShort(100); // This is the server group ID found in serverlist.xml.
			packet.PutInt(account.SelectedBarrackLayer);
			packet.PutByte(1);
			packet.PutByte(1);

			packet.PutInt(PropertyId.Account.Medal);
			packet.PutFloat(account.Medals);

			packet.PutInt(PropertyId.Account.CTT_TempProperty_AC_Str_2);
			packet.PutLpString("x64_Client");

			packet.PutInt(PropertyId.Account.CTT_TempProperty_AC_Str_3);
			packet.PutLpString("x86_Client");

			packet.PutInt(PropertyId.Account.CTT_TempProperty_AC_Str_1);
			packet.PutLpString("x64_OS");

			packet.PutInt(PropertyId.Account.Medal_Get_Date);
			packet.PutLpString("202107321185720"); // Date 2021-07-3-21-18-57-20
		}
	}

	/// <summary>
	/// Common interface for accounts, for use with account helpers.
	/// </summary>
	public interface IAccount
	{
		/// <summary>
		/// Returns the number of medals (TP) the account has.
		/// </summary>
		int Medals { get; }

		/// <summary>
		/// Returns the number of free medals (TP) the account has.
		/// </summary>
		int GiftMedals { get; }

		/// <summary>
		/// Returns the number of premium medals (TP) the account has.
		/// </summary>
		int PremiumMedals { get; }

		/// <summary>
		/// Returns the selected barrack map.
		/// </summary>
		int SelectedBarrack { get; }

		/// <summary>
		/// Returns the selected barrack layer.
		/// </summary>
		int SelectedBarrackLayer { get; }
	}
}
