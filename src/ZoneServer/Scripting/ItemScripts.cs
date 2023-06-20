using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A function that handles the usage of an item.
	/// </summary>
	/// <param name="character">The character who used the item.</param>
	/// <param name="item">The item that is being used.</param>
	/// <param name="strArg">String argument, as defined in the item data.</param>
	/// <param name="numArg1">First number argument, as defined in the item data.</param>
	/// <param name="numArg2">Second number argument, as defined in the item data.</param>
	/// <returns></returns>
	public delegate ItemUseResult ItemScriptFunc(Character character, Item item, string strArg, float numArg1, float numArg2);

	/// <summary>
	/// Specifies the result of using an item.
	/// </summary>
	public enum ItemUseResult
	{
		/// <summary>
		/// The item was used successfully and should be decremented.
		/// </summary>
		Okay,

		/// <summary>
		/// The usage failed and the item should not be decremented.
		/// </summary>
		Fail,
	}
}
