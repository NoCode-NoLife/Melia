using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handler for Aggress Buff, which massively increases movement speed
	/// </summary>
	[BuffHandler(BuffId.Aggress_Buff)]
	public class Aggress_Buff : BuffHandler
	{
		private const float MspdBonus = 30f;

		/// <summary>
		/// Starts buff, modifying the movement speed
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			AddPropertyModifier(buff, target, PropertyName.MSPD_BM, MspdBonus);
			Send.ZC_MSPD(target);
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
			Send.ZC_MSPD(buff.Target);
		}
	}
}
