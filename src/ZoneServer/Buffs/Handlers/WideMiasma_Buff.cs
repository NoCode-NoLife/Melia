using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the WideMiasma Buff that turns the player into stealth instance and increase move speed
	/// </summary>
	[BuffHandler(BuffId.WideMiasma_Buff)]
	public class WideMiasma_Buff : BuffHandler
	{
		private const float MspdBuffRate = 0.1f;
		private const string varName = "Melia.MiasmaBonusMspd";

		// TODO: Make provoqued enemies lose interest.
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			var bonusMspd = target.Properties.GetFloat(PropertyName.MSPD) * MspdBuffRate;
			buff.Vars.SetFloat(varName, bonusMspd);

			target.Properties.Modify(PropertyName.MSPD_BM, bonusMspd);
			Send.ZC_MSPD(target);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(varName, out var bonusMspd))
			{
				var target = buff.Target;

				target.Properties.Modify(PropertyName.MSPD_BM, -bonusMspd);
				Send.ZC_MSPD(target);
			}
		}
	}
}
