using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handler for the RootCrystalCoolDown_BUFF buff, decreases skill cooldowns.
	/// </summary>
	/// <remarks>
	/// NumArg1: None
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.RootCrystalCoolDown_BUFF)]
	public class RootCrystalCoolDown_BUFF : BuffHandler
	{
		/// <summary>
		/// Cooldown reduction in percent.
		/// </summary>
		private const float CooldownReduction = 50;

		/// <summary>
		/// Starts the buff, decreasing skill cooldowns.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			// It appears like this is not exactly how the game typically
			// handles this buff, but we are using the OverHeat_BM
			// property as a multiplier for the cooldown in our skill
			// cooldown calculations, so this should work fine in most,
			// if not all, cases, with minor variations.

			AddPropertyModifier(buff, buff.Target, PropertyName.OverHeat_BM, -CooldownReduction);
		}

		/// <summary>
		/// Ends buff, resetting skill cooldowns.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.OverHeat_BM);
		}
	}
}
