using Melia.Channel.Buffs.Base;
using Melia.Shared.Const;

namespace Melia.Channel.Buffs.Generic
{
	/// <summary>
	/// A generic buff handler implmentation
	/// </summary>
	public class BuffHandler : IBuffHandler
	{
		public void OnStart(World.Buff buff)
		{
			// Behavior on buff start, one time buff
		}
		public void WhileActive(World.Buff buff)
		{
			// Behavior on buff update time
		}

		public void OnEnd(World.Buff buff)
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
		public void OnStart(World.Buff buff)
		{
			var target = buff.Target;
			//target.Heal(HealType.Hp, (target.MaxHp * 10) / 100);
		}

		public void WhileActive(World.Buff buff)
		{
		}

		public void OnEnd(World.Buff buff)
		{
		}
	}

	/// <summary>
	/// A common slow buff handler implmentation
	/// </summary>
	[BuffHandler(BuffId.Common_Slow)]
	public class CommonSlowHandler : IBuffHandler
	{
		public void OnStart(World.Buff buff)
		{
			var target = buff.Target;
			// TODO Something with Move Speed
		}

		public void WhileActive(World.Buff buff)
		{
		}

		public void OnEnd(World.Buff buff)
		{
			// Reset move speed
		}
	}
}
