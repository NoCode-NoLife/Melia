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
			// Movement speed +3 per stack when stack is 3 or less
			// Movement Speed -5% per stack when stack is 4 or more
			var targetCharacter = buff.Target as Character;

			if (buff.OverbuffCounter <= 3)
			{
				var bonus = BuffBonus;

				var modifier = buff.Vars.GetFloat(VarName);
				buff.Vars.SetFloat(VarName, modifier + bonus);

				if (targetCharacter != null)
				{
					targetCharacter.Properties.Modify(PropertyName.MSPD_BM, bonus);
				}
			}
			else
			{
				if (targetCharacter != null)
				{
					var mspd = targetCharacter.Properties.GetFloat(PropertyName.MSPD);
					var penalty = mspd * DebuffPenaltyRate;
					var modifier = buff.Vars.GetFloat(VarName);
					targetCharacter.Properties.Modify(PropertyName.MSPD_BM, penalty);

					buff.Vars.SetFloat(VarName, modifier + penalty);
				}
			}

			if (targetCharacter != null)
			{
				Send.ZC_MOVE_SPEED(targetCharacter);
			}
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var targetCharacter = buff.Target as Character;

			var mspd = buff.Target.Properties.GetFloat(PropertyName.MSPD);
			buff.Target.Properties.SetFloat("MSPD_BM", mspd);

			if (targetCharacter != null)
			{
				if (buff.Vars.TryGetFloat(VarName, out var modifier))
					targetCharacter.Properties.Modify(PropertyName.MSPD_BM, -modifier);

				Send.ZC_MOVE_SPEED(targetCharacter);
			}
		}
	}
}
