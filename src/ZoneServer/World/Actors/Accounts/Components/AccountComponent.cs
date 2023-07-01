using Melia.Zone.Database;
using Yggdrasil.Composition;

namespace Melia.Zone.World.Actors.Accounts.Components
{
	/// <summary>
	/// A component for an account.
	/// </summary>
	public abstract class AccountComponent : IComponent
	{
		/// <summary>
		/// Returns the owner of this component.
		/// </summary>
		public Account Account{ get; }

		/// <summary>
		/// Initializes component's properties.
		/// </summary>
		/// <param name="account"></param>
		public AccountComponent(Account account)
		{
			this.Account = account;
		}
	}
}
