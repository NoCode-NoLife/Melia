using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Premium_Token, which increases movement speed and exp gained.
	/// </summary>
	[BuffHandler(BuffId.Premium_Token)]
	public class Premium_Token : BuffHandler
	{
		private const float MspdBonus = 3f;

		/// <summary>
		/// Starts buff, modifying the movement speed and exp rate
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			AddPropertyModifier(buff, target, PropertyName.MSPD_BM, MspdBonus);			
			Send.ZC_MSPD(target);

			// TODO: Seems like it should also set the PCEtc property AdditionalExpRate
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed and exp rate
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
			Send.ZC_MSPD(buff.Target);
		}
	}
}
