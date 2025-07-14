using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Shared.Util.TaskHelper;

namespace Melia.Zone.Pads.Handlers.Cleric.Sadhu
{
	/// <summary>
	/// Handler for the Sadhu Anila Effect Pad, creates and disables the effect
	/// </summary>
	[PadHandler(PadName.Sadhu_Anila_Effect_Pad)]
	public class Sadhu_Anila_Effect_Pad : ICreatePadHandler, IDestroyPadHandler
	{
		private const float PadMoveDistance = 180;
		private const float PadMoveSpeedForward = 185;

		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;
			pad.Movement.Speed = PadMoveSpeedForward;

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Sadhu_Anila_Effect_Pad, 2.356195f, 0, 50, true);

			CallSafe(this.MovePad(pad, args.Creator));
		}

		/// <summary>
		/// Called when the pad is destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Destroyed(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Sadhu_Anila_Effect_Pad, 2.356195f, 0, 50, false);
		}

		/// <summary>
		/// Makes pad moves forwards
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		private async Task MovePad(Pad pad, ICombatEntity creator)
		{
			// Moves the pad forward.
			var destination = creator.Position.GetRelative2D(creator.Direction, PadMoveDistance);
			var moveTime = pad.Movement.MoveTo(destination);

			await Task.Delay(moveTime);
			await Task.Delay(150);

			pad.Destroy();
		}
	}
}
