﻿using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Scouts.Assassin
{
	/// <summary>
	/// Handler for Hallucination Smoke Buff, which raises crit rate
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Unused
	/// </remarks>
	[BuffHandler(BuffId.HallucinationSmoke_Buff)]
	internal class HallucinationSmoke_Buff : BuffHandler
	{
		// Official bonus rate is unknown
		private const float CRTHRBonus = 0.2f;

		/// <summary>
		/// Starts buff, increasing Crit Rate
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var CRTHRbuff = buff.Target.Properties.GetFloat(PropertyName.CRTHR) * CRTHRBonus;

			AddPropertyModifier(buff, buff.Target, PropertyName.CRTHR_BM, CRTHRbuff);
		}

		/// <summary>
		/// Ends the buff, resetting crit rate
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.CRTHR_BM);
		}
	}
}
