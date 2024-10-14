using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handle for the HighAnchoring_Debuff, which reduces Crit Dodge
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.HighAnchoring_Debuff)]
	public class HighAnchoring_Debuff : BuffHandler
	{
		private const float CRTDRPenaltyRate = 0.1f;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.CRTDR_BM, -this.GetCritDodgePenalty(buff));
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.CRTDR_BM);
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
