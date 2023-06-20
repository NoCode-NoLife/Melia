using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A function that handles a transaction.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="strArg"></param>
	/// <returns></returns>
	public delegate NormalTxResult NormalTxScriptFunc(Character character, string strArg);

	/// <summary>
	/// A function that handles a transaction.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="numArgs"></param>
	/// <returns></returns>
	public delegate NormalTxResult NormalTxNumScriptFunc(Character character, int[] numArgs);

	/// <summary>
	/// Specifies the result of the transaction.
	/// </summary>
	public enum NormalTxResult
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
}
