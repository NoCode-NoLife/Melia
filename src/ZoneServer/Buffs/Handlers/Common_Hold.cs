using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Hold Buff which sets the target to a on hold position
	/// </summary>
	[BuffHandler(BuffId.Common_Hold)]
	public class Common_Hold : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var movementComponent = buff.Target.Components.Get<MovementComponent>();

			if (movementComponent != null) {
				movementComponent.ApplyHold();
			}
		}

		public override void OnEnd(Buff buff)
		{
			var movementComponent = buff.Target.Components.Get<MovementComponent>();

			if (movementComponent != null)
			{
				movementComponent.ReleaseHold();
			}
		}
	}
}
