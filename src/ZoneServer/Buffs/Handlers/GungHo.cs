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
		private const string VarName = "Melia.AtkRateBonus";
		private const float AtkRateBonusPerLevel = 0.02f; // 2%

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetAtkRateBonus(buff);
			buff.Vars.SetFloat(VarName, bonus);

			buff.Target.Properties.Modify(PropertyName.PATK_RATE_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var bonus))
				buff.Target.Properties.Modify(PropertyName.PATK_RATE_BM, -bonus);
		}

		private float GetAtkRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * AtkRateBonusPerLevel;
		}
	}
}
