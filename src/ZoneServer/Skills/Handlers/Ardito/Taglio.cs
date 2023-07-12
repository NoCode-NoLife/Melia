using System;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Taglio.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Taglio)]
	public class Taglio : IDynamicCasted
	{
		private int _effectId;

		/// <summary>
		/// Handles skill casting - Start
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="maxCastingTime"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster, float maxCastingTime)
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
			// Duration changed to 5 seconds
			// Movement speed increase effect removed
			// Cooldown increased by 10 seconds
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19))
			{
				caster.Properties.Modify(PropertyName.MSPD_BM, 10);
				Send.ZC_MSPD(caster);
			}

			// Why are we trusting the client?
			// Find a way of getting the max Cast time for each skill...
			cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(maxCastingTime));

			this.AreaOfEffect(skill, caster, maxCastingTime, cancellationTokenSource.Token);
		}

		/// <summary>
		/// Handles skill casting - Stop
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			var buffComponent = caster.Components.Get<BuffComponent>();

			if (buffComponent.Has(BuffId.Taglio_Buff))
			{
				buffComponent.Remove(BuffId.Taglio_Buff);
			}

			Send.ZC_NORMAL.Skill_50(caster, skill.Id, 2.1f);
			Send.ZC_STOP_SOUND(caster, "voice_war_atk_long_cast");
			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "Arditi_Taglio", skill.Id, caster.Position, this._effectId, false);

			// Taglio: Tenacity
			// Duration changed to 5 seconds
			// Movement speed increase effect removed
			// Cooldown increased by 10 seconds
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19))
			{
				caster.Properties.Modify(PropertyName.MSPD_BM, -10);
				Send.ZC_MSPD(caster);
			}
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="maxCastingTime"></param>
		/// <param name="cancellationToken"></param>
		private async void AreaOfEffect(Skill skill, ICombatEntity caster, float maxCastingTime, CancellationToken cancellationToken)
		{
			await Task.Delay(150);

			var buffComponent = caster.Components.Get<BuffComponent>();

			if (buffComponent != null)
			{
				if (!buffComponent.Has(BuffId.Taglio_Buff))
				{
					buffComponent.Start(BuffId.Taglio_Buff, TimeSpan.FromSeconds(maxCastingTime));
				}
			}

			this._effectId = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "Arditi_Taglio", skill.Id, caster.Position, this._effectId, true);

			var hitDelay = TimeSpan.FromMilliseconds(500);

			await Task.Delay(hitDelay);

			var character = caster as Character;

			if (character != null)
			{
				if (character.Gender == Gender.Male)
					Send.ZC_PLAY_SOUND(character, "voice_war_atk_long_cast");
				else
					Send.ZC_PLAY_SOUND(character, "voice_atk_long_cast_f");
			}

			while(!cancellationToken.IsCancellationRequested)
			{
				var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 80, width: 50, angle: 180);
				var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					this.ExecuteHitInfo(skill, caster, target);
				}

				await Task.Delay(TimeSpan.FromMilliseconds(100));
			}
		}

		/// <summary>
		/// Sends the Hit Info.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private async void ExecuteHitInfo(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var damageDelay = TimeSpan.Zero;
			var skillHitDelay = TimeSpan.Zero;

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			var abilityComponent = caster.Components.Get<AbilityComponent>();

			// Ability - Taglio: Remove Knockback
			if (abilityComponent != null && !abilityComponent.IsActive(AbilityId.Arditi8))
			{
				var knockBackDistance = 35;
				var knockBackPos = target.Position.GetRelative(caster.Direction, knockBackDistance);
				var angle = target.GetDirection(knockBackPos).DegreeAngle;
				var kb = new KnockBackInfo(caster.Position, knockBackPos, skill);

				Send.ZC_KNOCKDOWN_INFO(caster, target, kb);

				target.Position = kb.ToPosition;
			}

			Send.ZC_SKILL_HIT_INFO(caster, skillHit);

			await Task.Delay(150);
		}
	}
}
