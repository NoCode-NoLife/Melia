using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for the Concentration Buff, which increases the target's
	/// crit rate.
	/// </summary>
	[BuffHandler(BuffId.Concentration_Buff)]
	public class Concentration_Buff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var bonus = this.GetCritRateBonus(buff);
			buff.Target.Properties.Modify(PropertyName.CRTHR_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			var bonus = this.GetCritRateBonus(buff);
			buff.Target.Properties.Modify(PropertyName.CRTHR_BM, -bonus);
		}

		private float GetCritRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			var bonus = skillLevel * 2;

			return bonus;
		}
	}
}
