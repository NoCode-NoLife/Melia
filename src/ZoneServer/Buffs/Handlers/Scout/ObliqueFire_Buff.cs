using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers.Scout
{
	/// <summary>
	/// Handler for Oblique Fire buff, which affects the target's movement
	/// speed.
	/// </summary>
	[BuffHandler(BuffId.ObliqueFire_Buff)]
	public class ObliqueFire_Buff : BuffHandler
	{
		private const float BuffBonus = 3f;

		/// <summary>
		/// Starts buff, modifying the target's movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			// Limit it to 3 stacks since it only happens for the first
			// three hits of Oblique Fire.
			if (buff.OverbuffCounter <= 3)
			{
				AddPropertyModifier(buff, buff.Target, PropertyName.MSPD_BM, BuffBonus);
				Send.ZC_MSPD(buff.Target);
			}
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
			Send.ZC_MSPD(buff.Target);
		}
	}
}
