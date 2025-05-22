using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handler for Sprinkle Sands Debuff, which reduces Accuracy and Evasion.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.SprinkleSands_Debuff)]
	public class SprinkleSands_Debuff : BuffHandler
	{
		private const float HRPenaltyRate = 0.2f;
		private const float DRPenaltyRate = 0.2f;

		/// <summary>
		/// Starts buff, reducing HR and DR.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var reduceHR = buff.Target.Properties.GetFloat(PropertyName.HR) * HRPenaltyRate;
			var reduceDR = buff.Target.Properties.GetFloat(PropertyName.DR) * DRPenaltyRate;

			AddPropertyModifier(buff, buff.Target, PropertyName.HR_BM, -reduceHR);
			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, -reduceDR);
		}

		/// <summary>
		/// Ends the buff, resetting HR and DR.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.HR_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);
		}
	}
}
