using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Bear Buff, which increases the target's defenses.
	/// </summary>
	[BuffHandler(BuffId.Cloaking_Buff)]
	public class Cloaking_Buff : BuffHandler
	{
		private const string VarName = "Melia.DefenseRateBonus";
		private const float DefenseRateBonus = 0.25f; // 25%

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetDefenseRateBonus(buff);
			buff.Vars.SetFloat(VarName, bonus);

			buff.Target.Properties.Modify(PropertyName.DEF_RATE_BM, bonus);
			buff.Target.Properties.Modify(PropertyName.MDEF_RATE_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var bonus))
			{
				buff.Target.Properties.Modify(PropertyName.DEF_RATE_BM, -bonus);
				buff.Target.Properties.Modify(PropertyName.MDEF_RATE_BM, -bonus);
			}
		}

		private float GetDefenseRateBonus(Buff buff)
		{
			return DefenseRateBonus;
		}
	}
}
