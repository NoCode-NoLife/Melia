using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Rodelero
{
	/// <summary>
	/// Handle for the Slithering Buff, which increases block rate,
	/// Physical defense, and movement speed.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Slithering_Buff)]
	public class Slithering_Buff : BuffHandler
	{
		private const float BlkRateBonusPerLevel = 0.1f;
		private const float DefRateBonusPerLevel = 0.05f;
		private const float MSPDBonusPerLevel = 1.5f;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM, this.GetBlkBonus(buff));
			AddPropertyModifier(buff, buff.Target, PropertyName.DEF_RATE_BM, this.GetDefBonus(buff));
			AddPropertyModifier(buff, buff.Target, PropertyName.MSPD_BM, this.GetMSPDBonus(buff));

			Send.ZC_MSPD(buff.Target);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.DEF_RATE_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);

			Send.ZC_MSPD(buff.Target);
		}

		/// <summary>
		/// Returns the Block bonus to use
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetBlkBonus(Buff buff)
		{
			return BlkRateBonusPerLevel * buff.NumArg1;
		}

		/// <summary>
		/// Returns the PDef bonus to use
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetDefBonus(Buff buff)
		{
			return DefRateBonusPerLevel * buff.NumArg1;
		}

		/// <summary>
		/// Returns the MSPD bonus to use
		/// </summary>
		/// <remarks>
		/// Strangely, the game seems to truncate this to an int.
		/// So it increases by 1 every odd level and 2 every even level
		/// </remarks>
		/// <param name="buff"></param>
		/// <returns></returns>
		private int GetMSPDBonus(Buff buff)
		{
			return (int)(MSPDBonusPerLevel * buff.NumArg1);
		}
	}
}
