using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Cyclone Enable Moving shot Buff, which lets you
	/// move during Doppelsoldner_Cyclone
	/// </summary>
	[BuffHandler(BuffId.Cyclone_EnableMovingShot_Buff)]
	public class Cyclone_EnableMovingShot_Buff : BuffHandler
	{
		private const float MovingShotBonusPerLevel = 0.2f;

		public override void OnStart(Buff buff)
		{
			var movingShotBonus = this.GetMovingShotBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.MovingShot_BM, 1f);
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
