using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Storage
{
	/// <summary>
	/// Custom team storage that itilizes the personal storage system.
	/// </summary>
	public class CustomTeamStorage : PersonalStorage
	{
		/// <summary>
		/// Creates new team storage.
		/// </summary>
		/// <param name="owner"></param>
		public CustomTeamStorage(Character owner) : base(owner)
		{
		}

		/// <summary>
		/// Returns the saved size of the storage.
		/// </summary>
		/// <returns></returns>
		protected override int GetSavedSize()
			=> this.Owner.Connection.Account.Variables.Perm.GetInt("Melia.CustomTeamStorageSize", this.GetStorageSize());

		/// <summary>
		/// Sets the saved size of the storage.
		/// </summary>
		/// <param name="size"></param>
		protected override void SetSavedSize(int size)
			=> this.Owner.Connection.Account.Variables.Perm.SetInt("Melia.CustomTeamStorageSize", size);
	}
}
