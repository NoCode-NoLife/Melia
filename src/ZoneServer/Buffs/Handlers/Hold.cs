using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Hold Debuff, which prevents movement
	/// </summary>
	[BuffHandler(BuffId.Hold)]
	public class Hold : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			if (target.Components.TryGet<MovementComponent>(out var movementComponent))
			{
				movementComponent.Stop();
				movementComponent.SetFixedMoveSpeed(0.0001f);
			}
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			if (target.Components.TryGet<MovementComponent>(out var movementComponent))
			{
				movementComponent.Stop();
				movementComponent.ResetFixedMoveSpeed();
			}
		}
	}
}
