using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Handle for the Bear Buff, which increases the target's defense.
	/// </summary>
	[BuffHandler(BuffId.Double_pay_earn_Buff)]
	public class DoublePayEarn : BuffHandler
	{
		private const string VarName = "Melia.LootingChanceBonus";
		private const float LootingChanceBonusPerLevel = 30f; // 30 looting chance is 3% drop rate bonus

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetLootingChanceBonus(buff);
			buff.Vars.SetFloat(VarName, bonus);

			buff.Target.Properties.Modify(PropertyName.LootingChance_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var bonus))
				buff.Target.Properties.Modify(PropertyName.LootingChance_BM, -bonus);
		}

		private float GetLootingChanceBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * LootingChanceBonusPerLevel;
		}
	}
}
