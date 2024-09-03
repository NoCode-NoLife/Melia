using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Components;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handle for the Hold Debuff, which prevents movement.
	/// </summary>
	[BuffHandler(BuffId.Hold)]
	public class Hold : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			if (buff.Target.Components.TryGet<StateLockComponent>(out var stateLocks))
				stateLocks.Lock(LockType.Movement);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Target.Components.TryGet<StateLockComponent>(out var stateLocks))
				stateLocks.Unlock(LockType.Movement);
		}
	}
}
