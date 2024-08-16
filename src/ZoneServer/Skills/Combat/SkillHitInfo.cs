using System;
using Melia.Shared.Game.Const;
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
		/// Gets or sets the delay before the damage is shown.
		/// </summary>
		public TimeSpan DamageDelay { get; set; }

		/// <summary>
		/// Gets or sets the skill's hit delay, which affects the animations.
		/// </summary>
		public TimeSpan SkillHitDelay { get; set; }

		/// <summary>
		/// Gets or sets the hit effect displayed on the target.
		/// </summary>
		public HitEffect HitEffect { get; set; } = HitEffect.Impact;

		/// <summary>
		/// Gets or sets the force id, which is used to synchronize
		/// effects and animations during "force" skills, such as
		/// Magic Missile and Multi Shot.
		/// </summary>
		public int ForceId { get; set; }

		/// <summary>
		/// Gets or sets the number of hits that are displayed. The damage
		/// is split evenly between the hits.
		/// </summary>
		public int HitCount { get; set; } = 1;

		/// <summary>
		/// Gets or sets the knock back information. Leave empty for none.
		/// </summary>
		public KnockBackInfo KnockBackInfo { get; set; }

		/// <summary>
		/// Returns true if the knock back info was set.
		/// </summary>
		public bool IsKnockBack => this.KnockBackInfo != null;

		/// <summary>
		/// Creates new skill hit.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="result"></param>
		/// <param name="damageDelay"></param>
		/// <param name="skillHitDelay"></param>
		public SkillHitInfo(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult result, TimeSpan damageDelay, TimeSpan skillHitDelay)
		{
			this.Attacker = attacker;
			this.Target = target;
			this.Skill = skill;
			this.HitInfo = new HitInfo(attacker, target, skill, result.Damage, result.Result);
			this.DamageDelay = damageDelay;
			this.SkillHitDelay = skillHitDelay;
			this.HitEffect = result.Effect;
			this.HitCount = result.HitCount;
		}
	}
}
