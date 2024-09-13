﻿using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Buff handler for SP potions that heal a percentage of the user's
	/// max SP.
	/// </summary>
	[BuffHandler(BuffId.Drug_HealSP_MSP)]
	public class Drug_HealSP_MSP : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			this.WhileActive(buff);
		}

		public override void WhileActive(Buff buff)
		{
			var character = buff.Target;

			var maxSp = character.Properties.GetFloat(PropertyName.MSP);
			var spHealAmount = maxSp * 0.20f;

			character.Heal(0, spHealAmount);
		}
	}
}
