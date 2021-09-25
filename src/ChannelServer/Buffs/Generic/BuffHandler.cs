using System;
using Melia.Channel.Buffs.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;

namespace Melia.Channel.Buffs.Generic
{
	/// <summary>
	/// A generic buff handler implmentation
	/// </summary>
	public class BuffHandler : IBuffHandler
	{
		public void OnStart(BuffId buffId, ICombatEntity target)
		{
			target.Components.Get<World.Buffs>().AddOrUpdate(buffId);
		}

		public void WhileActive(BuffId buffId, ICombatEntity target)
		{
			var buff = target.Components.Get<World.Buffs>().Get(buffId);
		}

		public void OnEnd(BuffId buffId, ICombatEntity target)
		{
			//target.Components.Get<World.Buffs>().Remove(buffId);
		}
	}

	/// <summary>
	/// A heal buff handler implmentation
	/// </summary>
	[BuffHandler(BuffId.Heal_Buff)]
	public class HealBuffHandler : IBuffHandler
	{
		public void OnStart(BuffId buffId, ICombatEntity target)
		{
			target.Components.Get<World.Buffs>().AddOrUpdate(buffId);
		}

		public void WhileActive(BuffId buffId, ICombatEntity target)
		{
			var buff = target.Components.Get<World.Buffs>().Get(buffId);
			target.Heal(HealType.Hp, (target.MaxHp * 10) / 100);
		}

		public void OnEnd(BuffId buffId, ICombatEntity target)
		{

		}
	}
}
