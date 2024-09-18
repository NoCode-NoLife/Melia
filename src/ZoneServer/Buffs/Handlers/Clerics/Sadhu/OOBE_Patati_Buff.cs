using System;
using Yggdrasil.Util;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.SplashAreas;
using Melia.Shared.World;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Buffs.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Handler for the Out Of Body Experience (OOBE) Patati Buff
	/// which makes the character go back to original position after a while
	/// and creates an effect that damages enemies inside within a chance of knocking-down them
	/// </summary>
	[BuffHandler(BuffId.OOBE_Patati_Buff)]
	public class OOBE_Patati_Buff : Sadhu_BuffHandler_Base
	{
		private const int MaxTargets = 10;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var caster = buff.Caster;

			// [Arts] Spirit Expert: Wandering Soul
			if (caster.IsAbilityActive(AbilityId.Sadhu35) || caster is not Character casterCharacter)
				return;

			var dummyCharacter = casterCharacter.Map.GetDummyCharacter((int)buff.NumArg2);

			if (dummyCharacter != null)
			{
				dummyCharacter.Died += this.OnDummyDied;
			}
		}

		public override void OnEnd(Buff buff)
		{
			var caster = buff.Caster;

			if (caster is not Character casterCharacter)
				return;

			var skillCharacter = casterCharacter is DummyCharacter dummyCharacter && dummyCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35)
				? dummyCharacter.Owner
				: caster;

			if (skillCharacter.TryGetSkill(SkillId.Sadhu_Patati, out var skill))
			{
				skillCharacter.SetAttackState(true);

				this.AreaOfEffect(caster, skill, caster.Position);

				// [Arts] Spirit Expert: Wandering Soul
				if (casterCharacter is DummyCharacter dummyCharacter2 && dummyCharacter2.Owner.IsAbilityActive(AbilityId.Sadhu35))
				{
					Send.ZC_SKILL_READY(dummyCharacter2.Owner, caster, skill, caster.Position, caster.Position);
					Send.ZC_NORMAL.UpdateSkillEffect(dummyCharacter2.Owner, caster.Handle, caster.Position, caster.Direction, Position.Zero);
					Send.ZC_SKILL_MELEE_GROUND(dummyCharacter2.Owner, caster, skill, caster.Position, ForceId.GetNew(), null);
				}
				else
				{
					skill.IncreaseOverheat();
				}
			}

			// [Arts] Spirit Expert: Wandering Soul
			if (casterCharacter is DummyCharacter dummyCharacter3 && dummyCharacter3.Owner.IsAbilityActive(AbilityId.Sadhu35))
			{
				this.RemoveDummyCharacter(dummyCharacter3);
				return;
			}

			casterCharacter.Properties.Modify(PropertyName.MSPD_BM, -buff.NumArg1);

			Send.ZC_NORMAL.EndOutOfBodyBuff(casterCharacter, BuffId.OOBE_Patati_Buff);
			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 255, 255, 255, 0.01f);

			Send.ZC_PLAY_SOUND(casterCharacter, "skl_eff_yuchae_end_2");

			this.ReturnToBody(casterCharacter, (int)buff.NumArg2);
		}

		/// <summary>
		/// Creates the Area of Effect
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		private void AreaOfEffect(ICombatEntity caster, Skill skill, Position position)
		{
			Send.ZC_GROUND_EFFECT(caster, "F_cleric_patati_explosion", position, 0.8f, 1f, 0, 0, 0);

			var circle = new Circle(position, 60);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, circle);

			foreach (var target in targets.LimitRandom(MaxTargets))
			{
				var chance = this.GetKnockdownChance(skill);

				if (chance >= RandomProvider.Get().Next(100))
					this.KnockdownEntity(caster, target, skill);

				this.Attack(skill, caster, target);
			}
		}

		/// <summary>
		/// Attacks the target
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var modifier = SkillModifier.MultiHit(6);
			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(200));

			Send.ZC_HIT_INFO(caster, target, hit);
		}

		/// <summary>
		/// Knockdown the entity close to the caster position
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		private void KnockdownEntity(ICombatEntity caster, ICombatEntity target, Skill skill)
		{
			var kb = new KnockBackInfo(caster.Position, target.Position, skill);
			target.Position = kb.ToPosition;

			Send.ZC_KNOCKDOWN_INFO(caster, target, kb);
		}

		/// <summary>
		/// Returns the knockdown chance once the monster is hit
		/// </summary>
		/// <param name="skill"></param>
		private float GetKnockdownChance(Skill skill)
		{
			return 35 + (4.5f * skill.Level);
		}
	}
}
