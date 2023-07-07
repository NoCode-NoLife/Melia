using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for ObliqueFire_Buff, which increases the target's
	/// movement speed.
	/// </summary>
	[BuffHandler(BuffId.ObliqueFire_Buff)]
	public class ObliqueFireBuffHandler : BuffHandler
	{
		private const string VarName = "Melia.StatModifier";
		private const float BuffBonus = 3f;
		private const float DebuffPenaltyRate = -0.05f;

		/// <summary>
		/// Starts buff, modifying the target's movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;

			// Movement speed +3 per stack when stack is 3 or less
			// Movement Speed -5% per stack when stack is 4 or more

			if (buff.OverbuffCounter <= 3)
			{
				var bonus = BuffBonus;

				var modifier = buff.Vars.GetFloat(VarName);
				buff.Vars.SetFloat(VarName, modifier + bonus);

				target.Properties.Modify(PropertyName.MSPD_BM, bonus);
			}
			else
			{
				var mspd = target.Properties.GetFloat(PropertyName.MSPD);
				var penalty = mspd * DebuffPenaltyRate;

				var modifier = buff.Vars.GetFloat(VarName);
				buff.Vars.SetFloat(VarName, modifier + penalty);

				target.Properties.Modify(PropertyName.MSPD_BM, penalty);
			}

			Send.ZC_MOVE_SPEED(target);
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;

			if (buff.Vars.TryGetFloat(VarName, out var modifier))
				target.Properties.Modify(PropertyName.MSPD_BM, -modifier);

			Send.ZC_MOVE_SPEED(target);
		}
	}
}
