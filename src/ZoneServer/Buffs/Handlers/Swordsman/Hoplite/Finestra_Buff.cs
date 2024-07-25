using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Hoplite
{
	/// <summary>
	/// Handle for the Finestra Buff, which flatly increases critical rate
	/// </summary>
	[BuffHandler(BuffId.Finestra_Buff)]
	public class Finestra_Buff : BuffHandler
	{
		private const float CrtBonusBase = 20f;
		private const float CrtBonusPerLevel = 8f;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			AddPropertyModifier(buff, target, PropertyName.CRTHR_BM, CrtBonusBase * CrtBonusPerLevel * buff.NumArg1);
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			RemovePropertyModifier(buff, target, PropertyName.CRTHR_BM);		
		}
	}
}
