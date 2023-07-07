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
using Melia.Zone.Skills.Combat;
using System.Collections.Generic;
using System.Threading;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Wugushi skill Poison Pot.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_ThrowGuPot)]
	public class PoisonPot : IGroundSkillHandler
	{
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

			if (!caster.Position.InRange2D(farPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_NORMAL.Skill_06(caster as Character, "shot_fail", 0.5f, "", 1, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
			Send.ZC_NORMAL.Skill_59(caster as Character, caster.Handle, "shot_fail", skill.Id, farPos, caster.Position.GetDirection(caster.Position), true);
			Send.ZC_NORMAL.Skill_E3(caster as Character, null, "STAGE_1");

			// Start the task
			Task.Run(() => AreaOfEffect(skill, caster, farPos));
		}

		async Task AreaOfEffect(Skill skill, ICombatEntity caster, Position position)
		{
			using (var cancellationTokenSource = new CancellationTokenSource())
			{
				cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(15));

				while (!cancellationTokenSource.IsCancellationRequested)
				{
					// Radius seems precise
					var radius = 45;
					var center = position.GetRelative(position, radius);
					var splashArea = new Circle(center, radius);

					// Attack targets
					var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
					var damageDelay = TimeSpan.FromMilliseconds(150);

					var hits = new List<SkillHitInfo>();

					foreach (var target in targets.LimitBySDR(caster, skill))
					{
						if (!target.Components.Get<BuffComponent>().Has(BuffId.Archer_VerminPot_Debuff))
						{
							target.Components.Get<BuffComponent>().Start(BuffId.Archer_VerminPot_Debuff, skill.Level, 0, TimeSpan.FromSeconds(15), caster, skill);
						}
					}

					// Delay for 1 seconds
					await Task.Delay(200);
				}

				Send.ZC_NORMAL.Skill_59(caster as Character, caster.Handle, "shot_fail", skill.Id, position, caster.Position.GetDirection(caster.Position), false);
			}
		}
	}
}
