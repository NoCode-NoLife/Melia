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
	/// Handle for the Riding Companion Buff, which gives certain bonuses.
	/// </summary>
	[BuffHandler(BuffId.RidingCompanion)]
	public class RidingCompanion : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = (Character)buff.Target;

			// Generic values from Velheider, should be companion specific?
			AddPropertyModifier(buff, target, PropertyName.MSPD_BM, 4f);
			AddPropertyModifier(buff, target, PropertyName.DR_BM, 3f);
			AddPropertyModifier(buff, target, PropertyName.DEF_BM, 12f);

			Send.ZC_OBJECT_PROPERTY(target, PropertyName.MSPD, PropertyName.MSPD_BM,
						PropertyName.DR, PropertyName.DR_BM, PropertyName.MHP, PropertyName.MHP_RATE_BM,
						PropertyName.DEF, PropertyName.DEF_BM);
			Send.ZC_MOVE_SPEED(target);
		}

		public override void OnEnd(Buff buff)
		{
			var target = (Character)buff.Target;

			RemovePropertyModifier(buff, target, PropertyName.MSPD_BM);
			RemovePropertyModifier(buff, target, PropertyName.DR_BM);
			RemovePropertyModifier(buff, target, PropertyName.DEF_BM);

			Send.ZC_OBJECT_PROPERTY(target, PropertyName.MSPD, PropertyName.MSPD_BM,
						PropertyName.DR, PropertyName.DR_BM, PropertyName.MHP, PropertyName.MHP_RATE_BM,
						PropertyName.DEF, PropertyName.DEF_BM);
			Send.ZC_MOVE_SPEED(target);
		}
	}
}
