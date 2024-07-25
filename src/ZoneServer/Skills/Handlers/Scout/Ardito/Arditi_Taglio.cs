using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Taglio.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Taglio)]
	public class Arditi_Taglio : IDynamicCasted
	{
		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			// Taglio: Tenacity
			// - Duration changed to 5 seconds
			// - Movement speed increase effect removed
			// - Cooldown increased by 10 seconds
			if (!caster.IsAbilityActive(AbilityId.Arditi19))
			{
				var moveSpeed = this.GetBonusMoveSpeed();
				caster.Properties.Modify(PropertyName.MSPD_BM, moveSpeed);
				Send.ZC_MSPD(caster);
			}

			// Use a fix buff duration, as to not rely on the client to end
			// the cast in time.
			var maxCastingTime = this.GetMaxCastTime(caster);
			caster.StartBuff(BuffId.Taglio_Buff, TimeSpan.FromSeconds(maxCastingTime));

			if (caster is Character casterCharacter)
			{
				if (casterCharacter.Gender == Gender.Male)
					Send.ZC_PLAY_SOUND(casterCharacter, "voice_war_atk_long_cast");
				else
					Send.ZC_PLAY_SOUND(casterCharacter, "voice_atk_long_cast_f");
			}

			var pad = new Pad(PadName.Arditi_Taglio, caster, skill, new Square(caster.Position, caster.Direction, 45, 30));
			pad.Position = caster.Position;
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(maxCastingTime);
			pad.Trigger.MaxActorCount = 10;
			pad.Trigger.UpdateInterval = TimeSpan.FromMilliseconds(250);
			pad.Trigger.Subscribe(TriggerType.Update, this.OnTriggerUpdate);

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			caster.StopBuff(BuffId.Taglio_Buff);

			if (caster is Character casterCharacter)
			{
				Send.ZC_NORMAL.UnkDynamicCastEnd(casterCharacter, skill.Id, 2.1f);

				if (casterCharacter.Gender == Gender.Male)
					Send.ZC_STOP_SOUND(caster, "voice_war_atk_long_cast");
				else
					Send.ZC_STOP_SOUND(caster, "voice_atk_long_cast_f");
			}

			// Taglio: Tenacity
			if (!caster.IsAbilityActive(AbilityId.Arditi19))
			{
				var moveSpeed = this.GetBonusMoveSpeed();
				caster.Properties.Modify(PropertyName.MSPD_BM, -moveSpeed);
				Send.ZC_MSPD(caster);
			}
		}

		/// <summary>
		/// Called when an actor enters the area of the attack.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnTriggerUpdate(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				this.Attack(skill, caster, target);
			}
		}

		/// <summary>
		/// Attacks the target one time.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var skillHitResult = SCR_SkillHit(caster, target, skill);

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(100));
			Send.ZC_HIT_INFO(caster, target, hit);

			// Ability - Taglio: Remove Knockback
			if (!caster.IsAbilityActive(AbilityId.Arditi8))
			{
				var knockBackDistance = 10;
				var knockBackPos = target.Position.GetRelative(caster.Direction, knockBackDistance);
				var angle = target.GetDirection(knockBackPos).DegreeAngle;
				var kb = new KnockBackInfo(caster.Position, knockBackPos, skill);
				target.Position = kb.ToPosition;

				Send.ZC_KNOCKDOWN_INFO(caster, target, kb);
			}
		}

		/// <summary>
		/// Returns the Bonus MoveSpeed
		/// </summary>
		/// <returns></returns>
		private float GetBonusMoveSpeed()
		{
			return 10f;
		}

		/// <summary>
		/// Returns the Max CastTime in seconds
		/// </summary>
		/// <returns></returns>
		private float GetMaxCastTime(ICombatEntity caster)
		{
			return caster.IsAbilityActive(AbilityId.Arditi19) ? 5f : 2f;
		}
	}
}
