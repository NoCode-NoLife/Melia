using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Smite Buff, which increases the target's attack.
	/// </summary>
	[BuffHandler(BuffId.GungHo)]
	public class GungHo : BuffHandler
	{
		private const float AtkRateBonusPerLevel = 0.02f;

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetAtkRateBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.PATK_RATE_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.PATK_RATE_BM);
		}

		private float GetAtkRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * AtkRateBonusPerLevel;
		}
	}
}
