using System;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// Contains information about a hit and the damage it caused.
	/// </summary>
	public class HitInfo
	{
		/// <summary>
		/// Returns a reference to the attacker.
		/// </summary>
		public ICombatEntity Attacker { get; }

		/// <summary>
		/// Returns a reference to the target.
		/// </summary>
		public ICombatEntity Target { get; }

		/// <summary>
		/// Returns the id of the skill used in the attack.
		/// </summary>
		public SkillId SkillId { get; }

		/// <summary>
		/// Returns the damage dealt.
		/// </summary>
		public float Damage { get; set; }

		/// <summary>
		/// Returns the target's current HP after the hit.
		/// </summary>
		public float Hp { get; }

		/// <summary>
		/// Returns the HP priority of the current HP value after the hit.
		/// </summary>
		public int HpPriority { get; }

		/// <summary>
		/// Returns the result type of the hit, affecting the hit effect.
		/// </summary>
		public HitResultType ResultType { get; set; }

		/// <summary>
		/// Returns the type of the hit, affecting the hit effect.
		/// </summary>
		public HitType Type { get; set; }

		/// <summary>
		/// Gets or sets the hit's force id.
		/// </summary>
		public int ForceId { get; set; }

		/// <summary>
		/// Gets or sets the number of times an attack hits.
		/// </summary>
		public int HitCount { get; set; } = 1;

		/// <summary>
		/// Gets or sets the delay before the damage is shown.
		/// </summary>
		public TimeSpan DamageDelay { get; set; }

		/// <summary>
		/// Creates new hit.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="damageDelay"></param>
		/// <param name="skillHitResult"></param>
		public HitInfo(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult, TimeSpan damageDelay = default)
			: this(attacker, target, skill, skillHitResult.Damage, skillHitResult.Result, skillHitResult.HitCount, damageDelay)
		{
		}

		/// <summary>
		/// Creates new hit.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="damage"></param>
		/// <param name="resultType"></param>
		/// <param name="hitCount"></param>
		/// <param name="damageDelay"></param>
		public HitInfo(ICombatEntity attacker, ICombatEntity target, Skill skill, float damage, HitResultType resultType, int hitCount = 0, TimeSpan damageDelay = default)
			: this(attacker, target, skill.Id, damage, resultType, hitCount, damageDelay)
		{
		}

		/// <summary>
		/// Creates new hit.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skillId"></param>
		/// <param name="damage"></param>
		/// <param name="resultType"></param>
		///	<param name="hitCount"></param>
		///	<param name="damageDelay"></param>
		public HitInfo(ICombatEntity attacker, ICombatEntity target, SkillId skillId, float damage, HitResultType resultType, int hitCount = 0, TimeSpan damageDelay = default)
		{
			this.Attacker = attacker;
			this.Target = target;
			this.SkillId = skillId;

			this.Damage = damage;
			this.ResultType = resultType;
			this.HitCount = hitCount;
			this.DamageDelay = damageDelay == default ? TimeSpan.Zero : damageDelay;

			this.Hp = target.Hp;
			this.HpPriority = target.HpChangeCounter;
		}
	}
}
