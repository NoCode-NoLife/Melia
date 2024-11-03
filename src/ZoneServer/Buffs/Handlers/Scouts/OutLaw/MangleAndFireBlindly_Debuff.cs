using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scouts.OutLaw
{
	/// <summary>
	/// Handle for the Mangle and Fire Blindly Debuff, which
	/// reduces damage dealt to the inflictor of the buff
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Extra Crit Chance
	/// </remarks>
	[BuffHandler(BuffId.MangleAndFireBlindly_Debuff)]
	public class MangleAndFireBlindly_Debuff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
	{
		/// <summary>
		/// Reduces damage dealt if the target is the caster of the buff
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (target == buff.Caster)
			{
				modifier.FinalDamageMultiplier -= 0.07f * buff.OverbuffCounter;
			}
		}
	}
}
