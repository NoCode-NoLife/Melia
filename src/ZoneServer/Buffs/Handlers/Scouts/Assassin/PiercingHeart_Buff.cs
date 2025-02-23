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
	/// Handler for Piercing Heart Buff, which raises crit rate
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Unused
	/// </remarks>
	[BuffHandler(BuffId.PiercingHeart_Buff)]
	internal class PiercingHeart_Buff : BuffHandler
	{
		// Official bonus rate is unknown
		private const float CRTHRBonus = 0.5f;

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
