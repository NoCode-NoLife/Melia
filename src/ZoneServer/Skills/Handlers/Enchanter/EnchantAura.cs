using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Zone.Skills.Combat;
using System.Collections.Generic;
using System.Threading;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Enchanter skill Enchant Aura.
	/// </summary>
	[SkillHandler(SkillId.Enchanter_EnchantAura)]
	public class EnchantAura : IGroundSkillHandler
	{
		private Task _areaOfEffect;
		private CancellationTokenSource _cancellationTokenSource;

		/// <summary>
		/// Handles the skill, creates an area of effect that damages the enemies inside
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			// Cancel the area of effect task
			if (_areaOfEffect != null)
			{
				Send.ZC_SKILL_CAST_CANCEL(caster);
				_cancellationTokenSource?.Cancel();
				_areaOfEffect = null;
				return;
			}

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			// Create a new cancellation token source
			_cancellationTokenSource = new CancellationTokenSource();

			// Start the task
			_areaOfEffect = Task.Run(() => AreaOfEffect(_cancellationTokenSource.Token, skill, caster, caster.Position));
		}

		async Task AreaOfEffect(CancellationToken cancellationToken, Skill skill, ICombatEntity caster, Position position)
		{
			while (true)
			{
				// Check if cancellation is requested
				if (cancellationToken.IsCancellationRequested)
				{
					break;
				}

				// Delay for 3 seconds
				await Task.Delay(3000);

				// Cancel if the caster has not enough SP
				if (!caster.TrySpendSp(skill))
				{
					break;
				}

				// HardCoded for the moment, seems precisa tho
				var radius = 80;
				var center = position.GetRelative(position, radius);
				var splashArea = new Circle(center, radius);

				Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

				// Attack targets
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				var damageDelay = TimeSpan.FromMilliseconds(150);

				var hits = new List<SkillHitInfo>();

				foreach (var target in targets)
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult.Damage, skillHitResult.Result);

					Send.ZC_HIT_INFO(caster, target, skill, hit);
				}
			}
		}
	}
}
