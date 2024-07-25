using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Rodelero
{
	/// <summary>
	/// Handle for the Slithering Debuff, which flatly decreases
	/// evasion and movement speed
	/// </summary>
	/// <remarks>
	/// NumArg1: Ability Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Slithering_Debuff)]
	public class Slithering_Debuff : BuffHandler
	{
		private const float DRPenaltyPerLevel = 15f;
		private const float MSPDPenaltyPerLevel = 4f;

		public override void OnStart(Buff buff)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, -this.GetDodgePenalty(buff));
			AddPropertyModifier(buff, buff.Target, PropertyName.MSPD_BM, -this.GetMSPDPenalty(buff));
			Send.ZC_MSPD(buff.Target);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
			Send.ZC_MSPD(buff.Target);
		}

		/// <summary>
		/// Returns the Dodge penalty
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetDodgePenalty(Buff buff)
		{
			return buff.NumArg1 * DRPenaltyPerLevel;
		}

		/// <summary>
		/// Returns the Dodge penalty
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetMSPDPenalty(Buff buff)
		{
			return buff.NumArg1 * MSPDPenaltyPerLevel;
		}
	}
}
