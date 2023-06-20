using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A function that handles a transaction.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="args"></param>
	/// <returns></returns>
	public delegate DialogTxResult DialogTxScriptFunc(Character character, DialogTxArgs args);

	/// <summary>
	/// Specifies the result of the transaction.
	/// </summary>
	public enum DialogTxResult
	{
		/// <summary>
		/// The transaction was successful.
		/// </summary>
		Okay,

		/// <summary>
		/// The transaction failed.
		/// </summary>
		Fail,
	}

	/// <summary>
	/// Arguments for a TX item script function.
	/// </summary>
	public class DialogTxArgs
	{
		/// <summary>
		/// Returns the character who initiated the transaction.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns the items that are involved in the transaction.
		/// </summary>
		public DialogTxItem[] TxItems { get; }

		/// <summary>
		/// Returns the numeric arguments for the transaction.
		/// </summary>
		public int[] NumArgs { get; }

		/// <summary>
		/// Returns the string arguments for the transaction.
		/// </summary>
		public string[] StrArgs { get; }

		/// <summary>
		/// Creates new arguments.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="txItems"></param>
		/// <param name="numArgs"></param>
		/// <param name="strArgs"></param>
		public DialogTxArgs(Character character, DialogTxItem[] txItems, int[] numArgs, string[] strArgs)
		{
			this.Character = character;
			this.TxItems = txItems;
			this.NumArgs = numArgs;
			this.StrArgs = strArgs;
		}
	}

	/// <summary>
	/// An item that is involved in a transaction script.
	/// </summary>
	public class DialogTxItem
	{
		/// <summary>
		/// Returns the item that is involved in the transaction.
		/// </summary>
		public Item Item { get; }

		/// <summary>
		/// Returns the amount of items subject to the transaction.
		/// </summary>
		public int Amount { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="item"></param>
		/// <param name="amount"></param>
		public DialogTxItem(Item item, int amount)
		{
			this.Item = item;
			this.Amount = amount;
		}
	}
}
