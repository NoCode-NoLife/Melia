using System;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Taglio.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Taglio)]
	public class Taglio : IDynamicCasted
	{
		private int forceId;

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

			var cancellationTokenSource = new CancellationTokenSource();

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
			cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(maxCastingTime));
			caster.StartBuff(BuffId.Taglio_Buff, TimeSpan.FromSeconds(maxCastingTime));

			this.AreaOfEffect(skill, caster, cancellationTokenSource.Token);
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
				Send.ZC_NORMAL.UnkDynamicCastEnd(casterCharacter, skill.Id, 2.1f);

			Send.ZC_STOP_SOUND(caster, "voice_war_atk_long_cast");
			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_Taglio", skill.Id, caster.Position, forceId, false);

			// Taglio: Tenacity
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19))
			{
				var moveSpeed = this.GetBonusMoveSpeed();
				caster.Properties.Modify(PropertyName.MSPD_BM, -moveSpeed);
				Send.ZC_MSPD(caster);
			}
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="cancellationToken"></param>
		private async void AreaOfEffect(Skill skill, ICombatEntity caster, CancellationToken cancellationToken)
		{
			await Task.Delay(150);

			forceId = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_Taglio", skill.Id, caster.Position, forceId, true);

			await Task.Delay(TimeSpan.FromMilliseconds(500));

			if (caster is Character casterCharacter)
			{
				if (casterCharacter.Gender == Gender.Male)
					Send.ZC_PLAY_SOUND(casterCharacter, "voice_war_atk_long_cast");
				else
					Send.ZC_PLAY_SOUND(casterCharacter, "voice_atk_long_cast_f");
			}

			while (!cancellationToken.IsCancellationRequested)
			{
				var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 80, width: 50, angle: 180);
				var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					this.ExecuteHitInfo(skill, caster, target);
				}

				await Task.Delay(TimeSpan.FromMilliseconds(300));
			}
		}

		/// <summary>
		/// Sends the Hit Info.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void ExecuteHitInfo(Skill skill, ICombatEntity caster, ICombatEntity target)
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
		/// Returns the Max CastTime
		/// </summary>
		/// <returns></returns>
		private float GetMaxCastTime(ICombatEntity caster)
		{
			return caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19) ? 5f : 2f;
		}
	}
}
