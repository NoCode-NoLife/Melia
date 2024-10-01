using System;
using System.Buffers;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Archers.Ranger;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Archers.Ranger
{
	/// <summary>
	/// Buff handler for Strafing Shot, which is needed to
	/// use Ranger_Strafe
	/// </summary>
	/// <remarks>
	/// NumArg1: Number of times Strafe has been chained
	/// (used by Ranger54)
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Ranger_StrapingShot)]
	public class Ranger_StrapingShot : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			if (buff.Target is Character character)
				Send.ZC_SEND_PC_EXPROP(character, new MsgParameter("Ranger_StrapingShot", "1"));
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Target is Character character)
				Send.ZC_SEND_PC_EXPROP(character, new MsgParameter("Ranger_StrapingShot", "0"));
		}
	}
}
