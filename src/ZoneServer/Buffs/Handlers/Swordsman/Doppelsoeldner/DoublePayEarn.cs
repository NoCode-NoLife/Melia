using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Handle for the Double Pay Earn buff, which increases Looting Chance (drop rate)
	/// but increases the damage you take.
	/// </summary>
	[BuffHandler(BuffId.Double_pay_earn_Buff)]
	public class Double_Pay_Earn_Buff : BuffHandler
	{
		private const float LootingChanceBonusPerLevel = 30f; // 30 looting chance is 3% drop rate bonus

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetLootingChanceBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.LootingChance_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.LootingChance_BM);
		}

		private float GetLootingChanceBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * LootingChanceBonusPerLevel;
		}
	}
}
