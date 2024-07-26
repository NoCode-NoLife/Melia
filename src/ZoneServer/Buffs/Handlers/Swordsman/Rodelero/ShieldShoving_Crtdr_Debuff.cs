using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Rodelero
{
	/// <summary>
	/// Handle for the ShieldPush_DEF_Debuff, which reduces Evasion
	/// Block, and Crit Dodge.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.ShieldShoving_Crtdr_Debuff)]
	public class ShieldShoving_Crtdr_Debuff : BuffHandler
	{
		private const float BlkPenaltyRate = 0.2f;
		private const float DRPenaltyRate = 0.2f;
		private const float CRTDRPenaltyRate = 0.2f;

		public override void OnStart(Buff buff)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_BM, -this.GetBlockPenalty(buff));
			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, -this.GetDodgePenalty(buff));
			AddPropertyModifier(buff, buff.Target, PropertyName.CRTDR_BM, -this.GetCritDodgePenalty(buff));
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.CRTDR_BM);
		}

		/// <summary>
		/// Returns the Block penalty
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetBlockPenalty(Buff buff)
		{
			var curVal = buff.Target.Properties.GetFloat(PropertyName.BLK);

			var reduction = curVal * BlkPenaltyRate;
			return reduction;
		}

		/// <summary>
		/// Returns the Dodge penalty
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetDodgePenalty(Buff buff)
		{
			var curVal = buff.Target.Properties.GetFloat(PropertyName.DR);

			var reduction = curVal * DRPenaltyRate;
			return reduction;
		}

		/// <summary>
		/// Returns the Crit Dodge penalty
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetCritDodgePenalty(Buff buff)
		{
			var curVal = buff.Target.Properties.GetFloat(PropertyName.CRTDR);

			var reduction = curVal * CRTDRPenaltyRate;
			return reduction;
		}
	}
}
