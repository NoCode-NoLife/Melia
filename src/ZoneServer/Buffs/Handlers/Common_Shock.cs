using Melia.Zone.Buffs.Base;
using Melia.Zone.World;
using Melia.Shared.Game.Const;
using System;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Common_Shock, which reduces INT and SPR
	/// </summary>
	[BuffHandler(BuffId.Common_Shock)]
	public class Common_Shock : BuffHandler
	{
		private const float IntDebuffRate = 0.1f;
		private const float SprDebuffRate = 0.1f;

		/// <summary>
		/// Starts buff, reducing Int and Spr
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			var reduceInt = target.Properties.GetFloat(PropertyName.INT) * IntDebuffRate;
			AddPropertyModifier(buff, buff.Target, PropertyName.INT_BM, -reduceInt);

			var reduceSpr = target.Properties.GetFloat(PropertyName.MNA) * SprDebuffRate;
			AddPropertyModifier(buff, buff.Target, PropertyName.MNA_BM, -reduceSpr);
		}

		/// <summary>
		/// Ends the buff, resetting the Int and Spr
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.INT_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.MNA_BM);
		}
	}
}
