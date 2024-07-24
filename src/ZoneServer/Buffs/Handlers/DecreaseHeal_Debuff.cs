using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the DecreaseHeal_Debuff that changes the character's healing reduction
	/// and evasion properties.
	/// </summary>
	[BuffHandler(BuffId.DecreaseHeal_Debuff)]
	public class DecreaseHeal_Debuff : BuffHandler
	{
		public const string DebuffVarName = "DecreaseHeal_Debuff.HealingReduction";

		public override void OnStart(Buff buff)
		{
			buff.Vars.SetFloat(DebuffVarName, this.GetHealingReduction(buff));
		}

		/// <summary>
		/// Return the Buff Healing Reduction value
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		public float GetHealingReduction(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return (3 * skillLevel) / 100;
		}
	}
}
