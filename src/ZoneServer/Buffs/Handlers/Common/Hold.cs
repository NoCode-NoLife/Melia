using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
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
			buff.Target.AddState(StateType.Held);
		}

		public override void OnEnd(Buff buff)
		{
			buff.Target.RemoveState(StateType.Held);
		}
	}
}
