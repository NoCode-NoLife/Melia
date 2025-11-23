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
	/// which makes the character go back to original position
	/// after a while and creates an effect that damages enemies
	/// inside within a chance of knocking-down them.
	/// </summary>
	[BuffHandler(BuffId.OOBE_Patati_Buff)]
	public class OOBE_Patati_Buff : Sadhu_BuffHandler_Base
	{
		private const int MaxTargets = 10;

		/// <summary>
		/// Starts buff, adding an event handler for
		/// the death of the dummy character.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="activationType"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var caster = buff.Caster;

			AddPropertyModifier(buff, caster, PropertyName.MSPD_BM, (int)buff.NumArg1);

			// Don't continue if the caster is not a Character
			if (caster is not Character casterCharacter)
				return;

			var dummyCharacter = casterCharacter.Map.GetCharacter((int)buff.NumArg2);

			if (dummyCharacter != null)			
				dummyCharacter.Died += this.OnDummyDied;			
		}

		/// <summary>
		/// Executes the buff handler's end behavior.
		/// Does not actually end or remove the buff.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var caster = buff.Caster;

			RemovePropertyModifier(buff, caster, PropertyName.MSPD_BM);

			// Ignore if the caster is not a Character
			if (caster is not Character casterCharacter)
				return;

			// It spawns an clone character in form of a spirit that is controlled by AI.
			// So we need to identify the Source character that will be used on the buff ending.
			var characterSkillHandling = casterCharacter is DummyCharacter dummyCharacter && dummyCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35)
				? dummyCharacter.Owner
				: caster;

			// Don't continue if the caster doesn't have the skill.
			if (!characterSkillHandling.TryGetSkill(SkillId.Sadhu_Patati, out var skill))
				return;

			characterSkillHandling.SetAttackState(true);

			// Creates the Area Of Effect for that will damages enemies inside.
			this.AreaOfEffect(caster, skill, caster.Position);

			// [Arts] Spirit Expert: Wandering Soul - AI Controlled Spirit
			if (casterCharacter is DummyCharacter dummyCharacter2 && dummyCharacter2.Owner.IsAbilityActive(AbilityId.Sadhu35))
			{
				Send.ZC_SKILL_READY(dummyCharacter2.Owner, caster, skill, caster.Position, caster.Position);
				Send.ZC_NORMAL.UpdateSkillEffect(dummyCharacter2.Owner, caster.Handle, caster.Position, caster.Direction, Position.Zero);
				Send.ZC_SKILL_MELEE_GROUND(dummyCharacter2.Owner, caster, skill, caster.Position, ForceId.GetNew(), null);
			}
			else // Spirit was controlled by the player
			{
				skill.IncreaseOverheat();
			}

			// [Arts] Spirit Expert: Wandering Soul: AI Controlled Spirit
			// Removes the clone character (spirit) from the map.
			if (casterCharacter is DummyCharacter dummyCharacter3 && dummyCharacter3.Owner.IsAbilityActive(AbilityId.Sadhu35))
			{
				this.RemoveSpritCloneCharacter(dummyCharacter3);
				return;
			}

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
		/// <param name="position"></param>
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
		/// Attacks the targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var dealsDamageCharacter = caster is DummyCharacter dummyCharacter && dummyCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35)
				? dummyCharacter.Owner
				: caster;

			var modifier = SkillModifier.MultiHit(6);
			var skillHitResult = SCR_SkillHit(dealsDamageCharacter, target, skill, modifier);

			target.TakeDamage(skillHitResult.Damage, dealsDamageCharacter);

			var hit = new HitInfo(dealsDamageCharacter, target, skill, skillHitResult, TimeSpan.FromMilliseconds(200));

			Send.ZC_HIT_INFO(dealsDamageCharacter, target, hit);
		}

		/// <summary>
		/// Knockdown the entity close to the caster position.
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
		/// Returns the knockdown chance once the monster is hit.
		/// </summary>
		/// <param name="skill"></param>
		private float GetKnockdownChance(Skill skill)
		{
			return 35 + (4.5f * skill.Level);
		}
	}
}
