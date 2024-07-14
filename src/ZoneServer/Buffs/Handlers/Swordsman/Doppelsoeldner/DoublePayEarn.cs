using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Handler for the Double Pay Earn buff, which increases the item drop rate,
	/// but also the damage you take.
	/// </summary>
	[BuffHandler(BuffId.Double_pay_earn_Buff)]
	public class Double_Pay_Earn_Buff : BuffHandler
	{
		private const float LootingChanceBonusPerLevel = 3;

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
			var percentPerLevel = LootingChanceBonusPerLevel;

			// The bonus is a value in tens, so a 3% bonus requires a value of 30.
			return percentPerLevel * skillLevel * 10;
		}
	}
}
