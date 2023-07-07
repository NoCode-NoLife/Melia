using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Oblique Fire buff, which affects the target's movement
	/// speed.
	/// </summary>
	[BuffHandler(BuffId.ObliqueFire_Buff)]
	public class ObliqueFireBuffHandler : BuffHandler
	{
		private const string VarName = "Melia.StatModifier";
		private const float BuffBonus = 3f;

		/// <summary>
		/// Starts buff, modifying the target's movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			// Limit it to 3 stacks since it only happens for the first
			// three hits of Oblique Fire.
			if (buff.OverbuffCounter <= 3)
			{
				var bonus = BuffBonus;

				var modifier = buff.Vars.GetFloat(VarName);
				buff.Vars.SetFloat(VarName, modifier + bonus);

				target.Properties.Modify(PropertyName.MSPD_BM, bonus);

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
