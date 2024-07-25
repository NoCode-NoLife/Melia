using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Scout
{
	/// <summary>
	/// Handle for the Free Step Buff, which increases the target's
	/// dodge rate.
	/// </summary>
	[BuffHandler(BuffId.FreeStep_Buff)]
	public class FreeStep_Buff : BuffHandler
	{
		private const float DodgeRateBonusPerLevel = 0.04f;

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetEvasionBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.DR_RATE_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_RATE_BM);
		}

		private float GetEvasionBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			var bonus = skillLevel * DodgeRateBonusPerLevel;

			return bonus;
		}
	}
}
