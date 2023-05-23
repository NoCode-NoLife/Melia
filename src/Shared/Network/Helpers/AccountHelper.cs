using Melia.Shared.Tos.Const;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Shared.Network.Helpers
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
			var properties = new Properties("Account");
			properties.SetFloat("Medal", account.Medals);
			properties.SetString("CTT_TempProperty_AC_Str_2", "x64_Client");
			properties.SetString("CTT_TempProperty_AC_Str_3", "x86_Client");
			properties.SetString("CTT_TempProperty_AC_Str_1", "x64_OS");
			properties.SetString("Medal_Get_Date", "202107321185720");

			var propertyList = properties.GetAll();
			var size = propertyList.GetSize();

			packet.PutShort(size);
			packet.PutShort(100); // This is the server group ID found in serverlist.xml.
			packet.PutInt(account.SelectedBarrackLayer);
			packet.PutByte(1);
			packet.PutByte(1);

			packet.AddProperties(propertyList);
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
