using Melia.Zone.Buffs.Base;
using Melia.Zone.World;
using Melia.Shared.Tos.Const;
using System;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Common_Slow, which affects the movement speed on use.
	/// </summary>
	[BuffHandler(BuffId.Common_Slow)]
	public class CommonSlowHandler : BuffHandler
	{
		private const float MspdDebuffRate = 0.5f;

		/// <summary>
		/// Starts buff, modifying the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			Send.ZC_SHOW_EMOTICON(target, "I_emo_slowdown", buff.Duration);
			Send.ZC_NORMAL.PlayTextEffect(target, caster, "SHOW_BUFF_TEXT", (float)BuffId.Common_Slow, null);

			var reduceMspd = target.Properties.GetFloat(PropertyName.MSPD) * MspdDebuffRate;
			buff.Vars.SetFloat("Melia.ReduceMspd", reduceMspd);

			target.Properties.Modify(PropertyName.MSPD_BM, -reduceMspd);
			Send.ZC_MSPD(target);
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat("Melia.ReduceMspd", out var reduceMspd))
			{
				var target = buff.Target;

				target.Properties.Modify(PropertyName.MSPD_BM, reduceMspd);
				Send.ZC_MSPD(target);
			}
		}
	}
}
