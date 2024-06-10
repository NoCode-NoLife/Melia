using Melia.Shared.Game.Const;
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
		private const string VarName = "Melia.DodgeRateBonus";
		private const float DodgeRateBonusPerLevel = 0.04f;

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetEvasionBonus(buff);
			buff.Vars.SetFloat(VarName, bonus);

			buff.Target.Properties.Modify(PropertyName.DR_RATE_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var bonus))
				buff.Target.Properties.Modify(PropertyName.DR_RATE_BM, -bonus);
		}

		private float GetEvasionBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			var bonus = skillLevel * DodgeRateBonusPerLevel;

			return bonus;
		}
	}
}
