using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Leg Hold Trap Debuff, which makes the target imoble
	/// </summary>
	[BuffHandler(BuffId.LegHoldTrap_Debuff)]
	public class LegHoldTrap_Debuff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			// We may need to add "CanMove" variable to this component.
			if (!buff.Target.Components.TryGet<AiComponent>(out var component))
			{
				var movementComponent = target.Components.Get<MovementComponent>();
				movementComponent?.Stop();
				// movementComponent.MoveSpeedType = MoveSpeedType.Stop;
			}

			// Well I don't know a better way of doing this
			// Lets just decrease the movespeed to zero?
			if (target as Character != null)
			{
				var reduceMspd = target.Properties.GetFloat(PropertyName.MSPD);
				buff.Vars.SetFloat("Melia.ReduceMspd", reduceMspd);

				target.Properties.Modify(PropertyName.MSPD_BM, -reduceMspd);
				Send.ZC_MSPD(target);
			}			
		}

		public override void OnEnd(Buff buff)
		{
			// Enable AI movement again?
			// movementComponent.MoveSpeedType = MoveSpeedType.Walking;

			var target = buff.Target;

			if (target as Character != null)
			{
				if (buff.Vars.TryGetFloat("Melia.ReduceMspd", out var reduceMspd))
				{
					target.Properties.Modify(PropertyName.MSPD_BM, reduceMspd);
					Send.ZC_MSPD(target);
				}
			}
		}
	}
}
