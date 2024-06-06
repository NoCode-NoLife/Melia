using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handle for the High Guard Buff, which increases the target's block rate and critical defense,
	/// but prevents evasion
	/// </summary>
	[BuffHandler(BuffId.HighGuard_Buff)]
	public class GungHo : BuffHandler
	{
		private const float BlkRateBonus = 0.15f; // 15%
		private const float CrtDrRateBonus = 0.3f; // 30%

		public override void OnStart(Buff buff)
		{
			buff.Target.Properties.Modify(PropertyName.BLK_RATE_BM, BlkRateBonus);
			buff.Target.Properties.Modify(PropertyName.CRTDR_RATE_BM, CrtDrRateBonus);
		}

		public override void OnEnd(Buff buff)
		{
			buff.Target.Properties.Modify(PropertyName.BLK_RATE_BM, -BlkRateBonus);
			buff.Target.Properties.Modify(PropertyName.CRTDR_RATE_BM, -CrtDrRateBonus);
		}
	}
}
