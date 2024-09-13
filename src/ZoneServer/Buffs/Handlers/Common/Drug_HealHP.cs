using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Buff handler for HP potions that heal a fixed amount of HP.
	/// </summary>
	[BuffHandler(BuffId.Drug_HealHP)]
	public class Drug_HealHP : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			this.WhileActive(buff);
		}

		public override void WhileActive(Buff buff)
		{
			// Yes... arg1 * 7 is actually correct. No, I have no idea
			// why they don't simply use the amount of HP to heal. Yes,
			// the devs are weird.

			var hpHealAmount = buff.NumArg1 * 7;
			buff.Target.Heal(hpHealAmount, 0);
		}
	}
}
