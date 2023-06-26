using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Free Step Buff, which increases the target's
	/// dodge rate.
	/// </summary>
	[BuffHandler(BuffId.FreeStep_Buff)]
	public class FreeStep_Buff : BuffHandler
	{
		private const float DodgeRatePerLevel = 0.04f;

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetEvasionBonus(buff);
			buff.Target.Properties.Modify(PropertyName.DR_RATE_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			var bonus = this.GetEvasionBonus(buff);
			buff.Target.Properties.Modify(PropertyName.DR_RATE_BM, -bonus);
		}

		private float GetEvasionBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			var bonus = skillLevel * DodgeRatePerLevel;

			return bonus;
		}
	}
}
