using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Components;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handle for the Stun Debuff, which prevents taking any action
	/// </summary>
	[BuffHandler(BuffId.Stun)]
	public class Stun : BuffHandler
	{
		public override void OnExtend(Buff buff)
		{
			buff.Target.AddState(StateType.Stunned, buff.Duration);
		}
	}
}
