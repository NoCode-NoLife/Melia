using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handle for the Riding Companion Buff, which gives certain bonuses.
	/// </summary>
	public class RidingCompanion : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var target = (Character)buff.Target;

			// Generic values from Velheider, should be companion specific?
			target.Properties.Modify(PropertyName.MSPD_BM, 4f);
			target.Properties.Modify(PropertyName.DR_BM, 3f);
			target.Properties.Modify(PropertyName.DEF_BM, 12f);
		}

		public override void OnEnd(Buff buff)
		{
			var target = (Character)buff.Target;

			// Generic values from Velheider, should be companion specific?
			target.Properties.Modify(PropertyName.MSPD_BM, -4f);
			target.Properties.Modify(PropertyName.DR_BM, -3f);
			target.Properties.Modify(PropertyName.DEF_BM, -12f);
		}
	}
}
