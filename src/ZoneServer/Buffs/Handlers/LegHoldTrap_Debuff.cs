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
			var movementComponent = target.Components.Get<MovementComponent>();

			if (movementComponent != null)
			{				
				movementComponent?.Stop();
			}

			target.Properties.Modify(PropertyName.FIXMSPD_BM, 0.00001f);
			Send.ZC_MSPD(target);
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;
			var movementComponent = target.Components.Get<MovementComponent>();

			if (movementComponent != null)
			{
				movementComponent?.Stop();
			}

			target.Properties.Modify(PropertyName.FIXMSPD_BM, 0);
			Send.ZC_MSPD(target);
		}
	}
}
