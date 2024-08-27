﻿using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Highlander
{
	/// <summary>
	/// Handler for Warcry_Buff, which increases PAtk
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Stacks
	/// </remarks>
	[BuffHandler(BuffId.Warcry_Buff)]
	public class Warcry_Buff : BuffHandler
	{
		private const float PAtkBonusPerStack = 0.025f;

		/// <summary>
		/// Starts buff, increasing PAtk
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var bonusPatk = target.Properties.GetFloat(PropertyName.PATK) * (buff.NumArg2 * PAtkBonusPerStack);

			AddPropertyModifier(buff, target, PropertyName.PATK_BM, bonusPatk);
		}

		/// <summary>
		/// Ends the buff, resetting PAtk.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.PATK_BM);
		}
	}
}