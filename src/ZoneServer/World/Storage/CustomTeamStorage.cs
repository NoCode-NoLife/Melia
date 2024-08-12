using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Storage
{
	// Failed experiment to create a custom storage that we can set a separate
	// size on. See PersonalStorage.InitSize for more info.

	/// <summary>
	/// Custom team storage that itilizes the personal storage system.
	/// </summary>
	//public class CustomTeamStorage : PersonalStorage
	//{
	//	/// <summary>
	//	/// Creates new team storage.
	//	/// </summary>
	//	/// <param name="owner"></param>
	//	public CustomTeamStorage(Character owner) : base(owner)
	//	{
	//	}

	//	/// <summary>
	//	/// Returns the saved size of the storage.
	//	/// </summary>
	//	/// <returns></returns>
	//	protected override int GetSavedSize()
	//		=> this.Owner.Connection.Account.Variables.Perm.GetInt("Melia.CustomTeamStorageSize", this.GetStorageSize());

	//	/// <summary>
	//	/// Sets the saved size of the storage.
	//	/// </summary>
	//	/// <param name="size"></param>
	//	protected override void SetSavedSize(int size)
	//		=> this.Owner.Connection.Account.Variables.Perm.SetInt("Melia.CustomTeamStorageSize", size);
	//}
}
