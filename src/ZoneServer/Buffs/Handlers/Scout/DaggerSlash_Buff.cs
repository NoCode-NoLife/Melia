using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scout
{
	/// <summary>
	/// Handler for the Dagger Slash Buff.
	/// </summary>
	[BuffHandler(BuffId.DaggerSlash_Buff)]
	public class DaggerSlash_Buff : BuffHandler
	{
		/// <summary>
		/// Applies the buff's effect during combat calculations.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		/// <returns></returns>
		[ScriptableFunction]
		public static float SCR_Combat_BeforeCalc_DaggerSlash_Buff(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!attacker.TryGetBuff(BuffId.DaggerSlash_Buff, out var daggerSlashBuff))
				return 0;

			modifier.DamageMultiplier += daggerSlashBuff.OverbuffCounter * 0.07f;

			return 0;
		}
	}
}
