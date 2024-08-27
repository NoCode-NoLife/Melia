using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handle for the Giant Swing debuff, which reduces hit rate
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Unused
	/// </remarks>
	[BuffHandler(BuffId.giantswing_Debuff)]
	public class giantswing_Debuff : BuffHandler
	{
		// The true percentage of the reduction is unknown
		public const float HrDebuffRateBase = 0.05f;
		public const float HrDebuffRatePerLevel = 0.05f;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			var reduceHr = target.Properties.GetFloat(PropertyName.HR) * (HrDebuffRateBase + HrDebuffRatePerLevel * buff.NumArg1);

			AddPropertyModifier(buff, target, PropertyName.HR_BM, -reduceHr);
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			RemovePropertyModifier(buff, target, PropertyName.HR_BM);
		}
	}
}
