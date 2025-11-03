using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handle for the TakingOwner Buff, which gives sets the companion as safe (unhittable).
	/// </summary>
	[BuffHandler(BuffId.TakingOwner)]
	public class TakingOwner : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			// TODO: Do we have a SetSafe equivalent?
			//target.SetSafe(true);
		}

		public override void OnEnd(Buff buff)
		{
			var target = (Character)buff.Target;

			// TODO: Do we have a SetSafe equivalent?
			//target.SetSafe(false);
		}
	}
}
