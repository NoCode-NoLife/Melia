using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World;
using Melia.Zone.World.Entities;
using Melia.Shared.Tos.Const;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler DashRun, the movement speed buff for running.
	/// </summary>
	[BuffHandler(BuffId.DashRun)]
	public class DashRun : BuffHandler
	{
		/// <summary>
		/// Starts the buff, increasing the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = (Character)buff.Target;

			// Increase movement speed and add stamina usage over time
			target.Properties.Modify(PropertyId.PC.MSPD_BM, 10);
			target.Properties.Modify(PropertyId.PC.Sta_Run, 500);

			Send.ZC_MOVE_SPEED(target);
		}

		/// <summary>
		/// Ends buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var target = (Character)buff.Target;

			target.Properties.Modify(PropertyId.PC.MSPD_BM, -10);
			target.Properties.Modify(PropertyId.PC.Sta_Run, -500);

			Send.ZC_MOVE_SPEED(target);
		}

		/// <summary>
		/// Executed regularly while the buff is active, stops it once
		/// the target is out of stamina.
		/// </summary>
		/// <param name="buff"></param>
		public override void WhileActive(Buff buff)
		{
			// TODO: Disable if stamina <= 0.
		}
	}
}
