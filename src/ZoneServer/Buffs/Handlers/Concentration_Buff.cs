using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for the Concentration Buff, which increases the target's
	/// crit rate.
	/// </summary>
	[BuffHandler(BuffId.Concentration_Buff)]
	public class Concentration_Buff : BuffHandler
	{
		private const string VarName = "Melia.CritRateBonus";
		private const float BonusPerLevel = 2;

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetCritRateBonus(buff);
			buff.Vars.SetFloat(VarName, bonus);

			buff.Target.Properties.Modify(PropertyName.CRTHR_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var bonus))
				buff.Target.Properties.Modify(PropertyName.CRTHR_BM, -bonus);
		}

		private float GetCritRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			var bonus = skillLevel * BonusPerLevel;

			return bonus;
		}
	}
}
