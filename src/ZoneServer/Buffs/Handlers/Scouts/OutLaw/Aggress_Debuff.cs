using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handler for Break Brick Debuff, which reduces Evasion
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Unhinge Level
	/// This is related to Outlaw13, which changes the buff effect to
	/// also increase movement speed but decrease accuracy
	/// </remarks>
	[BuffHandler(BuffId.Aggress_Debuff)]
	internal class Aggress_Debuff : BuffHandler
	{
		private const float DRPenaltyPerLevel = 0.02f;
		private const float HRPenaltyPerLevel = 0.03f;
		private const float MspdBonus = 5f;

		/// <summary>
		/// Starts buff, reducing Dodge Rate
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var reduceDR = buff.Target.Properties.GetFloat(PropertyName.DR) * buff.NumArg1 * DRPenaltyPerLevel;

			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, -reduceDR);

			if (buff.NumArg2 > 0)
			{
				var reduceHR = buff.Target.Properties.GetFloat(PropertyName.HR) * buff.NumArg2 * HRPenaltyPerLevel;

				AddPropertyModifier(buff, buff.Target, PropertyName.HR_BM, -reduceHR);
				AddPropertyModifier(buff, buff.Target, PropertyName.MSPD_BM, MspdBonus);
				Send.ZC_MSPD(buff.Target);
			}
		}

		/// <summary>
		/// Ends the buff, resetting dodge rate.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);

			if (buff.NumArg2 > 0)
			{
				RemovePropertyModifier(buff, buff.Target, PropertyName.HR_BM);
				RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
				Send.ZC_MSPD(buff.Target);
			}
		}
	}
}
