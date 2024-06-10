using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Smite Buff, which increases the target's attack.
	/// </summary>
	[BuffHandler(BuffId.Smite_Buff)]
	public class Smite_Buff : BuffHandler
	{
		private const float AtkRateBonus = 0.1f; // 10%

		public override void OnStart(Buff buff)
		{
			buff.Target.Properties.Modify(PropertyName.PATK_MAIN_RATE_BM, AtkRateBonus);
		}

		public override void OnEnd(Buff buff)
		{
			buff.Target.Properties.Modify(PropertyName.PATK_MAIN_RATE_BM, -AtkRateBonus);
		}
	}
}
