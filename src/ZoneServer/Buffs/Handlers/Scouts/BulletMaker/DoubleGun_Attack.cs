using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handle for the Double Gun Stance Buff, enables movement while attacking
	/// </summary>
	[BuffHandler(BuffId.DoubleGunStance_Buff)]
	public class DoubleGunStance_Buff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.MovingShot_BM, this.GetMovingShotBonus(buff));

			buff.Target.Properties.Invalidate(PropertyName.MovingShotable);

			if (buff.Target is Character character)
				Send.ZC_MOVE_SPEED(character);			
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MovingShot_BM);

			buff.Target.Properties.Invalidate(PropertyName.MovingShotable);

			if (buff.Target is Character character)
				Send.ZC_MOVE_SPEED(character);			
		}

		private float GetMovingShotBonus(Buff buff)
		{
			return 1f;
		}
	}
}
