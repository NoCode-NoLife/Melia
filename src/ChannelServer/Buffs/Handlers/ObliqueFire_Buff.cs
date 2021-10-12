using System;
using Melia.Channel.Buffs.Base;
using Melia.Channel.Network;
using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;

namespace Melia.Channel.Buffs.Handlers
{
	/// <summary>
	/// Handler for ObliqueFire_Buff, which increases the target's
	/// movement speed.
	/// </summary>
	[BuffHandler(BuffId.ObliqueFire_Buff)]
	public class ObliqueFireBuffHandler : BuffHandler
	{
		/// <summary>
		/// Starts buff, modifying the target's movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;

			if (buff.OverbuffCounter <= 3)
			{
				target.Properties.Modify(PropertyId.PC.SPEED_BM, 3f);
				Send.ZC_MOVE_SPEED(target);
			}
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;

			target.Properties.Modify(PropertyId.PC.SPEED_BM, -3f * Math.Min(buff.OverbuffCounter, 3));
			Send.ZC_MOVE_SPEED(target);
		}
	}
}
