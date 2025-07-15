﻿using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handler for Break Brick Debuff, which reduces crit chance.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.BreakBrick_Debuff)]
	internal class BreakBrick_Debuff : BuffHandler
	{
		private const float CRTPenaltyPerLevel = 1f;

		/// <summary>
		/// Starts buff, reducing crit rate.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var reduceCrt = buff.Target.Properties.GetFloat(PropertyName.CRTHR) * buff.NumArg1 * CRTPenaltyPerLevel;

			AddPropertyModifier(buff, buff.Target, PropertyName.CRTHR_BM, -reduceCrt);
		}

		/// <summary>
		/// Ends the buff, resetting crit rate.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.CRTHR_BM);
		}
	}
}
