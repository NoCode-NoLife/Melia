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
		private const float BonusPerLevel = 2;

		public override void OnStart(Buff buff)
		{
			var bonus = this.GetCritRateBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.CRTHR_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.CRTHR_BM);
		}

		private float GetCritRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			var bonus = skillLevel * BonusPerLevel;

			return bonus;
		}
	}
}
