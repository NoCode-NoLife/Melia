using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handle for the High Guard Buff, which increases the target's block rate
	/// and critical defense, but prevents evasion.
	/// </summary>
	[BuffHandler(BuffId.HighGuard_Buff)]
	public class HighGuard_Buff : BuffHandler
	{
		private const float BlkRateBonus = 0.15f;
		private const float CrtDrRateBonus = 0.3f;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			AddPropertyModifier(buff, target, PropertyName.BLK_RATE_BM, BlkRateBonus);
			AddPropertyModifier(buff, target, PropertyName.CRTDR_RATE_BM, CrtDrRateBonus);
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			RemovePropertyModifier(buff, target, PropertyName.BLK_RATE_BM);
			RemovePropertyModifier(buff, target, PropertyName.CRTDR_RATE_BM);
		}
	}
}
