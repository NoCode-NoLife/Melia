using Melia.Shared.Tos.Const;
using Melia.Shared.ObjectProperties;

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
			var propertyList = account.Properties.GetAll();
			var size = propertyList.GetByteCount();

			packet.PutShort(size);
			packet.PutShort(100); // This is the server group ID found in serverlist.xml. Update: Is it though? Looks more like the enter limit.
			packet.PutShort(0); // [i373230] Value: 1003. Server group id?
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

		/// <summary>
		/// Returns a reference to the account's properties.
		/// </summary>
		Properties Properties { get; }
	}
}
