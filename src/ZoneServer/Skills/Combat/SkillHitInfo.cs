using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Components;

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
		/// Returns the result of the combat calculations.
		/// </summary>
		private SkillHitResult HitResult { get; }

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
			this.HitResult = result;
			this.HitInfo = new HitInfo(attacker, target, skill, result.Damage, result.Result);
			this.DamageDelay = damageDelay;
			this.SkillHitDelay = skillHitDelay;
			this.HitEffect = result.Effect;
			this.HitCount = result.HitCount;

			if (skill.Data.HitType == SkillHitType.Force)
				this.ForceId = Melia.Zone.Skills.Combat.ForceId.GetNew();
		}

		/// <summary>
		/// Applies the calculated damage to the target of the hit.
		/// </summary>
		public void ApplyDamage()
		{
			this.Target.TakeDamage(this.HitInfo.Damage, this.Attacker);
		}

		/// <summary>
		/// Applies the knock back to the hit's target and updates the hit
		/// type.
		/// </summary>
		public void ApplyKnockBack()
			=> this.ApplyKnockBack(this.Target);

		/// <summary>
		/// Applies the knock back to the target and updates the hit type.
		/// </summary>
		/// <param name="target"></param>
		public void ApplyKnockBack(ICombatEntity target)
		{
			// Create knock back info if it wasn't yet set from the
			// outside. This way we don't get knock back information into
			// the combat packets if we don't set or apply the knock back.
			// The option to set it manually is primarily for backwards
			// compatibility.
			if (this.KnockBackInfo == null)
			{
				var result = this.HitResult;

				if (result.KnockBack.Type == KnockBackType.None)
					return;

				var type = result.KnockBack.Type;
				var velocity = result.KnockBack.Velocity;
				var vAngle = result.KnockBack.VAngle;

				this.KnockBackInfo = new KnockBackInfo(this.Attacker.Position, target.Position, type, velocity, vAngle);
			}

			// Knockback immunity check - may need to move this
			if (target.IsBuffActive(BuffId.BullyPainBarrier_Buff))
			{
				this.KnockBackInfo = null;
				return;
			}

			var isKnockBack = this.KnockBackInfo.HitType == KnockBackType.KnockBack;
			var isKnockDown = this.KnockBackInfo.HitType == KnockBackType.KnockDown;

			if (isKnockBack && target.IsLocked(LockType.GetKnockedBack))
			{
				this.KnockBackInfo = null;
				return;
			}
			else if (isKnockDown && target.IsLocked(LockType.GetKnockedDown))
			{
				this.KnockBackInfo = null;
				return;
			}

			this.HitInfo.KnockBackType = this.KnockBackInfo.HitType;
			target.Position = this.KnockBackInfo.ToPosition;

			target.AddState(StateType.KnockedBack, this.KnockBackInfo.Time);

			// Set knock down state as well if applicable, so we can check for
			// both KB and KD as necessary. We can't consider them to be the
			// same because some skills and buffs have special behavior for
			// knock downs.
			if (isKnockDown)
				target.AddState(StateType.KnockedDown, this.KnockBackInfo.Time);
		}
	}
}
