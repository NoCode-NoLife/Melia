using System;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Combat
{
	public class SkillHitInfo
	{
		public ICombatEntity Attacker { get; }
		public ICombatEntity Target { get; }
		public Skill Skill { get; }
		public HitInfo HitInfo { get; }
		public TimeSpan DamageDelay { get; }
		public TimeSpan SkillHitDelay { get; }

		public SkillHitInfo(ICombatEntity attacker, ICombatEntity target, Skill skill, float damage, TimeSpan damageDelay, TimeSpan skillHitDelay)
		{
			this.Attacker = attacker;
			this.Target = target;
			this.Skill = skill;
			this.HitInfo = new HitInfo(damage, target.Hp, 0, 3);
			this.DamageDelay = damageDelay;
			this.SkillHitDelay = skillHitDelay;
		}
	}
}
