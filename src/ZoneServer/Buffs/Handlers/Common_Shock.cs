using Melia.Zone.Buffs.Base;
using Melia.Zone.World;
using Melia.Shared.Game.Const;
using System;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Common_Slow, which affects the movement speed on use.
	/// </summary>
	[BuffHandler(BuffId.Common_Shock)]
	public class Common_Shock : BuffHandler
	{
		private const float IntDebuffRate = 0.1f;
		private const float SprDebuffRate = 0.1f;
		private const string ReduceIntName = "Melia.ReduceInt";
		private const string ReduceSprName = "Melia.ReduceSpr";

		/// <summary>
		/// Starts buff, reducing Int and Spr
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			var reduceInt = target.Properties.GetFloat(PropertyName.INT) * IntDebuffRate;
			buff.Vars.SetFloat(ReduceIntName, -reduceInt);

			target.Properties.Modify(PropertyName.INT_BM, -reduceInt);

			var reduceSpr = target.Properties.GetFloat(PropertyName.MNA) * SprDebuffRate;
			buff.Vars.SetFloat(ReduceSprName, -reduceSpr);

			target.Properties.Modify(PropertyName.MNA_BM, -reduceSpr);
		}

		/// <summary>
		/// Ends the buff, resetting the Int and Spr
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(ReduceIntName, out var reduceInt))
			{
				var target = buff.Target;

				target.Properties.Modify(PropertyName.INT_BM, reduceInt);
			}

			if (buff.Vars.TryGetFloat(ReduceSprName, out var reduceSpr))
			{
				var target = buff.Target;

				target.Properties.Modify(PropertyName.MNA_BM, reduceSpr);
			}
		}
	}
}
