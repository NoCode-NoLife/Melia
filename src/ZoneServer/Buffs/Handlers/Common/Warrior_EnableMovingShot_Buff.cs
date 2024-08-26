using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handle for the Warrior_EnableMovingShot Buff, which
	/// gives moving shot with a given value
	/// </summary>
	/// <remarks>
	/// NumArg1: MovingShot_BM value
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Warrior_EnableMovingShot_Buff)]
	public class Warrior_EnableMovingShot_Buff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.MovingShot_BM, buff.NumArg1);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MovingShot_BM);
		}
	}
}
