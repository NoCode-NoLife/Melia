using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Doppelsoeldner
{
	/// <summary>
	/// Handle for the Cyclone Enable Moving shot Buff, which lets you
	/// move during Doppelsoldner_Cyclone
	/// </summary>
	[BuffHandler(BuffId.Cyclone_EnableMovingShot_Buff)]
	public class Cyclone_EnableMovingShot_Buff : BuffHandler
	{
		private const float MovingShotBonusPerLevel = 0.2f;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.MovingShot_BM, this.GetMovingShotBonus(buff));
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MovingShot_BM);
		}

		private float GetMovingShotBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * MovingShotBonusPerLevel;
		}
	}
}
