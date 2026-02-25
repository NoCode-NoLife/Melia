using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handle for the OOBE_Prakriti Sadhu46 ([Arts] Prakriti: Penance) Debuff,
	/// which increases damage final damage taken from crit attacks.
	/// </summary>
	[BuffHandler(BuffId.OOBE_Prakriti_Sadhu46_Debuff)]
	public class OOBE_Prakriti_Sadhu46_Debuff : BuffHandler, IBuffCombatAttackAfterCalcHandler
	{
		/// <summary>
		/// Applies the debuff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (skillHitResult.Result == HitResultType.Crit)
				modifier.DamageMultiplier += 0.15f;
		}
	}
}
