using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the DecreaseHeal_Debuff that changes the character's healing reduction
	/// and evasion properties.
	/// </summary>
	[BuffHandler(BuffId.DecreaseHeal_Debuff)]
	public class DecreaseHeal_Debuff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			buff.Vars.SetFloat("DecreaseHeal_Debuff.HealingReduction", this.GetHealingReduction(buff));
		}

		public override void OnEnd(Buff buff) { }

		/// <summary>
		/// Return the Buff Healing Reduction value
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetHealingReduction(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return (3 * skillLevel) / 100;
		}
	}
}
