using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Components;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handle for the Silence Debuff, which prevents taking any action
	/// </summary>
	[BuffHandler(BuffId.Common_Silence)]
	public class Common_Silence : BuffHandler
	{
		public override void OnExtend(Buff buff)
		{
			buff.Target.AddState(StateType.Stunned, buff.Duration);
		}
	}
}
