using System;
using Melia.Shared.Game;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Database
{
	public class PremiumStatus
	{
		/// <summary>
		/// Returns the normal premium state, for non-premium users.
		/// </summary>
		public PremiumState Normal { get; } = new PremiumState(PremiumType.Normal, DateTime.MaxValue, 0);

		/// <summary>
		/// Returns the PC premium state.
		/// </summary>
		public PremiumState PC { get; } = new PremiumState(PremiumType.PC, DateTime.MinValue, 0);

		/// <summary>
		/// Returns the token premium state, for premium users via token item usage.
		/// </summary>
		public PremiumState Token { get; } = new PremiumState(PremiumType.Token, DateTime.MinValue, 0);

		/// <summary>
		/// Returns true if the account is considered to have premium status.
		/// </summary>
		public bool PremiumActive => this.PC.Active || this.Token.Active;

		/// <summary>
		/// Returns true if the account can use the token warp feature.
		/// </summary>
		public bool CanUseTokenWarp => this.Token.Active;

		/// <summary>
		/// Returns true if characters of this account receive the Premium
		/// Token buff.
		/// </summary>
		public bool CanUseBuff => this.Token.Active;
	}
}
