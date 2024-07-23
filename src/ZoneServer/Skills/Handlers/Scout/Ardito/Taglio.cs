using System;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Pads;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Taglio.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Taglio)]
	public class Taglio : IDynamicCasted
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
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19))
			{
				var moveSpeed = this.GetBonusMoveSpeed();
				caster.Properties.Modify(PropertyName.MSPD_BM, moveSpeed);
				Send.ZC_MSPD(caster);
			}

			// Never trust the client.
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
			if (caster.IsBuffActive(BuffId.Taglio_Buff))
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
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19))
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

			var targets = pad.Trigger.GetActors().Cast<ICombatEntity>().ToList();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				if (!caster.CanAttack(target))
					continue;

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
			var abilityComponent = caster.Components.Get<AbilityComponent>();
			if (abilityComponent != null && !abilityComponent.IsActive(AbilityId.Arditi8))
			{
				var knockBackDistance = 10;
				var knockBackPos = target.Position.GetRelative(caster.Direction, knockBackDistance);
				var angle = target.GetDirection(knockBackPos).DegreeAngle;
				var kb = new KnockBackInfo(caster.Position, knockBackPos, skill);

				Send.ZC_KNOCKDOWN_INFO(caster, target, kb);

				target.Position = kb.ToPosition;
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
			return caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19) ? 5f : 2f;
		}
	}
}
