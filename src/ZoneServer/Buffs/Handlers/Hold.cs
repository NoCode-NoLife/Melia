using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Hold Debuff, which prevents movement.
	/// </summary>
	[BuffHandler(BuffId.Hold)]
	public class Hold : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			if (target.Components.TryGet<MovementComponent>(out var movementComponent))
				movementComponent.ApplyHold();
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			if (target.Components.TryGet<MovementComponent>(out var movementComponent))
				movementComponent.ReleaseHold();
		}
	}
}
