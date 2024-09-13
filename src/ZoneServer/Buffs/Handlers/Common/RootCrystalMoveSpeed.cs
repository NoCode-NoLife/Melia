using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handler for the RootCrystalMoveSpeed buff, which increases movement speed.
	/// </summary>
	/// <remarks>
	/// NumArg1: Flat speed bonus
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.RootCrystalMoveSpeed)]
	public class RootCrystalMoveSpeed : BuffHandler
	{
		/// <summary>
		/// Starts the buff, increasing the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var speedBonus = buff.NumArg1;

			AddPropertyModifier(buff, buff.Target, PropertyName.MSPD_BM, speedBonus);
		}

		/// <summary>
		/// Ends buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
		}
	}
}
