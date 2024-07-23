using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Shared.Data.Database;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Contains code related to the Momentary Block Buff
	/// </summary>
	/// <remarks>
	/// This buff is granted by certain skills and causes you to always
	/// block for a duration.  It also provides a method to determine
	/// if an attack was successfully blocked, as some skills have
	/// an extra effect if it was
	/// </remarks>
	[BuffHandler(BuffId.Skill_MomentaryBlock_Buff)]
	public class Skill_MomentaryBlock_Buff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
	{
		private const string VarName = "Melia.BlockedAttack";

		public override void OnStart(Buff buff)
		{
			buff.Vars.SetBool(VarName, false);
		}

		/// <summary>
		/// This can be called to see if an attack was blocked
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		public static bool WasAttackBlocked(Buff buff)
		{
			if (buff.Vars.TryGetBool(VarName, out var value)) 
			{
				return value;
			}

			return false;
		}

		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			Log.Warning("Checking forced block");
			// Magic is unblockable, so it doesn't register a block in this case
			if (skill.Data.ClassType != SkillClassType.Magic)
			{ 
				modifier.ForcedBlock = true;
				buff.Vars.SetBool(VarName, true);
			}
		}
	}
}
