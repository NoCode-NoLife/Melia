using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scouts.Scout
{
	/// <summary>
	/// Handler for the Dagger Slash Buff.
	/// </summary>
	[BuffHandler(BuffId.DaggerSlash_Buff)]
	public class DaggerSlash_Buff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
	{
		/// <summary>
		/// Applies the buff's effect before the damage calculation.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			modifier.DamageMultiplier += buff.OverbuffCounter * 0.07f;
		}
	}
}
