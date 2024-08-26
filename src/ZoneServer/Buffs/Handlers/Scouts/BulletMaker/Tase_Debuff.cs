using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handle for the Tase Debuff, which makes the target receive additional Lightning Property damage when hit
	/// </summary>
	[BuffHandler(BuffId.Tase_Debuff)]
	public class Tase_Debuff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			// @TODO: Reduce the Lightning property resistance of the target
		}

		public override void OnEnd(Buff buff)
		{
			// @TODO: Increase the Lightning property resistance of the target
		}
	}
}
