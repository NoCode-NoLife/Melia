using Melia.Shared.Tos.Const;
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
		/// Returns a reference to the skill used in the attack.
		/// </summary>
		public Skill Skill { get; }

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
		/// Creates new hit.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="skillHitResult"></param>
		public HitInfo(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
			: this(attacker, target, skill, skillHitResult.Damage, skillHitResult.Result)
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
		public HitInfo(ICombatEntity attacker, ICombatEntity target, Skill skill, float damage, HitResultType resultType)
		{
			this.Attacker = attacker;
			this.Target = target;
			this.Skill = skill;

			this.Damage = damage;
			this.ResultType = resultType;

			this.Hp = target.Hp;
			this.HpPriority = target.HpChangeCounter;
		}
	}
}
