using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Rodelero
{
	/// <summary>
	/// Handle for the Shield Charge Buff, which increases block rate,
	/// and Physical Defense
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.ShieldCharge_Buff)]
	public class ShieldCharge_Buff : BuffHandler
	{
		private const float BlkRateBase = 0.1f;
		private const float BlkRateBonusPerLevel = 0.06f;
		private const float DefRateBase = 0.1f;
		private const float DefRateBonusPerLevel = 0.06f;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM, this.GetBlkBonus(buff));
			AddPropertyModifier(buff, buff.Target, PropertyName.DEF_RATE_BM, this.GetDefBonus(buff));
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.DEF_RATE_BM);
		}

		/// <summary>
		/// Returns the Block bonus to use
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetBlkBonus(Buff buff)
		{
			return BlkRateBase + BlkRateBonusPerLevel * buff.NumArg1;
		}

		/// <summary>
		/// Returns the PDef bonus to use
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetDefBonus(Buff buff)
		{
			return DefRateBase + DefRateBonusPerLevel * buff.NumArg1;
		}
	}
}
