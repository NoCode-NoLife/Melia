using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scouts.Assassin
{
	/// <summary>
	/// Handler for Hallucination Smoke Debuff, which reduces
	/// Accuracy and Evasion
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Damage to take when buff ends
	/// </remarks>
	[BuffHandler(BuffId.HallucinationSmoke_Debuff)]
	internal class HallucinationSmoke_Debuff : BuffHandler
	{
		private const float DRPenaltyRate = 0.2f;
		private const float HRPenaltyRate = 0.2f;

		/// <summary>
		/// Starts buff, reducing Hit and Dodge Rate
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var reduceDR = buff.Target.Properties.GetFloat(PropertyName.DR) * DRPenaltyRate;
			var reduceHR = buff.Target.Properties.GetFloat(PropertyName.HR) * HRPenaltyRate;

			AddPropertyModifier(buff, buff.Target, PropertyName.DR_BM, -reduceDR);
			AddPropertyModifier(buff, buff.Target, PropertyName.HR_BM, -reduceHR);
		}

		/// <summary>
		/// Ends the buff, resetting hit and dodge rate, and
		/// potentially dealing damage
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.HR_BM);

			var attacker = buff.Caster;
			var target = buff.Target;
			var damage = buff.NumArg2;

			if (damage > 0)
				target.TakeSimpleHit(damage, attacker, SkillId.None);
		}
	}
}
