using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Bear Buff, which reduces damage taken
	/// This class's effect is handled in calc_combat, but this handler
	/// needs to remain so its duration can be saved on logout.
	/// </summary>
	[BuffHandler(BuffId.Bear_Buff)]
	public class Bear : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
		}

		public override void OnEnd(Buff buff)
		{
		}
	}
}
