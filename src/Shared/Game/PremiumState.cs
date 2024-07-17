using System;
using Melia.Shared.Game.Const;

namespace Melia.Shared.Game
{
	/// <summary>
	/// Represents an account's premium state.
	/// </summary>
	public class PremiumState
	{
		/// <summary>
		/// Returns the type of premium state this represents.
		/// </summary>
		public PremiumType Type { get; }

		/// <summary>
		/// Gets or sets the expiration date of the premium state.
		/// </summary>
		public DateTime Expiration { get; set; }

		/// <summary>
		/// Gets or sets a numeric argument associated with the premium state.
		/// </summary>
		public int NumArg { get; set; }

		/// <summary>
		/// Returns whether the premium state is active.
		/// </summary>
		public bool Active => this.Expiration > DateTime.Now;

		/// <summary>
		/// Returns the remaining seconds until the premium state expires.
		/// </summary>
		public int RemainingSeconds => (int)(this.Expiration - DateTime.Now).TotalSeconds;

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="expiration"></param>
		/// <param name="numArg"></param>
		public PremiumState(PremiumType type, DateTime expiration, int numArg)
		{
			this.Type = type;
			this.Expiration = expiration;
			this.NumArg = numArg;
		}
	}
}
