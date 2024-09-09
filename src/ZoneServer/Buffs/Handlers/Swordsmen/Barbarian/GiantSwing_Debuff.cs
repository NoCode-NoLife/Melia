using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handle for the Giant Swing debuff, which reduces hit rate.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.giantswing_Debuff)]
	public class Giantswing_Debuff : BuffHandler
	{
		// The true percentage of the reduction is unknown
		public const float HrDebuffRateBase = 0.05f;
		public const float HrDebuffRatePerLevel = 0.05f;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var reduceHr = buff.Target.Properties.GetFloat(PropertyName.HR) * (HrDebuffRateBase + HrDebuffRatePerLevel * buff.NumArg1);

			AddPropertyModifier(buff, buff.Target, PropertyName.HR_BM, -reduceHr);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.HR_BM);
		}
	}
}
