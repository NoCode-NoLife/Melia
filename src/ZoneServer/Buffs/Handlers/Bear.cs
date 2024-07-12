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
		private const float DefenseRateBonusPerLevel = 0.02f;

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetDefenseRateBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.DEF_RATE_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DEF_RATE_BM);
		}

		private float GetDefenseRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * DefenseRateBonusPerLevel;
		}
	}
}
