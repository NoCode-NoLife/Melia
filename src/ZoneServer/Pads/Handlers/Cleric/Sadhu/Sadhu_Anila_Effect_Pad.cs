using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;

namespace Melia.Zone.Pads.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Sadhu Anila Effect Pad, creates and disables the effect
	/// </summary>
	[PadHandler(PadName.Sadhu_Anila_Effect_Pad)]
	public class Sadhu_Anila_Effect_Pad : ICreatePadHandler, IDestroyPadHandler
	{
		private const float PadMoveDistance = 200;
		private const float PadMoveSpeedForward = 250;

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

			this.MovePad(pad, args.Creator);
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

			this.MovePad(pad, args.Creator);
		}

		/// <summary>
		/// Makes pad moves forwards
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		private async void MovePad(Pad pad, ICombatEntity creator)
		{
			// Forward and back, hovering a moment in between.
			var dest = creator.Position.GetRelative(creator.Direction, PadMoveDistance);
			var moveTime = pad.Movement.MoveTo(dest);

			await Task.Delay(moveTime);
			await Task.Delay(300);

			pad.Destroy();
		}
	}
}
