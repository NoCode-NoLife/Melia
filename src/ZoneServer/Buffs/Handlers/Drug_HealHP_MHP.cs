using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Buff handler for HP potions that heal a percentage of the user's
	/// max HP.
	/// </summary>
	[BuffHandler(BuffId.Drug_HealHP_MHP)]
	public class Drug_HealHP_MHP : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var character = buff.Target;

			// This buff seems weird. The description of "Basic Small HP
			// Potion" says it heals 20% of max HP, and that is indeed
			// what happens, but numArg1 is 25. "Basic HP Potion Supply"
			// and "Basic Large HP Potion" also say 20%, but they have
			// higher args. ToS Guru appears to generate descriptions
			// based on the behavior of "Drug_HealHP", multiplying the
			// arg with 7, but that doesn't match the in-game behavior
			// of the small potion. Until someone tells us the correct
			// behavior, we'll just do what the description says.

			var maxHp = character.Properties.GetFloat(PropertyName.MHP);
			var hpHealAmount = maxHp * 0.20f;

			character.Heal(hpHealAmount, 0);
		}

		public override void WhileActive(Buff buff)
		{
			var character = buff.Target;

			var maxHp = character.Properties.GetFloat(PropertyName.MHP);
			var hpHealAmount = maxHp * 0.20f;

			character.Heal(hpHealAmount, 0);
		}
	}
}
