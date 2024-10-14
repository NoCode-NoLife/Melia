using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills.Handlers.Archers.Ranger;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Ranger
{
	/// <summary>
	/// Buff handler for TimeBombArrow_Debuff, which deals damage
	/// and knocks down targets when it expires.
	/// </summary>
	/// <remarks>
	/// NumArg1: Damage of original shot
	/// NumArg2: Damage multiplier
	/// </remarks>
	[BuffHandler(BuffId.TimeBombArrow_Debuff)]
	public class TimeBombArrow_Debuff : BuffHandler
	{
		public override void OnEnd(Buff buff)
		{
			if (buff.Target.IsDead || !buff.Caster.TryGetSkill(SkillId.Ranger_TimeBombArrow, out var skill))
				return;

			var attacker = buff.Caster;
			var target = buff.Target;
			var damage = buff.NumArg1;
			var damageMultiplier = buff.NumArg2;

			Ranger_TimeBombArrow.ExplosionAttack(skill, attacker, target, damage, damageMultiplier);
		}
	}
}
