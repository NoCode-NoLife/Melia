using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Buff handler for SP potions that heal a fixed amount of SP.
	/// </summary>
	[BuffHandler(BuffId.Drug_HealSP)]
	public class Drug_HealSP : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var spHealAmount = buff.NumArg1 * 7;
			buff.Target.Heal(0, spHealAmount);
		}

		public override void WhileActive(Buff buff)
		{
			var spHealAmount = buff.NumArg1 * 7;
			buff.Target.Heal(0, spHealAmount);
		}
	}
}
