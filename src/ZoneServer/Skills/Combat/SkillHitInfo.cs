using System;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// Contains information about a hit from a skill.
	/// </summary>
	public class SkillHitInfo
	{
		/// <summary>
		/// Returns the entity that caused the hit.
		/// </summary>
		public ICombatEntity Attacker { get; }

		/// <summary>
		/// Returns the target of the hit.
		/// </summary>
		public ICombatEntity Target { get; }

		/// <summary>
		/// Returns the skill used in the attack.
		/// </summary>
		public Skill Skill { get; }

		/// <summary>
		/// Returns the hit's damage information.
		/// </summary>
		public HitInfo HitInfo { get; }

		/// <summary>
		/// Returns the delay before the damage is shown.
		/// </summary>
		public TimeSpan DamageDelay { get; }

		/// <summary>
		/// Returns the skill's hit delay, which affects the animations.
		/// </summary>
		public TimeSpan SkillHitDelay { get; }

		/// <summary>
		/// Gets or sets the hit effect displayed on the target.
		/// </summary>
		public HitEffect HitEffect { get; set; } = HitEffect.Impact;

		/// <summary>
		/// Gets or sets an unknown value that's necessary for force skills.
		/// </summary>
		public int ForceId { get; set; }

		/// <summary>
		/// Creates new skill hit.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="damage"></param>
		/// <param name="damageDelay"></param>
		/// <param name="skillHitDelay"></param>
		public SkillHitInfo(ICombatEntity attacker, ICombatEntity target, Skill skill, float damage, TimeSpan damageDelay, TimeSpan skillHitDelay)
		{
			this.Attacker = attacker;
			this.Target = target;
			this.Skill = skill;
			this.HitInfo = new HitInfo(attacker, target, skill, damage, HitResultType.Hit);
			this.DamageDelay = damageDelay;
			this.SkillHitDelay = skillHitDelay;
		}
	}
}
