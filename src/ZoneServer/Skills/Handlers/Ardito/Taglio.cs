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
	public class Taglio : IDynamicCastingSkillHandler
	{
		private float maxCastingTime = 0;
		private CancellationTokenSource _cancellationTokenSource;
		private int EffectId;

		/// <summary>
		/// Handles skill casting - Start
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="maxCastingTime"></param>
		public void HandleStartCasting(Skill skill, ICombatEntity caster, float maxCastingTime)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			// Why are we trusting the client?
			// TODO: Find a way to get the Cast Time of a skill
			this.maxCastingTime = maxCastingTime;

			_cancellationTokenSource = new CancellationTokenSource();

			// Taglio: Tenacity
			// Duration changed to 5 seconds{ nl}
			// *Movement speed increase effect removed{ nl}
			// *Cooldown increased by 10 seconds
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19))
			{
				caster.Properties.Modify(PropertyName.MSPD_BM, 10);
				Send.ZC_MSPD(caster);
			}

			this.AreaOfEffect(skill, caster, _cancellationTokenSource.Token);
		}

		/// <summary>
		/// Handles skill casting - Stop
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void HandleStopCasting(Skill skill, ICombatEntity caster)
		{
			if (_cancellationTokenSource != null)
			{
				_cancellationTokenSource.Cancel();
			}

			var character = caster as Character;

			if (character.Buffs.Has(BuffId.Taglio_Buff))
			{
				var buff = character.Buffs.Get(BuffId.Taglio_Buff);
				buff.End();
			}

			Send.ZC_NORMAL.Skill_50(character, skill.Id, 2.1f);
			Send.ZC_STOP_SOUND(character, "voice_war_atk_long_cast");
			Send.ZC_NORMAL.GroundEffect_59(character, "Arditi_Taglio", skill.Id, caster.Position, this.EffectId, false);

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
		/// <param name="cancellationToken"></param>
		private async void AreaOfEffect(Skill skill, ICombatEntity caster, CancellationToken cancellationToken)
		{
			await Task.Delay(150);

			var character = caster as Character;

			if (!character.Buffs.Has(BuffId.Taglio_Buff))
			{
				character.StartBuff(BuffId.Taglio_Buff, TimeSpan.FromSeconds(this.maxCastingTime));
			}

			this.EffectId = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect_59(character, "Arditi_Taglio", skill.Id, caster.Position, this.EffectId, true);
			Send.ZC_NORMAL.Skill_4F(character, skill.Id);

			var hitDelay = TimeSpan.FromMilliseconds(500);

			await Task.Delay(hitDelay);

			if (character.Gender == Gender.Male)
				Send.ZC_PLAY_SOUND(character, "voice_war_atk_long_cast");
			else
				Send.ZC_PLAY_SOUND(character, "voice_atk_long_cast_f");

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

			// We could've maybe cancel the skill withut rellying on the CZ_DYNAMIC_CASTING_END

			//await Task.Delay(TimeSpan.FromSeconds(this.maxCastingTime));

			//this.HandleStopCasting(skill, caster);
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

			// Ability - Taglio: Remove Knockback
			// TODO: Knowback not being appplyed for some reason, fix it
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi8))
			{
				var knockBackDistance = 35;
				var knockBackPos = target.Position.GetRelative(caster.Direction, knockBackDistance);
				var angle = target.GetDirection(knockBackPos).DegreeAngle;

				Send.ZC_KNOCKDOWN_INFO(caster as Character, target, target.Position, knockBackPos, angle);

				target.Position = knockBackPos;
			}

			Send.ZC_SKILL_HIT_INFO(caster, skillHit);

			await Task.Delay(150);
		}
	}
}
