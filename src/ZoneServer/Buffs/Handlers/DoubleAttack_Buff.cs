using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Double Attack Buff, which increases the target's
	/// crit and physical attack rate.
	/// </summary>
	[BuffHandler(BuffId.DoubleAttack_Buff)]
	public class DoubleAttack_Buff : BuffHandler
	{
		private const float CritRateBonus = 0.20f;
		private const float AttackRateBonus = 0.05f;

		public override void OnStart(Buff buff)
		{
			buff.Target.Properties.Modify(PropertyName.CRTHR_BM, CritRateBonus);
			buff.Target.Properties.Modify(PropertyName.PATK_RATE_BM, AttackRateBonus);
		}

		public override void OnEnd(Buff buff)
		{
			buff.Target.Properties.Modify(PropertyName.CRTHR_BM, -CritRateBonus);
			buff.Target.Properties.Modify(PropertyName.PATK_RATE_BM, -AttackRateBonus);
		}
	}
}
