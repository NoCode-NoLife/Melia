using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers.Scout
{
	/// <summary>
	/// Handler for Oblique Fire buff, which affects the target's movement
	/// speed.
	/// </summary>
	[BuffHandler(BuffId.ObliqueFire_Debuff)]
	public class ObliqueFire_Debuff : BuffHandler
	{
		private const float DebuffPenaltyRate = -0.05f;

		/// <summary>
		/// Starts buff, modifying the target's movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			// Limit it to 2 stacks since it only happens for the fourth
			// fifth hit of Oblique Fire.
			if (buff.OverbuffCounter <= 2)
			{
				var mspd = buff.Target.Properties.GetFloat(PropertyName.MSPD);
				var penalty = mspd * DebuffPenaltyRate;

				AddPropertyModifier(buff, buff.Target, PropertyName.MSPD_BM, penalty);
				Send.ZC_MSPD(buff.Target);
			}
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
			Send.ZC_MSPD(buff.Target);
		}
	}
}
