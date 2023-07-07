using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Oblique Fire buff, which affects the target's movement
	/// speed.
	/// </summary>
	[BuffHandler(BuffId.ObliqueFire_Debuff)]
	public class ObliqueFire_DebuffHandler : BuffHandler
	{
		private const string VarName = "Melia.StatModifier";
		private const float DebuffPenaltyRate = -0.05f;

		/// <summary>
		/// Starts buff, modifying the target's movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			// Limit it to 2 stacks since it only happens for the fourth
			// fifth hit of Oblique Fire.
			if (buff.OverbuffCounter <= 2)
			{
				var mspd = target.Properties.GetFloat(PropertyName.MSPD);
				var penalty = mspd * DebuffPenaltyRate;

				var modifier = buff.Vars.GetFloat(VarName);
				buff.Vars.SetFloat(VarName, modifier + penalty);

				target.Properties.Modify(PropertyName.MSPD_BM, penalty);

				Send.ZC_MSPD(target);
			}
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			if (buff.Vars.TryGetFloat(VarName, out var modifier))
			{
				target.Properties.Modify(PropertyName.MSPD_BM, -modifier);
				Send.ZC_MSPD(target);
			}
		}
	}
}
