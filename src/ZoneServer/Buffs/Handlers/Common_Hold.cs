using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Hold Buff which sets the target to a on hold position
	/// </summary>
	[BuffHandler(BuffId.Common_Hold)]
	public class Common_Hold : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
				buff.Target.Lock(LockType.Movement);
		}

		public override void OnEnd(Buff buff)
		{
			buff.Target.Unlock(LockType.Movement);
		}
	}
}
