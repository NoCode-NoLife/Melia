using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Pads.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Bullet Marker Freeze Bullet pad, creates and disables the effect
	/// </summary>
	[PadHandler(PadName.Bulletmarker_FreezeBullet)]
	public class Bulletmarker_FreezeBullet : ICreatePadHandler, IDestroyPadHandler
	{
		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Bulletmarker_FreezeBullet, 0, 72.30239f, 50, true);
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

			if (creator.TryGetSkill(SkillId.Bulletmarker_FreezeBullet, out var freezeSkill))
			{
				freezeSkill.Vars.SetBool("Pad_" + PadName.Bulletmarker_FreezeBullet, false);
			}
		
			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Bulletmarker_FreezeBullet, 0, 72.30239f, 50, false);
		}
	}
}
