using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handler for Freeze, which applies hold on the target
	/// </summary>
	[BuffHandler(BuffId.Freeze)]
	public class Freeze : BuffHandler
	{
		/// <summary>
		/// Starts buff
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			if (target.Components.TryGet<MovementComponent>(out var movementComponent))
				movementComponent.ApplyHold();
		}

		/// <summary>
		/// Ends the buff
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			if (target.Components.TryGet<MovementComponent>(out var movementComponent))
				movementComponent.ReleaseHold();
		}
	}
}
