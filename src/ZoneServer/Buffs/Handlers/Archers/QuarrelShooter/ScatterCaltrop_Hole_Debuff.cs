using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Components;

namespace Melia.Zone.Buffs.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Handle for the ScatterCaltrop Hole Debuff, which prevents movement
	/// </summary>
	[BuffHandler(BuffId.ScatterCaltrop_Hole_Debuff)]
	public class ScatterCaltrop_Hole_Debuff : BuffHandler
	{
		public override void OnExtend(Buff buff)
		{
			buff.Target.AddState(StateType.Held, buff.Duration);
		}
	}
}
