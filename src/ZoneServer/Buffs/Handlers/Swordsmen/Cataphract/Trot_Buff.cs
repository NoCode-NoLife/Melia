using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Cataphract
{
	/// <summary>
	/// Buff handler for Trot, which increases movement speed while riding
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Trot_Buff)]
	public class Trot_Buff : BuffHandler
	{
		/// <summary>
		/// Starts buff, increasing movement speed
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			AddPropertyModifier(buff, target, PropertyName.MSPD_BM, GetSpeedBonus(buff));
			Send.ZC_MSPD(target);
		}

		/// <summary>
		/// Ends the buff, resetting movement speed
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
			Send.ZC_MSPD(buff.Target);
		}


		/// <summary>
		/// Returns the speed bonus granted by the buff.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		private float GetSpeedBonus(Buff buff)
		{
			return 5 + buff.NumArg1;
		}


		/// <summary>
		/// Drains SP over time to keep the buff active
		/// </summary>
		/// <param name="buff"></param>
		public override void WhileActive(Buff buff)
		{
			if (!buff.Target.IsBuffActive(BuffId.RidingCompanion))
			{
				buff.Target.StopBuff(buff.Id);
				return;
			}
			if (!buff.Target.TrySpendSp(20))
			{
				buff.Target.StopBuff(buff.Id);
				return;
			}
		}
	}
}
