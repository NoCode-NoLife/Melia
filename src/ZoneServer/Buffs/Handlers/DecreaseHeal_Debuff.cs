using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Lethargy main debuff that reduces a target's attack
	/// and evasion properties.
	/// </summary>
	[BuffHandler(BuffId.DecreaseHeal_Debuff)]
	public class DecreaseHeal_Debuff : BuffHandler
	{
		private const float AtkReductionRatePerLevel = 2;
		private const float EvasionReductionRatePerLevel = 1;

		public override void OnStart(Buff buff)
		{
			var actualHealingModifier = buff.Caster.Properties.GetFloat(PropertyName.HEAL_BM);
			var healingReduction = this.GetHealingReduction(buff);
			var healingModifier = actualHealingModifier - healingReduction;
			AddPropertyModifier(buff, buff.Target, PropertyName.HEAL_BM, healingModifier);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.HEAL_BM);
		}

		/// <summary>
		/// Return the Buff Healing Reduction value
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetHealingReduction(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return Math.Max((3 * skillLevel) / 100, 1);
		}
	}
}
