using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handler for the RootCrystalCoolDown_BUFF buff, decreases skill cooldowns.
	/// </summary>
	/// <remarks>
	/// NumArg1: ?
	/// NumArg2: ?
	/// </remarks>
	[BuffHandler(BuffId.RootCrystalCoolDown_BUFF)]
	public class RootCrystalCoolDown_BUFF : BuffHandler
	{
		/// <summary>
		/// Starts the buff, decreasing skill cooldowns.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			// TOOD: Figure out how officials handle decreasing cooldowns.
			//   Is it a one time thing that we can apply directly? Do we
			//   have to keep track of the reduction somehow? TBD.
		}

		/// <summary>
		/// Ends buff, resetting skill cooldowns.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
		}
	}
}
