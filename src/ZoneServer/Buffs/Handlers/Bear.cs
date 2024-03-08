using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Bear Buff, which increases the target's defense.
	/// </summary>
	[BuffHandler(BuffId.Bear_Buff)]
	public class Bear : BuffHandler
	{
		private const string VarName = "Melia.DefenseRateBonus";
		private const float DefenseRateBonusPerLevel = 0.02f; // 2%

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetDefenseRateBonus(buff);
			buff.Vars.SetFloat(VarName, bonus);

			buff.Target.Properties.Modify(PropertyName.DEF_RATE_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var bonus))
				buff.Target.Properties.Modify(PropertyName.DEF_RATE_BM, -bonus);
		}

		private float GetDefenseRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * DefenseRateBonusPerLevel;
		}
	}
}
