using Melia.Channel.Buffs.Base;
using Melia.Channel.Network;
using Melia.Channel.World;
using Melia.Channel.World.Entities;
using Melia.Shared.Tos.Const;

namespace Melia.Channel.Buffs.Handlers
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
			var target = buff.Target as Character;

			// Movement speed +3 per stack when stack is 3 or less
			// Movement Speed -5% per stack when stack is 4 or more

			if (buff.OverbuffCounter <= 3)
			{
				var add = 3f;
				target.Properties.Modify(PropertyId.PC.MSPD_BM, add);

				// Keep track of the changes we made to the speed buff
				// property, to be able to reset it accurately once the
				// buff ends.
				// Ideally, we would be able to create named modifiers
				// for properties, that we can later remove in one fell
				// swoop, but then we would also need to save and load
				// those modifiers. Let's stick to this solution for
				// now, even if it's not the prettiest.
				var modifier = target.Variables.Perm.Get<float>(ModifierVar, 0);
				target.Variables.Perm[ModifierVar] = modifier + add;
			}
			else
			{
				// TODO: This part needs more research. There doesn't seem
				//   to be a property for modifying the speed by a percentage,
				//   but if we do that manually, couldn't we end up removing
				//   more than we should in OnEnd, when the speed changes?

				var mspd = target.Properties.GetFloat(PropertyId.PC.MSPD);
				var add = -mspd * 0.05f;

				target.Properties.Modify(PropertyId.PC.MSPD_BM, add);

				var modifier = target.Variables.Perm.Get<float>(ModifierVar, 0);
				target.Variables.Perm[ModifierVar] = modifier + add;
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

			var modifier = target.Variables.Perm.Get<float>(ModifierVar, 0);
			target.Variables.Perm.Remove(ModifierVar);

			target.Properties.Modify(PropertyId.PC.SPEED_BM, modifier);

			Send.ZC_MOVE_SPEED(target);
		}
	}
}
