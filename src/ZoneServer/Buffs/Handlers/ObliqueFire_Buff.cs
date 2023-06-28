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
		private const string ModifierVar = "Buff:ObliqueFire_Buff/Modifier";

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
				var add = 3f;
				buff.Target.Properties.Modify("MSPD_BM", add);

				// Keep track of the changes we made to the speed buff
				// property, to be able to reset it accurately once the
				// buff ends.
				// Ideally, we would be able to create named modifiers
				// for properties, that we can later remove in one fell
				// swoop, but then we would also need to save and load
				// those modifiers. Let's stick to this solution for
				// now, even if it's not the prettiest.

				if (targetCharacter != null)
				{
					var modifier = targetCharacter.Variables.Perm.Get<float>(ModifierVar, 0);
					targetCharacter.Variables.Perm.SetFloat(ModifierVar, modifier + add);
				}
			}
			else
			{
				// TODO: This part needs more research. There doesn't seem
				//   to be a property for modifying the speed by a percentage,
				//   but if we do that manually, couldn't we end up removing
				//   more than we should in OnEnd, when the speed changes?

				var mspd = buff.Target.Properties.GetFloat(PropertyName.MSPD);
				var add = -mspd * 0.05f;

				buff.Target.Properties.Modify("MSPD_BM", add);

				if (targetCharacter != null)
				{
					var modifier = targetCharacter.Variables.Perm.Get<float>(ModifierVar, 0);
					targetCharacter.Variables.Perm.SetFloat(ModifierVar, modifier + add);
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
				var modifier = targetCharacter.Variables.Perm.Get<float>(ModifierVar, 0);
				targetCharacter.Variables.Perm.Remove(ModifierVar);

				targetCharacter.Properties.Modify("MSPD_BM", modifier);

				Send.ZC_MOVE_SPEED(targetCharacter);
			}
		}
	}
}
