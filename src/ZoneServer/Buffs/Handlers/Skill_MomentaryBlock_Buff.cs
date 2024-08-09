using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Contains code related to the Momentary Block Buff
	/// </summary>
	/// <remarks>
	/// This buff is granted by certain skills and causes you to always
	/// block for a duration. It also provides a method to determine
	/// if an attack was successfully blocked, as some skills have
	/// an extra effect if it was.
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
		/// Returns true if the entity has the buff and an attack was blocked
		/// at some point.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public static bool WasAttackBlocked(ICombatEntity entity)
		{
			if (!entity.TryGetBuff(BuffId.Skill_MomentaryBlock_Buff, out var buff))
				return false;

			if (!buff.Vars.TryGetBool(VarName, out var value))
				return false;

			return value;
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
			// Don't let magic or unblockable attacks trigger the buff's effect.
			// While we check for magic before a forced block as well, we don't
			// want to flag the buff as having blocked something.
			if (skill.Data.ClassType == SkillClassType.Magic || modifier.Unblockable)
				return;

			modifier.ForcedBlock = true;
			buff.Vars.SetBool(VarName, true);
		}
	}
}
