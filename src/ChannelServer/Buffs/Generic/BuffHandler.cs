using System;
using Melia.Channel.Buffs.Base;
using Melia.Channel.Network;
using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.Buffs.Generic
{
	/// <summary>
	/// A generic buff handler implmentation
	/// </summary>
	public class BuffHandler : IBuffHandler
	{
		public void OnStart(Buff buff)
		{
			// Behavior on buff start, one time buff
		}
		public void WhileActive(Buff buff)
		{
			// Behavior on buff update time
		}

		public void OnEnd(Buff buff)
		{
			// Behavior on buff removal
		}
	}

	/// <summary>
	/// A heal buff handler implmentation
	/// </summary>
	[BuffHandler(BuffId.Heal_Buff)]
	public class HealBuffHandler : IBuffHandler
	{
		public void OnStart(Buff buff)
		{
			var target = buff.Target;

			//target.Heal(HealType.Hp, (int)(target.Properties.GetFloat(PropertyId.PC.MHP) * 5) / 100);
		}

		public void WhileActive(Buff buff)
		{
		}

		public void OnEnd(Buff buff)
		{
		}
	}

	/// <summary>
	/// A common slow buff handler implmentation
	/// </summary>
	[BuffHandler(BuffId.Common_Slow)]
	public class CommonSlowHandler : IBuffHandler
	{
		public void OnStart(Buff buff)
		{
			var target = buff.Target;
			// TODO Something with Move Speed
		}

		public void WhileActive(Buff buff)
		{
		}

		public void OnEnd(Buff buff)
		{
			// Reset move speed
		}
	}

	/// <summary>
	/// An oblique fire buff handler implmentation
	/// </summary>
	[BuffHandler(BuffId.ObliqueFire_Buff)]
	public class ObliqueFireBuffHandler : IBuffHandler
	{
		public void OnStart(Buff buff)
		{
			var target = buff.Target as Character;
			if (buff.OverbuffCounter <= 3)
			{
				target.Properties.Modify(PropertyId.PC.SPEED_BM, 3f);
				Send.ZC_MOVE_SPEED(target);
			}
		}

		public void WhileActive(Buff buff)
		{
		}

		public void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;
			// Reset move speed
			target.Properties.Modify(PropertyId.PC.SPEED_BM, -3f * Math.Min(buff.OverbuffCounter, 3));
			Send.ZC_MOVE_SPEED(target);
		}
	}
}
